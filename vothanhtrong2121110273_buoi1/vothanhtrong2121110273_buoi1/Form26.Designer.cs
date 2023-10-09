namespace vothanhtrong2121110273_buoi1
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            pbEgg = new PictureBox();
            tmEgg = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbEgg).BeginInit();
            SuspendLayout();
            // 
            // pbEgg
            // 
            pbEgg.Image = (Image)resources.GetObject("pbEgg.Image");
            pbEgg.Location = new Point(349, 12);
            pbEgg.Name = "pbEgg";
            pbEgg.Size = new Size(75, 95);
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.TabIndex = 0;
            pbEgg.TabStop = false;
            // 
            // tmEgg
            // 
            tmEgg.Tick += tmEgg_Tick;
            // 
            // Form26
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbEgg);
            Name = "Form26";
            Text = "Form26";
            Load += Form26_Load;
            ((System.ComponentModel.ISupportInitialize)pbEgg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbEgg;
        private System.Windows.Forms.Timer tmEgg;
    }
}