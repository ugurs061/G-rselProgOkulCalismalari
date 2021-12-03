using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ÇİZİM İŞLEMLERİ İÇİN DEĞİŞKENLER
        Graphics g;//çizim işlemlerinde kullanılan sınıf
        SolidBrush s;//dolgu rengi için kullanılır
        Pen p;//çizgi stili oluşturmak için kullanılır
        Random rnd = new Random();
        Color renk;
        int x1, y1,x2,y2, gen=200, yük=200,r;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            

            //ELİPS DOLDURMA İŞLEMİ
            gen = 100;
            yük = 100;
            x1 = e.X-(gen/2);//x koordinatı
            y1 = e.Y-(yük / 2);//y koordinatı
            

            renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk
            s = new SolidBrush(renk);//dolgu stili ayarlanıyor

            g.FillEllipse(s, x1, y1, gen, yük);//elips doldurma fonksiyonu
            if (e.Button == MouseButtons.Right)//sağ tuşa basıldıysa formu temizle
            this.Refresh();

        }

        int yön = -1;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //ELİPS DOLDURMA İŞLEMİ
            //büyüme/küçülme işlemi
            if (gen > 200)
                yön = -1;
            if (gen < 0)
                yön = 1;

            gen += yön;
            yük = gen;//genişlik yükseklik aynı

            x1 = e.X - (gen / 2);//x koordinatı
            y1 = e.Y - (yük / 2);//y koordinatı


            renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk
            //s = new SolidBrush(renk);//dolgu stili ayarlanıyor
            //g.FillEllipse(s, x1, y1, gen, yük);//elips doldurma fonksiyonu

            //p = new Pen(renk, 2);//çizgi stili ayarlanıyor
            //g.DrawEllipse(p, x1, y1, gen, yük);//dörtgen çizdirme fonksiyonu
            //g.DrawRectangle(p, x1, y1, gen, yük);//dörtgen çizdirme fonksiyonu

            s = new SolidBrush(renk);//dolgu stili ayarlanıyor
            g.DrawString((e.X+","+e.Y), label1.Font, s, new Point(e.X,e.Y));

            if (e.Button == MouseButtons.Right)//sağ tuşa basıldıysa formu temizle
                this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DÖRTGEN DOLDURMA İŞLEMİ
            x1 = Convert.ToInt16(textBox9.Text);
            y1 = Convert.ToInt16(textBox10.Text);
            gen = Convert.ToInt16(textBox11.Text);
            yük = Convert.ToInt16(textBox12.Text);

            renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk
           s = new SolidBrush(renk);//dolgu stili ayarlanıyor

            g.FillRectangle(s, x1, y1, gen, yük);//dörtgen doldurma fonksiyonu
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DÖRTGEN ÇİZDİRME İŞLEMİ
            x1 = Convert.ToInt16(textBox9.Text);
            y1 = Convert.ToInt16(textBox10.Text);
            gen = Convert.ToInt16(textBox11.Text);
            yük = Convert.ToInt16(textBox12.Text);

            renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk
            p = new Pen(renk, rnd.Next(3, 8));//çizgi stili ayarlanıyor

            g.DrawRectangle(p, x1, y1, gen, yük);//dörtgen çizdirme fonksiyonu
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ELİPS DOLDURMA İŞLEMİ
            x1 = Convert.ToInt16(textBox5.Text);
            y1 = Convert.ToInt16(textBox6.Text);
            gen = Convert.ToInt16(textBox7.Text);
            yük = Convert.ToInt16(textBox8.Text);

            renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk
            s= new SolidBrush(renk);//dolgu stili ayarlanıyor

            g.FillEllipse(s, x1, y1, gen, yük);//elips doldurma fonksiyonu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ELİPS ÇİZDİRME İŞLEMİ
            x1 = Convert.ToInt16(textBox5.Text);
            y1 = Convert.ToInt16(textBox6.Text);
            gen = Convert.ToInt16(textBox7.Text);
            yük = Convert.ToInt16(textBox8.Text);

            renk = Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256),rnd.Next(0, 256));//rastgele renk
            p = new Pen(renk, rnd.Next(3,8));//çizgi stili ayarlanıyor

            g.DrawEllipse(p, x1, y1, gen, yük);//elips çizdirme fonksiyonu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt16(textBox1.Text);
            y1 = Convert.ToInt16(textBox2.Text);
            x2 = Convert.ToInt16(textBox3.Text);
            y2 = Convert.ToInt16(textBox4.Text);

            p = new Pen(Color.Red,3);//çizgi stili ayarlanıyor

            g.DrawLine(p,x1,y1,x2,y2);//çizgi çizdirme fonksiyonu
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();//g çizim işlemleri için aktif hale getiriliyor
        }

        
    }
}
