using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace proje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string aranan = "";
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = e.X + "," + e.Y;//farenin x,y koordinatı
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//dosya açma dialog kutusu gösteriliyor
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);//dosya yükleme işlemi
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
               richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//dosya kaydetme işlemi
        }

        private void farklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();//dosya kaydetme dialog kutusunu gösterme
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);//dosya kaydetme işlemi
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan çıkış
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();//geri al
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();//yinele
        }

        private void tümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";//kes
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//kopyala
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//yapıştır
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();//tümünü seç
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();//yazı tipi dialog kutusu aktif ediliyor
            richTextBox1.SelectionFont = fontDialog1.Font;//seçilen yazının tipi değiştiriliyor
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//dosya açma dialog kutusu gösteriliyor
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);//dosya yükleme işlemi
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();//yeni dosya
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();//renk dialog kutusu gösteriliyor
            richTextBox1.SelectionColor = colorDialog1.Color;//seçilen yazının renk değiştirme işlemi
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();//yazı tipi dialog kutusu aktif ediliyor
            richTextBox1.SelectionFont = fontDialog1.Font;//seçilen yazının tipi değiştiriliyor
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";//kes
        }

        private void kopyalaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();//kopyala
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();//yapıştır
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void renkDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();//renk dialog kutusu gösteriliyor
            richTextBox1.SelectionColor = colorDialog1.Color;//seçilen yazının renk değiştirme işlemi
        }

        private void yazıTipiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();//yazı tipi dialog kutusu aktif ediliyor
            richTextBox1.SelectionFont = fontDialog1.Font;//seçilen yazının tipi değiştiriliyor
        }

        private void buToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
