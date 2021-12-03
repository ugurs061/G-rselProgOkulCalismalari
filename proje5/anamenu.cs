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
    public partial class anamenu : Form
    {
        //1-form türetme
        dosya yenidosya = new dosya();
        duzen yeniduzen = new duzen();
        ekle yeniekle = new ekle();
        gorunum yenigörünüm = new gorunum();
        yardım yeniyardım = new yardım();
        public anamenu()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidosya.Show();//2-form gösterme
            yeniduzen.Hide();//2-form gizleme
            yeniekle.Hide();//2-form gizleme
            yenigörünüm.Hide();//2-form gizleme
            yeniyardım.Hide();//2-form gizleme
        }

        private void düzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidosya.Hide();//2-form gösterme
            yeniduzen.Show();//2-form gizleme
            yeniekle.Hide();//2-form gizleme
            yenigörünüm.Hide();//2-form gizleme
            yeniyardım.Hide();//2-form gizleme
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidosya.Hide();//2-form gösterme
            yeniduzen.Hide();//2-form gizleme
            yeniekle.Show();//2-form gizleme
            yenigörünüm.Hide();//2-form gizleme
            yeniyardım.Hide();//2-form gizleme
        }

        private void görünümToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidosya.Hide();//2-form gösterme
            yeniduzen.Hide();//2-form gizleme
            yeniekle.Hide();//2-form gizleme
            yenigörünüm.Show();//2-form gizleme
            yeniyardım.Hide();//2-form gizleme
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yenidosya.Hide();//2-form gösterme
            yeniduzen.Hide();//2-form gizleme
            yeniekle.Hide();//2-form gizleme
            yenigörünüm.Hide();//2-form gizleme
            yeniyardım.Show();//2-form gizleme
        }

        private void anamenu_Load(object sender, EventArgs e)//form yükleme olayı
        {
            this.Text = "Kullanıcı Adı: "+veri.kullanıcıadı + "Şifre:"+ veri.sifre;
            

            yenidosya.MdiParent = this;
            yeniduzen.MdiParent = this;
            yeniekle.MdiParent = this;
            yenigörünüm.MdiParent = this;
            yeniyardım.MdiParent = this;

        }
    }
}
