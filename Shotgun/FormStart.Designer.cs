namespace Shotgun
{
    partial class FormStart
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
            this.PicStart = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnGameRules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicStart)).BeginInit();
            this.SuspendLayout();
            // 
            // PicStart
            // 
            this.PicStart.Image = global::Shotgun.Properties.Resources.Startimage;
            this.PicStart.Location = new System.Drawing.Point(179, 56);
            this.PicStart.Name = "PicStart";
            this.PicStart.Size = new System.Drawing.Size(213, 206);
            this.PicStart.TabIndex = 0;
            this.PicStart.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(169, 271);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(109, 46);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "SPELA";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(284, 271);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(108, 46);
            this.BtnQuit.TabIndex = 2;
            this.BtnQuit.Text = "AVSLUTA";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(220, 18);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(131, 35);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "SHOTGUN";
            // 
            // BtnGameRules
            // 
            this.BtnGameRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGameRules.Location = new System.Drawing.Point(457, 271);
            this.BtnGameRules.Name = "BtnGameRules";
            this.BtnGameRules.Size = new System.Drawing.Size(114, 43);
            this.BtnGameRules.TabIndex = 7;
            this.BtnGameRules.Text = "Spelregler";
            this.BtnGameRules.UseVisualStyleBackColor = true;
            this.BtnGameRules.Click += new System.EventHandler(this.BtnGameRules_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 332);
            this.Controls.Add(this.BtnGameRules);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.PicStart);
            this.Name = "FormStart";
            this.ShowIcon = false;
            this.Text = "SHOTGUN";
            ((System.ComponentModel.ISupportInitialize)(this.PicStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicStart;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnGameRules;
    }
}

