using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavApp
{
    public partial class frmSinavEkrani : Form
    {
        public string AdSoyad { get; set; }
        public string SinavDosyaYolu { get; set; }
        public TimeSpan SinavSüresi { get; private set; }
        public double SinavSüresiYüzdeOn { get; private set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) :this()
        {
            AdSoyad = adSoyad;
            lblAdSoyad.Text = adSoyad;
            SinavDosyaYolu = sinavDosyaYolu;
        }

        private void frmSinavEkrani_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(SinavDosyaYolu))
            {
                lblSinavAdi.Text = streamReader.ReadLine();
                lblSinavAciklama.Text = streamReader.ReadLine();
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;
                //timer1.Interval = 1;
            }

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (SinavSüresi.TotalSeconds == 0)
            //{
            //    timer1.Stop();
            //}
            //this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            //if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            //{
            //    lblKalanZaman.ForeColor = Color.Red;
            //}
            //SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds-1);
        }
    }
}
