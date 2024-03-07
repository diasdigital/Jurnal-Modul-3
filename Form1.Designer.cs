namespace modul3_1302223134
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonPlus = new Button();
            buttonEqual = new Button();
            boxHasil = new TextBox();
            button0 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(83, 110);
            button1.Name = "button1";
            button1.Size = new Size(46, 23);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 110);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(177, 110);
            button3.Name = "button3";
            button3.Size = new Size(46, 23);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(83, 132);
            button4.Name = "button4";
            button4.Size = new Size(46, 23);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(130, 132);
            button5.Name = "button5";
            button5.Size = new Size(46, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(177, 132);
            button6.Name = "button6";
            button6.Size = new Size(46, 23);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(83, 154);
            button7.Name = "button7";
            button7.Size = new Size(46, 23);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(130, 154);
            button8.Name = "button8";
            button8.Size = new Size(46, 23);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(177, 154);
            button9.Name = "button9";
            button9.Size = new Size(46, 23);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(266, 110);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(46, 23);
            buttonPlus.TabIndex = 9;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(266, 132);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(46, 23);
            buttonEqual.TabIndex = 10;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // boxHasil
            // 
            boxHasil.Enabled = false;
            boxHasil.Location = new Point(83, 46);
            boxHasil.Name = "boxHasil";
            boxHasil.Size = new Size(229, 23);
            boxHasil.TabIndex = 12;
            boxHasil.TextChanged += boxHasil_TextChanged;
            // 
            // button0
            // 
            button0.Location = new Point(130, 177);
            button0.Name = "button0";
            button0.Size = new Size(46, 23);
            button0.TabIndex = 13;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 227);
            Controls.Add(button0);
            Controls.Add(boxHasil);
            Controls.Add(buttonEqual);
            Controls.Add(buttonPlus);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonPlus;
        private Button buttonEqual;
        private TextBox boxHasil;
        private Button button0;
    }
}
