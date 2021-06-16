namespace FinalTermProject
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
            this.components = new System.ComponentModel.Container();
            this.TITTLE_NAME = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarlabel = new System.Windows.Forms.Label();
            this.percentagelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITTLE_NAME
            // 
            this.TITTLE_NAME.AutoSize = true;
            this.TITTLE_NAME.BackColor = System.Drawing.Color.White;
            this.TITTLE_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TITTLE_NAME.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITTLE_NAME.ForeColor = System.Drawing.Color.Red;
            this.TITTLE_NAME.Location = new System.Drawing.Point(161, 58);
            this.TITTLE_NAME.Name = "TITTLE_NAME";
            this.TITTLE_NAME.Size = new System.Drawing.Size(594, 46);
            this.TITTLE_NAME.TabIndex = 0;
            this.TITTLE_NAME.Text = "MAKE YOUR SHOP SMART TO USE";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.OrangeRed;
            this.progressBar.Location = new System.Drawing.Point(100, 628);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(742, 14);
            this.progressBar.TabIndex = 4;
            // 
            // ProgressBarlabel
            // 
            this.ProgressBarlabel.AutoSize = true;
            this.ProgressBarlabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBarlabel.ForeColor = System.Drawing.Color.Red;
            this.ProgressBarlabel.Location = new System.Drawing.Point(96, 589);
            this.ProgressBarlabel.Name = "ProgressBarlabel";
            this.ProgressBarlabel.Size = new System.Drawing.Size(150, 22);
            this.ProgressBarlabel.TabIndex = 5;
            this.ProgressBarlabel.Text = "Loading now....";
            // 
            // percentagelabel
            // 
            this.percentagelabel.AutoSize = true;
            this.percentagelabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagelabel.ForeColor = System.Drawing.Color.Red;
            this.percentagelabel.Location = new System.Drawing.Point(252, 591);
            this.percentagelabel.Name = "percentagelabel";
            this.percentagelabel.Size = new System.Drawing.Size(26, 21);
            this.percentagelabel.TabIndex = 6;
            this.percentagelabel.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalTermProject.Properties.Resources.shopFIRST;
            this.pictureBox1.Location = new System.Drawing.Point(100, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Splash
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 665);
            this.Controls.Add(this.percentagelabel);
            this.Controls.Add(this.ProgressBarlabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TITTLE_NAME);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITTLE_NAME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label ProgressBarlabel;
        private System.Windows.Forms.Label percentagelabel;
        private System.Windows.Forms.Timer timer1;
    }
}

