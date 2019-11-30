using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiBulmaOyunu
{
    public partial class SkorEkleme : Form
    {
        public int gelenPuan;
        public SkorEkleme(int gelenPuan)
        {
            InitializeComponent();
            this.gelenPuan = gelenPuan;
        }

        class SkorTablosu
        {
            string ad;
            int puan;

            public SkorTablosu(string ad, int puan)
            {
                this.Ad = ad;
                this.Puan = puan;
            }

            public string Ad { get => ad; set => ad = value; }
            public int Puan { get => puan; set => puan = value; }
        }

        private void SkorEkleme_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSkorEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                string ad = txtAd.Text;
                string dosya_yolu = @"../../Skor.txt";
                if (!File.Exists(dosya_yolu))
                {
                    File.Create(@"../../Skor.txt");
                    MessageBox.Show("Dosya Oluşturuldu");
                    MessageBox.Show("Gelen Sayi:" + gelenPuan);
                }

                FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string yazi = sr.ReadLine();
                List<SkorTablosu> skorListesi = new List<SkorTablosu>();
                while (yazi != null)
                {
                    string[] parca = yazi.Split('|');
                    skorListesi.Add(new SkorTablosu(parca[0], int.Parse(parca[1])));
                    yazi = sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                skorListesi.Add(new SkorTablosu(ad, gelenPuan));
                skorListesi = skorListesi.OrderBy(x => x.Puan).ToList();
                skorListesi.Reverse();

                for (int i = 0; i < skorListesi.Count; i++)
                {
                    Console.WriteLine(skorListesi[i].Ad + "|" + skorListesi[i].Puan);
                }

                FileStream fs2 = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Write);
                StreamWriter sr2 = new StreamWriter(fs2);

                for (int i = 0; i < skorListesi.Count; i++)
                {
                    sr2.WriteLine(skorListesi[i].Ad + "|" + skorListesi[i].Puan);
                }
                sr2.Flush();
                fs2.Close();

                MessageBox.Show("Paunınız Kayıt Edildi.");

                Start start = new Start();
                start.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Bir İsim Giriniz");
            }
        }
    }
}
