using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;//yavaşlatmak için

namespace proje13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //OYUN İÇİN KULLANILAN GLOBAL DEĞİŞKEN
        int[,] dizi = new int[20, 20];//resimlerin kodlarınının tutulduğu dizi
        Random rnd = new Random();
        int durum = 1;

        public void dizioluştur()//dizi oluşturmak için
        {
            int i, j;

            for(i=0;i<20;i++)
                for (j = 0; j < 20; j++)
                    dizi[i, j] = rnd.Next(0,10);
        
        }

        public void resimoluştur()//picturebox oluşturmak için
        {
            int i, j;

            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    PictureBox p = new PictureBox();//1-nesne tanımlama
                    p.Name = "p#"+i+"_"+j;//p#0_0,p#0_1,...
                    p.Width = 25;
                    p.Height = 25;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;//2-nesnenin özellikleri ayarlanıyor
                    p.Image = Image.FromFile("yıldız.png");//dizi[0,0]->1, => 1.png
                    p.Left = 10 + 30*i;
                    p.Top = 10 + 30*j;
                    p.Enabled = true;
                    p.Click += new System.EventHandler(testet);
                    this.Controls.Add(p);//picturebox(nesne) forma entegre ediliyor

                }
            }
    
        }

        public void dizigöster()
        {
            int i, j;
            PictureBox p = new PictureBox();//1-nesne tanımlama
            string isim;
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    isim = "p#" + i + "_" + j;//p#0_0,p#0_1,...
                    p = (PictureBox)this.Controls[isim];
                    p.Image = Image.FromFile(dizi[i,j]+".png");//dizi[0,0]->1, => 1.png
                }
            }


        }

        public void resimgizle()
        {
            int i, j;
            PictureBox p = new PictureBox();//1-nesne tanımlama
            string isim;
            for (i = 0; i < 20; i++)
            {
                for (j = 0; j < 20; j++)
                {
                    isim = "p#" + i + "_" + j;//p#0_0,p#0_1,...
                    p = (PictureBox)this.Controls[isim];
                    p.Enabled = true;
                    p.Image = Image.FromFile("yıldız.png");//dizi[0,0]->1, => 1.png
                }
            }


        }


        int ilk, son;
        int puan = 0;
        PictureBox ilkresim, sonresim;
        private void testet(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            int sat, süt;
            int index,index1;     
            string ad = p.Name;
            string isim = "";
            index = ad.IndexOf("#");
            index1 = ad.IndexOf("_");
            sat =Convert.ToInt16( ad.Substring(index+1,index1-index-1));
            süt = Convert.ToInt16(ad.Substring(index1 + 1, ad.Length - index1 - 1));
            isim = "p#" + sat + "_" + süt;//p#0_0,p#0_1,..
            p.Image = Image.FromFile(dizi[sat,süt] + ".png");


            if (durum == 1)//ilk kez tıklandı ise
            {
                ilk = dizi[sat, süt];
                isim = "p#" + sat + "_" + süt;//p#0_0,p#0_1,...
                ilkresim = (PictureBox)this.Controls[isim];
                
                durum = 2;
            }
            else //ikinci kez tıklandı ise
            {
                son= dizi[sat, süt];
                isim = "p#" + sat + "_" + süt;//p#0_0,p#0_1,...
                sonresim = (PictureBox)this.Controls[isim];

                if (ilk == son)//tıklanan resimler aynı
                {
                    puan++;
                    label1.Text = "PUAN:" + puan;
                    ilkresim.Enabled = false;//resmi açık bırak
                    sonresim.Enabled = false;//resmi açık bırak
                }
                else//tıklanan resimler aynı değil
                {
                    timer1.Start();
                }



                durum = 1;
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ilkresim.Image = Image.FromFile("yıldız.png");//resmi kapat
            sonresim.Image = Image.FromFile("yıldız.png");//resmi kapat

            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dizioluştur();
            resimgizle();
            puan = 0;
            ilk = 0;
            son = 0;
            ilkresim = null;
            sonresim = null;
            label1.Text = "PUAN:" + puan;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            resimgizle();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            resimgizle();
            timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dizioluştur();
            resimoluştur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dizigöster();
            timer2.Start();
        }
    }
}
