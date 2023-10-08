namespace vothanhtrong2121110273_buoi1
{
    partial class Form17
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
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            btSelect = new Button();
            btDeselect = new Button();
            btSelectAll = new Button();
            btDeselectAll = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.ItemHeight = 25;
            lbSong.Items.AddRange(new object[] { "Cơn mưa ngang qua", "Nắng ấm xa dần", "Chúng ta của hiện tại", "Chúng ta không thuộc về nhau", "Buông đôi tay nhau ra", "Hãy trao cho anh", "Nơi này có anh", "Em của ngày hôm qua", "Am thầm bên em ", "Lạc trôi" });
            lbSong.Location = new Point(38, 41);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(213, 379);
            lbSong.TabIndex = 0;
            lbSong.SelectedIndexChanged += lbSong_SelectedIndexChanged;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.ItemHeight = 25;
            lbFavorite.Location = new Point(326, 41);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(213, 379);
            lbFavorite.TabIndex = 1;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(257, 126);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(63, 43);
            btSelect.TabIndex = 2;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(257, 175);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(63, 43);
            btDeselect.TabIndex = 3;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // btSelectAll
            // 
            btSelectAll.Location = new Point(257, 224);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(63, 43);
            btSelectAll.TabIndex = 4;
            btSelectAll.Text = ">>";
            btSelectAll.UseVisualStyleBackColor = true;
            btSelectAll.Click += btSelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(257, 273);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(63, 43);
            btDeselectAll.TabIndex = 5;
            btDeselectAll.Text = "<<";
            btDeselectAll.UseVisualStyleBackColor = true;
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 6;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(326, 9);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 7;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btDeselectAll);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Name = "Form17";
            Text = "Form17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbSong;
        private ListBox lbFavorite;
        private Button btSelect;
        private Button btDeselect;
        private Button btSelectAll;
        private Button btDeselectAll;
        private Label label1;
        private Label label2;
    }
}