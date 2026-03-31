namespace lab2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtInput = new TextBox();
            lblResult = new TextBox();
            btnFactorialCalculate = new Button();
            label2 = new Label();
            txtArrayInput = new TextBox();
            lblSumResult = new TextBox();
            btnCalculateSum = new Button();
            label3 = new Label();
            label4 = new Label();
            txtExponentNum = new TextBox();
            txtBaseNum = new TextBox();
            txtInputFibo = new TextBox();
            lblResultPower = new TextBox();
            lblResultFibo = new TextBox();
            btnCalculatePower = new Button();
            btnCalculateFibonacci = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 37);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Factorial Calculator:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(56, 70);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(168, 27);
            txtInput.TabIndex = 1;
            txtInput.Text = "Input Here";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Ivory;
            lblResult.Location = new Point(56, 103);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(168, 27);
            lblResult.TabIndex = 2;
            // 
            // btnFactorialCalculate
            // 
            btnFactorialCalculate.Location = new Point(86, 145);
            btnFactorialCalculate.Name = "btnFactorialCalculate";
            btnFactorialCalculate.Size = new Size(94, 29);
            btnFactorialCalculate.TabIndex = 3;
            btnFactorialCalculate.Text = "Calculate";
            btnFactorialCalculate.UseVisualStyleBackColor = true;
            btnFactorialCalculate.Click += btnFactorialCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 37);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 4;
            label2.Text = "Sum Calculator:";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(397, 70);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(168, 27);
            txtArrayInput.TabIndex = 5;
            txtArrayInput.Text = "Input Here";
            // 
            // lblSumResult
            // 
            lblSumResult.BackColor = Color.Ivory;
            lblSumResult.Location = new Point(397, 103);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(168, 27);
            lblSumResult.TabIndex = 6;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(427, 145);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 29);
            btnCalculateSum.TabIndex = 7;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 254);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 8;
            label3.Text = "Power Calculator:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 254);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 9;
            label4.Text = "Fibbonacci Calculator:";
            // 
            // txtExponentNum
            // 
            txtExponentNum.Location = new Point(566, 287);
            txtExponentNum.Name = "txtExponentNum";
            txtExponentNum.Size = new Size(168, 27);
            txtExponentNum.TabIndex = 10;
            txtExponentNum.Text = "Input Power Here";
            // 
            // txtBaseNum
            // 
            txtBaseNum.Location = new Point(382, 287);
            txtBaseNum.Name = "txtBaseNum";
            txtBaseNum.Size = new Size(168, 27);
            txtBaseNum.TabIndex = 11;
            txtBaseNum.Text = "Input Base Here";
            // 
            // txtInputFibo
            // 
            txtInputFibo.Location = new Point(56, 287);
            txtInputFibo.Name = "txtInputFibo";
            txtInputFibo.Size = new Size(168, 27);
            txtInputFibo.TabIndex = 12;
            txtInputFibo.Text = "Input Here";
            // 
            // lblResultPower
            // 
            lblResultPower.BackColor = Color.Ivory;
            lblResultPower.Location = new Point(475, 320);
            lblResultPower.Name = "lblResultPower";
            lblResultPower.Size = new Size(168, 27);
            lblResultPower.TabIndex = 13;
            // 
            // lblResultFibo
            // 
            lblResultFibo.BackColor = Color.Ivory;
            lblResultFibo.Location = new Point(56, 320);
            lblResultFibo.Name = "lblResultFibo";
            lblResultFibo.Size = new Size(200, 27);
            lblResultFibo.TabIndex = 14;
            // 
            // btnCalculatePower
            // 
            btnCalculatePower.Location = new Point(515, 363);
            btnCalculatePower.Name = "btnCalculatePower";
            btnCalculatePower.Size = new Size(94, 29);
            btnCalculatePower.TabIndex = 15;
            btnCalculatePower.Text = "Calculate";
            btnCalculatePower.UseVisualStyleBackColor = true;
            btnCalculatePower.Click += btnCalculatePower_Click;
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(86, 363);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(94, 29);
            btnCalculateFibonacci.TabIndex = 16;
            btnCalculateFibonacci.Text = "Calculate";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculateFibonacci);
            Controls.Add(btnCalculatePower);
            Controls.Add(lblResultFibo);
            Controls.Add(lblResultPower);
            Controls.Add(txtInputFibo);
            Controls.Add(txtBaseNum);
            Controls.Add(txtExponentNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCalculateSum);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(label2);
            Controls.Add(btnFactorialCalculate);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private TextBox lblResult;
        private Button btnFactorialCalculate;
        private Label label2;
        private TextBox txtArrayInput;
        private TextBox lblSumResult;
        private Button btnCalculateSum;
        private Label label3;
        private Label label4;
        private TextBox txtExponentNum;
        private TextBox txtBaseNum;
        private TextBox txtInputFibo;
        private TextBox lblResultPower;
        private TextBox lblResultFibo;
        private Button btnCalculatePower;
        private Button btnCalculateFibonacci;
    }
}
