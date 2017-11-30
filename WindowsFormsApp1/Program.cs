using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form form = new Form();
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

            Application.Run(form);
        }

        private static void TiklayincaCalis(object a, EventArgs x)
        {
            MessageBox.Show("Deneme");
        }
    }
}
