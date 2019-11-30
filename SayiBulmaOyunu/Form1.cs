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
    public partial class SayiBulmaOyunu : Form
    {
        public int gelenSayi;
        public bool tekrarli = true;
        public int hakSayisi;
        public int puan = 0;
        int sure = 10;
        public SayiBulmaOyunu(int gelenSayi,bool tekrarli,int hakSayisi)
        {
            InitializeComponent();
            this.gelenSayi = gelenSayi;
            this.tekrarli = tekrarli;
            this.hakSayisi = hakSayisi;
        }
        

        private void SayiBulmaOyunu_KeyUp(object sender, KeyEventArgs e)
        {
            puan = 0;
            // Rakam Kontrolü
            timer2.Stop();
            timer2.Start();
            string basilanTus = "";
            
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 || e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 ||
                e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 || e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 ||
                e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 ||
                e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
               
                if(e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
                {
                    basilanTus = 0.ToString();
                }
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                {
                    basilanTus = 1.ToString();
                }
                if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                {
                    basilanTus = 2.ToString();
                }
                if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                {
                    basilanTus = 3.ToString();
                }
                if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                {
                    basilanTus = 4.ToString();
                }
                if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                {
                    basilanTus = 5.ToString();
                }
                if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                {
                    basilanTus = 6.ToString();
                }
                if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                {
                    basilanTus = 7.ToString();
                }
                if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                {
                    basilanTus = 8.ToString();
                }
                if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                {
                    basilanTus = 9.ToString();
                }
            }
           
        }

        int sayimiz;
        List<string> rakamlar = new List<string>();
        private void SayiBulmaOyunu_Load(object sender, EventArgs e)
        {
            lblHak.Text = "Hakkınız : " + hakSayisi;
            for (int i = 0; i < this.gelenSayi; i++)
            {
                TextBox txt = (TextBox)this.Controls["txt" + i];
                txt.Visible = true; 
            }

            Random random = new Random();
            if (gelenSayi == 3)
            {
                bool kontrol = true;
                sayimiz = random.Next(100, 1000);
                int yuzler = sayimiz / 100;
                int onlar = (sayimiz % 100) / 10;
                int birler = ((sayimiz % 100) % 10);
                if (!tekrarli)
                {
                    while (kontrol)
                    {
                        if(yuzler != onlar && yuzler != birler && onlar != birler)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(100, 1000);
                            yuzler = sayimiz / 100;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }
                else
                {
                    while (kontrol)
                    {
                        if (yuzler == onlar || yuzler == birler || onlar == birler)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(100, 1000);
                            yuzler = sayimiz / 100;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }

                
                rakamlar.Add(yuzler.ToString());
                rakamlar.Add(onlar.ToString());
                rakamlar.Add(birler.ToString());
            }
            else if (gelenSayi == 4)
            {
                bool kontrol = true;
                sayimiz = random.Next(1000, 10000);
                int binler = sayimiz / 1000;
                int yuzler = (sayimiz / 100) % 10;
                int onlar = (sayimiz % 100) / 10;
                int birler = ((sayimiz % 100) % 10);

                if (!tekrarli)
                {
                    while (kontrol)
                    {
                        if (binler != yuzler && binler != onlar && binler != birler && yuzler != onlar && yuzler != birler && onlar != birler )
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(1000, 10000);
                            binler = sayimiz / 1000;
                            yuzler = (sayimiz / 100) % 10;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }
                else
                {
                    while (kontrol)
                    {
                        if (binler == yuzler || binler == onlar || binler == birler || yuzler == onlar || yuzler == birler || onlar == birler)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(1000, 10000);
                            binler = sayimiz / 1000;
                            yuzler = (sayimiz / 100) % 10;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }
                
                rakamlar.Add(binler.ToString());
                rakamlar.Add(yuzler.ToString());
                rakamlar.Add(onlar.ToString());
                rakamlar.Add(birler.ToString());
            }
            else if (gelenSayi == 5)
            {
                bool kontrol = true;
                sayimiz = random.Next(10000, 100000);
                int onbinler = (sayimiz / 10000);
                int binler = (sayimiz / 1000) % 10;
                int yuzler = (sayimiz / 100) % 10;
                int onlar = (sayimiz % 100) / 10;
                int birler = ((sayimiz % 100) % 10);

                if (!tekrarli)
                {
                    while (kontrol)
                    {
                        if (onbinler != binler && onbinler != yuzler && onbinler != onlar && onbinler != birler &&
                            binler != yuzler && binler != onlar && binler != birler &&
                            yuzler != onlar && yuzler != birler &&
                            onlar != birler)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(10000, 100000);
                            onbinler = (sayimiz / 10000);
                            binler = (sayimiz / 1000) % 10;
                            yuzler = (sayimiz / 100) % 10;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }
                else
                {
                    while (kontrol)
                    {
                        if (onbinler == binler || onbinler == yuzler || onbinler == onlar || onbinler == birler ||
                            binler == yuzler || binler == onlar || binler == birler ||
                            yuzler == onlar || yuzler == birler ||
                            onlar == birler)
                        {
                            kontrol = false;
                        }
                        else
                        {
                            sayimiz = random.Next(10000, 100000);
                            onbinler = (sayimiz / 10000);
                            binler = (sayimiz / 1000) % 10;
                            yuzler = (sayimiz / 100) % 10;
                            onlar = (sayimiz % 100) / 10;
                            birler = ((sayimiz % 100) % 10);
                        }
                    }
                }
                
                rakamlar.Add(onbinler.ToString());
                rakamlar.Add(binler.ToString());
                rakamlar.Add(yuzler.ToString());
                rakamlar.Add(onlar.ToString());
                rakamlar.Add(birler.ToString());
            }

            
            Console.WriteLine("Sayimiz : " + sayimiz);

            timer2.Interval = 1000 * 1;
            timer2.Start();

        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            int kullanici_Birler = 0;
            int kullanici_Onlar = 0;
            int kullanici_Yuzler = 0;
            int kullanici_Binler = 0;
            int kullanici_Onbinler = 0;
            sure = 10;
            if (hakSayisi > 0)
            {
                if (txt0.Text != "" && txt1.Text != "" && txt2.Text != "")
                {
                    kullanici_Birler = int.Parse(txt0.Text);
                    kullanici_Onlar = int.Parse(txt1.Text);
                    kullanici_Yuzler = int.Parse(txt2.Text);

                    hakSayisi--;
                    lblHak.Text = "Hakkınız : " + hakSayisi;
                }
                else
                {
                    MessageBox.Show("Lütfen Bütün Sayıları Giriniz");
                    return;
                }

                if (this.gelenSayi == 4)
                {
                    if (txt3.Text != "")
                    {
                        kullanici_Binler = int.Parse(txt3.Text);
                        
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bütün Sayıları Giriniz");
                        return;
                    }
                }
                else if (this.gelenSayi == 5)
                {
                    if (txt3.Text != "" && txt4.Text != "")
                    {
                        kullanici_Binler = int.Parse(txt3.Text);
                        kullanici_Onbinler = int.Parse(txt4.Text);

                    
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Bütün Sayıları Giriniz");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Oyun Bitti Skor " + puan + " Sayı : " + sayimiz);
                SkorEkleme skorEkleme = new SkorEkleme(puan);
                skorEkleme.Visible = true;
                this.Close();
            }
            
            if(gelenSayi == 3)
            {
                if(kullanici_Yuzler == int.Parse(rakamlar[0]))
                {
                    txt2.BackColor = Color.Blue;
                }
                else
                {
                    if(kullanici_Yuzler == int.Parse(rakamlar[1]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if(kullanici_Yuzler == int.Parse(rakamlar[2]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                }

                if(kullanici_Onlar == int.Parse(rakamlar[1]))
                {
                    txt1.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Onlar == int.Parse(rakamlar[0]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[2]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                }

                if(kullanici_Birler == int.Parse(rakamlar[2]))
                {
                    txt0.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Birler == int.Parse(rakamlar[0]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[1]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                }

            }
            else if(gelenSayi == 4)
            {
                if(kullanici_Binler == int.Parse(rakamlar[0]))
                {
                    txt3.BackColor = Color.Blue;
                }
                else
                {
                    if(kullanici_Binler == int.Parse(rakamlar[1]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else if(kullanici_Binler == int.Parse(rakamlar[2]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else if(kullanici_Binler == int.Parse(rakamlar[3]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                }
                if (kullanici_Yuzler == int.Parse(rakamlar[1]))
                {
                    txt2.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Yuzler == int.Parse(rakamlar[0]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Yuzler == int.Parse(rakamlar[2]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Yuzler == int.Parse(rakamlar[3]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                }

                if (kullanici_Onlar == int.Parse(rakamlar[2]))
                {
                    txt1.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Onlar == int.Parse(rakamlar[0]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[1]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[3]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                }

                if (kullanici_Birler == int.Parse(rakamlar[3]))
                {
                    txt0.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Birler == int.Parse(rakamlar[0]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[1]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[2]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                }
            }
            else if(gelenSayi == 5)
            {
                if(kullanici_Onbinler == int.Parse(rakamlar[0]))
                {
                    txt4.BackColor = Color.Blue;
                }
                else
                {
                    if(kullanici_Onbinler == int.Parse(rakamlar[1]))
                    {
                        txt4.BackColor = Color.Red;
                    }
                    else if(kullanici_Onbinler == int.Parse(rakamlar[2]))
                    {
                        txt4.BackColor = Color.Red;
                    }
                    else if(kullanici_Onbinler == int.Parse(rakamlar[3]))
                    {
                        txt4.BackColor = Color.Red;
                    }
                    else if(kullanici_Onbinler == int.Parse(rakamlar[4]))
                    {
                        txt4.BackColor = Color.Red;
                    }
                }

                if (kullanici_Binler == int.Parse(rakamlar[1]))
                {
                    txt3.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Binler == int.Parse(rakamlar[0]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else if (kullanici_Binler == int.Parse(rakamlar[2]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else if (kullanici_Binler == int.Parse(rakamlar[3]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                    else if (kullanici_Binler == int.Parse(rakamlar[4]))
                    {
                        txt3.BackColor = Color.Red;
                    }
                }

                if (kullanici_Yuzler == int.Parse(rakamlar[2]))
                {
                    txt2.BackColor = Color.Blue;
                }
                else
                {
                    if (kullanici_Yuzler == int.Parse(rakamlar[0]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Yuzler == int.Parse(rakamlar[1]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Yuzler == int.Parse(rakamlar[3]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Yuzler == int.Parse(rakamlar[4]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                }

                if (kullanici_Onlar == int.Parse(rakamlar[3]))
                {
                    txt1.BackColor = Color.Blue;
                }
                else
                {
                    if(kullanici_Onlar == int.Parse(rakamlar[0]))
                    {
                        txt2.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[1]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[2]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                    else if (kullanici_Onlar == int.Parse(rakamlar[4]))
                    {
                        txt1.BackColor = Color.Red;
                    }
                }

                if (kullanici_Birler == int.Parse(rakamlar[4]))
                {
                    txt0.BackColor = Color.Blue;
                }
                else
                {
                    if(kullanici_Birler == int.Parse(rakamlar[0]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[1]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[2]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                    else if (kullanici_Birler == int.Parse(rakamlar[3]))
                    {
                        txt0.BackColor = Color.Red;
                    }
                }
            }

            // Puan Hesaplama
            for(int i = 0; i < gelenSayi; i++)
            {
                TextBox txt = (TextBox)this.Controls["txt" + i];
                if(txt.BackColor == Color.Blue)
                {
                    puan += 10;
                }
                else if(txt.BackColor == Color.Red)
                {
                    puan += 5;
                }
            }
            bool bittiMi = false;
            for (int i = 0; i < gelenSayi; i++)
            {
                TextBox txt = (TextBox)this.Controls["txt" + i];
                if(txt.BackColor == Color.Blue)
                {
                    bittiMi = true;
                }
                else
                {
                    bittiMi = false;
                    break;
                }
            }
            if (bittiMi)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Tebrikler Bütün Sayıları Buldunuz" + puan);
                SkorEkleme skorEkleme = new SkorEkleme(puan);
                skorEkleme.Visible = true;
                this.Close();
                return;
            }

            timer1.Interval = 1000 * 5;
            timer1.Start();
            if(hakSayisi < 1)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Oyun Bitti " + puan + " Sayimiz " + sayimiz);
                SkorEkleme skorEkleme = new SkorEkleme(puan);
                skorEkleme.Visible = true;  
                this.Close();
                return;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                TextBox txt = (TextBox)this.Controls["txt" + i];
                txt.BackColor = Color.White;
            }
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sure--;
            lbl_Sure.Text = "Süre :" + sure;
            if(sure == 0)
            {
                hakSayisi--;
                sure = 10;
            }
            lblHak.Text = "Hakkınız : " + hakSayisi;
            if (hakSayisi == 0)
            {
                MessageBox.Show("Oyun Bitti " + puan + " Sayımız : " + sayimiz);
                timer2.Stop();
                SkorEkleme skorEkleme = new SkorEkleme(puan);
                skorEkleme.Visible = true;
                this.Close();
                return;
            }
        }
    }
}
