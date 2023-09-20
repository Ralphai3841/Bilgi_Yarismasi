
namespace Bilgi_Yarismasi
{
    partial class FrmBaslat
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnYarismayaBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1151, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZENGİN OLMAK İSTER MİSİN ?";
            // 
            // BtnYarismayaBasla
            // 
            this.BtnYarismayaBasla.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnYarismayaBasla.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYarismayaBasla.Location = new System.Drawing.Point(333, 369);
            this.BtnYarismayaBasla.Name = "BtnYarismayaBasla";
            this.BtnYarismayaBasla.Size = new System.Drawing.Size(575, 188);
            this.BtnYarismayaBasla.TabIndex = 1;
            this.BtnYarismayaBasla.Text = "YARIŞMAYI BAŞLAT";
            this.BtnYarismayaBasla.UseVisualStyleBackColor = false;
            this.BtnYarismayaBasla.Click += new System.EventHandler(this.BtnYarismayaBasla_Click);
            // 
            // FrmBaslat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1300, 759);
            this.Controls.Add(this.BtnYarismayaBasla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBaslat";
            this.Text = "FrmBaslat";
            this.Load += new System.EventHandler(this.FrmBaslat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnYarismayaBasla;
    }
}