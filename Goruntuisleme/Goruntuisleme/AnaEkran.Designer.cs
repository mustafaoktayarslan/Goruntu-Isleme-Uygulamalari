
namespace Goruntuisleme
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoğrafSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoğrafıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yuklenenhistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olusanhistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parlaklıkAyarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastAyarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esikleTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrastGermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEşitlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.meanOrtalamaFiltresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianOrtancaFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.laplacianFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.açılıDöndürmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tersÇevirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakınlaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzaklaştırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ötelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.perspektifDüzeltmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.görüntüyüAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.durumlb = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleDescription = "";
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.SlateGray;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(1, 0);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(30, 472);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 127;
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(478, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 375);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fotoğrafSeçToolStripMenuItem,
            this.fotoğrafıKaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dosyaToolStripMenuItem.Image")));
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.dosyaToolStripMenuItem.Text = "DOSYA";
            // 
            // fotoğrafSeçToolStripMenuItem
            // 
            this.fotoğrafSeçToolStripMenuItem.Name = "fotoğrafSeçToolStripMenuItem";
            this.fotoğrafSeçToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fotoğrafSeçToolStripMenuItem.Text = "Fotoğraf Seç";
            this.fotoğrafSeçToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafSeçToolStripMenuItem_Click);
            // 
            // fotoğrafıKaydetToolStripMenuItem
            // 
            this.fotoğrafıKaydetToolStripMenuItem.Name = "fotoğrafıKaydetToolStripMenuItem";
            this.fotoğrafıKaydetToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fotoğrafıKaydetToolStripMenuItem.Text = "Fotoğrafı Kaydet";
            this.fotoğrafıKaydetToolStripMenuItem.Click += new System.EventHandler(this.fotoğrafıKaydetToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramFiltreToolStripMenuItem,
            this.negatifToolStripMenuItem,
            this.griFiltreToolStripMenuItem,
            this.parlaklıkAyarıToolStripMenuItem,
            this.kontrastAyarıToolStripMenuItem,
            this.esikleTSM,
            this.kontrastGermeToolStripMenuItem,
            this.histogramEşitlemeToolStripMenuItem,
            this.toolStripSeparator1,
            this.meanOrtalamaFiltresiToolStripMenuItem,
            this.medianOrtancaFiltreToolStripMenuItem,
            this.gaussToolStripMenuItem,
            this.toolStripSeparator2,
            this.laplacianFiltreToolStripMenuItem,
            this.denemeToolStripMenuItem,
            this.toolStripSeparator4,
            this.dilationToolStripMenuItem,
            this.erıToolStripMenuItem,
            this.toolStripSeparator3,
            this.açılıDöndürmeToolStripMenuItem,
            this.tersÇevirmeToolStripMenuItem,
            this.aynalamaToolStripMenuItem,
            this.yakınlaştırmaToolStripMenuItem,
            this.uzaklaştırmaToolStripMenuItem,
            this.ötelemeToolStripMenuItem,
            this.toolStripSeparator5,
            this.perspektifDüzeltmeToolStripMenuItem});
            this.fToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fToolStripMenuItem.Image")));
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(99, 34);
            this.fToolStripMenuItem.Text = "FİLTRELER";
            // 
            // histogramFiltreToolStripMenuItem
            // 
            this.histogramFiltreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yuklenenhistogramToolStripMenuItem,
            this.olusanhistogramToolStripMenuItem});
            this.histogramFiltreToolStripMenuItem.Name = "histogramFiltreToolStripMenuItem";
            this.histogramFiltreToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.histogramFiltreToolStripMenuItem.Text = "Histogram";
            // 
            // yuklenenhistogramToolStripMenuItem
            // 
            this.yuklenenhistogramToolStripMenuItem.Name = "yuklenenhistogramToolStripMenuItem";
            this.yuklenenhistogramToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.yuklenenhistogramToolStripMenuItem.Text = "Yüklenen Resim Histogramı";
            this.yuklenenhistogramToolStripMenuItem.Click += new System.EventHandler(this.yuklenenhistogramToolStripMenuItem_Click);
            // 
            // olusanhistogramToolStripMenuItem
            // 
            this.olusanhistogramToolStripMenuItem.Name = "olusanhistogramToolStripMenuItem";
            this.olusanhistogramToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.olusanhistogramToolStripMenuItem.Text = "Oluşan Resim Histogramı";
            this.olusanhistogramToolStripMenuItem.Click += new System.EventHandler(this.olusanhistogramToolStripMenuItem_Click);
            // 
            // negatifToolStripMenuItem
            // 
            this.negatifToolStripMenuItem.Name = "negatifToolStripMenuItem";
            this.negatifToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.negatifToolStripMenuItem.Text = "Negatif Filtre";
            this.negatifToolStripMenuItem.Click += new System.EventHandler(this.negatifToolStripMenuItem_Click);
            // 
            // griFiltreToolStripMenuItem
            // 
            this.griFiltreToolStripMenuItem.Name = "griFiltreToolStripMenuItem";
            this.griFiltreToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.griFiltreToolStripMenuItem.Text = "Gri Filtre";
            this.griFiltreToolStripMenuItem.Click += new System.EventHandler(this.griFiltreToolStripMenuItem_Click);
            // 
            // parlaklıkAyarıToolStripMenuItem
            // 
            this.parlaklıkAyarıToolStripMenuItem.Name = "parlaklıkAyarıToolStripMenuItem";
            this.parlaklıkAyarıToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.parlaklıkAyarıToolStripMenuItem.Text = "Parlaklık Ayarı";
            this.parlaklıkAyarıToolStripMenuItem.Click += new System.EventHandler(this.parlaklıkAyarıToolStripMenuItem_Click);
            // 
            // kontrastAyarıToolStripMenuItem
            // 
            this.kontrastAyarıToolStripMenuItem.Name = "kontrastAyarıToolStripMenuItem";
            this.kontrastAyarıToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.kontrastAyarıToolStripMenuItem.Text = "Kontrast Ayarı";
            this.kontrastAyarıToolStripMenuItem.Click += new System.EventHandler(this.kontrastAyarıToolStripMenuItem_Click);
            // 
            // esikleTSM
            // 
            this.esikleTSM.Name = "esikleTSM";
            this.esikleTSM.Size = new System.Drawing.Size(233, 22);
            this.esikleTSM.Text = "Eşikleme Filtre";
            this.esikleTSM.Click += new System.EventHandler(this.esikleTSM_Click);
            // 
            // kontrastGermeToolStripMenuItem
            // 
            this.kontrastGermeToolStripMenuItem.Name = "kontrastGermeToolStripMenuItem";
            this.kontrastGermeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.kontrastGermeToolStripMenuItem.Text = "Kontrast Germe";
            this.kontrastGermeToolStripMenuItem.Click += new System.EventHandler(this.kontrastGermeToolStripMenuItem_Click);
            // 
            // histogramEşitlemeToolStripMenuItem
            // 
            this.histogramEşitlemeToolStripMenuItem.Name = "histogramEşitlemeToolStripMenuItem";
            this.histogramEşitlemeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.histogramEşitlemeToolStripMenuItem.Text = "Histogram Eşitleme";
            this.histogramEşitlemeToolStripMenuItem.Click += new System.EventHandler(this.histogramEşitlemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // meanOrtalamaFiltresiToolStripMenuItem
            // 
            this.meanOrtalamaFiltresiToolStripMenuItem.Name = "meanOrtalamaFiltresiToolStripMenuItem";
            this.meanOrtalamaFiltresiToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.meanOrtalamaFiltresiToolStripMenuItem.Text = "Mean (Ortalama) Filtre";
            this.meanOrtalamaFiltresiToolStripMenuItem.Click += new System.EventHandler(this.meanOrtalamaFiltresiToolStripMenuItem_Click);
            // 
            // medianOrtancaFiltreToolStripMenuItem
            // 
            this.medianOrtancaFiltreToolStripMenuItem.Name = "medianOrtancaFiltreToolStripMenuItem";
            this.medianOrtancaFiltreToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.medianOrtancaFiltreToolStripMenuItem.Text = "Median (Ortanca) Filtre";
            this.medianOrtancaFiltreToolStripMenuItem.Click += new System.EventHandler(this.medianOrtancaFiltreToolStripMenuItem_Click);
            // 
            // gaussToolStripMenuItem
            // 
            this.gaussToolStripMenuItem.Name = "gaussToolStripMenuItem";
            this.gaussToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.gaussToolStripMenuItem.Text = "Gauss Filtre";
            this.gaussToolStripMenuItem.Click += new System.EventHandler(this.gaussToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // laplacianFiltreToolStripMenuItem
            // 
            this.laplacianFiltreToolStripMenuItem.Name = "laplacianFiltreToolStripMenuItem";
            this.laplacianFiltreToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.laplacianFiltreToolStripMenuItem.Text = "Yüksek Geçirgen Filtreler";
            this.laplacianFiltreToolStripMenuItem.Click += new System.EventHandler(this.laplacianFiltreToolStripMenuItem_Click);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.denemeToolStripMenuItem.Text = "Konvolüsyon Filtre";
            this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
            // 
            // dilationToolStripMenuItem
            // 
            this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
            this.dilationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.dilationToolStripMenuItem.Text = "Dilation";
            this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
            // 
            // erıToolStripMenuItem
            // 
            this.erıToolStripMenuItem.Name = "erıToolStripMenuItem";
            this.erıToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.erıToolStripMenuItem.Text = "Erosion";
            this.erıToolStripMenuItem.Click += new System.EventHandler(this.erıToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
            // 
            // açılıDöndürmeToolStripMenuItem
            // 
            this.açılıDöndürmeToolStripMenuItem.Name = "açılıDöndürmeToolStripMenuItem";
            this.açılıDöndürmeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.açılıDöndürmeToolStripMenuItem.Text = "Açılı Döndürme";
            this.açılıDöndürmeToolStripMenuItem.Click += new System.EventHandler(this.açılıDöndürmeToolStripMenuItem_Click);
            // 
            // tersÇevirmeToolStripMenuItem
            // 
            this.tersÇevirmeToolStripMenuItem.Name = "tersÇevirmeToolStripMenuItem";
            this.tersÇevirmeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.tersÇevirmeToolStripMenuItem.Text = "Ters Çevirme";
            this.tersÇevirmeToolStripMenuItem.Click += new System.EventHandler(this.tersÇevirmeToolStripMenuItem_Click);
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.aynalamaToolStripMenuItem_Click);
            // 
            // yakınlaştırmaToolStripMenuItem
            // 
            this.yakınlaştırmaToolStripMenuItem.Name = "yakınlaştırmaToolStripMenuItem";
            this.yakınlaştırmaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.yakınlaştırmaToolStripMenuItem.Text = "Yakınlaştırma";
            this.yakınlaştırmaToolStripMenuItem.Click += new System.EventHandler(this.yakınlaştırmaToolStripMenuItem_Click);
            // 
            // uzaklaştırmaToolStripMenuItem
            // 
            this.uzaklaştırmaToolStripMenuItem.Name = "uzaklaştırmaToolStripMenuItem";
            this.uzaklaştırmaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.uzaklaştırmaToolStripMenuItem.Text = "Uzaklaştırma";
            this.uzaklaştırmaToolStripMenuItem.Click += new System.EventHandler(this.uzaklaştırmaToolStripMenuItem_Click);
            // 
            // ötelemeToolStripMenuItem
            // 
            this.ötelemeToolStripMenuItem.Name = "ötelemeToolStripMenuItem";
            this.ötelemeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.ötelemeToolStripMenuItem.Text = "Öteleme";
            this.ötelemeToolStripMenuItem.Click += new System.EventHandler(this.ötelemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(230, 6);
            // 
            // perspektifDüzeltmeToolStripMenuItem
            // 
            this.perspektifDüzeltmeToolStripMenuItem.Name = "perspektifDüzeltmeToolStripMenuItem";
            this.perspektifDüzeltmeToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.perspektifDüzeltmeToolStripMenuItem.Text = "Perspektif Düzeltme";
            this.perspektifDüzeltmeToolStripMenuItem.Click += new System.EventHandler(this.perspektifDüzeltmeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.fToolStripMenuItem,
            this.görüntüyüAktarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(298, 29);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görüntüyüAktarToolStripMenuItem
            // 
            this.görüntüyüAktarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("görüntüyüAktarToolStripMenuItem.Image")));
            this.görüntüyüAktarToolStripMenuItem.Name = "görüntüyüAktarToolStripMenuItem";
            this.görüntüyüAktarToolStripMenuItem.Size = new System.Drawing.Size(144, 34);
            this.görüntüyüAktarToolStripMenuItem.Text = "Görüntüyü Aktar";
            this.görüntüyüAktarToolStripMenuItem.Click += new System.EventHandler(this.görüntüyüAktarToolStripMenuItem_Click);
            // 
            // degertxt
            // 
            this.degertxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.degertxt.Location = new System.Drawing.Point(183, 40);
            this.degertxt.Name = "degertxt";
            this.degertxt.Size = new System.Drawing.Size(104, 23);
            this.degertxt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Değeri Girin:";
            // 
            // durumlb
            // 
            this.durumlb.BackColor = System.Drawing.Color.SlateGray;
            this.durumlb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durumlb.ForeColor = System.Drawing.Color.White;
            this.durumlb.Location = new System.Drawing.Point(685, 35);
            this.durumlb.Name = "durumlb";
            this.durumlb.Size = new System.Drawing.Size(193, 28);
            this.durumlb.TabIndex = 0;
            this.durumlb.Text = "SEÇİLEN FİLTRE";
            this.durumlb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.durumlb.Click += new System.EventHandler(this.durumlb_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(897, 471);
            this.Controls.Add(this.durumlb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.degertxt);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fotoğrafıKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griFiltreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parlaklıkAyarıToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem esikleTSM;
        private System.Windows.Forms.TextBox degertxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label durumlb;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem görüntüyüAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastGermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEşitlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrastAyarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanOrtalamaFiltresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianOrtancaFiltreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianFiltreToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erıToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem açılıDöndürmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tersÇevirmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakınlaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzaklaştırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramFiltreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yuklenenhistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olusanhistogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem perspektifDüzeltmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ötelemeToolStripMenuItem;
    }
}

