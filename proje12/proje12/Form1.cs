using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;//dosya okuma/yazma işlemi için referans
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> dosya;//dosyadan okunan bilgileri tutmak için
        int kayıtsayısı = 0;
        int kayıtno = 0;

        public void dosyadanoku()
        { 
        
        }

        public void dosyayabilgiyaz()
        { 
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //Dosya yolu-adı seçiliyor
            saveFileDialog1.ShowDialog();//dialog kutusu gösteriliyor
            textBox1.Text = saveFileDialog1.FileName;//dosya adı
  
            dosya = File.ReadAllLines(textBox1.Text).ToList() ;
            //dosya oluşturma işlemi

            dosya.Add(DateTime.Now.ToLongTimeString());//günün tarihi
            dosya.Add(DateTime.Now.ToLongTimeString());//değiştirme tarihi
            dosya.Add("0");//kayıt sayısı 0
            dosya.Add("#############################");//ayraç-dosya bilgisi sonu

            File.WriteAllLines(saveFileDialog1.FileName,dosya,Encoding.UTF8);//dosyayı kaydetme

            kayıtno = 0;
            kayıtsayısı = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//dialog kutusu gösteriliyor
            textBox1.Text = openFileDialog1.FileName;//dosya adı

            dosya = File.ReadAllLines(textBox1.Text).ToList();
            richTextBox1.AppendText("Dosya Oluşturma Tarihi:" + dosya[0]+"\n");//oluşturma tarihi
            richTextBox1.AppendText("Dosya Değiştirme Tarihi:" + dosya[1] + "\n");//değiştirme tarihi
            richTextBox1.AppendText("Dosya Değiştirme Tarihi:" + dosya[2] + "\n");//Kayıt sayısı

            kayıtsayısı = Convert.ToInt16(dosya[2]);//kayıtsayısı
            kayıtno = Convert.ToInt16(dosya[2]);//kayıtno

            textBox2.Text = kayıtsayısı.ToString();
            textBox3.Text = kayıtno.ToString();

        }


     

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dosya = File.ReadAllLines("bilgi.txt", Encoding.UTF8).ToList();//dosyadan satır satır bilgi okuma
            richTextBox1.AppendText("Dosya Oluşturma Tarihi:"+dosya[0]);//oluşturma tarihi
            richTextBox1.AppendText("Dosya Değiştirme Tarihi:" + dosya[1]);//değiştirme tarihi
            richTextBox1.AppendText("Dosya Değiştirme Tarihi:" + dosya[2]);//Kayıt sayısı
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dosya.Add(textBox4.Text);//dosyay bilgi ekleme-isim
            dosya.Add(textBox5.Text);//dosyay bilgi ekleme-soyisim
            dosya.Add(textBox6.Text);//dosyay bilgi ekleme-telefon
            dosya.Add(textBox7.Text);//dosyay bilgi ekleme-eposta

            kayıtsayısı++;//kayıt sayısı 1 arttı
            kayıtno = kayıtsayısı;
            textBox2.Text = kayıtsayısı.ToString();
            textBox3.Text = kayıtno.ToString();

            dosya[1]= DateTime.Now.ToLongTimeString();//değiştirme tarihi
            dosya[2] = kayıtsayısı.ToString();//kayıtsaıyısı güncellendi

            File.WriteAllLines("bilgi.txt", dosya, Encoding.UTF8);//dosyadaki bilgileri bilgisayara kaydetme
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index;

            kayıtno--;
            if (kayıtno == 0)
                kayıtno = 1;
            textBox3.Text = kayıtno.ToString();

         
             index = kayıtno * 4;

            textBox4.Text = dosya[index];
            textBox5.Text = dosya[index+1];
            textBox6.Text = dosya[index+2];
            textBox7.Text = dosya[index+3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index;

            kayıtno++;
            if (kayıtno > kayıtsayısı)
                kayıtno = kayıtsayısı;

            textBox3.Text = kayıtno.ToString();

            index = kayıtno * 4;

            textBox4.Text = dosya[index];
            textBox5.Text = dosya[index + 1];
            textBox6.Text = dosya[index + 2];
            textBox7.Text = dosya[index + 3];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = kayıtno * 4;
            dosya[index] = textBox4.Text;
            dosya[index+1] = textBox5.Text;
            dosya[index+2] = textBox6.Text;
            dosya[index+3] = textBox7.Text;
            dosya[1] = DateTime.Now.ToLongTimeString();//değiştirme tarihi

            File.WriteAllLines("bilgi.txt", dosya, Encoding.UTF8);//dosyadaki bilgileri bilgisayara kaydetme
        }
    }
}
