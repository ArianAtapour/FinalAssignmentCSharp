namespace SkateAssignment5ArianAtapour
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pbSplash = new System.Windows.Forms.PictureBox();
            this.pbSplah = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSplash
            // 
            this.pbSplash.Image = ((System.Drawing.Image)(resources.GetObject("pbSplash.Image")));
            this.pbSplash.Location = new System.Drawing.Point(76, 28);
            this.pbSplash.Name = "pbSplash";
            this.pbSplash.Size = new System.Drawing.Size(288, 262);
            this.pbSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSplash.TabIndex = 0;
            this.pbSplash.TabStop = false;
            // 
            // pbSplah
            // 
            this.pbSplah.Location = new System.Drawing.Point(12, 296);
            this.pbSplah.MarqueeAnimationSpeed = 50;
            this.pbSplah.Name = "pbSplah";
            this.pbSplah.Size = new System.Drawing.Size(410, 23);
            this.pbSplah.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbSplah.TabIndex = 1;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.ControlBox = false;
            this.Controls.Add(this.pbSplah);
            this.Controls.Add(this.pbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pbSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplash;
        private System.Windows.Forms.ProgressBar pbSplah;
    }
}