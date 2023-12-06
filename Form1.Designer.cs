namespace MyCalculator
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
            FirstNumber = new Label();
            TxtNumber1 = new NumericUpDown();
            TxtNumber2 = new NumericUpDown();
            SecondNumber = new Label();
            SumButton = new Button();
            divideButton = new Button();
            multiplyButton = new Button();
            MinusButton = new Button();
            Risultbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)TxtNumber1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumber2).BeginInit();
            SuspendLayout();
            // 
            // FirstNumber
            // 
            FirstNumber.AutoSize = true;
            FirstNumber.Location = new Point(345, 58);
            FirstNumber.Name = "FirstNumber";
            FirstNumber.Size = new Size(53, 14);
            FirstNumber.TabIndex = 0;
            FirstNumber.Text = "عدد اول";
            // 
            // TxtNumber1
            // 
            TxtNumber1.Location = new Point(75, 50);
            TxtNumber1.Name = "TxtNumber1";
            TxtNumber1.Size = new Size(245, 22);
            TxtNumber1.TabIndex = 1;
            // 
            // TxtNumber2
            // 
            TxtNumber2.Location = new Point(75, 87);
            TxtNumber2.Name = "TxtNumber2";
            TxtNumber2.Size = new Size(245, 22);
            TxtNumber2.TabIndex = 3;
            // 
            // SecondNumber
            // 
            SecondNumber.AutoSize = true;
            SecondNumber.Location = new Point(343, 95);
            SecondNumber.Name = "SecondNumber";
            SecondNumber.Size = new Size(55, 14);
            SecondNumber.TabIndex = 2;
            SecondNumber.Text = "عدد دوم";
            // 
            // SumButton
            // 
            SumButton.Location = new Point(42, 124);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(78, 39);
            SumButton.TabIndex = 4;
            SumButton.Text = "+";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(343, 124);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 39);
            divideButton.TabIndex = 7;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(244, 124);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(76, 39);
            multiplyButton.TabIndex = 8;
            multiplyButton.Text = "*";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(141, 124);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(76, 39);
            MinusButton.TabIndex = 9;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // Risultbutton
            // 
            Risultbutton.BackColor = SystemColors.InactiveBorder;
            Risultbutton.Location = new Point(93, 212);
            Risultbutton.Name = "Risultbutton";
            Risultbutton.Size = new Size(246, 40);
            Risultbutton.TabIndex = 10;
            Risultbutton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 309);
            Controls.Add(Risultbutton);
            Controls.Add(MinusButton);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(SumButton);
            Controls.Add(TxtNumber2);
            Controls.Add(SecondNumber);
            Controls.Add(TxtNumber1);
            Controls.Add(FirstNumber);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ماشین حساب من";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)TxtNumber1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtNumber2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNumber;
        private NumericUpDown TxtNumber1;
        private NumericUpDown TxtNumber2;
        private Label SecondNumber;
        private Button SumButton;
        private Button divideButton;
        private Button multiplyButton;
        private Button MinusButton;
        private Button Risultbutton;
    }
}