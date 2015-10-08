namespace WalkingAnimation
{
    partial class frmAnimation
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
            this.picWalkingMan = new System.Windows.Forms.PictureBox();
            this.btnRunAnimation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // picWalkingMan
            // 
            this.picWalkingMan.Image = global::WalkingAnimation.Properties.Resources.walk1;
            this.picWalkingMan.Location = new System.Drawing.Point(151, 52);
            this.picWalkingMan.Name = "picWalkingMan";
            this.picWalkingMan.Size = new System.Drawing.Size(180, 180);
            this.picWalkingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picWalkingMan.TabIndex = 0;
            this.picWalkingMan.TabStop = false;
            // 
            // btnRunAnimation
            // 
            this.btnRunAnimation.Location = new System.Drawing.Point(204, 257);
            this.btnRunAnimation.Name = "btnRunAnimation";
            this.btnRunAnimation.Size = new System.Drawing.Size(75, 23);
            this.btnRunAnimation.TabIndex = 1;
            this.btnRunAnimation.Text = "button1";
            this.btnRunAnimation.UseVisualStyleBackColor = true;
            this.btnRunAnimation.Click += new System.EventHandler(this.btnRunAnimation_Click);
            // 
            // frmAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 306);
            this.Controls.Add(this.btnRunAnimation);
            this.Controls.Add(this.picWalkingMan);
            this.Name = "frmAnimation";
            this.Text = "Animation";
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalkingMan;
        private System.Windows.Forms.Button btnRunAnimation;
    }
}

