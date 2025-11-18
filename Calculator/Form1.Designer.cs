
namespace Calculator
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            buttonEquals = new Button();
            button0 = new Button();
            button12 = new Button();
            buttonFib = new Button();
            buttonRootTwo = new Button();
            buttonPower = new Button();
            buttonAbsolute = new Button();
            buttonReciprocal = new Button();
            buttonPi = new Button();
            buttonMultiplication = new Button();
            buttonDiv = new Button();
            buttonLog = new Button();
            buttonFloat = new Button();
            buttonMinus = new Button();
            buttonPlus = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 58);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(4, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(85, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(166, 69);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(166, 98);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(85, 98);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(4, 98);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Location = new Point(166, 127);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(85, 127);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(4, 127);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(166, 156);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(75, 23);
            buttonEquals.TabIndex = 12;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // button0
            // 
            button0.Location = new Point(85, 156);
            button0.Name = "button0";
            button0.Size = new Size(75, 23);
            button0.TabIndex = 11;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button12
            // 
            button12.Location = new Point(4, 214);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 10;
            button12.Text = "Clear";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // buttonFib
            // 
            buttonFib.Location = new Point(166, 185);
            buttonFib.Name = "buttonFib";
            buttonFib.Size = new Size(75, 23);
            buttonFib.TabIndex = 15;
            buttonFib.Text = "n!";
            buttonFib.UseVisualStyleBackColor = true;
            buttonFib.Click += buttonFib_Click;
            // 
            // buttonRootTwo
            // 
            buttonRootTwo.Location = new Point(247, 214);
            buttonRootTwo.Name = "buttonRootTwo";
            buttonRootTwo.Size = new Size(75, 23);
            buttonRootTwo.TabIndex = 14;
            buttonRootTwo.Text = "2√x";
            buttonRootTwo.UseVisualStyleBackColor = true;
            // 
            // buttonPower
            // 
            buttonPower.Location = new Point(247, 185);
            buttonPower.Name = "buttonPower";
            buttonPower.Size = new Size(75, 23);
            buttonPower.TabIndex = 13;
            buttonPower.Text = "^";
            buttonPower.UseVisualStyleBackColor = true;
            buttonPower.Click += buttonPower_Click;
            // 
            // buttonAbsolute
            // 
            buttonAbsolute.Location = new Point(166, 214);
            buttonAbsolute.Name = "buttonAbsolute";
            buttonAbsolute.Size = new Size(75, 23);
            buttonAbsolute.TabIndex = 18;
            buttonAbsolute.Text = "|x|";
            buttonAbsolute.UseVisualStyleBackColor = true;
            // 
            // buttonReciprocal
            // 
            buttonReciprocal.Location = new Point(85, 214);
            buttonReciprocal.Name = "buttonReciprocal";
            buttonReciprocal.Size = new Size(75, 23);
            buttonReciprocal.TabIndex = 17;
            buttonReciprocal.Text = "1/x";
            buttonReciprocal.UseVisualStyleBackColor = true;
            // 
            // buttonPi
            // 
            buttonPi.Location = new Point(4, 185);
            buttonPi.Name = "buttonPi";
            buttonPi.Size = new Size(75, 23);
            buttonPi.TabIndex = 16;
            buttonPi.Text = "π";
            buttonPi.UseVisualStyleBackColor = true;
            buttonPi.Click += buttonPi_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Location = new Point(247, 69);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(75, 23);
            buttonMultiplication.TabIndex = 19;
            buttonMultiplication.Text = "*";
            buttonMultiplication.UseVisualStyleBackColor = true;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(247, 98);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 23);
            buttonDiv.TabIndex = 20;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonLog
            // 
            buttonLog.Location = new Point(85, 185);
            buttonLog.Name = "buttonLog";
            buttonLog.Size = new Size(75, 23);
            buttonLog.TabIndex = 24;
            buttonLog.Text = "log";
            buttonLog.UseVisualStyleBackColor = true;
            // 
            // buttonFloat
            // 
            buttonFloat.Location = new Point(4, 156);
            buttonFloat.Name = "buttonFloat";
            buttonFloat.Size = new Size(75, 23);
            buttonFloat.TabIndex = 23;
            buttonFloat.Text = ".";
            buttonFloat.UseVisualStyleBackColor = true;
            buttonFloat.Click += buttonFloat_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(247, 156);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 23);
            buttonMinus.TabIndex = 22;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(247, 127);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 23);
            buttonPlus.TabIndex = 21;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 243);
            Controls.Add(buttonLog);
            Controls.Add(buttonFloat);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonAbsolute);
            Controls.Add(buttonReciprocal);
            Controls.Add(buttonPi);
            Controls.Add(buttonFib);
            Controls.Add(buttonRootTwo);
            Controls.Add(buttonPower);
            Controls.Add(buttonEquals);
            Controls.Add(button0);
            Controls.Add(button12);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonEquals;
        private Button button0;
        private Button button12;
        private Button buttonFib;
        private Button buttonRootTwo;
        private Button buttonPower;
        private Button buttonAbsolute;
        private Button buttonReciprocal;
        private Button buttonPi;
        private Button buttonMultiplication;
        private Button buttonDiv;
        private Button buttonLog;
        private Button buttonFloat;
        private Button buttonMinus;
        private Button buttonPlus;
    }
}
