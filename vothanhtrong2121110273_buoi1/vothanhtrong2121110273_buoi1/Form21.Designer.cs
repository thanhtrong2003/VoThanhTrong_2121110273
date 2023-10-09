namespace vothanhtrong2121110273_buoi1
{
    partial class Form21
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
            components = new System.ComponentModel.Container();
            dgvEmployee = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btDelete = new Button();
            btClose = new Button();
            tbName = new TextBox();
            tbAge = new TextBox();
            employeeBindingSource = new BindingSource(components);
            btEdit = new Button();
            pbImage = new PictureBox();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvEmployee.Location = new Point(73, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 62;
            dgvEmployee.RowTemplate.Height = 33;
            dgvEmployee.Size = new Size(689, 181);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Mã nhân viên";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Tên nhân viên";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.HeaderText = "Tuổi";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Gender";
            Column4.HeaderText = "Giới tính(Nam)";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 212);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 258);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 299);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // tbId
            // 
            tbId.Location = new Point(176, 209);
            tbId.Name = "tbId";
            tbId.Size = new Size(197, 31);
            tbId.TabIndex = 4;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Location = new Point(73, 343);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(85, 29);
            ckGender.TabIndex = 5;
            ckGender.Text = "Name";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(355, 381);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(112, 34);
            btAddNew.TabIndex = 6;
            btAddNew.Text = "Thêm";
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(498, 381);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(112, 34);
            btDelete.TabIndex = 7;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(760, 381);
            btClose.Name = "btClose";
            btClose.Size = new Size(112, 34);
            btClose.TabIndex = 8;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(176, 258);
            tbName.Name = "tbName";
            tbName.Size = new Size(246, 31);
            tbName.TabIndex = 9;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(176, 299);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(197, 31);
            tbAge.TabIndex = 10;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // btEdit
            // 
            btEdit.Location = new Point(630, 381);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(112, 34);
            btEdit.TabIndex = 11;
            btEdit.Text = "Sửa";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(533, 220);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(97, 110);
            pbImage.TabIndex = 12;
            pbImage.TabStop = false;
            // 
            // btFile
            // 
            btFile.Location = new Point(650, 299);
            btFile.Name = "btFile";
            btFile.Size = new Size(112, 34);
            btFile.TabIndex = 13;
            btFile.Text = "Chọn ảnh";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form21
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 496);
            Controls.Add(btFile);
            Controls.Add(pbImage);
            Controls.Add(btEdit);
            Controls.Add(tbAge);
            Controls.Add(tbName);
            Controls.Add(btClose);
            Controls.Add(btDelete);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Name = "Form21";
            Text = "Form21";
            Load += Form21_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btDelete;
        private Button btClose;
        private TextBox tbName;
        private TextBox tbAge;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private BindingSource employeeBindingSource;
        private Button btEdit;
        private PictureBox pbImage;
        private Button btFile;
    }
}