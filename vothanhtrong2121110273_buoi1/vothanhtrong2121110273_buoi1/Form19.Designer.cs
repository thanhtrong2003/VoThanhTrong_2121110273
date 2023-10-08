namespace vothanhtrong2121110273_buoi1
{
    partial class Form19
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pbImage = new PictureBox();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 26);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 20);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 72);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 31);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 72);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 126);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Ảnh 3*4";
            // 
            // pbImage
            // 
            pbImage.Location = new Point(172, 126);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(142, 162);
            pbImage.TabIndex = 5;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(372, 144);
            btFile.Name = "btFile";
            btFile.Size = new Size(112, 34);
            btFile.TabIndex = 6;
            btFile.Text = "Chọn ảnh";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form19";
            Text = "Form19";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private PictureBox pbImage;
        private Button btFile;
    }
}