namespace SayiBulmaOyunu
{
    partial class Start
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbSayi = new System.Windows.Forms.ComboBox();
            this.rbTekrarli = new System.Windows.Forms.RadioButton();
            this.rbTekrarsiz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHakSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(275, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSayi
            // 
            this.cbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSayi.FormattingEnabled = true;
            this.cbSayi.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cbSayi.Location = new System.Drawing.Point(315, 257);
            this.cbSayi.Name = "cbSayi";
            this.cbSayi.Size = new System.Drawing.Size(121, 33);
            this.cbSayi.TabIndex = 1;
            // 
            // rbTekrarli
            // 
            this.rbTekrarli.AutoSize = true;
            this.rbTekrarli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbTekrarli.Location = new System.Drawing.Point(281, 359);
            this.rbTekrarli.Name = "rbTekrarli";
            this.rbTekrarli.Size = new System.Drawing.Size(90, 28);
            this.rbTekrarli.TabIndex = 4;
            this.rbTekrarli.TabStop = true;
            this.rbTekrarli.Text = "Tekrarlı";
            this.rbTekrarli.UseVisualStyleBackColor = true;
            // 
            // rbTekrarsiz
            // 
            this.rbTekrarsiz.AutoSize = true;
            this.rbTekrarsiz.Checked = true;
            this.rbTekrarsiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbTekrarsiz.Location = new System.Drawing.Point(386, 359);
            this.rbTekrarsiz.Name = "rbTekrarsiz";
            this.rbTekrarsiz.Size = new System.Drawing.Size(104, 28);
            this.rbTekrarsiz.TabIndex = 5;
            this.rbTekrarsiz.TabStop = true;
            this.rbTekrarsiz.Text = "Tekrarsız";
            this.rbTekrarsiz.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(194, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hak Sayısı:";
            // 
            // txtHakSayisi
            // 
            this.txtHakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtHakSayisi.Location = new System.Drawing.Point(315, 315);
            this.txtHakSayisi.Name = "txtHakSayisi";
            this.txtHakSayisi.Size = new System.Drawing.Size(121, 31);
            this.txtHakSayisi.TabIndex = 7;
            this.txtHakSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHakSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbTekrarsiz);
            this.Controls.Add(this.rbTekrarli);
            this.Controls.Add(this.cbSayi);
            this.Controls.Add(this.button1);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSayi;
        private System.Windows.Forms.RadioButton rbTekrarli;
        private System.Windows.Forms.RadioButton rbTekrarsiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHakSayisi;
    }
}