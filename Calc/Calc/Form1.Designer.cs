namespace Calc
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
            txtDisplay = new TextBox();
            btnNumber1 = new Button();
            btnNumber2 = new Button();
            btnNumber3 = new Button();
            btnNumber6 = new Button();
            btnNumber5 = new Button();
            btnNumber4 = new Button();
            btnNumber9 = new Button();
            btnNumber8 = new Button();
            btnNumber7 = new Button();
            btnNumber0 = new Button();
            Minus = new Button();
            Add = new Button();
            Multiply = new Button();
            Devide = new Button();
            Clear = new Button();
            btnEqual = new Button();
            btnDot = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(218, 67);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnNumber1
            // 
            btnNumber1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber1.Location = new Point(11, 235);
            btnNumber1.Name = "btnNumber1";
            btnNumber1.Size = new Size(69, 69);
            btnNumber1.TabIndex = 1;
            btnNumber1.Text = "1";
            btnNumber1.UseVisualStyleBackColor = true;
            btnNumber1.Click += DigitButton_Click;
            // 
            // btnNumber2
            // 
            btnNumber2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber2.Location = new Point(86, 235);
            btnNumber2.Name = "btnNumber2";
            btnNumber2.Size = new Size(69, 69);
            btnNumber2.TabIndex = 2;
            btnNumber2.Text = "2";
            btnNumber2.UseVisualStyleBackColor = true;
            btnNumber2.Click += DigitButton_Click;
            // 
            // btnNumber3
            // 
            btnNumber3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber3.Location = new Point(161, 235);
            btnNumber3.Name = "btnNumber3";
            btnNumber3.Size = new Size(69, 69);
            btnNumber3.TabIndex = 3;
            btnNumber3.Text = "3";
            btnNumber3.UseVisualStyleBackColor = true;
            btnNumber3.Click += DigitButton_Click;
            // 
            // btnNumber6
            // 
            btnNumber6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber6.Location = new Point(161, 160);
            btnNumber6.Name = "btnNumber6";
            btnNumber6.Size = new Size(69, 69);
            btnNumber6.TabIndex = 4;
            btnNumber6.Text = "6";
            btnNumber6.UseVisualStyleBackColor = true;
            btnNumber6.Click += DigitButton_Click;
            // 
            // btnNumber5
            // 
            btnNumber5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber5.Location = new Point(86, 160);
            btnNumber5.Name = "btnNumber5";
            btnNumber5.Size = new Size(69, 69);
            btnNumber5.TabIndex = 5;
            btnNumber5.Text = "5";
            btnNumber5.UseVisualStyleBackColor = true;
            btnNumber5.Click += DigitButton_Click;
            // 
            // btnNumber4
            // 
            btnNumber4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber4.Location = new Point(11, 160);
            btnNumber4.Name = "btnNumber4";
            btnNumber4.Size = new Size(69, 69);
            btnNumber4.TabIndex = 6;
            btnNumber4.Text = "4";
            btnNumber4.UseVisualStyleBackColor = true;
            btnNumber4.Click += DigitButton_Click;
            // 
            // btnNumber9
            // 
            btnNumber9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber9.Location = new Point(161, 85);
            btnNumber9.Name = "btnNumber9";
            btnNumber9.Size = new Size(69, 69);
            btnNumber9.TabIndex = 7;
            btnNumber9.Text = "9";
            btnNumber9.UseVisualStyleBackColor = true;
            btnNumber9.Click += DigitButton_Click;
            // 
            // btnNumber8
            // 
            btnNumber8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber8.Location = new Point(86, 85);
            btnNumber8.Name = "btnNumber8";
            btnNumber8.Size = new Size(69, 69);
            btnNumber8.TabIndex = 8;
            btnNumber8.Text = "8";
            btnNumber8.UseVisualStyleBackColor = true;
            btnNumber8.Click += DigitButton_Click;
            // 
            // btnNumber7
            // 
            btnNumber7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber7.Location = new Point(11, 85);
            btnNumber7.Name = "btnNumber7";
            btnNumber7.Size = new Size(69, 69);
            btnNumber7.TabIndex = 9;
            btnNumber7.Text = "7";
            btnNumber7.UseVisualStyleBackColor = true;
            btnNumber7.Click += DigitButton_Click;
            // 
            // btnNumber0
            // 
            btnNumber0.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNumber0.Location = new Point(86, 310);
            btnNumber0.Name = "btnNumber0";
            btnNumber0.Size = new Size(69, 69);
            btnNumber0.TabIndex = 10;
            btnNumber0.Text = "0";
            btnNumber0.UseVisualStyleBackColor = true;
            btnNumber0.Click += DigitButton_Click;
            // 
            // Minus
            // 
            Minus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Minus.Location = new Point(237, 87);
            Minus.Name = "Minus";
            Minus.Size = new Size(69, 69);
            Minus.TabIndex = 11;
            Minus.Text = "-";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += OperatorButton_Click;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(236, 12);
            Add.Name = "Add";
            Add.Size = new Size(69, 69);
            Add.TabIndex = 13;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            Add.Click += OperatorButton_Click;
            // 
            // Multiply
            // 
            Multiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Multiply.Location = new Point(236, 235);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(69, 69);
            Multiply.TabIndex = 14;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            Multiply.Click += OperatorButton_Click;
            // 
            // Devide
            // 
            Devide.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Devide.Location = new Point(237, 160);
            Devide.Name = "Devide";
            Devide.Size = new Size(69, 69);
            Devide.TabIndex = 15;
            Devide.Text = "/";
            Devide.UseVisualStyleBackColor = true;
            Devide.Click += OperatorButton_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(11, 310);
            Clear.Name = "Clear";
            Clear.Size = new Size(69, 69);
            Clear.TabIndex = 16;
            Clear.Text = "CE";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.Info;
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(236, 310);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(70, 69);
            btnEqual.TabIndex = 20;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(161, 310);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(69, 69);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += DigitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 393);
            Controls.Add(btnDot);
            Controls.Add(btnEqual);
            Controls.Add(Clear);
            Controls.Add(Devide);
            Controls.Add(Multiply);
            Controls.Add(Add);
            Controls.Add(Minus);
            Controls.Add(btnNumber0);
            Controls.Add(btnNumber7);
            Controls.Add(btnNumber8);
            Controls.Add(btnNumber9);
            Controls.Add(btnNumber4);
            Controls.Add(btnNumber5);
            Controls.Add(btnNumber6);
            Controls.Add(btnNumber3);
            Controls.Add(btnNumber2);
            Controls.Add(btnNumber1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnNumber1;
        private Button btnNumber2;
        private Button btnNumber3;
        private Button btnNumber6;
        private Button btnNumber5;
        private Button btnNumber4;
        private Button btnNumber9;
        private Button btnNumber8;
        private Button btnNumber7;
        private Button btnNumber0;
        private Button Minus;
        private Button Add;
        private Button Multiply;
        private Button Devide;
        private Button Clear;
        private Button btnEqual;
        private Button btnDot;
    }
}