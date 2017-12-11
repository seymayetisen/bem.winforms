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

        int soruSayisi = 0;

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
                SinavSüresi = TimeSpan.FromSeconds(int.Parse(streamReader.ReadLine()));
                SinavSüresiYüzdeOn = SinavSüresi.TotalSeconds * 0.1;

                string line = "";

                this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");
                int top = -350;
                int left = 0;

                while (!string.IsNullOrWhiteSpace((line = streamReader.ReadLine())))
                {
                    soruSayisi++;
                    var items = line.Split('|');

                    top += (soruSayisi % 2 == 1) ? 350 : 0;
                    left = (soruSayisi % 2 == 1) ? 0 : 286;

                    var groupBox = new GroupBox
                    {
                        Location = new Point(left, top),
                        Name = soruSayisi.ToString(),
                        Size = new Size(275, 300),
                        Text = $"{soruSayisi}. Soru"
                    };

                    var lbl = new Label
                    {
                        Text = items[0],
                        MaximumSize = new Size(260, 0),
                        AutoSize = true,
                        Location = new Point(15, 15)
                    };
                    int radiotop = lbl.Location.Y + lbl.PreferredHeight + 15;
                    for (int i = 1; i < items.Length-1; i++)
                    {

                        var rdb = new RadioButton
                        {
                            Text = items[i],
                            Enabled = false,
                            Name = soruSayisi.ToString() + i.ToString(),
                            AutoSize = true,
                            Location = new Point(20, radiotop)
                            
                            //Name.prgCevapOrani_Click += new System.EventHandler(this.prgCevapOrani_Click)

                        };
                        rdb.CheckedChanged += new System.EventHandler(ProgresbarHesapla);
                        
                        

                        groupBox.Controls.Add(rdb);
                        radiotop += 30;
                    }
                    

                    groupBox.Controls.Add(lbl);

                    pnlSorular.Controls.Add(groupBox);

                };
               // timer1.Interval = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (SinavSüresi.TotalSeconds == 0)
            {
                timer1.Stop();
                CevaplariKayitEt();
                goupBoxDöndürRadiolarinEtkinligi(false);
            }
            this.lblKalanZaman.Text = SinavSüresi.ToString(@"hh\:mm\:ss");

            if (SinavSüresi.TotalSeconds <= SinavSüresiYüzdeOn)
            {
                lblKalanZaman.ForeColor = Color.Red;
            }
            SinavSüresi = TimeSpan.FromSeconds(SinavSüresi.TotalSeconds - 1);
        }

        private void basla_Click(object sender, EventArgs e)
        {
            goupBoxDöndürRadiolarinEtkinligi(true);
            timer1.Start();
            btnBasla.Enabled = false;
        }
        private List<Control> goupBoxDöndürRadiolarinEtkinligi(bool EtkinMi)
        {
            List<Control> GroupBoxControls = new List<Control>();
            GroupBoxControls.Clear();
            foreach (Control control2 in this.pnlSorular.Controls)
            {
                if (control2 is GroupBox)
                {
                    GroupBoxControls.Add(control2);
                    foreach (Control control in control2.Controls)
                    {
                        
                        if (control is RadioButton)
                        {
                            RadioButton radio = control as RadioButton;

                            radio.Enabled = EtkinMi;
                        }
                    }
                }
            }
            return GroupBoxControls;
        }
        private void ProgresbarHesapla(object sender, EventArgs e)
        {
            byte value = 0;
            List<Control> GroupBoxLar = new List<Control>();
            GroupBoxLar = goupBoxDöndürRadiolarinEtkinligi(true);
            prgCevapOrani.Maximum = GroupBoxLar.Count;

            
            foreach (var groupBox in GroupBoxLar)
            {
                foreach (var control in groupBox.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton radio = control as RadioButton;
                        if (radio.Checked)
                        {
                            value++;
                        }
                    }
                }
                
            }

            prgCevapOrani.Value = value;
        }
        private void btnBitti_Click(object sender, EventArgs e)
        {
            CevaplariKayitEt();
            timer1.Stop();
            
        }
        private void CevaplariKayitEt()
        {
            int CevaplananSecenek = 0;
            using (var streamWriter = new StreamWriter(@"C:\Users\Seyma\Source\Repos\bem.winforms\SinavApp\Cevaplar\" + lblSinavAdi.Text + "-" + lblAdSoyad.Text + "-001.txt", true))
            {
                streamWriter.WriteLine($"{lblSinavAdi.Text}");
                List<Control> GroupBoxLar = new List<Control>();
                GroupBoxLar = goupBoxDöndürRadiolarinEtkinligi(false);
                foreach (var groupBox in GroupBoxLar)
                {
                    foreach (var control in groupBox.Controls)
                    {
                        if (control is RadioButton)
                        {
                            CevaplananSecenek++;
                            RadioButton radio = control as RadioButton;
                            if (radio.Checked)
                            {
                                streamWriter.WriteLine($"{groupBox.Name} {CevaplananSecenek}");
                                CevaplananSecenek = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }

        
    }
}
