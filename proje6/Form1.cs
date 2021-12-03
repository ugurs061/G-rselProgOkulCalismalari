using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();//timer1 başlat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();//timer1 durdur
        }

        int yön = 5;
        Random rnd = new Random();
        int r, g, b;
        int gen = -5;
        int sn = 0;

        int []resim= new int[10];
        int[] hız = new int[10];
        private void button5_Click(object sender, EventArgs e)
        {
            //rastgele resim oluşturma
            int i;
            for (i = 0; i <10; i++)
            {
                resim[i] = rnd.Next(1, 6);//restgele resim numarası oluşturma

                PictureBox p;
                p = (PictureBox)this.Controls["p" + (i+1)];
                p.Image =Image.FromFile(resim[i] + ".gif");
            }

         
            //rastgele hız dizisi oluşturma
            for (i = 0; i <10; i++)
                hız[i] = rnd.Next(5,20);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            timer2.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //rastgele resim oluşturma
            int i;
            for (i = 1; i <= 10; i++)
            {
                PictureBox p;
                p = (PictureBox)this.Controls["p" + i];
    
                p.Image = Image.FromFile(resim[i-1] + ".gif");

                if (p.Top + p.Height >= this.Height)//resim indiyse yenile
                {
                    resim[i-1] = rnd.Next(1,6);
                    hız[i-1] = rnd.Next(5, 20);
                    p.Top = 0;
                }

                p.Top += hız[i-1];//resimler kendi hız değeri ile düşecek
            }
        }

        int ss = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width + panel1.Left + 5 >= this.Width)//en sağa ulaştık mı?
                yön = -5;
            if (panel1.Left<= 0)//en sola geldik mi?
                yön = 5;
            panel1.Left +=yön;//soldan uzaklık yöne bağlı değişiyor

            
            if (panel1.Width + 5 >= 100)//boyut 100 oldu mu?
                gen = -5;
            if (panel1.Width - 5 <= 0)//boyut 0 oldu mu?
                gen = 5;
            panel1.Width += gen;
            panel1.Height += gen;

            r = rnd.Next(0,255); g = rnd.Next(0, 255); b = rnd.Next(0, 255);
            panel1.BackColor = Color.FromArgb(r,g,b);//panel1 arkaplan rengi rastgele

            //panel1.Top +=0;//yukarıdan uzaklık


            //KRONOMETRE
            ss++;
            if (ss == 100)
            {
                sn++;
                ss = 0;
            }
            label1.Text = sn+"";
            label3.Text = ss + "";

        }

        private void p1_MouseClick(object sender, MouseEventArgs e)
        {
            testet(0);
        }

        private void p2_MouseClick(object sender, MouseEventArgs e)
        {
            testet(1);
        }

        private void p3_MouseClick(object sender, MouseEventArgs e)
        {
            testet(2);
        }

        private void p4_MouseClick(object sender, MouseEventArgs e)
        {
            testet(3);
        }

        private void p5_MouseClick(object sender, MouseEventArgs e)
        {
            testet(4);
        }

        private void p6_MouseClick(object sender, MouseEventArgs e)
        {
            testet(5);
        }

        private void p7_MouseClick(object sender, MouseEventArgs e)
        {
            testet(6);
        }

        private void p8_MouseClick(object sender, MouseEventArgs e)
        {
            testet(7);
        }

        private void p9_MouseClick(object sender, MouseEventArgs e)
        {
            testet(8);
        }

        private void p10_MouseClick(object sender, MouseEventArgs e)
        {
            testet(9);
        }


        //Tıklanan resmi test etme
        int puan1 = 0, puan2 = 0, puan3 = 0, puan4 = 0;
        public void testet(int sayı)
        {

            int resimno = resim[sayı];

            resim[sayı] = rnd.Next(1, 6);
            hız[sayı] = rnd.Next(5, 20);

            switch (resimno)
            {

                case 1:
                    puan1 += resimno * hız[sayı];
                    break;
                case 2:
                    puan2 += resimno * hız[sayı];
                    break;
                case 3:
                    puan3 += resimno * hız[sayı];
                    break;
                case 4:
                    puan4 += resimno * hız[sayı];
                    break;
                case 5:
                    puan1 = 0;
                    puan2 = 0;
                    puan3 = 0; 
                    puan4 = 0;
                    break;
                default:
                    break;
            }

            //puanlar yazdırılıyor
            label4.Text = puan1.ToString();
            label5.Text = puan2.ToString();
            label6.Text = puan3.ToString();
            label7.Text = puan4.ToString();

        }
    }
}
