using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j,hücresayısı;
            hücresayısı = Convert.ToInt16(textBox1.Text);

            for (i=0;i< hücresayısı;i++)
            {
                for (j = 0; j < hücresayısı; j++)
                {
                    Color renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk oluşturma

                    //DİNAMİK BUTTON OLUŞTURMA
                    Button b = new Button();//1-b adında bir button nesnesi tanımlandı
                    b.Name = "b_" + i + "_" + j;//buton ismi b_0_0,b_0_1 gibi...
                    b.Width = 50;
                    b.Height = 50;//2-b nin nesne özellikleri ayarlandı
                    b.Top = 50+j*50;
                    b.Left = 200 + i* 50;
                    b.BackColor = renk;
                    b.FlatStyle = FlatStyle.Flat;
                    //b.Text = b.Name;
                    b.MouseClick += new MouseEventHandler(buton_gizle);//b nesnesi için MouseClick olayı tanımlanıyor
                    b.MouseMove += new MouseEventHandler(buton_değiştir);//b nesnesi için MouseEnter olayı tanımlanıyor

                    this.Controls.Add(b);//3- b nesnesi forma entegre ediliyor
                }
            }


            
        }

        private void buton_gizle(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;//tıklanan buton ile b eşleştirildi
            b.Visible = false;//tıklanan buton görünmez
            this.Text = b.Name;//tıklanan butonun ismi form başlığında gösteriliyor
        }


        private void buton_değiştir(object sender, MouseEventArgs e)
        {
            //SOL TUŞA BASILI TUTULMADIYSA BİRŞEY YAPMA
            if (e.Button != MouseButtons.Left)
                return;//birşey yapmadan geri dön
            Button b = (Button)sender;//tıklanan buton ile b eşleştirildi
            b.Visible = false;
        }

        int pno = 0;
        Random rnd = new Random();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //DİNAMİK BUTTON OLUŞTURMA
            Color renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk oluşturma
            Panel p = new Panel();//1-p panel nesnesi tanımlanıyor
            p.Name = "p_" + pno;
            p.Width = rnd.Next(20, 50);
            p.Height = p.Width;//2-p nin nesne özellikleri ayarlandı
            p.Top = e.Y;
            p.Left = e.X;
            p.BackColor = renk;
            this.Controls.Add(p);//3- p nesnesi forma entegre ediliyor
            pno++;//panel numarası 1 arttı
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            return;
            //SOL TUŞA BASILI TUTULMADIYSA BİRŞEY YAPMA
            if (e.Button != MouseButtons.Left)
                return;//birşey yapmadan geri dön

            //DİNAMİK PANEL OLUŞTURMA
            Color renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk oluşturma
            Panel p = new Panel();//1-p panel nesnesi tanımlanıyor
            p.Name = "p_" + pno;
            p.Width = rnd.Next(20, 50); p.Width = 50;
           p.Height = p.Width;//2-p nin nesne özellikleri ayarlandı
            p.Top = e.Y;
            p.Left = e.X;
            p.BackColor = renk;
            p.MouseClick += new MouseEventHandler(panel_gizle);//p nesnesi için MouseClick olayı tanımlanıyor
            p.MouseEnter+= new EventHandler(panel_değiştir);//p nesnesi için MouseEnter olayı tanımlanıyor
            p.MouseLeave += new EventHandler(panel_değiştir1);//p nesnesi için MouseLeave olayı 
            this.Controls.Add(p);//3- p nesnesi forma entegre ediliyor
            pno++;//panel numarası 1 arttı
        }

        private void panel_gizle(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)sender;//tıklanan panel ile p eşleştirildi
            p.Visible = false;//tıklanan panel görünmez
            this.Text = p.Name;//tıklanan panelin ismi form başlığında gösteriliyor
        }

        private void panel_değiştir(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;//tıklanan panel ile p eşleştirildi
            Color renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk oluşturma
            p.BackColor = renk;
            p.Width = 100;
            p.Height = p.Width;//2-p nin nesne özellikleri ayarlandı
           
        }

        private void panel_değiştir1(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;//tıklanan panel ile p eşleştirildi
            Color renk = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));//rastgele renk oluşturma
            p.BackColor = renk;
            p.Width = 50;
            p.Height = p.Width;//2-p nin nesne özellikleri ayarlandı
        }
    }
}
