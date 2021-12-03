
namespace proje6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p10 = new System.Windows.Forms.PictureBox();
            this.p9 = new System.Windows.Forms.PictureBox();
            this.p8 = new System.Windows.Forms.PictureBox();
            this.p7 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(12, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "BAŞLAT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "DURDUR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(319, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(377, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(507, 12);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(50, 50);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 6;
            this.p1.TabStop = false;
            this.p1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p1_MouseClick);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(579, 12);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(50, 50);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 7;
            this.p2.TabStop = false;
            this.p2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p2_MouseClick);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(648, 12);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(50, 50);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 8;
            this.p3.TabStop = false;
            this.p3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p3_MouseClick);
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(725, 12);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(50, 50);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 9;
            this.p4.TabStop = false;
            this.p4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p4_MouseClick);
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(797, 12);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(50, 50);
            this.p5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p5.TabIndex = 10;
            this.p5.TabStop = false;
            this.p5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p5_MouseClick);
            // 
            // p10
            // 
            this.p10.Location = new System.Drawing.Point(1164, 12);
            this.p10.Name = "p10";
            this.p10.Size = new System.Drawing.Size(50, 50);
            this.p10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p10.TabIndex = 15;
            this.p10.TabStop = false;
            this.p10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p10_MouseClick);
            // 
            // p9
            // 
            this.p9.Location = new System.Drawing.Point(1092, 12);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(50, 50);
            this.p9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p9.TabIndex = 14;
            this.p9.TabStop = false;
            this.p9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p9_MouseClick);
            // 
            // p8
            // 
            this.p8.Location = new System.Drawing.Point(1015, 12);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(50, 50);
            this.p8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p8.TabIndex = 13;
            this.p8.TabStop = false;
            this.p8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p8_MouseClick);
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(946, 12);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(50, 50);
            this.p7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p7.TabIndex = 12;
            this.p7.TabStop = false;
            this.p7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p7_MouseClick);
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(874, 12);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(50, 50);
            this.p6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p6.TabIndex = 11;
            this.p6.TabStop = false;
            this.p6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p6_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Oyun Başlat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Oyun Durdur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 41);
            this.button5.TabIndex = 18;
            this.button5.Text = "Oyun Hazırla";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proje6.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::proje6.Properties.Resources._2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::proje6.Properties.Resources._3;
            this.pictureBox3.Location = new System.Drawing.Point(12, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::proje6.Properties.Resources._4;
            this.pictureBox4.Location = new System.Drawing.Point(12, 330);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(121, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 55);
            this.label4.TabIndex = 23;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(121, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 55);
            this.label5.TabIndex = 24;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(121, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 55);
            this.label6.TabIndex = 25;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(121, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 55);
            this.label7.TabIndex = 26;
            this.label7.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 665);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.p10);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p10;
        private System.Windows.Forms.PictureBox p9;
        private System.Windows.Forms.PictureBox p8;
        private System.Windows.Forms.PictureBox p7;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

