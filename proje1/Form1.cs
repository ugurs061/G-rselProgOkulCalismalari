using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;// enabled = true ya da false durumu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Lime; // Panel1 in arkaplanı yeşil renk olacak.
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;// enabled = true ya da false ----- aktiflik/pasiflik durumu
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;// Panel1 in arkaplanı kırmızı renk olacak.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Blue; // Panel1 in arkaplanı mavi renk olacak.
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true; //// Visible = true ya da false ---- görünürlük/pasiflik durumu
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false; //// Visible = true ya da false ---- görünürlük/pasiflik durumu
        }

        private void label1_MouseHover(object sender, EventArgs e)// Üzerine gelme olayı
        {
            panel1.Width = 100;// genişlik
            panel1.Height = 100;// yükseklik
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            panel1.Width = 75;// genişlik
            panel1.Height = 75;// yükseklik
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            panel1.Width = 50;// genişlik
            panel1.Height = 50;// yükseklik
        }
    }
}
