namespace vothanhtrong2121110273_buoi1
{
    partial class Form9
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
            tbSox = new TextBox();
            tbSoy = new TextBox();
            tbkqua = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btLuu = new Button();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // tbSox
            // 
            tbSox.Location = new Point(97, 33);
            tbSox.Name = "tbSox";
            tbSox.Size = new Size(583, 23);
            tbSox.TabIndex = 0;
            // 
            // tbSoy
            // 
            tbSoy.Location = new Point(97, 75);
            tbSoy.Name = "tbSoy";
            tbSoy.Size = new Size(583, 23);
            tbSoy.TabIndex = 1;
            // 
            // tbkqua
            // 
            tbkqua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbkqua.Location = new Point(97, 137);
            tbkqua.Multiline = true;
            tbkqua.Name = "tbkqua";
            tbkqua.Size = new Size(583, 204);
            tbkqua.TabIndex = 2;
            tbkqua.TextChanged += textBox3_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 41);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "Số X\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 83);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "Số Y\r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 145);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Kết quả\r\n";
            // 
            // btLuu
            // 
            btLuu.Location = new Point(33, 373);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(75, 23);
            btLuu.TabIndex = 6;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // btCong
            // 
            btCong.Location = new Point(478, 373);
            btCong.Name = "btCong";
            btCong.Size = new Size(75, 23);
            btCong.TabIndex = 7;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.Location = new Point(581, 373);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(75, 23);
            btNhan.TabIndex = 8;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += button3_Click;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btThoat.Location = new Point(696, 373);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(75, 23);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(btLuu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbkqua);
            Controls.Add(tbSoy);
            Controls.Add(tbSox);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSox;
        private TextBox tbSoy;
        private TextBox tbkqua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btLuu;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
    }
}