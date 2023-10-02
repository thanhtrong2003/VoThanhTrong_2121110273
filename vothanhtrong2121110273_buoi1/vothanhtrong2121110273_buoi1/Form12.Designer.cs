namespace vothanhtrong2121110273_buoi1
{
    partial class Form12
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
            cbFaculty = new ComboBox();
            tbDisplay = new TextBox();
            btnOk = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngoại ngữ", "Quản trị kinh doanh ", "Cơ khí ", "Điện", "Cơ khí động lực" });
            cbFaculty.Location = new Point(164, 21);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(303, 23);
            cbFaculty.TabIndex = 0;
            cbFaculty.SelectedIndexChanged += cbFaculty_SelectedIndexChanged;
            // 
            // tbDisplay
            // 
            tbDisplay.Location = new Point(164, 88);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(303, 174);
            tbDisplay.TabIndex = 1;
            tbDisplay.TextChanged += tbDisplay_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(392, 284);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(311, 284);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnOk);
            Controls.Add(tbDisplay);
            Controls.Add(cbFaculty);
            Name = "Form12";
            Text = "Form12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbFaculty;
        private TextBox tbDisplay;
        private Button btnOk;
        private Button btnClear;
    }
}