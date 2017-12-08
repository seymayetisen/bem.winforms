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
        public int SinavSüresi { get; set; }
        public double SinavSüresiYüzdeOn { get; set; }

        public frmSinavEkrani()
        {
            InitializeComponent();

            //var frmGiris = this.Owner as frmGiris;
            //this.lblAdSoyad.Text = frmGiris.txtAdSoyad.Text;
        }

        public frmSinavEkrani(string adSoyad, string sinavDosyaYolu) : this()
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
                SinavSüresi = int.Parse(streamReader.ReadLine());
                SinavSüresiYüzdeOn = SinavSüresi / 10;
              
                int position = 0;
                int position2 = 60;


                string satir = "";

                do
                {
                    
                        satir = streamReader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(satir))
                    {
                        var groupBox = new GroupBox();
                        var label = new Label();
                        

                        label.AutoSize = true;
                        groupBox.AutoSize = true;
                        //

                        
                        groupBox.Location = new Point(0, position);
                       
                        position += 110;


                        label.Text = satir.Substring(0, satir.IndexOf(@"?"));
                        

                        panel1.Controls.Add(label);
                        panel1.Controls.Add(groupBox);
                        groupBox.Controls.Add(label);
                        string[] parcala = satir.Split('|');
                        for (int i = 1; i < parcala.Length - 1; i++)
                        {
                            var radioBtn = new RadioButton();
                            radioBtn.Location = new Point( position2,40);
                            radioBtn.AutoSize = true;
                            radioBtn.Text = parcala[i];
                            
                            position2 += 50;
                            label.Controls.Add(radioBtn);
                        }

                    }
                    
                } while (!string.IsNullOrWhiteSpace(satir));
            }
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi == 0)
            {
                timer1.Stop();
            }
            this.lblKalanZaman.Text = string.Format("{0:00}:{1:00}:{2:00}", (SinavSüresi / 3600), (SinavSüresi / 60), (SinavSüresi % 60));
            
            if (SinavSüresi <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            SinavSüresi--;

        }
    }
}
