namespace CalculatorGui
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
            btn7 = new Button();
            btn1 = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDevide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnC = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnEqual = new Button();
            btnAdd = new Button();
            History = new ListBox();
            btnDecimal = new Button();
            btnClearHistory = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(12, 27);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(381, 43);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(224, 224, 224);
            btn7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(12, 98);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(12, 178);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 2;
            btn1.Text = "1\r\n";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Lime;
            btnMultiply.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(318, 137);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 3;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(212, 137);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(112, 137);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(12, 137);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDevide
            // 
            btnDevide.BackColor = Color.Lime;
            btnDevide.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevide.Location = new Point(318, 98);
            btnDevide.Name = "btnDevide";
            btnDevide.Size = new Size(75, 23);
            btnDevide.TabIndex = 7;
            btnDevide.Text = "/";
            btnDevide.UseVisualStyleBackColor = false;
            btnDevide.Click += btnDevide_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(212, 98);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(224, 224, 224);
            btn8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(112, 98);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(112, 178);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(212, 178);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Lime;
            btnC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(212, 219);
            btnC.Name = "btnC";
            btnC.Size = new Size(75, 23);
            btnC.TabIndex = 12;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(12, 219);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 23);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Lime;
            btnMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(318, 178);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(75, 23);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.Red;
            btnEqual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(12, 250);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(128, 41);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(318, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // History
            // 
            History.BackColor = Color.FromArgb(224, 224, 224);
            History.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            History.FormattingEnabled = true;
            History.ItemHeight = 21;
            History.Location = new Point(12, 306);
            History.Name = "History";
            History.Size = new Size(381, 109);
            History.TabIndex = 17;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(112, 219);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(75, 23);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnClearHistory
            // 
            btnClearHistory.BackColor = Color.Red;
            btnClearHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearHistory.Location = new Point(212, 250);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(181, 41);
            btnClearHistory.TabIndex = 19;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = false;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(btnClearHistory);
            Controls.Add(btnDecimal);
            Controls.Add(History);
            Controls.Add(btnAdd);
            Controls.Add(btnEqual);
            Controls.Add(btnMinus);
            Controls.Add(btn0);
            Controls.Add(btnC);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btnDevide);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btnMultiply);
            Controls.Add(btn1);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn1;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnDevide;
        private Button btn9;
        private Button btn8;
        private Button btn2;
        private Button btn3;
        private Button btnC;
        private Button btn0;
        private Button btnMinus;
        private Button btnEqual;
        private Button btnAdd;
        private ListBox History;
        private Button btnDecimal;
        private Button btnClearHistory;
    }
}
