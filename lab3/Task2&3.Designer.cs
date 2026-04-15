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
            listBoxShow.Location = new Point(82, 62);
            listBoxShow.Name = "listBoxShow";
            listBoxShow.Size = new Size(630, 224);
            listBoxShow.TabIndex = 0;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(82, 312);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(108, 29);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show Items";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Task2_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShow);
            Controls.Add(listBoxShow);
            Name = "Task2_3";
            Text = "Task2_3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxShow;
        private Button buttonShow;
    }
}