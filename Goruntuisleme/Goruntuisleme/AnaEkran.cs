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
using System.Collections;
namespace Goruntuisleme
{
    public partial class AnaEkran : Form
    {
        string secilenfiltre = "";
        int esik1= 0;
        int esik2 = 0;
        int sayac = 1;
        double x1 = -1;
        double y1 = -1;
        double x2 = -1;
        double y2 = -1;
        double x3 = -1;
        double y3 = -1;
        double x4 = -1;
        double y4 = -1;
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void fotoğrafSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }
        public void DosyaAc()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.DefaultExt = ".jpg";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";

            try
            {
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }

        private void fotoğrafıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Resmi|*.jpg|Bitmap Resmi|*.bmp|Gif Resmi|*.gif";
            saveFileDialog1.Title = "Resmi Kaydet";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "" && pictureBox2.Image != null) //Dosya adı boş değilse kaydedecek.
            {
                // FileStream nesnesi ile kayıtı gerçekleştirecek. 
                FileStream DosyaAkisi = (FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        pictureBox2.Image.Save(DosyaAkisi, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                DosyaAkisi.Close();
            }
            else
            {
                MessageBox.Show("GÖRÜNTÜ KAYDEDİLEMEDİ!", "UYARI");
            }
        }

        private void negatifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Negatif Filtre";

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            { // Resimdeki beyaz noktalardan alınan rengi çıkararak oluşan görün
                Color AlinanRenk, islenenRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int GoruntuGenislik = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü 

                int GoruntuYukseklik = GirisResmi.Height;
                CikisResmi = new Bitmap(GoruntuGenislik, GoruntuYukseklik); //Cikis resmini oluşturuyor. 

                for (int x = 0; x < GoruntuGenislik; x++)
                {
                    for (int y = 0; y < GoruntuYukseklik; y++)
                    {
                        AlinanRenk = GirisResmi.GetPixel(x, y);
                        R = 255 - AlinanRenk.R;
                        G = 255 - AlinanRenk.G;
                        B = 255 - AlinanRenk.B;
                        islenenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, islenenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void griFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Gri Filtre";

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                Color AlinanRenk, islenenRenk;
                Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
                int GoruntuGenislik = GirisResmi.Width;
                int GoruntuYukseklik = GirisResmi.Height;
                Bitmap CikisResmi = new Bitmap(GoruntuGenislik, GoruntuYukseklik); //Cikis resmi oluşturuldu daha sonra picturebox2 ye a

                int GriDeger = 0;
                for (int x = 0; x < GoruntuGenislik; x++)
                {
                    for (int y = 0; y < GoruntuYukseklik; y++)
                    {
                        AlinanRenk = GirisResmi.GetPixel(x, y);
                        double R = AlinanRenk.R;
                        double G = AlinanRenk.G;
                        double B = AlinanRenk.B;
                        //GriDeger = Convert.ToInt16((R + G + B) / 3); 

                        GriDeger = Convert.ToInt16(R * 0.299 + G * 0.587 + B * 0.114);
                        islenenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                        CikisResmi.SetPixel(x, y, islenenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void parlaklıkAyarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Parlaklık Ayarı";

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                pictureBox2.Image = pictureBox1.Image;
                int R = 0, G = 0, B = 0;
                Color AlinanRenk, islenenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int GoruntuGenislik = GirisResmi.Width; // giriş resminin genişliği tanımlandı
                int GoruntuYukseklik = GirisResmi.Height; // giriş resminin yüksekliği tanımlandı
                CikisResmi = new Bitmap(GoruntuGenislik, GoruntuYukseklik); //Cikis resmini oluşturuyor. Boyutları giriş resmi 

                for (int x = 0; x < GoruntuGenislik; x++)
                {
                    for (int y = 0; y < GoruntuYukseklik; y++)
                    {
                        AlinanRenk = GirisResmi.GetPixel(x, y);// Giriş Resminin 
                                                               //Parlaklığı trackbardan aldığı değere göre arttıracak veya azaltacak
                                                               //Renkler 255 geçtiyse son sınır olan 255 alınacak.

                        R = AlinanRenk.R + ((trackBar1.Value - 127));
                        G = AlinanRenk.G + ((trackBar1.Value - 127));
                        B = AlinanRenk.B + ((trackBar1.Value - 127));
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;

                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        degertxt.Text = (trackBar1.Value - 127).ToString();

                        islenenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, islenenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void esikleTSM_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Eşikleme Filtre";

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                if (degertxt.Text == "")
                {
                    MessageBox.Show("DEĞER GİRİNİZ!", "UYARI");
                }
                else
                {
                    int R = 0, G = 0, B = 0;
                    Color AlinanRenk, islenenRenk;
                    Bitmap GirisResmi, CikisResmi;
                    GirisResmi = new Bitmap(pictureBox1.Image);
                    int GoruntuGenislik = GirisResmi.Width; //GirisResmi global tanımlandı.
                    int GoruntuYukseklik = GirisResmi.Height;
                    CikisResmi = new Bitmap(GoruntuGenislik, GoruntuYukseklik); //Cikis resmini oluşturuyor. Boyutları 

                    int EsiklemeDegeri = Convert.ToInt32(degertxt.Text);
                    for (int x = 0; x < GoruntuGenislik; x++)
                    {
                        for (int y = 0; y < GoruntuYukseklik; y++)
                        {
                            AlinanRenk = GirisResmi.GetPixel(x, y);
                            if (AlinanRenk.R >= EsiklemeDegeri)
                                R = 255;
                            else
                                R = 0;
                            if (AlinanRenk.G >= EsiklemeDegeri)
                                G = 255;
                            else
                                G = 0;
                            if (AlinanRenk.B >= EsiklemeDegeri)
                                B = 255;
                            else
                                B = 0;
                            islenenRenk = Color.FromArgb(R, G, B);
                            CikisResmi.SetPixel(x, y, islenenRenk);
                        }
                    }
                    pictureBox2.Image = CikisResmi;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int R = 0, G = 0, B = 0;
            Color AlinanRenk, islenenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int GoruntuGenislik = GirisResmi.Width; //GirisResmi global tanımlandı.
            int GoruntuYukseklik = GirisResmi.Height;
            CikisResmi = new Bitmap(GoruntuGenislik, GoruntuYukseklik); //Cikis resmini oluşturuyor. Boyutları 
            int EsiklemeDegeri = Convert.ToInt32(degertxt.Text);
            for (int x = 0; x < GoruntuGenislik; x++)
            {
                for (int y = 0; y < GoruntuYukseklik; y++)
                {
                    AlinanRenk = GirisResmi.GetPixel(x, y);
                    if (AlinanRenk.R >= EsiklemeDegeri)
                        R = 255;
                    else
                        R = 0;
                    if (AlinanRenk.G >= EsiklemeDegeri)
                        G = 255;
                    else
                        G = 0;
                    if (AlinanRenk.B >= EsiklemeDegeri)
                        B = 255;
                    else
                        B = 0;
                    islenenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, islenenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            degertxt.Text = trackBar1.Value.ToString();
            if (durumlb.Text == "Eşikleme Filtre")
            {
                esikleTSM_Click(sender, e);
            }
            else if (durumlb.Text == "Parlaklık Ayarı")
            {
                parlaklıkAyarıToolStripMenuItem_Click(sender, e);
            }
            else if (durumlb.Text == "Kontrast Ayarı")
            {
                kontrastAyarıToolStripMenuItem_Click(sender, e);
            }
        }

        private void yuklenenhistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Histogram";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                int[] dizipikselsayisi = new int[256];
                int ortalama = 0;
                Color AlinanRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
                GirisResmi = new Bitmap(pictureBox1.Image);
                int GoruntuGenislik = GirisResmi.Width; //GirisResmi global tanımlandı.
                int GoruntuYukseklik = GirisResmi.Height;

                for (int x = 0; x < GirisResmi.Width; x++)
                {
                    for (int y = 0; y < GirisResmi.Height; y++)
                    {
                        AlinanRenk = GirisResmi.GetPixel(x, y);
                        ortalama = (int)(AlinanRenk.R + AlinanRenk.G + AlinanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                        dizipikselsayisi[ortalama]++;
                    }
                    if (x < 256)
                    {
                        if (esik1 == 0)
                        {
                            if (dizipikselsayisi[x] > 0)
                            {
                                esik1 = x;

                            }
                        }
                        if (dizipikselsayisi[x] > 0)
                        {
                            esik2 = x;
                        }
                    }
                }
                Histogram form2 = new Histogram(dizipikselsayisi);
                form2.Show();
            }
        }

        private void olusanhistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Histogram";
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("YENİ RESİM OLUŞTURMADINIZ!", "UYARI");
            }
            else
            {
                int[] dizipikselsayisi = new int[256];
                int ortalama = 0;
                Color AlinanRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi; //Histogram için giriş resmi gri-ton olmalıdır.
                GirisResmi = new Bitmap(pictureBox2.Image);
                int GoruntuGenislik = GirisResmi.Width; //GirisResmi global tanımlandı.
                int GoruntuYukseklik = GirisResmi.Height;

                for (int x = 0; x < GirisResmi.Width; x++)
                {
                    for (int y = 0; y < GirisResmi.Height; y++)
                    {
                        AlinanRenk = GirisResmi.GetPixel(x, y);
                        ortalama = (int)(AlinanRenk.R + AlinanRenk.G + AlinanRenk.B) / 3; //Griton resimde üç kanal rengi aynı değere sahiptir.
                        dizipikselsayisi[ortalama]++;
                    }
                    if (x < 256)
                    {
                        if (esik1 == 0)
                        {
                            if (dizipikselsayisi[x] > 0)
                            {
                                esik1 = x; ;
                            }
                        }
                        if (dizipikselsayisi[x] > 0)
                        {
                            esik2 = x;
                        }
                    }
                }
                Histogram form2 = new Histogram(dizipikselsayisi);
                form2.Show();
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.Image = null;
        }

        private void görüntüyüAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Filtrelenmiş görüntü üzerinde işlem yapmak için aktarılsın mı?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    pictureBox1.Image = pictureBox2.Image;
                }
            }
        }

        private void kontrastGermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (esik1 == 0 && esik2 == 0)
            {
                MessageBox.Show("Histogram oluşturmadan bu işlem uygulanamaz.", "UYARI");
            }
            else
            {
                Color OkunanRenk, DonusenRenk;
                int R = 0, G = 0, B = 0;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı. İçerisine görüntü yüklendi.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları giriş resmi ile aynı olur. Tanımlaması globalde yapıldı.
                int Y1 = 0;
                int Y2 = 255;

                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);
                        R = OkunanRenk.R;
                        G = OkunanRenk.G;
                        B = OkunanRenk.B;
                        int Gri = (R + G + B) / 3;

                        int X = Gri;
                        int Y = ((((X - esik1) * Y2 - Y1)) / (esik2 - esik1)) + Y1;
                        if (Y > 255) Y = 255;
                        if (Y < 0) Y = 0;
                        DonusenRenk = Color.FromArgb(Y, Y, Y);
                        CikisResmi.SetPixel(x, y, DonusenRenk);

                    }
                }
                pictureBox2.Refresh();
                pictureBox2.Image = null;
                pictureBox2.Image = CikisResmi;
            }

        }

        private void durumlb_Click(object sender, EventArgs e)
        {

        }

        private void histogramEşitlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Histogram Eşitleme";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                Bitmap renderedImage = new Bitmap(pictureBox1.Image);
                uint pixels = (uint)renderedImage.Height * (uint)renderedImage.Width;
                decimal Const = 255 / (decimal)pixels;

                int x, y, R, G, B;
                int[] HistogramRed2 = new int[256];
                int[] HistogramGreen2 = new int[256];
                int[] HistogramBlue2 = new int[256];

                for (var i = 0; i < renderedImage.Width; i++)
                {
                    for (var j = 0; j < renderedImage.Height; j++)
                    {
                        Color piksel = renderedImage.GetPixel(i, j);

                        HistogramRed2[piksel.R]++;
                        HistogramGreen2[piksel.G]++;
                        HistogramBlue2[piksel.B]++;

                    }
                }

                int[] cdfR = HistogramRed2;
                int[] cdfG = HistogramGreen2;
                int[] cdfB = HistogramBlue2;

                for (int r = 1; r <= 255; r++)
                {
                    cdfR[r] = cdfR[r] + cdfR[r - 1];
                    cdfG[r] = cdfG[r] + cdfG[r - 1];
                    cdfB[r] = cdfB[r] + cdfB[r - 1];
                }
                for (y = 0; y < renderedImage.Height; y++)
                {
                    for (x = 0; x < renderedImage.Width; x++)
                    {
                        Color pixelColor = renderedImage.GetPixel(x, y);

                        R = (int)((decimal)cdfR[pixelColor.R] * Const);
                        G = (int)((decimal)cdfG[pixelColor.G] * Const);
                        B = (int)((decimal)cdfB[pixelColor.B] * Const);

                        Color newColor = Color.FromArgb(R, G, B);
                        renderedImage.SetPixel(x, y, newColor);
                    }
                }
                pictureBox2.Image = renderedImage;
            }
            
        }

        private void kontrastAyarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Kontrast Ayarı";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                int R = 0, G = 0, B = 0;
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resmini oluşturuyor. Boyutları
                double c_deger = 0;
                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x, y);

                        c_deger = (2 * trackBar1.Value - 255);
                        degertxt.Text = c_deger.ToString();

                        double C_KontrastSeviyesi = c_deger;

                        double F_KontrastFaktoru = (259 * (C_KontrastSeviyesi + 255)) / (255 * (259 - C_KontrastSeviyesi));

                        R = OkunanRenk.R;
                        G = OkunanRenk.G;
                        B = OkunanRenk.B;
                        R = (int)((F_KontrastFaktoru * (R - 128)) + 128);
                        G = (int)((F_KontrastFaktoru * (G - 128)) + 128);
                        B = (int)((F_KontrastFaktoru * (B - 128)) + 128);
                        //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x, y, DonusenRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void meanOrtalamaFiltresiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Ortalama Filtre";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }

            else
            {

                if (degertxt.Text == "")
                {
                    MessageBox.Show("Değer Girin Kısmına Tek Sayı Olarak Şablon Boyutunu Giriniz", "");
                }
                else
                {
                    if (Convert.ToInt32(degertxt.Text) % 2 == 0)
                    {
                        MessageBox.Show("Şablon Boyutunu Tek Sayı Olarak Giriniz", "");
                    }
                    else
                    {
                        int SablonBoyutu = Convert.ToInt32(degertxt.Text); //şablon boyutu 3 den büyük tek rakam olmalıdır(3, 5, 7 gibi).
                        Color OkunanRenk;
                        Bitmap GirisResmi, CikisResmi;
                        GirisResmi = new Bitmap(pictureBox1.Image);
                        int ResimGenisligi = GirisResmi.Width;
                        int ResimYuksekligi = GirisResmi.Height;
                        CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);

                        int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                        for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                        {
                            for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                            {
                                toplamR = 0;
                                toplamG = 0;
                                toplamB = 0;

                                for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                                {
                                    for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                    {
                                        OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                        toplamR = toplamR + OkunanRenk.R;
                                        toplamG = toplamG + OkunanRenk.G;
                                        toplamB = toplamB + OkunanRenk.B;
                                    }
                                }
                                ortalamaR = toplamR / (SablonBoyutu * SablonBoyutu);
                                ortalamaG = toplamG / (SablonBoyutu * SablonBoyutu);
                                ortalamaB = toplamB / (SablonBoyutu * SablonBoyutu);
                                CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                            }
                        }
                        pictureBox2.Image = CikisResmi;
                    }

                }
            }
        }

        private void medianOrtancaFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Ortanca Filtre";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }

            else
            {
                if (degertxt.Text == "")
                {
                    MessageBox.Show("Değer Girin Kısmına Tek Sayı Olarak Şablon Boyutunu Giriniz", "");
                }
                else
                {
                    if (Convert.ToInt32(degertxt.Text) % 2 == 0)
                    {
                        MessageBox.Show("Şablon Boyutunu Tek Sayı Olarak Giriniz", "");
                    }
                    else
                    {
                        Color OkunanRenk;
                        Bitmap GirisResmi, CikisResmi;
                        GirisResmi = new Bitmap(pictureBox1.Image);
                        int ResimGenisligi = GirisResmi.Width;
                        int ResimYuksekligi = GirisResmi.Height;
                        CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                        int SablonBoyutu = Convert.ToInt32(degertxt.Text); //şablon boyutu 3 den büyük tek rakam olmalı
                        int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                        int[] R = new int[ElemanSayisi];
                        int[] G = new int[ElemanSayisi];
                        int[] B = new int[ElemanSayisi];
                        int[] Gri = new int[ElemanSayisi];
                        int x, y, i, j;
                        for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++)
                        {
                            for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                            {
                                //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                                int k = 0;
                                for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                                {
                                    for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                                    {
                                        OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                        R[k] = OkunanRenk.R;
                                        G[k] = OkunanRenk.G;
                                        B[k] = OkunanRenk.B;
                                        Gri[k] = Convert.ToInt16(R[k] * 0.299 + G[k] * 0.587 + B[k] * 0.114);
                                        k++;
                                    }
                                }
                                //Gri tona göre sıralama yapıyor. Aynı anda üç rengide değiştiriyor.
                                int GeciciSayi = 0;
                                for (i = 0; i < ElemanSayisi; i++)
                                {
                                    for (j = i + 1; j < ElemanSayisi; j++)
                                    {
                                        if (Gri[j] < Gri[i])
                                        {
                                            GeciciSayi = Gri[i];
                                            Gri[i] = Gri[j];
                                            Gri[j] = GeciciSayi;
                                            GeciciSayi = R[i];
                                            R[i] = R[j];
                                            R[j] = GeciciSayi;
                                            GeciciSayi = G[i];
                                            G[i] = G[j];
                                            G[j] = GeciciSayi;
                                            GeciciSayi = B[i];
                                            B[i] = B[j];
                                            B[j] = GeciciSayi;
                                        }
                                    }
                                }
                                //Sıralama sonrası ortadaki değeri çıkış resminin piksel değeri olarak atıyor.
                                CikisResmi.SetPixel(x, y, Color.FromArgb(R[(ElemanSayisi - 1) / 2], G[(ElemanSayisi - 1) / 2], B[(ElemanSayisi - 1) / 2]));
                            }
                        }
                        pictureBox2.Image = CikisResmi;
                    }
                }
            }
        }

        private void gaussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Gauss Filtre";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else 
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int SablonBoyutu = 5; //Çekirdek matrisin boyutu
                int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                int x, y, i, j, toplamR, toplamG, toplamB, ortalamaR, ortalamaG, ortalamaB;
                int[] Matris = { 1, 4, 7, 4, 1, 4, 20, 33, 20, 4, 7, 33, 55, 33, 7, 4, 20, 33, 20, 4, 1, 4, 7, 4, 1 };
                int MatrisToplami = 1 + 4 + 7 + 4 + 1 + 4 + 20 + 33 + 20 + 4 + 7 + 33 + 55 + 33 + 7 + 4 + 20 +
               33 + 20 + 4 + 1 + 4 + 7 + 4 + 1;


                for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
                {
                    for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;
                        //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                        int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                toplamR = toplamR + OkunanRenk.R * Matris[k];
                                toplamG = toplamG + OkunanRenk.G * Matris[k];
                                toplamB = toplamB + OkunanRenk.B * Matris[k];
                                k++;
                            }
                            ortalamaR = toplamR / MatrisToplami;
                            ortalamaG = toplamG / MatrisToplami;
                            ortalamaB = toplamB / MatrisToplami;
                            CikisResmi.SetPixel(x, y, Color.FromArgb(ortalamaR, ortalamaG, ortalamaB));
                        }
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            

        }

        private void laplacianFiltreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuksekGecirgen frm3 = new YuksekGecirgen();
            frm3.Show();

            YuksekGecirgen form3 = (YuksekGecirgen)Application.OpenForms["Form3"];
            frm3.pictureBox1.Image = this.pictureBox1.Image;

        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Konvolüsyon Filtre";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else 
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int SablonBoyutu = 3;
                int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                int x, y, i, j, toplamR, toplamG, toplamB;
                int R, G, B;
                int[] Matris = { 0, -4, 0, -4, 20, -4, 0, -4, 0 };
                int MatrisToplami = 0 + -4 + 0 + -4 + 20 + -4 + 0 + -4 + 0;
                for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi

                {
                    for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                    {
                        toplamR = 0;
                        toplamG = 0;
                        toplamB = 0;
                        //Şablon bölgesi (çekirdek matris) içindeki pikselleri tarıyor.
                        int k = 0; //matris içindeki elemanları sırayla okurken kullanılacak.
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                toplamR = toplamR + OkunanRenk.R * Matris[k];
                                toplamG = toplamG + OkunanRenk.G * Matris[k];
                                toplamB = toplamB + OkunanRenk.B * Matris[k];
                                k++;
                            }
                        }
                        R = toplamR / MatrisToplami;
                        G = toplamG / MatrisToplami;
                        B = toplamB / MatrisToplami;
                        //===========================================================
                        //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                        if (R > 255) R = 255;
                        if (G > 255) G = 255;
                        if (B > 255) B = 255;
                        if (R < 0) R = 0;
                        if (G < 0) G = 0;
                        if (B < 0) B = 0;
                        //===========================================================
                        CikisResmi.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            
        }

  

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Dilation";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else 
            {
                Color OkunanRenk, OkunanRenk1;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int SablonBoyutu; //Çekirdek matrisin boyutu
                try
                {
                    SablonBoyutu = Convert.ToInt32(degertxt.Text);
                }
                catch
                {
                    SablonBoyutu = 5;
                }
                int ElemanSayisi = SablonBoyutu * SablonBoyutu;
                int x = 0, y = 0, i, j;


                for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
                {
                    for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                    {
                        OkunanRenk1 = GirisResmi.GetPixel(x, y);
                        bool beyazbuldu = false;

                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                if (OkunanRenk.R == 255) //Komşularda Siyah Var ise 
                                    beyazbuldu = true;
                            }
                        }


                        if (beyazbuldu)
                        {
                            CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));

                        }

                        else CikisResmi.SetPixel(x, y, OkunanRenk1);

                    }
                }

                pictureBox2.Image = CikisResmi;
            }
           
        }

        private void erıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Erosion";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else 
            { 
            Color OkunanRenk, OkunanRenk1;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu;
            try
            {
                SablonBoyutu = Convert.ToInt32(degertxt.Text);
            }
            catch
            {
                SablonBoyutu = 5;
            }
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x = 0, y = 0, i, j;


            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) //Resmi taramaya şablonun yarısı kadar dış kenarlardan içeride başlayacak ve bitirecek.
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    OkunanRenk1 = GirisResmi.GetPixel(x, y);
                    bool siyahbuldu = false;

                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            if (OkunanRenk.R == 0) //Komşularda Siyah Var ise 
                                siyahbuldu = true;
                        }
                    }


                    if (siyahbuldu)
                    {
                        CikisResmi.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                    }

                    else CikisResmi.SetPixel(x, y, OkunanRenk1);

                }
            }

            pictureBox2.Image = CikisResmi;
            }
            

        }

        private void açılıDöndürmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Açılı Döndürme";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim yükleyiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int Aci;
                try 
                {
                     Aci = Convert.ToInt16(degertxt.Text);
                }
                catch
                {
                    Aci = 0;
                  
                }
                double RadyanAci = Aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
                int x0 = ResimGenisligi / 2;
                int y0 = ResimYuksekligi / 2;
                for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                {
                    for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x1, y1);
                        //Aliaslı Döndürme -Sağa Kaydırma
                        x2 = (x1 - x0) - Math.Tan(RadyanAci / 2) * (y1 - y0) + x0;
                        y2 = (y1 - y0) + y0;
                        x2 = Convert.ToInt16(x2);
                        y2 = Convert.ToInt16(y2);
                        //Aliaslı Döndürme -Aşağı kaydırma
                        x2 = (x2 - x0) + x0;
                        y2 = Math.Sin(RadyanAci) * (x2 - x0) + (y2 - y0) + y0;
                        x2 = Convert.ToInt16(x2);
                        y2 = Convert.ToInt16(y2);
                        //Aliaslı Döndürme -Sağa Kaydırma
                        x2 = (x2 - x0) - Math.Tan(RadyanAci / 2) * (y2 - y0) + x0;
                        y2 = (y2 - y0) + y0;
                        x2 = Convert.ToInt16(x2);
                        y2 = Convert.ToInt16(y2);
                        if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                            CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                        //OkunanRenk = GirisResmi.GetPixel(x1, y1);
                        ////Döndürme Formülleri
                        //x2 = Math.Cos(RadyanAci) * (x1 - x0) - Math.Sin(RadyanAci) * (y1 - y0) + x0;
                        //y2 = Math.Sin(RadyanAci) * (x1 - x0) + Math.Cos(RadyanAci) * (y1 - y0) + y0;
                        //if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        //    CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);


                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void tersÇevirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Ters Çevirme";
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim yükleyiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                double Aci = 180;
                double RadyanAci = Aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
                int x0 = ResimGenisligi / 2;
                int y0 = ResimYuksekligi / 2;
                for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                {
                    for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x1, y1);
                       

                        //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama----------
                        double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                        x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                        y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                        if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                            CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void aynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Aynalama";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim yükleyiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                double Aci = 90;
                double RadyanAci = Aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                //Resim merkezini buluyor. Resim merkezi etrafında döndürecek. 
                int x0 = ResimGenisligi / 2;
                int y0 = ResimYuksekligi / 2;
                for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                {
                    for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x1, y1);
                        //----A-Orta dikey eksen etrafında aynalama ----------------
                        //x2 = Convert.ToInt16(-x1 + 2 * x0); 
                        //y2 = Convert.ToInt16(y1);
                        //----B-Orta yatay eksen etrafında aynalama ----------------
                        //x2 = Convert.ToInt16(x1);
                        //y2 = Convert.ToInt16(-y1 + 2 *y0);

                        //----C-Ortadan geçen 45 açılı çizgi etrafında aynalama----------
                        double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                        x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                        y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                        if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                            CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void yakınlaştırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Yakınlaştırma";
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim yükleyiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
              
                Color OkunanRenk;
                Bitmap GirisResmi, CikisResmi;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width;
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
                int BuyutmeKatsayisi;

                try {  
                    BuyutmeKatsayisi = Convert.ToInt32(degertxt.Text); 
                }
                catch 
                {
                    BuyutmeKatsayisi = 2;
                }
                int x2 = 0, y2 = 0;
                for (int x1 = 0; x1 < ResimGenisligi; x1++)
                {

                    for (int y1 = 0; y1 < ResimYuksekligi; y1++)
                    {

                        OkunanRenk = GirisResmi.GetPixel(x1, y1);

                        for (int i = 0; i < BuyutmeKatsayisi; i++)
                        {
                            for (int j = 0; j < BuyutmeKatsayisi; j++)
                            {
                                x2 = x1 * BuyutmeKatsayisi + i;
                                y2 = y1 * BuyutmeKatsayisi + j;
                                if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                                    CikisResmi.SetPixel(x2, y2, OkunanRenk);
                            }
                        }

                    }

                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void uzaklaştırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim yükleyiniz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                Color OkunanRenk, DonusenRenk;
                Bitmap GirisResmi, CikisResmi;
                int R = 0, G = 0, B = 0;
                GirisResmi = new Bitmap(pictureBox1.Image);
                int ResimGenisligi = GirisResmi.Width; //GirisResmi global tanımlandı.
                int ResimYuksekligi = GirisResmi.Height;
                CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); //Cikis resminin boyutları
                int x2 = 0, y2 = 0; //Çıkış resminin x ve y si olacak.
                int KucultmeKatsayisi;
                try { KucultmeKatsayisi = Convert.ToInt32(degertxt.Text); }
                catch { KucultmeKatsayisi = 2; }

                for (int x1 = 0; x1 < ResimGenisligi; x1 = x1 + KucultmeKatsayisi)
                {
                    y2 = 0;
                    for (int y1 = 0; y1 < ResimYuksekligi; y1 = y1 + KucultmeKatsayisi)
                    {
                        //x ve y de ilerlerken her atlanan pikselleri okuyacak ve ortalama değerini alacak.
                        R = 0; G = 0; B = 0;
                        try //resim sınırının dışına çıkaldığında hata vermesin diye
                        {
                            for (int i = 0; i < KucultmeKatsayisi; i++)
                            {
                                for (int j = 0; j < KucultmeKatsayisi; j++)
                                {
                                    OkunanRenk = GirisResmi.GetPixel(x1 + i, y1 + j);
                                    R = R + OkunanRenk.R;
                                    G = G + OkunanRenk.G;
                                    B = B + OkunanRenk.B;
                                }
                            }
                        }
                        catch { }
                        //Renk kanallarının ortalamasını alıyor
                        R = R / (KucultmeKatsayisi * KucultmeKatsayisi);
                        G = G / (KucultmeKatsayisi * KucultmeKatsayisi);
                        B = B / (KucultmeKatsayisi * KucultmeKatsayisi);
                        DonusenRenk = Color.FromArgb(R, G, B);
                        CikisResmi.SetPixel(x2, y2, DonusenRenk);
                        y2++;
                    }
                    x2++;
                }
                pictureBox2.Image = CikisResmi;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            if (pictureBox1.Image != null && ( durumlb.Text=="Perspektif Düzeltme" || durumlb.Text=="Öteleme"))
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("X: "+coordinates.X+" Y: "+coordinates.Y+"\nDeğerleri atansın mı?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (sayac == 1)
                    {
                        x1 = coordinates.X;
                        y1 = coordinates.Y;
                        sayac++;
                        degertxt.Text = coordinates.ToString();
                        if (durumlb.Text == "Öteleme")
                        {
                            sayac = 6;
                        }
                    }
                    else if (sayac == 2)
                    {
                        x2 = coordinates.X;
                        y2 = coordinates.Y;
                        sayac++;
                        degertxt.Text = coordinates.ToString();

                    }
                    else if (sayac == 3)
                    {
                        x3 = coordinates.X;
                        y3 = coordinates.Y;
                        sayac++;
                        degertxt.Text = coordinates.ToString();
                    }
                    else if (sayac == 4)
                    {
                        x4 = coordinates.X;
                        y4 = coordinates.Y;
                        sayac++;
                        degertxt.Text = coordinates.ToString();
                    }
                    try
                    {
                        if (sayac == 5) perspektifDüzeltmeToolStripMenuItem_Click(sender, e);
                        else if (sayac == 6) 
                        {
                            ötelemeToolStripMenuItem_Click(sender, e);
                            sayac = 1;
                            x1 = -1;
                            y1 = -1;
                            x2 = -1;
                            y2 = -1;
                            x3 = -1;
                            y3 = -1;
                            x4 = -1;
                            y4 = -1;
                        }
                        
                    }
                    catch { }
                  

                }
            }
            



        }

        private void perspektifDüzeltmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Perspektif Düzeltme";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("FİLTRELENECEK RESİM SEÇMEDİNİZ!", "UYARI");
            }
            else
            {
                //Picture Boxta Koyulacak koordinat0
                double X1 = 0;
                double Y1 = 0;

                double X2 = 375;
                double Y2 = 0;

                double X3 = 0;
                double Y3 = 375;

                double X4 = 375;
                double Y4 = 375;

                double[,] GirisMatrisi = new double[8, 8];
                // { x1, y1, 1, 0, 0, 0, -x1 * X1, -y1 * X1 }
                GirisMatrisi[0, 0] = x1;
                GirisMatrisi[0, 1] = y1;
                GirisMatrisi[0, 2] = 1;
                GirisMatrisi[0, 3] = 0;
                GirisMatrisi[0, 4] = 0;
                GirisMatrisi[0, 5] = 0;
                GirisMatrisi[0, 6] = -x1 * X1;
                GirisMatrisi[0, 7] = -y1 * X1;
                //{ 0, 0, 0, x1, y1, 1, -x1 * Y1, -y1 * Y1 }
                GirisMatrisi[1, 0] = 0;
                GirisMatrisi[1, 1] = 0;
                GirisMatrisi[1, 2] = 0;
                GirisMatrisi[1, 3] = x1;
                GirisMatrisi[1, 4] = y1;
                GirisMatrisi[1, 5] = 1;
                GirisMatrisi[1, 6] = -x1 * Y1;
                GirisMatrisi[1, 7] = -y1 * Y1;
                //{ x2, y2, 1, 0, 0, 0, -x2 * X2, -y2 * X2 } 
                GirisMatrisi[2, 0] = x2;
                GirisMatrisi[2, 1] = y2;
                GirisMatrisi[2, 2] = 1;
                GirisMatrisi[2, 3] = 0;
                GirisMatrisi[2, 4] = 0;
                GirisMatrisi[2, 5] = 0;
                GirisMatrisi[2, 6] = -x2 * X2;
                GirisMatrisi[2, 7] = -y2 * X2;
                //{ 0, 0, 0, x2, y2, 1, -x2 * Y2, -y2 * Y2 }
                GirisMatrisi[3, 0] = 0;
                GirisMatrisi[3, 1] = 0;
                GirisMatrisi[3, 2] = 0;
                GirisMatrisi[3, 3] = x2;
                GirisMatrisi[3, 4] = y2;
                GirisMatrisi[3, 5] = 1;
                GirisMatrisi[3, 6] = -x2 * Y2;
                GirisMatrisi[3, 7] = -y2 * Y2;
                //{ x3, y3, 1, 0, 0, 0, -x3 * X3, -y3 * X3 }
                GirisMatrisi[4, 0] = x3;
                GirisMatrisi[4, 1] = y3;
                GirisMatrisi[4, 2] = 1;
                GirisMatrisi[4, 3] = 0;
                GirisMatrisi[4, 4] = 0;
                GirisMatrisi[4, 5] = 0;
                GirisMatrisi[4, 6] = -x3 * X3;
                GirisMatrisi[4, 7] = -y3 * X3;
                //{ 0, 0, 0, x3, y3, 1, -x3 * Y3, -y3 * Y3 }
                GirisMatrisi[5, 0] = 0;
                GirisMatrisi[5, 1] = 0;
                GirisMatrisi[5, 2] = 0;
                GirisMatrisi[5, 3] = x3;
                GirisMatrisi[5, 4] = y3;
                GirisMatrisi[5, 5] = 1;
                GirisMatrisi[5, 6] = -x3 * Y3;
                GirisMatrisi[5, 7] = -y3 * Y3;
                //{ x4, y4, 1, 0, 0, 0, -x4 * X4, -y4 * X4 }
                GirisMatrisi[6, 0] = x4;
                GirisMatrisi[6, 1] = y4;
                GirisMatrisi[6, 2] = 1;
                GirisMatrisi[6, 3] = 0;
                GirisMatrisi[6, 4] = 0;
                GirisMatrisi[6, 5] = 0;
                GirisMatrisi[6, 6] = -x4 * X4;
                GirisMatrisi[6, 7] = -y4 * X4;
                //{ 0, 0, 0, x4, y4, 1, -x4 * Y4, -y4 * Y4 } 
                GirisMatrisi[7, 0] = 0;
                GirisMatrisi[7, 1] = 0;
                GirisMatrisi[7, 2] = 0;
                GirisMatrisi[7, 3] = x4;
                GirisMatrisi[7, 4] = y4;
                GirisMatrisi[7, 5] = 1;
                GirisMatrisi[7, 6] = -x4 * Y4;
                GirisMatrisi[7, 7] = -y4 * Y4;
                double[,] matrisBTersi = MatrisTersiniAl(GirisMatrisi);

                double a00 = 0, a01 = 0, a02 = 0, a10 = 0, a11 = 0, a12 = 0, a20 = 0,
    a21 = 0, a22 = 0;
                a00 = matrisBTersi[0, 0] * X1 + matrisBTersi[0, 1] * Y1 +
               matrisBTersi[0, 2] *
               X2 + matrisBTersi[0, 3] * Y2 + matrisBTersi[0, 4] * X3 +
               matrisBTersi[0, 5] * Y3 +
                matrisBTersi[0, 6] * X4 + matrisBTersi[0, 7] * Y4;
                a01 = matrisBTersi[1, 0] * X1 + matrisBTersi[1, 1] * Y1 +
               matrisBTersi[1, 2] *
                X2 + matrisBTersi[1, 3] * Y2 + matrisBTersi[1, 4] * X3 +
               matrisBTersi[1, 5] * Y3 +
                matrisBTersi[1, 6] * X4 + matrisBTersi[1, 7] * Y4;
                a02 = matrisBTersi[2, 0] * X1 + matrisBTersi[2, 1] * Y1 +
               matrisBTersi[2, 2] *
                X2 + matrisBTersi[2, 3] * Y2 + matrisBTersi[2, 4] * X3 +
               matrisBTersi[2, 5] * Y3 +
                matrisBTersi[2, 6] * X4 + matrisBTersi[2, 7] * Y4;
                a10 = matrisBTersi[3, 0] * X1 + matrisBTersi[3, 1] * Y1 +
               matrisBTersi[3, 2] *
                X2 + matrisBTersi[3, 3] * Y2 + matrisBTersi[3, 4] * X3 +
               matrisBTersi[3, 5] * Y3 +
                matrisBTersi[3, 6] * X4 + matrisBTersi[3, 7] * Y4;
                a11 = matrisBTersi[4, 0] * X1 + matrisBTersi[4, 1] * Y1 +
               matrisBTersi[4, 2] *
                X2 + matrisBTersi[4, 3] * Y2 + matrisBTersi[4, 4] * X3 +
               matrisBTersi[4, 5] * Y3 +
                matrisBTersi[4, 6] * X4 + matrisBTersi[4, 7] * Y4;
                a12 = matrisBTersi[5, 0] * X1 + matrisBTersi[5, 1] * Y1 +
               matrisBTersi[5, 2] *
                X2 + matrisBTersi[5, 3] * Y2 + matrisBTersi[5, 4] * X3 +
               matrisBTersi[5, 5] * Y3 +
                matrisBTersi[5, 6] * X4 + matrisBTersi[5, 7] * Y4;
                a20 = matrisBTersi[6, 0] * X1 + matrisBTersi[6, 1] * Y1 +
               matrisBTersi[6, 2] *
                X2 + matrisBTersi[6, 3] * Y2 + matrisBTersi[6, 4] * X3 +
               matrisBTersi[6, 5] * Y3 +
                matrisBTersi[6, 6] * X4 + matrisBTersi[6, 7] * Y4;
                a21 = matrisBTersi[7, 0] * X1 + matrisBTersi[7, 1] * Y1 +
               matrisBTersi[7, 2] * X2 + matrisBTersi[7, 3] * Y2 + matrisBTersi[7, 4] * X3 +
               matrisBTersi[7, 5] * Y3 + matrisBTersi[7, 6] * X4 + matrisBTersi[7, 7] * Y4;
                a22 = 1;
                //------------------------- Perspektif düzeltme işlemi ------------------------

                PerspektifDuzelt(a00, a01, a02, a10, a11, a12, a20, a21, a22);
                sayac = 1;
                x1 = -1;
                y1 = -1;
                x2 = -1;
                y2 = -1;
                x3 = -1;
                y3 = -1;
                x4 = -1;
                y4 = -1;

            }






        }

        //================== Perspektif düzeltme işlemi =================
        public void PerspektifDuzelt(double a00, double a01, double a02,
       double a10, double a11, double a12, double a20,
       double a21, double a22)
        {
            Bitmap GirisResmi, CikisResmi;
            Color OkunanRenk;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double X, Y, z;
            for (int x = 0; x < (ResimGenisligi); x++)
            {
                for (int y = 0; y < (ResimYuksekligi); y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    z = a20 * x + a21 * y + 1;
                    X = (a00 * x + a01 * y + a02) / z;
                    Y = (a10 * x + a11 * y + a12) / z;
                    if (X > 0 && X < ResimGenisligi && Y > 0 && Y < ResimYuksekligi)
                        //Picturebox ın dışına çıkan kısımlar oluşturulmayacak.
                        CikisResmi.SetPixel((int)X, (int)Y, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        // MATRİS TERSİNİ ALMA---------------------
        public double[,] MatrisTersiniAl(double[,] GirisMatrisi)
        {
            int MatrisBoyutu = Convert.ToInt16(Math.Sqrt(GirisMatrisi.Length));
            //matris boyutu içindeki eleman sayısı olduğu için kare matrisde 
            //karekökü matris boyutu olur.
            double[,] CikisMatrisi = new double[MatrisBoyutu, MatrisBoyutu]; //A nın 
                                                                             //tersi alındığında bu matris içinde tutulacak
                                                                             //--I Birim matrisin içeriğini dolduruyor 
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (i == j)
                        CikisMatrisi[i, j] = 1;
                    else
                        CikisMatrisi[i, j] = 0;
                }
            }
            //--Matris Tersini alma işlemi---------
            double d, k;
            for (int i = 0; i < MatrisBoyutu; i++)
            {
                d = GirisMatrisi[i, i];
                for (int j = 0; j < MatrisBoyutu; j++)
                {
                    if (d == 0)
                    {
                        d = 0.0001; //0 bölme hata veriyordu. 
                    }
                    GirisMatrisi[i, j] = GirisMatrisi[i, j] / d;
                    CikisMatrisi[i, j] = CikisMatrisi[i, j] / d;
                }
                for (int x = 0; x < MatrisBoyutu; x++)
                {
                    if (x != i)
                    {
                        k = GirisMatrisi[x, i];
                        for (int j = 0; j < MatrisBoyutu; j++)
                        {
                            GirisMatrisi[x, j] = GirisMatrisi[x, j] - GirisMatrisi[i, j] * k;
                            CikisMatrisi[x, j] = CikisMatrisi[x, j] - CikisMatrisi[i, j] * k;
                        }
                    }
                }
            }
            return CikisMatrisi;
        }

        private void ötelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            durumlb.Text = "Öteleme";
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen resim seçiniz", "Dikkat!!!!");
                return;
            }
            
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            double x2 = 0, y2 = 0;

            //Taşıma mesafelerini atıyor.
            int Tx = (int)x1;
            int Ty = (int)y1;
            for (int x1 = 0; x1 < (ResimGenisligi); x1++)
            {
                for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x1, y1);
                    x2 = x1 + Tx;
                    y2 = y1 + Ty;
                    if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                        CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }


}


