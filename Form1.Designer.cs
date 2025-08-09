namespace A01_Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnPlus = new Button();
            btnEquals = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnDivide = new Button();
            btnTimes = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnErase = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            txtEquation = new TextBox();
            btnSettings = new Button();
            lblHistory = new Label();
            txtHistory = new TextBox();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 59);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(210, 35);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(14, 427);
            button1.Name = "button1";
            button1.Size = new Size(72, 66);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(95, 427);
            button2.Name = "button2";
            button2.Size = new Size(72, 66);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(173, 427);
            button3.Name = "button3";
            button3.Size = new Size(72, 66);
            button3.TabIndex = 4;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(251, 427);
            button4.Name = "button4";
            button4.Size = new Size(72, 66);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.BackColor = Color.WhiteSmoke;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.Font = new Font("Segoe UI", 18F);
            btn0.Location = new Point(12, 296);
            btn0.Name = "btn0";
            btn0.Size = new Size(48, 44);
            btn0.TabIndex = 6;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.WhiteSmoke;
            btnDot.FlatAppearance.BorderSize = 0;
            btnDot.Font = new Font("Segoe UI", 18F);
            btnDot.Location = new Point(66, 296);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(48, 44);
            btnDot.TabIndex = 7;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            btnDot.MouseDown += btnDot_MouseDown;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(224, 136, 4);
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.Font = new Font("Segoe UI", 18F);
            btnPlus.Location = new Point(120, 296);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(48, 44);
            btnPlus.TabIndex = 8;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += Operator;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(224, 136, 4);
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.Font = new Font("Segoe UI", 18F);
            btnEquals.Location = new Point(174, 296);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(48, 44);
            btnEquals.TabIndex = 9;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.WhiteSmoke;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.Font = new Font("Segoe UI", 18F);
            btn1.Location = new Point(12, 246);
            btn1.Name = "btn1";
            btn1.Size = new Size(48, 44);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.WhiteSmoke;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.Font = new Font("Segoe UI", 18F);
            btn2.Location = new Point(66, 246);
            btn2.Name = "btn2";
            btn2.Size = new Size(48, 44);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.WhiteSmoke;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.Font = new Font("Segoe UI", 18F);
            btn3.Location = new Point(120, 246);
            btn3.Name = "btn3";
            btn3.Size = new Size(48, 44);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(224, 136, 4);
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.Font = new Font("Segoe UI", 18F);
            btnMinus.Location = new Point(174, 246);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(48, 44);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += Operator;
            // 
            // btn4
            // 
            btn4.BackColor = Color.WhiteSmoke;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.Font = new Font("Segoe UI", 18F);
            btn4.Location = new Point(12, 196);
            btn4.Name = "btn4";
            btn4.Size = new Size(48, 44);
            btn4.TabIndex = 14;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.WhiteSmoke;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.Font = new Font("Segoe UI", 18F);
            btn5.Location = new Point(66, 196);
            btn5.Name = "btn5";
            btn5.Size = new Size(48, 44);
            btn5.TabIndex = 15;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.WhiteSmoke;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.Font = new Font("Segoe UI", 18F);
            btn6.Location = new Point(120, 196);
            btn6.Name = "btn6";
            btn6.Size = new Size(48, 44);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(224, 136, 4);
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.Font = new Font("Segoe UI", 18F);
            btnDivide.Location = new Point(174, 196);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(48, 44);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator;
            // 
            // btnTimes
            // 
            btnTimes.BackColor = Color.FromArgb(224, 136, 4);
            btnTimes.FlatAppearance.BorderSize = 0;
            btnTimes.Font = new Font("Segoe UI", 18F);
            btnTimes.Location = new Point(174, 146);
            btnTimes.Name = "btnTimes";
            btnTimes.Size = new Size(48, 44);
            btnTimes.TabIndex = 21;
            btnTimes.Text = "*";
            btnTimes.UseVisualStyleBackColor = false;
            btnTimes.Click += Operator;
            // 
            // btn9
            // 
            btn9.BackColor = Color.WhiteSmoke;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.Font = new Font("Segoe UI", 18F);
            btn9.Location = new Point(120, 146);
            btn9.Name = "btn9";
            btn9.Size = new Size(48, 44);
            btn9.TabIndex = 20;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.WhiteSmoke;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.Font = new Font("Segoe UI", 18F);
            btn8.Location = new Point(66, 146);
            btn8.Name = "btn8";
            btn8.Size = new Size(48, 44);
            btn8.TabIndex = 19;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.WhiteSmoke;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.Font = new Font("Segoe UI", 18F);
            btn7.Location = new Point(12, 146);
            btn7.Name = "btn7";
            btn7.Size = new Size(48, 44);
            btn7.TabIndex = 18;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btnErase
            // 
            btnErase.BackColor = Color.FromArgb(239, 43, 43);
            btnErase.FlatAppearance.BorderSize = 0;
            btnErase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnErase.Location = new Point(174, 98);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(48, 44);
            btnErase.TabIndex = 24;
            btnErase.Text = "⌫";
            btnErase.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 43, 43);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(120, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(48, 44);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "C";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(239, 43, 43);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(66, 98);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(48, 44);
            btnClear.TabIndex = 22;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtEquation
            // 
            txtEquation.BackColor = Color.IndianRed;
            txtEquation.BorderStyle = BorderStyle.None;
            txtEquation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEquation.Location = new Point(12, 42);
            txtEquation.Multiline = true;
            txtEquation.Name = "txtEquation";
            txtEquation.Size = new Size(210, 17);
            txtEquation.TabIndex = 25;
            txtEquation.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSettings
            // 
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(192, 7);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(30, 23);
            btnSettings.TabIndex = 26;
            btnSettings.Text = "☰";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistory.Location = new Point(231, 18);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(47, 15);
            lblHistory.TabIndex = 27;
            lblHistory.Text = "History";
            lblHistory.Click += label1_Click;
            // 
            // txtHistory
            // 
            txtHistory.Location = new Point(231, 36);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(107, 304);
            txtHistory.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(350, 352);
            Controls.Add(txtHistory);
            Controls.Add(lblHistory);
            Controls.Add(btnSettings);
            Controls.Add(txtEquation);
            Controls.Add(btnErase);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnTimes);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMinus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btn0;
        private Button btnDot;
        private Button btnPlus;
        private Button btnEquals;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnMinus;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnDivide;
        private Button btnTimes;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnErase;
        private Button btnDelete;
        private Button btnClear;
        private TextBox txtEquation;
        private Button btnSettings;
        private Label lblHistory;
        private TextBox txtHistory;
    }
}
