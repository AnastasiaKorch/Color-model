using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Color_models
{
    public partial class Form1 : Form
    {
        // pictureBox1
        BitmapData bitmap;
        Bitmap bit;
        //Graphics g;
        int totalSize;
        byte[] imageBytes;
        int[] gray;
        int[] histored;
        int[] histogreen;
        int[] histoblue;

        public Form1()
        {
            InitializeComponent();
            trackbars.Enabled = false;
            bit = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bit;
           // g = Graphics.FromImage(pictureBox1.Image);
           //g.Clear(Color.White);
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e) // Загрузка изображения
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName != null)
                { pictureBox1.Image = new Bitmap(ofd.FileName); }
            }
        }

        private void getBitmapData(PictureBox CurrentPicture) 
        {
            Rectangle bounds = new Rectangle(0, 0, CurrentPicture.Image.Width, CurrentPicture.Image.Height);
            bitmap = ((Bitmap)CurrentPicture.Image).LockBits(bounds, ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
            int RowSizeBytes = bitmap.Stride;
            totalSize = RowSizeBytes * bitmap.Height;
            imageBytes = new byte[totalSize];
            Marshal.Copy(bitmap.Scan0, imageBytes, 0, totalSize);
        }

        private void returnBitmapData(PictureBox CurrentPicture)
        {
            Marshal.Copy(imageBytes, 0, bitmap.Scan0, totalSize);
            ((Bitmap)CurrentPicture.Image).UnlockBits(bitmap);
            imageBytes = null;
            bitmap = null;
        }

        /*private void HistoGramGray()
        {
            
            Bitmap bm = (Bitmap)pictureBox4.Image;
            for (int x = 0; x < bm.Width; x++)
            {
                for (int y = 0; y < bm.Height; y++)
                {
                    Color c = bm.GetPixel(x, y);
                    
                }
            }
            // This outputs the histogram in an output window
            foreach (Color key in histo.Keys)
            {
                Debug.WriteLine(key.ToString() + ": " + histo[key]);
            }
        }*/

        private void чернобелоеToolStripMenuItem_Click(object sender, EventArgs e) //Черно-белое
        {
            trackbars.Enabled = false;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Нет изображения");
                return;
            }

            // pictureBox2
            byte[] grayBytes;

            // pictureBox3
            byte[] grayBytes2;

            // pictureBox4
            byte[] grayDifference;


            getBitmapData(pictureBox1);

            grayBytes = new byte[totalSize];
            grayBytes2 = new byte[totalSize];
            grayDifference = new byte[totalSize];

            gray = new int[256];
            for (int i = 0; i < 255; i++)
            { gray[i] = 0; }
            
            imageBytes.CopyTo(grayBytes, 0);
            imageBytes.CopyTo(grayBytes2, 0);

            // обработка исходного изображения
            int k = 0;
            for (int i = 0; i < pictureBox1.Image.Height; ++i)
                for (int j = 0; j < pictureBox1.Image.Width; ++j)
                {
                    k = i * bitmap.Stride + j * 4;
                    // серый цвет
                    byte c = (byte)(0.0722 * grayBytes[k] + 0.7152 * grayBytes[k + 1] + 0.2126 * grayBytes[k + 2]);
                    grayBytes[k] = c;
                    grayBytes[k + 1] = c;
                    grayBytes[k + 2] = c;
                    // другой серый цвет
                    c = (byte)(0.33 * grayBytes2[k] + 0.33 * grayBytes2[k + 1] + 0.33 * grayBytes2[k + 2]);
                    grayBytes2[k] = c;
                    grayBytes2[k + 1] = c;
                    grayBytes2[k + 2] = c;
                    // Разница между двумя серыми цветами
                    c = (byte)(Math.Abs(grayBytes[k] - grayBytes2[k]) + Math.Abs(grayBytes[k + 1] - grayBytes2[k + 1])+ Math.Abs(grayBytes[k + 2] - grayBytes2[k + 2]));
                    grayDifference[k] = c;
                    grayDifference[k+1] = c;
                    grayDifference[k + 2] = c;
                    gray[c]++;
                    //this.chart1.Series["Интенсивность"].Points.AddY((double)c);
                }

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();

            for (int i=0; i<255; i++)
            {
                this.chart1.Series["Интенсивность"].Points.AddY(gray[i]);
            }
     
            returnBitmapData(pictureBox1);

            DisplayImages(grayBytes, grayBytes2, grayDifference); // ссылка на создание

            
        }

        void DisplayImages(byte[] im1, byte[] im2, byte[] im3) // создание изображений на всех полях
        {
            Rectangle bounds;
            // создание 1ого варианта серого цвета в поле 2 
            pictureBox2.Image = new Bitmap(pictureBox1.Image);
            bounds = new Rectangle(0,0,pictureBox2.Image.Width, pictureBox2.Image.Height);
            BitmapData GrayBm = ((Bitmap)pictureBox2.Image).LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
        
            Marshal.Copy(im1, 0, GrayBm.Scan0, totalSize);
            ((Bitmap)pictureBox2.Image).UnlockBits(GrayBm);
            pictureBox2.Refresh();

            // создание 2ого варианта серого цветв в пол 3
            pictureBox3.Image = new Bitmap(pictureBox1.Image);
            bounds = new Rectangle(0,0,pictureBox3.Image.Width,pictureBox3.Image.Height);
            BitmapData GrayBm2 = ((Bitmap)pictureBox3.Image).LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);

            Marshal.Copy(im2, 0, GrayBm2.Scan0, totalSize);
            ((Bitmap)pictureBox3.Image).UnlockBits(GrayBm2);
            pictureBox3.Refresh();

            // создание разницы серых цветов в поле 4
            pictureBox4.Image = new Bitmap(pictureBox1.Image);
            bounds = new Rectangle(0,0,pictureBox4.Image.Width,pictureBox4.Image.Height);
            BitmapData differenceBitmapData = ((Bitmap)pictureBox4.Image).LockBits(bounds,ImageLockMode.ReadWrite,PixelFormat.Format32bppRgb);

            Marshal.Copy(im3, 0, differenceBitmapData.Scan0, totalSize);
            ((Bitmap)pictureBox4.Image).UnlockBits(differenceBitmapData);
            pictureBox4.Refresh();
        }

        void DisplayImages(byte[] im1) //создание изображения для HSV
        {
            Rectangle bounds;
            // создание картинки на pictureBox2
            pictureBox2.Image = new Bitmap(pictureBox1.Image);
            bounds = new Rectangle(0, 0, pictureBox2.Image.Width, pictureBox2.Image.Height);
            BitmapData GrayBm = ((Bitmap)pictureBox2.Image).LockBits(bounds, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);

            Marshal.Copy(im1, 0, GrayBm.Scan0, totalSize);
            ((Bitmap)pictureBox2.Image).UnlockBits(GrayBm);
            pictureBox2.Refresh();

            
            if (pictureBox3.Image != null)
            {
                pictureBox3.Image.Dispose();
                pictureBox3.Image = null;
            }

            if (pictureBox4.Image != null)
            {
                pictureBox4.Image.Dispose();
                pictureBox4.Image = null;
            }
        }

        

        private void разложитьПоКаналамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackbars.Enabled = false;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Нет изображения");
                return;
            }

            // pictureBox2
            byte[] red;

            // pictureBox3
            byte[] green;

            // pictureBox4
            byte[] blue;


            getBitmapData(pictureBox1);

            red = new byte[totalSize];
            green = new byte[totalSize];
            blue = new byte[totalSize];

            imageBytes.CopyTo(red, 0);
            imageBytes.CopyTo(green, 0);
            imageBytes.CopyTo(blue, 0);

            // Обработка исходного изображения
            int k = 0;
            histored = new int[256];
            histogreen = new int[256];
            histoblue = new int[256];
            for (int i=0; i<255; i++)
            {
                histored[i] = 0;
                histogreen[i] = 0;
                histoblue[i] = 0;
            }
            for (int i = 0; i < pictureBox1.Image.Height; ++i)
                for (int j = 0; j < pictureBox1.Image.Width; ++j)
                {
                    k = i * bitmap.Stride + j * 4;
                    // красный канал
                    red[k] = 0;
                    red[k + 1] = 0;
                    histored[red[k + 2]]++;
                    // зеленый канал
                    green[k] = 0;
                    green[k + 2] = 0;
                    histogreen[green[k + 1]]++;
                    // синий канал
                    blue[k + 1] = 0;
                    blue[k + 2] = 0;
                    histoblue[blue[k]]++;
                }

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();

            for (int i = 0; i<255; i++ )
            {
                this.chart1.Series["Red"].Points.AddY(histored[i]);
                this.chart1.Series["Green"].Points.AddY(histogreen[i]);
                this.chart1.Series["Blue"].Points.AddY(histoblue[i]);
            }
            returnBitmapData(pictureBox1);

            DisplayImages(red, green, blue); // ссылка на создание 
        }


        private void RGBtoHSV(byte b, byte g, byte r, ref double h, ref double s, ref double v)   //вспоманалтельная процедура для RGB - > HSV
        {
            double r1 = r / 255.0;
            double g1 = g / 255.0;
            double b1 = b / 255.0;

            double cMax = Math.Max(r1, Math.Max(g1, b1));
            double cMin = Math.Min(r1, Math.Min(g1, b1));
            double delta = cMax - cMin;

            // H
            if (delta == 0)
                h = 0;
            else if (cMax == r1)
                h = 60.0 * (((g1 - b1) / delta) % 6);
            else if (cMax == g1)
                h = 60.0 * ((b1 - r1) / delta + 2);
            else
                h = 60.0 * ((r1 - g1) / delta + 4);
            // S
            if (cMax == 0)
                s = 0;
            else
                s = delta / cMax;

            // V
            v = cMax;
        }

       

        private void HSVtoRGB(double h, double s, double v, ref double r, ref double g, ref double b) //вспомагательная процедура для HSV - > RGB
        {
            double c = v * s;
            double x = c * (1 - Math.Abs((h / 60.0) % 2 - 1));
            double m = v - c;
            double r1 = 0, g1 = 0, b1 = 0;
            if (0 <= h && h < 60)
                { r1 = c; g1 = x; b1 = 0; }
            else if (60 <= h && h < 120)
                { r1 = x; g1 = c; b1 = 0; }
            else if (120 <= h && h < 180)
                { r1 = 0; g1 = c; b1 = x; }
            else if (180 <= h && h < 240)
                { r1 = 0; g1 = x; b1 = c; }
            else if (240 <= h && h < 300)
                { r1 = x; g1 = 0; b1 = c; }
            else if (300 <= h && h < 360)
                { r1 = c; g1 = 0; b1 = x; }

            r = (r1 + m) * 255;
            g = (g1 + m) * 255;
            b = (b1 + m) * 255;
        }

        private void преобразоватьВHSVToolStripMenuItem_Click(object sender, EventArgs e) //RGB - > HSV
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Нет изображения");
                return;
            }
            trackbars.Enabled = true;

            // pictureBox2 
            byte[] HSV;
            
      
            getBitmapData(pictureBox1);

            HSV = new byte[totalSize];
          

            imageBytes.CopyTo(HSV, 0);
            

            // Обработка исходного изображения
            int k = 0;
            for (int i = 0; i < pictureBox1.Image.Height; ++i)
                for (int j = 0; j < pictureBox1.Image.Width; ++j)
                {
                    double h = 0, s = 0, v = 0;
                    k = i * bitmap.Stride + j * 4;
                    double r = imageBytes[k + 2];
                    double g = imageBytes[k + 1];
                    double b = imageBytes[k];
                    RGBtoHSV((byte)b, (byte)g, (byte)r, ref h, ref s, ref v);
                    // получаем HSV канал 
                    HSVtoRGB(h, s, v, ref r, ref g, ref b);
                    HSV[k] = (byte)b;
                    HSV[k + 1] = (byte)g;
                    HSV[k + 2] = (byte)r; // HSV
                }

     
            returnBitmapData(pictureBox1);

            DisplayImages(HSV);  // ссылка на создание

        }

        private void ProcessHSV(object sender, MouseEventArgs e) // HVS - > RGB
        {
         
            getBitmapData(pictureBox1);

            // pictureBox4
            byte[] blue;

            blue = new byte[totalSize];

            // Обработка исходного изображения
            int k = 0;
            for (int i = 0; i < pictureBox1.Image.Height; ++i)
                for (int j = 0; j < pictureBox1.Image.Width; ++j)
                {
                    double h = 0, s = 0, v = 0;
                    k = i * bitmap.Stride + j * 4;
                    double r = imageBytes[k + 2];
                    double g = imageBytes[k + 1];
                    double b = imageBytes[k];
                    RGBtoHSV((byte)b, (byte)g, (byte)r, ref h, ref s, ref v);
                    h += hue.Value;
                    if (h < 0)
                        h += 360;
                    s += sat.Value / 100.0;
                    s = Math.Min(1, Math.Max(s, 0));
                    v += val.Value / 100.0;
                    v = Math.Min(1, Math.Max(v, 0));
                    HSVtoRGB(h, s, v, ref r, ref g, ref b);
                    blue[k + 3] = 255;
                    blue[k + 2] = (byte)r;
                    blue[k + 1] = (byte)g;
                    blue[k] = (byte)b;
                }

         
            returnBitmapData(pictureBox1);

            pictureBox1.Refresh();

            DisplayImages(blue); // ссылка на создание
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьtoolStripMenuItem1_Click(object sender, EventArgs e) //сохранение
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Нет изображения");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "jpg";
            sfd.Filter =
            "Изображение (*.pmb;*.jpg;*.jpeg;*.tif;*.tiff;*.gif;*.png;*.exif)|*.pmb;*.jpg;*.jpeg;*.tif;*.tiff;*.gif;*.png;*.exif";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                //bit.Save(sfd.FileName);
                pictureBox2.Image.Save(sfd.FileName);
        }
        
        private void сбросToolStripMenuItem_Click(object sender, EventArgs e) //Сброс
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();
        }
    }
}
