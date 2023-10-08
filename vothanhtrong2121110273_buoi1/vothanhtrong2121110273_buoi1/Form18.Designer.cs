namespace vothanhtrong2121110273_buoi1
{
    partial class Form18
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
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            label1 = new Label();
            btSelect = new Button();
            label2 = new Label();
            btDeselect = new Button();
            songBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)songBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.DataSource = songBindingSource;
            lbSong.FormattingEnabled = true;
            lbSong.ItemHeight = 25;
            lbSong.Location = new Point(40, 36);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(311, 354);
            lbSong.TabIndex = 0;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.ItemHeight = 25;
            lbFavorite.Location = new Point(436, 36);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(352, 354);
            lbFavorite.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 2;
            label1.Text = "Danh sách bài hát";
            // 
            // btSelect
            // 
            btSelect.Location = new Point(357, 169);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(62, 43);
            btSelect.TabIndex = 3;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(436, 8);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 4;
            label2.Text = "Danh sách bài hát yêu thích";
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(357, 218);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(62, 43);
            btDeselect.TabIndex = 5;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // songBindingSource
            // 
            songBindingSource.DataSource = typeof(Song);
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btDeselect);
            Controls.Add(label2);
            Controls.Add(btSelect);
            Controls.Add(label1);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Name = "Form18";
            Text = "Form18";
            Load += Form18_Load;
            ((System.ComponentModel.ISupportInitialize)songBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbSong;
        private ListBox lbFavorite;
        private Label label1;
        private Button btSelect;
        private Label label2;
        private Button btDeselect;
        private BindingSource songBindingSource;
    }
}