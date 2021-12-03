using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje5
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        anamenu yenianamenü = new anamenu();//1-form türetme

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" & textBox2.Text=="123")
            {
                veri.kullanıcıadı = textBox1.Text;
                veri.sifre = textBox2.Text;
                
                yenianamenü.Show();//2-form gösterme
                this.Hide();//3-form gizleme 
            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

                
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapatma
        }
    }
}
