namespace Emin_Dal
{
    partial class Kullanıcı_Ekle
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
            this.tbxSifreOnay = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.lblAda = new System.Windows.Forms.Label();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.cbxStatu = new System.Windows.Forms.ComboBox();
            this.dtpickTarih = new System.Windows.Forms.DateTimePicker();
            this.lblOzellik = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblDogumT = new System.Windows.Forms.Label();
            this.lblYer = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btn_Yonet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxSifreOnay
            // 
            this.tbxSifreOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifreOnay.Location = new System.Drawing.Point(522, 221);
            this.tbxSifreOnay.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSifreOnay.MaxLength = 12;
            this.tbxSifreOnay.Name = "tbxSifreOnay";
            this.tbxSifreOnay.Size = new System.Drawing.Size(270, 26);
            this.tbxSifreOnay.TabIndex = 6;
            this.tbxSifreOnay.UseSystemPasswordChar = true;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSifre.Location = new System.Drawing.Point(522, 187);
            this.tbxSifre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSifre.MaxLength = 12;
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(270, 26);
            this.tbxSifre.TabIndex = 5;
            this.tbxSifre.UseSystemPasswordChar = true;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSoyad.Location = new System.Drawing.Point(522, 119);
            this.tbxSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSoyad.MaxLength = 22;
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(270, 26);
            this.tbxSoyad.TabIndex = 3;
            this.tbxSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLetter_KeyPress);
            // 
            // lblAda
            // 
            this.lblAda.AutoSize = true;
            this.lblAda.BackColor = System.Drawing.Color.Black;
            this.lblAda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAda.ForeColor = System.Drawing.Color.White;
            this.lblAda.Location = new System.Drawing.Point(360, 258);
            this.lblAda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAda.Name = "lblAda";
            this.lblAda.Size = new System.Drawing.Size(78, 20);
            this.lblAda.TabIndex = 42;
            this.lblAda.Text = "* Statü :";
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Location = new System.Drawing.Point(100, 327);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(130, 50);
            this.btnAnaMenu.TabIndex = 21;
            this.btnAnaMenu.Text = "Anasayfaya Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // cbxStatu
            // 
            this.cbxStatu.BackColor = System.Drawing.SystemColors.Window;
            this.cbxStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxStatu.FormattingEnabled = true;
            this.cbxStatu.Items.AddRange(new object[] {
            "Yazılım Test Uzmanı",
            "İş Zekâsı Uzmanı",
            "Web Yazılım Uzmanı",
            "Web Tasarımcısı",
            "Flash Tasarımcısı",
            "Web Master, Animasyon Tasarımcı (2D / 3D)",
            "Sistem Yöneticisi",
            "Veritabanı Yöneticisi",
            "Bilgi İşlem Destek Teknisyeni",
            "Yazılım Geliştirme Uzmanı",
            "İş Analisti"});
            this.cbxStatu.Location = new System.Drawing.Point(522, 255);
            this.cbxStatu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxStatu.Name = "cbxStatu";
            this.cbxStatu.Size = new System.Drawing.Size(270, 28);
            this.cbxStatu.TabIndex = 7;
            // 
            // dtpickTarih
            // 
            this.dtpickTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpickTarih.Location = new System.Drawing.Point(522, 153);
            this.dtpickTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickTarih.Name = "dtpickTarih";
            this.dtpickTarih.Size = new System.Drawing.Size(270, 26);
            this.dtpickTarih.TabIndex = 4;
            // 
            // lblOzellik
            // 
            this.lblOzellik.AutoSize = true;
            this.lblOzellik.BackColor = System.Drawing.Color.Black;
            this.lblOzellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzellik.ForeColor = System.Drawing.Color.White;
            this.lblOzellik.Location = new System.Drawing.Point(360, 224);
            this.lblOzellik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOzellik.Name = "lblOzellik";
            this.lblOzellik.Size = new System.Drawing.Size(123, 20);
            this.lblOzellik.TabIndex = 41;
            this.lblOzellik.Text = "* Şifre Onay :";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.BackColor = System.Drawing.Color.Black;
            this.lblIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.ForeColor = System.Drawing.Color.White;
            this.lblIcerik.Location = new System.Drawing.Point(360, 190);
            this.lblIcerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(74, 20);
            this.lblIcerik.TabIndex = 40;
            this.lblIcerik.Text = "* Şifre :";
            // 
            // lblDogumT
            // 
            this.lblDogumT.AutoSize = true;
            this.lblDogumT.BackColor = System.Drawing.Color.Black;
            this.lblDogumT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumT.ForeColor = System.Drawing.Color.White;
            this.lblDogumT.Location = new System.Drawing.Point(360, 158);
            this.lblDogumT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogumT.Name = "lblDogumT";
            this.lblDogumT.Size = new System.Drawing.Size(141, 20);
            this.lblDogumT.TabIndex = 39;
            this.lblDogumT.Text = "* Doğum Tarihi:";
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.BackColor = System.Drawing.Color.Black;
            this.lblYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYer.ForeColor = System.Drawing.Color.White;
            this.lblYer.Location = new System.Drawing.Point(360, 122);
            this.lblYer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(85, 20);
            this.lblYer.TabIndex = 38;
            this.lblYer.Text = "* Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Black;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(360, 88);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(56, 20);
            this.lblAd.TabIndex = 37;
            this.lblAd.Text = "* Ad :";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Black;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(360, 54);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(144, 20);
            this.lblTC.TabIndex = 36;
            this.lblTC.Text = "* TC Kimlik No :";
            // 
            // tbxAd
            // 
            this.tbxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAd.Location = new System.Drawing.Point(522, 85);
            this.tbxAd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAd.MaxLength = 22;
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(270, 26);
            this.tbxAd.TabIndex = 2;
            this.tbxAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLetter_KeyPress);
            // 
            // tbxTC
            // 
            this.tbxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTC.Location = new System.Drawing.Point(522, 51);
            this.tbxTC.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTC.MaxLength = 11;
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(270, 26);
            this.tbxTC.TabIndex = 1;
            this.tbxTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(650, 335);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 35);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btn_Yonet
            // 
            this.btn_Yonet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yonet.Location = new System.Drawing.Point(238, 327);
            this.btn_Yonet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Yonet.Name = "btn_Yonet";
            this.btn_Yonet.Size = new System.Drawing.Size(130, 50);
            this.btn_Yonet.TabIndex = 20;
            this.btn_Yonet.Text = "Geri";
            this.btn_Yonet.UseVisualStyleBackColor = true;
            this.btn_Yonet.Click += new System.EventHandler(this.btn_Yonet_Click);
            // 
            // Kullanıcı_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emin_Dal.Properties.Resources.ed_yazılım_logo;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btn_Yonet);
            this.Controls.Add(this.tbxSifreOnay);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.lblAda);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.cbxStatu);
            this.Controls.Add(this.dtpickTarih);
            this.Controls.Add(this.lblOzellik);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblDogumT);
            this.Controls.Add(this.lblYer);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.tbxTC);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kullanıcı_Ekle";
            this.Text = "Kullanıcı_Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSifreOnay;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label lblAda;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.ComboBox cbxStatu;
        private System.Windows.Forms.DateTimePicker dtpickTarih;
        private System.Windows.Forms.Label lblOzellik;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblDogumT;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btn_Yonet;
    }
}