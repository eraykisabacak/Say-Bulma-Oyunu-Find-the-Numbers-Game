namespace SayiBulmaOyunu
{
    partial class SayiBulmaOyunu
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
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.kontrol = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHak = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Sure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt0
            // 
            this.txt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt0.Location = new System.Drawing.Point(404, 176);
            this.txt0.MaxLength = 1;
            this.txt0.Multiline = true;
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(57, 67);
            this.txt0.TabIndex = 5;
            this.txt0.Visible = false;
            this.txt0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(324, 176);
            this.txt1.MaxLength = 1;
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(57, 67);
            this.txt1.TabIndex = 4;
            this.txt1.Visible = false;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(245, 176);
            this.txt2.MaxLength = 1;
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(57, 67);
            this.txt2.TabIndex = 3;
            this.txt2.Visible = false;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(163, 176);
            this.txt3.MaxLength = 1;
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(57, 67);
            this.txt3.TabIndex = 2;
            this.txt3.Visible = false;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(86, 176);
            this.txt4.MaxLength = 1;
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(57, 67);
            this.txt4.TabIndex = 1;
            this.txt4.Visible = false;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt4_KeyPress);
            this.txt4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            // 
            // kontrol
            // 
            this.kontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kontrol.Location = new System.Drawing.Point(199, 285);
            this.kontrol.Name = "kontrol";
            this.kontrol.Size = new System.Drawing.Size(149, 51);
            this.kontrol.TabIndex = 6;
            this.kontrol.Text = "Kontrol";
            this.kontrol.UseVisualStyleBackColor = true;
            this.kontrol.Click += new System.EventHandler(this.kontrol_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblHak.Location = new System.Drawing.Point(466, 355);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(100, 25);
            this.lblHak.TabIndex = 7;
            this.lblHak.Text = "Hakkınız:";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_Sure
            // 
            this.lbl_Sure.AutoSize = true;
            this.lbl_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lbl_Sure.Location = new System.Drawing.Point(81, 68);
            this.lbl_Sure.Name = "lbl_Sure";
            this.lbl_Sure.Size = new System.Drawing.Size(69, 25);
            this.lbl_Sure.TabIndex = 8;
            this.lbl_Sure.Text = "Süre :";
            // 
            // SayiBulmaOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Sure);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.kontrol);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Name = "SayiBulmaOyunu";
            this.Text = "Sayı Bulma Oyunu";
            this.Load += new System.EventHandler(this.SayiBulmaOyunu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SayiBulmaOyunu_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button kontrol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_Sure;
    }
}

