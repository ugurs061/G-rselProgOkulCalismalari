using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace proje14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL DEĞİŞKENLER
        int satır = 20, sütun = 20;
        int[,] dizi;
        Random rnd = new Random();
        PictureBox p;
        int uzunluk = 0; //yılan uzunluğu
        int[] ara;
        int[,] ara1;
        int[] yılan; //yılan içindeki değerler
        int yemek; //yılanın yediği yem
        int yönx, yöny;
        int[,] yılankoordinat; //yılan koordinatları
        int x, y;
        int[,] solucandeliği; //solucan deliği koordinatları
        int puan = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            resimoluştur(); //20x20 lik resim sistemi 
        }




        public void resimoluştur()
        {
            //DİNAMİK NESNE(PictureBox) OLUŞTURMA
            //20X20 PictureBox YAPISI OLUŞTURMA İŞLEMİ
            int i = 0, j = 0;
            for (i = 0; i < satır; i++) //SATIR SAYISI -->20
            {
                for (j = 0; j < sütun; j++) //SÜTUN SAYISI -->20
                {
                    p = new PictureBox();//Yeni Picturebox Nesnesi Tanımlama
                    p.Name = "p_" + i + "_" + j;//her yeni button a ayrı isim veriliyor p_1_1,p_1_2,..
                    p.Width = 32;//button genişliği 50
                    p.Height = 32;//button yüksekliği 50
                    p.Left = 10 + 32 * i;//picturebox ın soldan uzaklığı
                    p.Top = 10 + 32 * j;//picturebox ın yukarıdan uzaklığı
                    p.SizeMode = PictureBoxSizeMode.StretchImage;//resim picturebox boyutuna ayarlanıyor
                    this.Controls.Add(p);//button forma entegre ediliyor
                }
            }

        }

        public void dizioluştur()
        {

            int i = 0, j = 0, sa, sü;
            dizi = new int[satır, sütun]; //20x20 lik dizi

            for (i = 0; i < satır; i++) //SATIR SAYISI -->20
                for (j = 0; j < sütun; j++) //SÜTUN SAYISI -->20
                    dizi[i, j] = 0;//resim kodu diziye aktarılıyor dizi[0,0]=7 gibi

            //yumurta oluşturma
            for (i = 0; i < 10; i++) //
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 1;//yumurta oluştur
            }

            //kurbağa oluşturma
            for (i = 0; i < 10; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 2;//kurbağa oluştur
            }

            //kertenkele oluşturma
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 3;//kertenkele oluştur
            }

            //fare oluşturma
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 4;//fare oluştur
            }

            //civciv deliği oluşturma
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 5;//solucan deliği oluştur
            }

            //solucan deliği oluşturma
            solucandeliği = new int[5, 2];
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 6;//solucan deliği oluştur
                solucandeliği[i, 0] = sa;
                solucandeliği[i, 1] = sü;
            }

            //taş oluşturma
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 7;//taş deliği oluştur
            }
            //sansar oluşturma
            for (i = 0; i < 5; i++)
            {
                sa = rnd.Next(0, satır);//rastgele satır no üret
                sü = rnd.Next(0, sütun);//rastgele sütun no üret
                dizi[sa, sü] = 8;//sansar deliği oluştur
            }
        }

        public void dizigöster()
        {

            //pictureboxlarda dizideki değerlere göre resimler gösteriliyor
            int i = 0, j = 0, sa, sü;
            for (i = 0; i < satır; i++) //SATIR SAYISI -->20
                for (j = 0; j < sütun; j++) //SÜTUN SAYISI -->20
                    ((PictureBox)this.Controls["p_" + i + "_" + j]).Image = Image.FromFile(dizi[i, j] + ".png");

        }


        public void oyunhazırla()
        {

            yönx = 1; //x yönü
            yöny = 0; //y yönü
            x = 0; y = 0;
            puan = 0;
            label1.Text = "PUAN:" + puan;

            uzunluk = 1;
            yılankoordinat = new int[1, 2];//yılanın koordinatları x,y
            yılankoordinat[0, 0] = 0;//yılanın koordinatları x
            yılankoordinat[0, 1] = 0;//yılanın koordinatları y
            yılan = new int[1];//yılanın yediği canlılar 8,9,10,11,12,13
            yılan[0] = 14; //yılanın başı kırmızı daire
            dizioluştur();//20x20 lik resim sistemindeki resimlere karşılık gelen sayılar
            dizi[0, 0] = 14;//ilk resim yılanın başı
            dizigöster();// //20x20 lik resim sistemi gösterme


            //p = new PictureBox();//Yeni Picturebox Nesnesi Tanımlama
            //p.Name = "arkaplan";//
            //p.Width = 640;//picturebox genişliği 640
            //p.Height = 640;//picturebox yüksekliği 640
            //p.Left = 10;//picturebox ın soldan uzaklığı
            //p.Top = 10;//picturebox ın yukarıdan uzaklığı
            //p.Image = Image.FromFile("0.png");//arkaplan resmi oluşturuluyor
            //p.SizeMode = PictureBoxSizeMode.StretchImage;//resim picturebox boyutuna ayarlanıyor

        }

        public void yılanuzat()
        {
            int i;
            uzunluk++;
            int xk, yk;
            ara = new int[uzunluk];//yılanı uzatmak için ara diziler
            ara1 = new int[uzunluk, 2];
            ara[0] = 14;//yılanın başı
            ara[1] = yemek;//2. değer yenen yem

            //ara dizi yılan ile doluyor
            for (i = 2; i < uzunluk; i++)
                ara[i] = yılan[i - 1];

            //ara1 dizi yılan koordinatları ile doluyor
            ara1[0, 0] = x;
            ara1[0, 1] = y;
            for (i = 1; i < uzunluk; i++)
            {
                ara1[i, 0] = yılankoordinat[i - 1, 0];
                ara1[i, 1] = yılankoordinat[i - 1, 1];
            }

            //yeni yılan ve yılan koordinatı oluşturuluyor
            //dizi uzadı
            yılan = new int[uzunluk];
            yılankoordinat = new int[uzunluk, 2];
            for (i = 0; i < uzunluk; i++)
            {
                yılan[i] = ara[i];
                yılankoordinat[i, 0] = ara1[i, 0];
                yılankoordinat[i, 1] = ara1[i, 1];
            }

            //yenilenen yılan dizisi diziye aktarılıyor
            for (i = 0; i < uzunluk; i++)
            {
                xk = yılankoordinat[i, 0];
                yk = yılankoordinat[i, 1];
                dizi[xk, yk] = yılan[i];
            }
        }

        public void yılankısalt()
        {

            uzunluk--;
            if (uzunluk <= 0)//uzunluk 0 ise oyunu bitir
            {
                timer1.Stop();
                MessageBox.Show("Canınız Kalmadı.Oyun Bitti");
            }
            else//değilse yılanı kısalt
            {
                int i;
                int xk, yk;

                //yılanın son elamanı koparılıyor
                xk = yılankoordinat[uzunluk, 0];
                yk = yılankoordinat[uzunluk, 1];
                ((PictureBox)this.Controls["p_" + xk + "_" + yk]).Image = Image.FromFile("0.png");
                dizi[xk, yk] = 0;
                dizi[x, y] = rnd.Next(0, 6);

                //yılan kısaltmak için ara diziler
                ara = new int[uzunluk];
                ara1 = new int[uzunluk, 2];

                //ara dizi yılanın kısalmış hali
                for (i = 0; i <= uzunluk - 1; i++)
                {
                    ara[i] = yılan[i];
                    ara1[i, 0] = yılankoordinat[i, 0];
                    ara1[i, 1] = yılankoordinat[i, 1];
                }

                //yılan ve yılan koordinatları dizisi güncelleme
                yılan = new int[uzunluk];
                yılankoordinat = new int[uzunluk, 2];
                for (i = 0; i < uzunluk; i++)
                {
                    yılan[i] = ara[i];
                    yılankoordinat[i, 0] = ara1[i, 0];
                    yılankoordinat[i, 1] = ara1[i, 1];

                }
                //kısalan yılan kaydırılıyor
                yılankaydır();

                //yenilenen yılan dizisi diziye aktarılıyor
                for (i = 0; i < uzunluk; i++)
                {
                    xk = yılankoordinat[i, 0];
                    yk = yılankoordinat[i, 1];
                    dizi[xk, yk] = yılan[i];
                }

            }
        }

        public void yılankaydır()
        {
            if (uzunluk <= 0) //yılan uzunluğu sıfır ise işlem yapma
                return;
            int i;
            int xk, yk, sa, sü;

            //yılanın kuyruğundaki son resmi sıfırla
            xk = yılankoordinat[uzunluk - 1, 0];
            yk = yılankoordinat[uzunluk - 1, 1];
            ((PictureBox)this.Controls["p_" + xk + "_" + yk]).Image = Image.FromFile("0.png");
            dizi[xk, yk] = 0;

            //yılanın koordinatlarını kaydır
            for (i = uzunluk - 1; i > 0; i--)
            {
                yılankoordinat[i, 0] = yılankoordinat[i - 1, 0];
                yılankoordinat[i, 1] = yılankoordinat[i - 1, 1];

            }
            //yeni koordinatı yılana ekle
            yılankoordinat[0, 0] = x;
            yılankoordinat[0, 1] = y;

            //yılanın koordinatları denk düşen 
            //dizideki resimler sıfırlanıyor
            for (i = 0; i < uzunluk; i++)
            {
                xk = yılankoordinat[i, 0];
                yk = yılankoordinat[i, 1];
                dizi[xk, yk] = yılan[i];
            }

            //solucan deliği koordinatlarını diziye tekrar ekle
            for (i = 0; i < 5; i++)
            {
                sa = solucandeliği[i, 0];//ratır no 
                sü = solucandeliği[i, 1];//sütun no 
                dizi[sa, sü] = 6;//solucan deliği oluştur
                ((PictureBox)this.Controls["p_" + sa + "_" + sü]).Image = Image.FromFile("6.png");
            }

        }

        public void yılangöster()
        {
            int i;
            int xk, yk, sa, sü; ;
            for (i = 0; i < uzunluk; i++)
            {
                //yılanın koordinatları kullanılarak picturebox larda resimler gösteriliyor
                xk = yılankoordinat[i, 0];
                yk = yılankoordinat[i, 1];
                ((PictureBox)this.Controls["p_" + xk + "_" + yk]).Image = Image.FromFile(yılan[i] + ".png");
            }

            //solucan deliği koordinatlarını diziye tekrar ekle
            for (i = 0; i < 5; i++)
            {
                sa = solucandeliği[i, 0];//ratır no 
                sü = solucandeliği[i, 1];//sütun no 
                dizi[sa, sü] = 6;//solucan deliği oluştur

            }

        }
        public void dizigüncelle()
        {
            int i;
            int xk, yk, sa, sü;
            for (i = 0; i < uzunluk; i++)
            {
                //yılanın  koordinalarına denk gelen resimler 
                //dizi üzerinde sıfırlanıyor
                xk = yılankoordinat[i, 0];
                yk = yılankoordinat[i, 1];
                dizi[xk, yk] = 0;
            }


            //solucan deliği koordinatlarını diziye tekrar ekle
            for (i = 0; i < 5; i++)
            {
                sa = solucandeliği[i, 0];//ratır no 
                sü = solucandeliği[i, 1];//sütun no 
                dizi[sa, sü] = 6;//solucan deliği oluştur

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            oyunhazırla();
            //timer çalıştırma

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer durdurma
            timer1.Stop();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int sno = 0;//solucan deliği numarası
            //yeni x ve y korinatı yönx ve yöny ye bağlı olarak hesaplanıyor
            x = x + yönx;
            y = y + yöny;

            //yeni koordinat 0 ile 19 arasında olması için test ediliyor
            if (x > 19)
                x = 0;
            if (x < 0)
                x = 19;

            if (y > 19)
                y = 0;
            if (y < 0)
                y = 19;


            if (dizi[x, y] == 0)//x,y koordinatı boş ise sadece ilerle
            {
                dizigüncelle();
                yılankaydır();

            }
            else if (dizi[x, y] >= 1 && dizi[x, y] <= 5)//x,y koordinatı yiyecek
            {
                puan += dizi[x, y];// puan artır 
                label1.Text = "PUAN:" + puan;// puan göster 
                yemek = dizi[x, y] + 8;//yemek resmini bul
                dizi[x, y] = 0;//x,y koordinatını sıfırla
                dizigüncelle();
                yılanuzat();//yılan uzat


            }
            else if (dizi[x, y] == 6)
            {
                //x,y koordinatında solucan deliği varsa 
                //başka rastgele bir solucan deliğine sıçra
                sno = rnd.Next(0, 5);
                x = solucandeliği[sno, 0];
                y = solucandeliği[sno, 1];
                //dizigüncelle();
                yılankaydır();
                dizi[x, y] = 6;
                label1.Text = "PUAN:" + puan;
            }
            else if (dizi[x, y] == 7)
            {
                //x,y koordinatında taş var ise yılanı kısalt
                yılankısalt();
                dizigüncelle();
                puan -= 7;
                label1.Text = "PUAN:" + puan;
            }

            else if (dizi[x, y] == 8)
            {
                //x,y koordinatında sansar var ise oyunu bitir
                timer1.Stop();
                MessageBox.Show("Sansar! Oyun Bitti!");
            }
            //else if (dizi[x, y] > 8)
            //{
            //    //x,y koordinatında yılan var ise oyunu bitir
            //    timer1.Stop();
            //    MessageBox.Show("Kendine Çarptın! Oyun Bitti!");
            //}

            else { }
            //yılanı gösterme
            yılangöster();
            label2.Text = x + "," + y;
        }



        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            yönx = 0;
            yöny = 0;
            //basılan yön tuşuna göre yönx ve yöny belirleniyor
            if (e.KeyCode == Keys.W)
                yöny = -1;
            else if (e.KeyCode == Keys.S)
                yöny = 1;
            else if (e.KeyCode == Keys.A)
                yönx = -1;
            else if (e.KeyCode == Keys.D)
                yönx = 1;
            else if (e.KeyCode == Keys.Space)
                timer1.Stop();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //oyun başlatma
            timer1.Start();
        }




    }
}

