using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isUpdate;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kisi = (isUpdate) ? (Kisi)lstKisi.SelectedItem : new Kisi();

            kisi.Ad = txtAd.Text;
            kisi.Soyad = txtSoyad.Text;
            kisi.TcKimlikNo = txtKimlikNo.Text;
            kisi.Uzmanlik = txtUzmanlik.Text;

            if (!isUpdate)
            {
                lstKisi.Items.Add(kisi);
            }
            else
            {
                lstKisi.Items[lstKisi.SelectedIndex] = kisi;
            }

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKimlikNo.Text = "";
            txtUzmanlik.Text = "";

            isUpdate = false;
        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisi.SelectedItem is null)
            {
                return;
            }

            Kisi gelenKisi = lstKisi.SelectedItem as Kisi;

            txtAd.Text = gelenKisi.Ad;
            txtSoyad.Text = gelenKisi.Soyad;
            txtKimlikNo.Text = gelenKisi.TcKimlikNo;
            txtUzmanlik.Text = gelenKisi.Uzmanlik;

            isUpdate = true;
        }
    }
}
