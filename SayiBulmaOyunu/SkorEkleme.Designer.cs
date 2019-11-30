namespace SayiBulmaOyunu
{
    partial class SkorEkleme
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnSkorEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(112, 28);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(135, 26);
            this.txtAd.TabIndex = 1;
            // 
            // btnSkorEkle
            // 
            this.btnSkorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSkorEkle.Location = new System.Drawing.Point(112, 74);
            this.btnSkorEkle.Name = "btnSkorEkle";
            this.btnSkorEkle.Size = new System.Drawing.Size(135, 38);
            this.btnSkorEkle.TabIndex = 2;
            this.btnSkorEkle.Text = "Skor Ekle";
            this.btnSkorEkle.UseVisualStyleBackColor = true;
            this.btnSkorEkle.Click += new System.EventHandler(this.btnSkorEkle_Click);
            // 
            // SkorEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 130);
            this.Controls.Add(this.btnSkorEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Name = "SkorEkleme";
            this.Text = "SkorEkleme";
            this.Load += new System.EventHandler(this.SkorEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnSkorEkle;
    }
}