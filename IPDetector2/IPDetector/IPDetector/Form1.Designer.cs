namespace IPDetector
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SubnetBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MapBox = new System.Windows.Forms.PictureBox();
            this.AboutApps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(255, 42);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(336, 42);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // SubnetBox
            // 
            this.SubnetBox.Location = new System.Drawing.Point(73, 45);
            this.SubnetBox.Name = "SubnetBox";
            this.SubnetBox.Size = new System.Drawing.Size(166, 20);
            this.SubnetBox.TabIndex = 2;
            this.SubnetBox.TextChanged += new System.EventHandler(this.SubnetBox_TextChanged);
            // 
            // IPBox
            // 
            this.IPBox.Enabled = false;
            this.IPBox.Location = new System.Drawing.Point(73, 89);
            this.IPBox.Multiline = true;
            this.IPBox.Name = "IPBox";
            this.IPBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.IPBox.Size = new System.Drawing.Size(338, 191);
            this.IPBox.TabIndex = 3;
            this.IPBox.TextChanged += new System.EventHandler(this.IPBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Waiting for input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // MapBox
            // 
            this.MapBox.Location = new System.Drawing.Point(76, 89);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(338, 191);
            this.MapBox.TabIndex = 9;
            this.MapBox.TabStop = false;
            // 
            // AboutApps
            // 
            this.AboutApps.Location = new System.Drawing.Point(336, 292);
            this.AboutApps.Name = "AboutApps";
            this.AboutApps.Size = new System.Drawing.Size(75, 23);
            this.AboutApps.TabIndex = 10;
            this.AboutApps.Text = "About Apps";
            this.AboutApps.UseVisualStyleBackColor = true;
            this.AboutApps.Click += new System.EventHandler(this.AboutApps_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 323);
            this.Controls.Add(this.AboutApps);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.SubnetBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "IP DETECTOR";
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox SubnetBox;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox MapBox;
        private System.Windows.Forms.Button AboutApps;
    }
}

