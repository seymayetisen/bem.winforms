namespace Bem.WinForms.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.lstSehirler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSeciliOge = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.btnIlceEkle = new System.Windows.Forms.Button();
            this.btnIlceSil = new System.Windows.Forms.Button();
            this.lblIlce = new System.Windows.Forms.Label();
            this.txtComboIndex = new System.Windows.Forms.TextBox();
            this.btnChangeComboIndex = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merhaba";
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(110, 20);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(147, 21);
            this.txtMetin.TabIndex = 1;
            this.txtMetin.Text = "sddfg";
            // 
            // lstSehirler
            // 
            this.lstSehirler.FormattingEnabled = true;
            this.lstSehirler.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Amasay"});
            this.lstSehirler.Location = new System.Drawing.Point(110, 47);
            this.lstSehirler.Name = "lstSehirler";
            this.lstSehirler.Size = new System.Drawing.Size(211, 69);
            this.lstSehirler.TabIndex = 3;
            this.lstSehirler.Click += new System.EventHandler(this.lstSehirler_Click);
            this.lstSehirler.SelectedIndexChanged += new System.EventHandler(this.lstSehirler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(263, 18);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(66, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSeciliOge
            // 
            this.lblSeciliOge.AutoSize = true;
            this.lblSeciliOge.Location = new System.Drawing.Point(13, 63);
            this.lblSeciliOge.Name = "lblSeciliOge";
            this.lblSeciliOge.Size = new System.Drawing.Size(0, 13);
            this.lblSeciliOge.TabIndex = 5;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(13, 90);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Items.AddRange(new object[] {
            "Bakırköy",
            "Bağcılar",
            "Zeytinburnu"});
            this.cmbIlce.Location = new System.Drawing.Point(110, 161);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(211, 21);
            this.cmbIlce.TabIndex = 7;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // txtIlce
            // 
            this.txtIlce.Location = new System.Drawing.Point(110, 135);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(129, 20);
            this.txtIlce.TabIndex = 8;
            // 
            // btnIlceEkle
            // 
            this.btnIlceEkle.Location = new System.Drawing.Point(245, 132);
            this.btnIlceEkle.Name = "btnIlceEkle";
            this.btnIlceEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIlceEkle.TabIndex = 9;
            this.btnIlceEkle.Text = "Ekle";
            this.btnIlceEkle.UseVisualStyleBackColor = true;
            this.btnIlceEkle.Click += new System.EventHandler(this.btnIlceEkle_Click);
            // 
            // btnIlceSil
            // 
            this.btnIlceSil.Location = new System.Drawing.Point(16, 161);
            this.btnIlceSil.Name = "btnIlceSil";
            this.btnIlceSil.Size = new System.Drawing.Size(75, 23);
            this.btnIlceSil.TabIndex = 10;
            this.btnIlceSil.Text = "button2";
            this.btnIlceSil.UseVisualStyleBackColor = true;
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(16, 141);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(0, 13);
            this.lblIlce.TabIndex = 11;
            // 
            // txtComboIndex
            // 
            this.txtComboIndex.Location = new System.Drawing.Point(110, 200);
            this.txtComboIndex.Name = "txtComboIndex";
            this.txtComboIndex.Size = new System.Drawing.Size(100, 20);
            this.txtComboIndex.TabIndex = 12;
            // 
            // btnChangeComboIndex
            // 
            this.btnChangeComboIndex.Location = new System.Drawing.Point(245, 196);
            this.btnChangeComboIndex.Name = "btnChangeComboIndex";
            this.btnChangeComboIndex.Size = new System.Drawing.Size(75, 23);
            this.btnChangeComboIndex.TabIndex = 13;
            this.btnChangeComboIndex.Text = "Değiştir";
            this.btnChangeComboIndex.UseVisualStyleBackColor = true;
            this.btnChangeComboIndex.Click += new System.EventHandler(this.btnChangeComboIndex_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "From2\'yi Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnChangeComboIndex);
            this.Controls.Add(this.txtComboIndex);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.btnIlceSil);
            this.Controls.Add(this.btnIlceEkle);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblSeciliOge);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSehirler);
            this.Controls.Add(this.txtMetin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.ListBox lstSehirler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSeciliOge;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Button btnIlceEkle;
        private System.Windows.Forms.Button btnIlceSil;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.TextBox txtComboIndex;
        private System.Windows.Forms.Button btnChangeComboIndex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

