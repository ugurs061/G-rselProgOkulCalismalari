using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Değişkenler
        int w, h;//resim genişliği,yüksekliği
        Bitmap resim,kırmızı, yeşil, mavi, gri, negatif;//renk tonları

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            if (e.Button != MouseButtons.Left)
                return;//sol tuş basılı değilse birşey yapma/geri dön

            x = (e.X * w) / pictureBox1.Width;
            y= (e.Y*h) / pictureBox1.Height;

            resim.SetPixel(x-1, y-1, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x-1, y, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x-1, y+1, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x,y-1,panel1.BackColor);//boyama işlemi
            resim.SetPixel(x, y, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x, y+1, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x +1, y - 1, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x +1, y, panel1.BackColor);//boyama işlemi
            resim.SetPixel(x + 1, y + 1, panel1.BackColor);//boyama işlemi

            pictureBox1.Image = resim;//resim görüntüleme

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();//dialog gösterme
            panel1.BackColor = colorDialog1.Color;//renk atama
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j;//ddöngü değişkeni
            kırmızı = new Bitmap(w,h);//boş resim oluşturuldu
            yeşil = new Bitmap(w, h);//boş resim oluşturuldu
            mavi = new Bitmap(w, h);//boş resim oluşturuldu
            gri = new Bitmap(w, h);//boş resim oluşturuldu
            negatif = new Bitmap(w, h);//boş resim oluşturuldu
            int r, g, b,ort;//renk tonları
          
            //resim işleme döngü yapısı
            for (i = 0; i < w; i++)
            {
                for (j = 0; j < h; j++)
                {
                    r = resim.GetPixel(i,j).R;//kırmızı renk tonu 
                    g= resim.GetPixel(i, j).G;//yeşil renk tonu  
                    b= resim.GetPixel(i, j).B;//mavi renk tonu  

                    kırmızı.SetPixel(i,j,Color.FromArgb(r,0,0));//bir pixeli boyamak için kullanılır
                    yeşil.SetPixel(i, j, Color.FromArgb(0, g, 0));//bir pixeli boyamak için kullanılır
                    mavi.SetPixel(i, j, Color.FromArgb(0, 0, b));//bir pixeli boyamak için kullanılır

                    ort = (r + g + b) / 3;
                    gri.SetPixel(i, j, Color.FromArgb(ort, ort,ort));//bir pixeli boyamak için kullanılır

                    //negatif
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    negatif.SetPixel(i, j, Color.FromArgb(r, g, b));//bir pixeli boyamak için kullanılır
                }
            }

            //resim gösterme
            pictureBox2.Image = negatif;
            pictureBox3.Image = kırmızı;
            pictureBox4.Image = yeşil;
            pictureBox5.Image = mavi;
            pictureBox6.Image = gri;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//dialog gösterme
            pictureBox1.Image.Save(openFileDialog1.FileName);//resim kaydetme
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//dialog gösterme
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);//dosyadan resim yükleme
            resim =new Bitmap(pictureBox1.Image);//resim yükleme
            w = resim.Width;//resim genişliği
            h = resim.Height;//resim yüksekliği
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resim = new Bitmap(pictureBox1.Image);//resim yükleme
            w = resim.Width;//resim genişliği
            h = resim.Height;//resim yüksekliği
        }

        



    }
}
