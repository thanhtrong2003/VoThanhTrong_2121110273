namespace vothanhtrong2121110273_buoi1
{
    partial class Form20
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
            dgvEmployee = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            imageCol = new DataGridViewImageColumn();
            label1 = new Label();
            tbId = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            btClose = new Button();
            label2 = new Label();
            label3 = new Label();
            tbName = new TextBox();
            tbAge = new TextBox();
            btEdit = new Button();
            pbImage = new PictureBox();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, imageCol });
            dgvEmployee.Location = new Point(58, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.RowTemplate.Height = 33;
            dgvEmployee.Size = new Size(797, 217);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Mã nhân viên";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tuổi";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính(Nam)";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // imageCol
            // 
            imageCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            imageCol.HeaderText = "Image";
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageCol.MinimumWidth = 8;
            imageCol.Name = "imageCol";
            imageCol.Resizable = DataGridViewTriState.True;
            imageCol.SortMode = DataGridViewColumnSortMode.Automatic;
            imageCol.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 258);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            // 
            // tbId
            // 
            tbId.Location = new Point(156, 252);
            tbId.Name = "tbId";
            tbId.Size = new Size(213, 31);
            tbId.TabIndex = 2;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(58, 424);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(76, 29);
            ckGender.TabIndex = 3;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(351, 486);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(112, 34);
            btAddNew.TabIndex = 4;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(469, 486);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 5;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(715, 486);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 6;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 299);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 345);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 8;
            label3.Text = "Tuổi";
            // 
            // tbName
            // 
            tbName.Location = new Point(156, 299);
            tbName.Name = "tbName";
            tbName.Size = new Size(264, 31);
            tbName.TabIndex = 9;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(156, 345);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(213, 31);
            tbAge.TabIndex = 10;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(587, 486);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(112, 34);
            btEdit.TabIndex = 11;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(519, 235);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(105, 141);
            pbImage.TabIndex = 12;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(641, 345);
            btFile.Name = "btFile";
            btFile.Size = new Size(112, 34);
            btFile.TabIndex = 13;
            btFile.Text = "Thêm ảnh";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form20
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 613);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Controls.Add(btEdit);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btClose);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbId);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Name = "Form20";
            Text = "Form20";
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label label1;
        private TextBox tbId;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button btClose;
        private Label label2;
        private Label label3;
        private TextBox tbName;
        private TextBox tbAge;
        private Button btEdit;
        private PictureBox pbImage;
        private Button btFile;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn imageCol;
    }
}