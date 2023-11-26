
namespace csn_tictactoe_csharp
{
    partial class frm3x3
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
            this.lbnguoichoi = new System.Windows.Forms.Label();
            this.lbkytunguoichoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnguoichoi
            // 
            this.lbnguoichoi.AutoSize = true;
            this.lbnguoichoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnguoichoi.Location = new System.Drawing.Point(12, 9);
            this.lbnguoichoi.Name = "lbnguoichoi";
            this.lbnguoichoi.Size = new System.Drawing.Size(179, 37);
            this.lbnguoichoi.TabIndex = 0;
            this.lbnguoichoi.Text = "Người chơi:";
            // 
            // lbkytunguoichoi
            // 
            this.lbkytunguoichoi.AutoSize = true;
            this.lbkytunguoichoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkytunguoichoi.Location = new System.Drawing.Point(182, 9);
            this.lbkytunguoichoi.Margin = new System.Windows.Forms.Padding(0);
            this.lbkytunguoichoi.Name = "lbkytunguoichoi";
            this.lbkytunguoichoi.Size = new System.Drawing.Size(34, 37);
            this.lbkytunguoichoi.TabIndex = 1;
            this.lbkytunguoichoi.Text = "?";
            // 
            // frm3x3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbkytunguoichoi);
            this.Controls.Add(this.lbnguoichoi);
            this.Name = "frm3x3";
            this.Text = "Trò chơi tic-tac-toe";
            this.Activated += new System.EventHandler(this.frm3x3_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnguoichoi;
        private System.Windows.Forms.Label lbkytunguoichoi;
    }
}