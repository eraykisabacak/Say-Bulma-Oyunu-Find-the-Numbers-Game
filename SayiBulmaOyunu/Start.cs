using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiBulmaOyunu
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSayi.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir sayı seçiniz");
                return;
            }
            bool tekrarli = false;
            if (rbTekrarli.Checked)
            {
                tekrarli = true;
            }
            else
            {
                tekrarli = false;
            }
            if(txtHakSayisi.Text != "" && int.Parse(txtHakSayisi.Text) > 0)
            {
                SayiBulmaOyunu sayiBulmaOyunu = new SayiBulmaOyunu(int.Parse(cbSayi.Text), tekrarli,int.Parse(txtHakSayisi.Text));
                sayiBulmaOyunu.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Lütfen Hak Sayısını Yazınız");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
