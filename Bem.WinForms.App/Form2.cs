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
    public partial class BaskaBirEkran : Form
    {
        public int Id { get; set; }

        public BaskaBirEkran()
        {
            OgeleriOlustur();
            x = "Merhaba";
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBox)sender;

            //label1.Text = listBox.SelectedItem.ToString();
        }

        private void btnClck(object s, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            this.Text = Deneme(this.x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                foreach (var item2 in listBox2.Items)
                {
                    if(item.ToString() == item2.ToString())
                    {
                        listBox3.Items.Add(item);
                        continue;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Leave(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }

        private string Deneme(string s) {
            return s.ToUpper();
        }
    }
}
