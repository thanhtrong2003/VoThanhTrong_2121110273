namespace vothanhtrong2121110273_buoi1
{
    partial class Form14
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
            tbName = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            ckDiscount = new CheckBox();
            tbDiscount = new TextBox();
            tbResult = new TextBox();
            btRun = new Button();
            btClose = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(69, 12);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(555, 34);
            tbName.TabIndex = 0;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(95, 136);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 1;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(350, 136);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(61, 29);
            rbFemale.TabIndex = 2;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            ckDiscount.AutoSize = true;
            ckDiscount.Location = new Point(69, 238);
            ckDiscount.Name = "ckDiscount";
            ckDiscount.Size = new Size(108, 29);
            ckDiscount.TabIndex = 3;
            ckDiscount.Text = "Giảm giá";
            ckDiscount.UseVisualStyleBackColor = true;
            ckDiscount.CheckedChanged += ckDiscount_CheckedChanged;
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(219, 231);
            tbDiscount.Multiline = true;
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(405, 36);
            tbDiscount.TabIndex = 4;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(69, 297);
            tbResult.Multiline = true;
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(555, 116);
            tbResult.TabIndex = 5;
            tbResult.TextChanged += tbResult_TextChanged;
            // 
            // btRun
            // 
            btRun.Location = new Point(389, 456);
            btRun.Name = "btRun";
            btRun.Size = new Size(112, 34);
            btRun.TabIndex = 6;
            btRun.Text = "Tính tiền";
            btRun.UseVisualStyleBackColor = true;
            btRun.Click += btRun_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(512, 456);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 7;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 83);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 8;
            label1.Text = "Giới tính";
            label1.Click += label1_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 532);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btRun);
            Controls.Add(tbResult);
            Controls.Add(tbDiscount);
            Controls.Add(ckDiscount);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(tbName);
            Name = "Form14";
            Text = "Form14";
            Load += Form14_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox ckDiscount;
        private TextBox tbDiscount;
        private TextBox tbResult;
        private Button btRun;
        private Button btClose;
        private Label label1;
    }
}