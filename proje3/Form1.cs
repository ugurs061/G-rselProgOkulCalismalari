using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global değişken(Bütün alt fonksiyonlarda kullanılan değişkenlerdir. Fonksiyonlar haberleşecekse global değişkendir.) - 
        //yerel değişken(sadece ilgili fonksiyonların içinde kullanılan değişkenlere denir.) tanımları sınavda sorulabilir.

        //RESİM TUTMAK İÇİN NESNE TANIMLAMA
        Bitmap resim;//resim içindeki renk bilgisi burada tutulacak
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();//dosya gezgini dialog kutusu gösteriliyor
            textBox1.Text = folderBrowserDialog1.SelectedPath;//seçilen yol
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//dosya açma dialog kutusu gösteriliyor
            textBox1.Text = openFileDialog1.FileName;//dosya adı textbox da gösteriliyor
            richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);//dosya yükleme işlemi
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//dosya kaydetme dialog kutusunu gösterme
            textBox1.Text = saveFileDialog1.FileName;//dosya adı textbox da gösteriliyor
            richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.PlainText);//dosya kaydetme işlemi
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();//yazı tipi dialog kutusu aktif ediliyor
            //richTextBox1.Font = fontDialog1.Font;//yazı tipi değiştiriliyor
            richTextBox1.SelectionFont= fontDialog1.Font;//seçilen yazının tipi değiştiriliyor
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();//renk dialog kutusu gösteriliyor
            textBox1.Text = colorDialog1.Color.ToString();//renk gösterme işlemi
            //richTextBox1.ForeColor = colorDialog1.Color;//renk değiştirme işlemi
        richTextBox1.SelectionColor = colorDialog1.Color;//seçilen yazının renk değiştirme işlemi
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();//dialog kutusu gösterme işlemi
            pictureBox1.Image = Image.FromFile(openFileDialog2.FileName);//dosyadan resim yükleme işlemi
            resim = new Bitmap(openFileDialog2.FileName);//resim bilgisi okunuyor
        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();//dialog kutusu gösterme işlemi
            pictureBox1.Image.Save(saveFileDialog2.FileName);//resim kaydetme
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();//renk dialog kutusu gösteriliyor
            panel1.BackColor = colorDialog2.Color;//renk gösterme
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;

            if (e.Button != MouseButtons.Left)//sol tuşa basılı tutulmadıysa
                return;//geri dön,bu satırdan sonraki kodlar çalışmaz

            x = (resim.Width * e.X / pictureBox1.Width);//koordinat hesaplama
            y= (resim.Height * e.Y / pictureBox1.Height);

   
            panel2.BackColor = resim.GetPixel(x,y);//x,y koordinatındaki renk bilgisi alınıyor
            resim.SetPixel(x,y,Color.Red);//x,y koordinatını seçilen renk ile boyama

            pictureBox1.Image = resim;//boyanan resmi gösterme
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
