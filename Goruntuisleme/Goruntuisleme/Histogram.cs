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
    public partial class Histogram : Form
    {
        int[] DiziPikselSayilari= new int[256];
        public Histogram(int[] dizipix)
        {
            DiziPikselSayilari = dizipix;
            InitializeComponent();
        }
       


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int RenkMaksPikselSayisi = 0;
            int maxpix = 0;

            for (int k = 0; k <= 255; k++)
            {
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]);
                //Maksimum piksel sayısını bulmaya çalışıyor.
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                    maxpix = k;
                   

                }
            }
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.LightSkyBlue, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pb3.CreateGraphics();
            
            int GrafikYuksekligi = 300;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi;
            double OlcekX = 1.5;
            int X_kaydirma = 10;
            for (int x = 0; x <= 255; x++)
            {
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX),  GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                
                //Dikey kırmızı çizgiler.

            }
            textBox1.Text = RenkMaksPikselSayisi.ToString();
            textBox2.Text = maxpix.ToString();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
