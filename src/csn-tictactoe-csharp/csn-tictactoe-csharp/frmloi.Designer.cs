
namespace csn_tictactoe_csharp
{
    partial class frmloi
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
            this.lbloi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbloi
            // 
            this.lbloi.AutoSize = true;
            this.lbloi.Location = new System.Drawing.Point(85, 55);
            this.lbloi.Name = "lbloi";
            this.lbloi.Size = new System.Drawing.Size(36, 20);
            this.lbloi.TabIndex = 0;
            this.lbloi.Text = "???";
            // 
            // frmloi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 130);
            this.Controls.Add(this.lbloi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmloi";
            this.Text = "Lỗi";
            this.Activated += new System.EventHandler(this.frmloi_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloi;
    }
}