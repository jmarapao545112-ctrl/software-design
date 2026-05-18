using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace lab8
{
    public partial class Form1 : Form
    {
        private int apiStartIndex = 0;
        private const int apiPageSize = 10;
        public Form1()
        {
            InitializeComponent();
            lblApiPage.Text = "Page: 1 of 10";
            btnApiPrev.Enabled = false;
        }

        public async Task<string> GetBookInfoWithErrorHandlingAsync(string isbn)
        {
            string apiUrl = $"https://openlibrary.org/api/books?bibkeys=ISBN:{isbn}&format=json&jscmd=data";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);
                    var jsonResponse = JObject.Parse(response);

                    string key = $"ISBN:{isbn}";
                    if (jsonResponse[key] != null)
                    {
                        var bookData = jsonResponse[key];
                        string title = bookData["title"]?.ToString() ?? "N/A Title Field";

                        string authors = "Unknown Author";
                        if (bookData["authors"] != null)
                        {
                            var authorList = bookData["authors"].Select(a => a["name"]?.ToString());
                            authors = string.Join(", ", authorList);
                        }

                        string published = bookData["publish_date"]?.ToString() ?? "No Date Cataloged";

                        return $"TITLE: {title}\r\nAUTHOR: {authors}\r\nPUBLISHED: {published}";
                    }
                    else
                    {
                        return "No records located matching specified ISBN criteria.";
                    }
                }
            }
            catch (HttpRequestException)
            {
                return "Error: Unable to fetch data from the API. Please check your connection or try again later.";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }

        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter a valid ISBN sequence first.", "Missing Criteria");
                return;
            }

            btnFetchBook.Enabled = false;
            txtBookDetails.Text = "Fetching remote data payload...";

            string bookInfo = await GetBookInfoWithErrorHandlingAsync(isbn);
            txtBookDetails.Text = bookInfo;

            btnFetchBook.Enabled = true;
        }

        private async Task ExecuteAuthorApiLookupAsync(string authorName)
        {
            try
            {
                int pageNumber = (apiStartIndex / apiPageSize) + 1;
                string url = $"https://openlibrary.org/search.json?author={Uri.EscapeDataString(authorName)}&page={pageNumber}&limit={apiPageSize}";

                using (HttpClient client = new HttpClient())
                {
                    string json = await client.GetStringAsync(url);
                    var data = JObject.Parse(json);

                    lbxApiResults.Items.Clear();

                    var docsList = data["docs"];
                    int totalFound = data["numFound"] != null ? (int)data["numFound"] : 0;
                    int totalPages = (int)Math.Ceiling((double)totalFound / apiPageSize);
                    if (totalPages == 0) totalPages = 1;

                    if (docsList != null && docsList.Count() > 0)
                    {
                        foreach (var bookNode in docsList)
                        {
                            string title = bookNode["title"]?.ToString() ?? "Title Not Declared";
                            lbxApiResults.Items.Add(title);
                        }
                    }
                    else
                    {
                        lbxApiResults.Items.Add("No records found for this author.");
                    }

                    lblApiPage.Text = $"Page: {pageNumber} of {totalPages}";
                    btnApiPrev.Enabled = (apiStartIndex > 0);
                    btnApiNext.Enabled = (pageNumber < totalPages);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Web data index retrieval error status: {ex.Message}");
            }
        }

        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string targetAuthor = txtAuthorSearch.Text.Trim();
            if (string.IsNullOrEmpty(targetAuthor))
            {
                MessageBox.Show("Please enter an author name to look up.", "Input Missing");
                return;
            }

            apiStartIndex = 0;
            await ExecuteAuthorApiLookupAsync(targetAuthor);
        }

        private async void btnApiPrev_Click(object sender, EventArgs e)
        {
            if (apiStartIndex >= apiPageSize)
            {
                apiStartIndex -= apiPageSize;
                await ExecuteAuthorApiLookupAsync(txtAuthorSearch.Text.Trim());
            }
        }

        private async void btnApiNext_Click(object sender, EventArgs e)
        {
             apiStartIndex += apiPageSize; 
            await ExecuteAuthorApiLookupAsync(txtAuthorSearch.Text.Trim());
        }
    }
}
