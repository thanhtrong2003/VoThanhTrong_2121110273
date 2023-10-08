namespace vothanhtrong2121110273_buoi1
{
    partial class Form16
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dtpDate = new DateTimePicker();
            groupBox1 = new GroupBox();
            rbNu = new RadioButton();
            rbNam = new RadioButton();
            label3 = new Label();
            cbKhoa = new ComboBox();
            label4 = new Label();
            tbStatus = new TextBox();
            btThem = new Button();
            btThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 81);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(183, 75);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(353, 31);
            dtpDate.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNu);
            groupBox1.Controls.Add(rbNam);
            groupBox1.Location = new Point(183, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 105);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới tính";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(131, 40);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(61, 29);
            rbNu.TabIndex = 1;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(6, 40);
            rbNam.Name = "rbNam";
            rbNam.Size = new Size(75, 29);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 244);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 5;
            label3.Text = "Khoa";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Items.AddRange(new object[] { "Công Nghệ Thông Tin" });
            cbKhoa.Location = new Point(183, 236);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(353, 33);
            cbKhoa.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 297);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Trạng thái";
            // 
            // tbStatus
            // 
            tbStatus.Location = new Point(183, 297);
            tbStatus.Multiline = true;
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(353, 189);
            tbStatus.TabIndex = 8;
            // 
            // btThem
            // 
            btThem.Location = new Point(293, 517);
            btThem.Name = "btThem";
            btThem.Size = new Size(112, 34);
            btThem.TabIndex = 9;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(424, 517);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(112, 34);
            btThoat.TabIndex = 10;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 640);
            Controls.Add(btThoat);
            Controls.Add(btThem);
            Controls.Add(tbStatus);
            Controls.Add(label4);
            Controls.Add(cbKhoa);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(dtpDate);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form16";
            Text = "Form16";
            Load += Form16_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dtpDate;
        private GroupBox groupBox1;
        private RadioButton rbNu;
        private RadioButton rbNam;
        private Label label3;
        private ComboBox cbKhoa;
        private Label label4;
        private TextBox tbStatus;
        private Button btThem;
        private Button btThoat;
    }
}