using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)// nesne üzerinde hareket etme 
        {
            label1.Text = e.X + "," + e.Y;//e.x x kordinatı--- e.y y koordinatı
            label1.Left = e.X-5;//x
            label1.Top = e.Y-20;//y

            panel1.Left = e.X +10 ;//x
            panel1.Top = e.Y +10;//y

            int r, g, b;
            Random rnd = new Random();
            r = rnd.Next(0, 256);
            g = rnd.Next(0, 256);
            b = rnd.Next(0,256);
            Color renk = Color.FromArgb(r, g, b);

            //this.BackColor = renk; //formun rastgele arkaplan rengi

            panel1.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));

            listBox1.Items.Add(e.X);
            listBox2.Items.Add(e.Y);


        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)//Kaydırma olayı 
        {
            label2.Text = hScrollBar1.Value.ToString();//scrollbar değeri
            int r, b, g;
            r = hScrollBar1.Value;
            g= hScrollBar2.Value;
            b=hScrollBar3.Value;

            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label3.Text = hScrollBar2.Value.ToString();//scrollbar değeri

            int r, b, g;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            this.BackColor = Color.FromArgb(r, g, b);


        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = hScrollBar3.Value.ToString();//scrollbar değeri

            int r, b, g;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            this.BackColor = Color.FromArgb(r, g, b);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// Değer-indeks değişim olayı
        {
            listBox1.Items.Add(comboBox1.Text);// eleman ekleme olayı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();// listbox temizleme
            listBox2.Items.Clear();

        }
    }
}
