using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            kisi.IsActive = chkAktif.Checked;

            //if (rdbCinsiyetKadin.Checked)
            //{
            //    kisi.Cinsiyet = Cinsiyet.Kadın;
            //}
            //else if (rdbCinsiyetErkek.Checked)
            //{
            //    kisi.Cinsiyet = Cinsiyet.Erkek;
            //}

            foreach (Control item in pnlCinsiyet.Controls)
            {
                if(!(item is RadioButton))
                {
                    continue;
                }

                var rb = item as RadioButton;

                if (rb.Checked)
                {
                    kisi.Cinsiyet = (Cinsiyet)int.Parse(rb.Tag.ToString());
                }
            }


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

            chkAktif.Checked = true;

            rdbCinsiyetErkek.Checked = false;
            rdbCinsiyetKadin.Checked = false;

            isUpdate = false;
        }

        private void lstKisi_DrawItem(object sender, DrawItemEventArgs e)
        {
            //if (e.Index < 0) return;
            ////if the item state is selected them change the back color 
            //if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //    e = new DrawItemEventArgs(e.Graphics,
            //                              e.Font,
            //                              e.Bounds,
            //                              e.Index,
            //                              e.State ^ DrawItemState.Selected,
            //                              e.ForeColor,
            //                              Color.Yellow);//Choose the color

            //// Draw the background of the ListBox control for each item.
            //e.DrawBackground();
            //// Draw the current item text

            //var  box = (ListBox)sender;

            //var selectedItem = box.SelectedItem as Kisi;

            //var brush = (!(selectedItem is null) && selectedItem.IsActive) ? Brushes.Black : Brushes.Gray;

            //e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            //// If the ListBox has focus, draw a focus rectangle around the selected item.
            //e.DrawFocusRectangle();


            //Debug.WriteLine(e.Index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kisi = ((ListBox)sender).SelectedItem as Kisi;

            if(kisi is null)
            {
                return;
            }

            txtAd.Text = kisi.Ad;
            txtSoyad.Text = kisi.Soyad;
            txtKimlikNo.Text = kisi.TcKimlikNo;
            txtUzmanlik.Text = kisi.Uzmanlik;

            chkAktif.Checked = kisi.IsActive;


            if(kisi.Cinsiyet == Cinsiyet.Kadın)
            {
                rdbCinsiyetKadin.Checked = true;
            }
            else if (kisi.Cinsiyet == Cinsiyet.Erkek)
            {
                rdbCinsiyetErkek.Checked = true;
            } else if(kisi.Cinsiyet == Cinsiyet.Diger)
            {
                rbDiger.Checked = true;
            }

            isUpdate = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtAd.Text += "1"; 
        }
    }
}
