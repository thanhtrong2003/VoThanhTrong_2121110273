namespace vothanhtrong2121110273_buoi1
{
    partial class Form24
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
            tmStopWatch = new System.Windows.Forms.Timer(components);
            lbDisplay = new Label();
            btStart = new Button();
            btStop = new Button();
            SuspendLayout();
            // 
            // tmStopWatch
            // 
            tmStopWatch.Tick += tmStopWatch_Tick;
            // 
            // lbDisplay
            // 
            lbDisplay.AutoSize = true;
            lbDisplay.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lbDisplay.Location = new Point(165, 37);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(470, 191);
            lbDisplay.TabIndex = 0;
            lbDisplay.Text = "00:00";
            // 
            // btStart
            // 
            btStart.Location = new Point(339, 275);
            btStart.Name = "btStart";
            btStart.Size = new Size(112, 34);
            btStart.TabIndex = 1;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.Location = new Point(476, 275);
            btStop.Name = "btStop";
            btStop.Size = new Size(112, 34);
            btStop.TabIndex = 2;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // Form24
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(lbDisplay);
            Name = "Form24";
            Text = "Form24";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmStopWatch;
        private Label lbDisplay;
        private Button btStart;
        private Button btStop;
    }
}