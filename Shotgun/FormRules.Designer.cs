namespace Shotgun
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.LblRules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblRules
            // 
            this.LblRules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRules.AutoSize = true;
            this.LblRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRules.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRules.Location = new System.Drawing.Point(12, 74);
            this.LblRules.Name = "LblRules";
            this.LblRules.Size = new System.Drawing.Size(591, 200);
            this.LblRules.TabIndex = 0;
            this.LblRules.Text = resources.GetString("LblRules.Text");
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 365);
            this.Controls.Add(this.LblRules);
            this.Name = "FormRules";
            this.ShowIcon = false;
            this.Text = "Regler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRules;
    }
}