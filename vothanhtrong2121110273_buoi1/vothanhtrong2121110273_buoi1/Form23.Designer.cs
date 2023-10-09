namespace vothanhtrong2121110273_buoi1
{
    partial class Form23
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
            pbImage = new PictureBox();
            btLeft = new Button();
            btRight = new Button();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 12);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(128, 166);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btLeft
            // 
            btLeft.Location = new Point(89, 281);
            btLeft.Name = "btLeft";
            btLeft.Size = new Size(66, 63);
            btLeft.TabIndex = 1;
            btLeft.Text = "<-";
            btLeft.UseVisualStyleBackColor = true;
            btLeft.Click += btLeft_Click;
            // 
            // btRight
            // 
            btRight.Location = new Point(189, 281);
            btRight.Name = "btRight";
            btRight.Size = new Size(66, 63);
            btRight.TabIndex = 2;
            btRight.Text = "->";
            btRight.UseVisualStyleBackColor = true;
            btRight.Click += btRight_Click;
            // 
            // btFile
            // 
            btFile.Location = new Point(423, 281);
            btFile.Name = "btFile";
            btFile.Size = new Size(152, 63);
            btFile.TabIndex = 3;
            btFile.Text = "File";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btFile);
            Controls.Add(btRight);
            Controls.Add(btLeft);
            Controls.Add(pbImage);
            Name = "Form23";
            Text = "Form23";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Button btLeft;
        private Button btRight;
        private Button btFile;
    }
}