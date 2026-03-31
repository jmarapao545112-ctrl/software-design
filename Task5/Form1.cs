using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] bubbleSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] arr = { 24, 12, 66, 7, 58, 49, 32 };
            int[] sortedBubble = bubbleSort(arr);
            listBoxResults.DataSource = sortedBubble;
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 22, 35, 56, 87, 49, 91, 100 };
            int[] sortedOrder = DescendingOrder(numbers);
            listBoxResults.DataSource = sortedOrder;
        }

        public int[] DescendingOrder(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
                }
            return numbers;
        }
      
    }
}
 