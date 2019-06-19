using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _130510Win_FormsSinemaOtomasyonu__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void Koltuklar()
        {
            for (int i = 1; i < 14; i++)
            {
                for (int j = 1; j < 16; j++)
                {
                    Button koltuk = new Button();
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += koltuk_MouseDown;
                    koltuk.Top = 40+(i*45);
                    koltuk.Left = (j*45);
                    koltuk.Width = koltuk.Height = 40;
                    koltuk.Text = (Convert.ToChar((i+ 64)).ToString()) + j;
                    koltuk.BackColor = Color.OldLace;
                    this.Controls.Add(koltuk);
                }
            }
            textBox1.Visible = true;
            listView1.Visible = true;
            textBox1.Enabled = false;
        }
        Button sagtik;
        void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            sagtik=(Button)sender;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilmKaldir();
            Koltuklar();
        }

        private void FilmKaldir()
        {
        yavas:
            foreach (Control buton in this.Controls)
            {
                if (buton is PictureBox || buton is Label)
                {
                    buton.Dispose();
                    goto yavas;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FilmKaldir();
            Koltuklar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FilmKaldir();
            Koltuklar();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FilmKaldir();
            Koltuklar();
        }
        private void Rezervasyon()
        {
            KayitFormu kayit=new KayitFormu();
            DialogResult sonuc = kayit.ShowDialog();
            if (sonuc==DialogResult.OK)
            {
                if (kayit.txtİsim.Text=="" || kayit.txtSoyisim.Text=="")
                {
                    MessageBox.Show("Lütfen Zounlu Alanları Doldurunuz");
                }
                else
                {
                    ListViewItem ekle=new ListViewItem();
                    ekle.Text = sagtik.Text;
                    ekle.SubItems.Add("seans");
                    ekle.SubItems.Add(kayit.txtİsim.Text);
                    ekle.SubItems.Add(kayit.txtSoyisim.Text);
                    listView1.Items.Add(ekle);
                }
              }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı");
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Rezervasyon();
            sagtik.BackColor = Color.Red;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Rezervasyon();
            sagtik.BackColor = Color.Red;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Rezervasyon();
            sagtik.BackColor = Color.Red;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Rezervasyon();
            sagtik.BackColor = Color.Red;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Rezervasyon();
            sagtik.BackColor = Color.Red;
        }
        }
    }

