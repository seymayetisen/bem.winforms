using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bem.WinForms.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstSehirler.Items.Add(txtMetin.Text);
        }

        private void lstSehirler_Click(object sender, EventArgs e)
        {

        }

        private void lstSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;

            if(listBox.SelectedItem is null)
            {
                lblSeciliOge.Text = "";
                return;
            }

            var selectedItem = listBox.SelectedItem;

            lblSeciliOge.Text = selectedItem.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstSehirler.Items.Remove(lstSehirler.SelectedItem);
        }

        private void btnIlceEkle_Click(object sender, EventArgs e)
        {
            cmbIlce.Items.Add(txtIlce.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIlce.SelectedIndex = 0;
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = (ComboBox)sender;

            if(cmb.SelectedItem is null)
            {
                return;
            }

            lblIlce.Text = cmb.SelectedItem.ToString();
        }

        private void btnChangeComboIndex_Click(object sender, EventArgs e)
        {
            cmbIlce.SelectedIndex = int.Parse(txtComboIndex.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var baskaBirEkran = new BaskaBirEkran();

            baskaBirEkran.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }
    }
}
