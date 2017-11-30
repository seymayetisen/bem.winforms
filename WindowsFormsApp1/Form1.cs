using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form form = new Form();

        private void button1_Click(object sender, EventArgs e)
        {


            var btnEkle = new System.Windows.Forms.Button();

            btnEkle.Location = new Point(50, 70);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(66, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += TiklayincaCalis;

            var textBox = new GelismisTextBox();
            textBox.Location = new System.Drawing.Point(110, 135);
            textBox.Name = "txtIlce";
            textBox.Size = new System.Drawing.Size(129, 20);
            textBox.TabIndex = 8;


            form.Controls.Add(btnEkle);
            form.Controls.Add(textBox);

            form.Show();
        }

        private void TiklayincaCalis(object a, EventArgs x)
        {
            form.Controls[1].Text = "sdfsdf";
        }
    }
}
