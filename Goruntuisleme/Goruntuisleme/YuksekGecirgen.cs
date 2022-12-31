using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goruntuisleme
{
    public partial class YuksekGecirgen : Form
    { 
        public YuksekGecirgen()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaEkran form1 = (AnaEkran)Application.OpenForms["Form1"];
            form1.pictureBox2.Image = this.pictureBox1.Image;
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text == "SOL") 
            {
                AnaEkran form1 = (AnaEkran)Application.OpenForms["Form1"];
                form1.pictureBox2.Image = this.pictureBox1.Image;
            }
            else if (toolStripComboBox1.Text == "ORTA")
            {
                AnaEkran form1 = (AnaEkran)Application.OpenForms["Form1"];
                form1.pictureBox2.Image = this.pictureBox2.Image;
            }
            else if (toolStripComboBox1.Text == "SAĞ")
            {
                AnaEkran form1 = (AnaEkran)Application.OpenForms["Form1"];
                form1.pictureBox2.Image = this.pictureBox3.Image;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap image = new Bitmap(img);
            Color OkunanRenk;
            int R = 0, G = 0, B = 0;
            for (int x = 1; x < image.Width - 1; x++)
            {
                for (int y = 1; y < image.Height - 1; y++)
                {
                    OkunanRenk = img.GetPixel(x, y);
                    
                    Color color2, color4, color5, color6, color8;

                    color2 = img.GetPixel(x, y - 1);
                    color4 = img.GetPixel(x - 1, y);
                    color5 = img.GetPixel(x, y);
                    color6 = img.GetPixel(x + 1, y);
                    color8 = img.GetPixel(x, y + 1);

                    R = color2.R + color4.R + color5.R * (-4) + color6.R + color8.R;
                    G = color2.G + color4.G + color5.G * (-4) + color6.G + color8.G;
                    B = color2.B + color4.B + color5.B * (-4) + color6.B + color8.B;


                    int avg = (R+G+B) / 3;
                    if (avg > 255)
                        avg = 255;
                    if (avg < 0)
                        avg = 0;

                    image.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                
                }
            }
            pictureBox2.Image = image;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmiX, CikisResmiY, CikisResmiXY;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmiX = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiXY = new Bitmap(ResimGenisligi, ResimYuksekligi); 
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi

            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 - P4 + P6 - P7 + P9); //Dikey çizgileri Bulur
                    int Gy = Math.Abs(P1 + P2 + P3 - P7 - P8 - P9); //Yatay Çizgileri Bulur.
                    int Gxy = Gx + Gy;
                    if (Gx > 255) Gx = 255;
                    if (Gy> 255) Gy = 255;
                    if (Gxy > 255) Gxy = 255;
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak


                    CikisResmiX.SetPixel(x, y, Color.FromArgb(Gx, Gx, Gx));
                    CikisResmiY.SetPixel(x, y, Color.FromArgb(Gy, Gy, Gy));
                    CikisResmiXY.SetPixel(x, y, Color.FromArgb(Gxy, Gxy, Gxy));

                }
            }
            pictureBox1.Image = CikisResmiXY;
            pictureBox2.Image = CikisResmiX;
            pictureBox3.Image = CikisResmiY;
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmiX, CikisResmiY, CikisResmiXY;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmiX = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiXY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y;
            Color Renk;
            int P1, P2, P3, P4, P5, P6, P7, P8, P9;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi

            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    Renk = GirisResmi.GetPixel(x - 1, y - 1);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y - 1);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y - 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y);
                    P5 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P6 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x - 1, y + 1);
                    P7 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P8 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P9 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(-P1 + P3 -2 * P4 + 2 * P6 - P7 + P9); //Dikey çizgileri Bulur
                    int Gy = Math.Abs(P1 + 2*P2 + P3 - P7 - 2*P8 - P9); //Yatay Çizgileri Bulur.
                    int Gxy = Gx + Gy;
                    if (Gx > 255) Gx = 255;
                    if (Gy > 255) Gy = 255;
                    if (Gxy > 255) Gxy = 255;
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak


                    CikisResmiX.SetPixel(x, y, Color.FromArgb(Gx, Gx, Gx));
                    CikisResmiY.SetPixel(x, y, Color.FromArgb(Gy, Gy, Gy));
                    CikisResmiXY.SetPixel(x, y, Color.FromArgb(Gxy, Gxy, Gxy));

                }
            }
            pictureBox1.Image = CikisResmiXY;
            pictureBox2.Image = CikisResmiX;
            pictureBox3.Image = CikisResmiY;
        }

 

        private void button1_Click_1(object sender, EventArgs e)
        {

            AnaEkran form1 = (AnaEkran)Application.OpenForms["Form1"];
            this.pictureBox1.Image = form1.pictureBox1.Image;
        }

        private void toolStripDropDownButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

      

        //private Bitmap resimleriTopla(Bitmap image,Bitmap imageLaplas) 
        //{  

        // !!!!! ÇALIŞMIYOR !!!!

        //    Bitmap cikisresmi = new Bitmap(image.Width, image.Height);
        //    Color OkunanRenk,OkunanRenklaplas,DonusenRenk;
        //    int R=0, G=0, B=0;
        //    for (int x=0; x<image.Width;x++)
        //    {
        //        for (int y=0; y<image.Height; y++ )
        //        {
        //            OkunanRenk = image.GetPixel(x, y);
        //            OkunanRenklaplas = imageLaplas.GetPixel(x, y);

        //            R += OkunanRenk.R + OkunanRenklaplas.R;
        //            G += OkunanRenk.G + OkunanRenklaplas.G;
        //            B += OkunanRenk.B + OkunanRenklaplas.B;

        //            if (R > 255) R = 255;
        //            if (G > 255) G = 255;
        //            if (B > 255) B = 255;
        //            if (R < 0) R = 0;
        //            if (G < 0) G = 0;
        //            if (B < 0) B = 0;
        //            DonusenRenk = Color.FromArgb(R, G, B);
        //            cikisresmi.SetPixel(x, y, DonusenRenk);
        //        }
        //    }


        //    return cikisresmi;
        //}
    }
}
