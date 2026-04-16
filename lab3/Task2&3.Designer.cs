namespace lab3
{
    partial class Task2_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxShow = new ListBox();
            buttonShow = new Button();
            SuspendLayout();
            // 
            // listBoxShow
            // 
            listBoxShow.FormattingEnabled = true;
            listBoxShow.ItemHeight = 15;
            listBoxShow.Location = new Point(72, 46);
            listBoxShow.Margin = new Padding(3, 2, 3, 2);
            listBoxShow.Name = "listBoxShow";
            listBoxShow.Size = new Size(552, 199);
            listBoxShow.TabIndex = 0;
            // 
            // buttonShow
            // 
            buttonShow.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShow.Location = new Point(72, 261);
            buttonShow.Margin = new Padding(3, 2, 3, 2);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(128, 28);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show Items";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Task2_3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonShow);
            Controls.Add(listBoxShow);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Task2_3";
            Text = "Task2_3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxShow;
        private Button buttonShow;
    }
}