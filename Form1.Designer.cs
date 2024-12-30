namespace Emin_Dal
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
            this.btn_Kullanici_Onay = new System.Windows.Forms.Button();
            this.btn_Kullanici_Giris = new System.Windows.Forms.Button();
            this.btn_Boss_Onay = new System.Windows.Forms.Button();
            this.btn_Boss_Giris = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.txtbox_kadi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.lbl_kadi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Kullanici_Onay
            // 
            this.btn_Kullanici_Onay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kullanici_Onay.Location = new System.Drawing.Point(439, 361);
            this.btn_Kullanici_Onay.Name = "btn_Kullanici_Onay";
            this.btn_Kullanici_Onay.Size = new System.Drawing.Size(100, 40);
            this.btn_Kullanici_Onay.TabIndex = 12;
            this.btn_Kullanici_Onay.Text = "GİRİŞ";
            this.btn_Kullanici_Onay.UseVisualStyleBackColor = true;
            this.btn_Kullanici_Onay.Visible = false;
            this.btn_Kullanici_Onay.Click += new System.EventHandler(this.btn_Kullanici_Onay_Click);
            // 
            // btn_Kullanici_Giris
            // 
            this.btn_Kullanici_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kullanici_Giris.Location = new System.Drawing.Point(260, 316);
            this.btn_Kullanici_Giris.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kullanici_Giris.Name = "btn_Kullanici_Giris";
            this.btn_Kullanici_Giris.Size = new System.Drawing.Size(120, 50);
            this.btn_Kullanici_Giris.TabIndex = 1;
            this.btn_Kullanici_Giris.Text = "Kullanıcı Girişi";
            this.btn_Kullanici_Giris.UseVisualStyleBackColor = true;
            this.btn_Kullanici_Giris.Click += new System.EventHandler(this.btn_Kullanici_Giris_Click);
            // 
            // btn_Boss_Onay
            // 
            this.btn_Boss_Onay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Boss_Onay.Location = new System.Drawing.Point(439, 361);
            this.btn_Boss_Onay.Name = "btn_Boss_Onay";
            this.btn_Boss_Onay.Size = new System.Drawing.Size(100, 40);
            this.btn_Boss_Onay.TabIndex = 13;
            this.btn_Boss_Onay.Text = "GİRİŞ";
            this.btn_Boss_Onay.UseVisualStyleBackColor = true;
            this.btn_Boss_Onay.Visible = false;
            this.btn_Boss_Onay.Click += new System.EventHandler(this.btn_Boss_Onay_Click);
            // 
            // btn_Boss_Giris
            // 
            this.btn_Boss_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Boss_Giris.Location = new System.Drawing.Point(428, 316);
            this.btn_Boss_Giris.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Boss_Giris.Name = "btn_Boss_Giris";
            this.btn_Boss_Giris.Size = new System.Drawing.Size(120, 50);
            this.btn_Boss_Giris.TabIndex = 2;
            this.btn_Boss_Giris.Text = "Yönetici Girişi";
            this.btn_Boss_Giris.UseVisualStyleBackColor = true;
            this.btn_Boss_Giris.Click += new System.EventHandler(this.btn_Boss_Giris_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Location = new System.Drawing.Point(14, 389);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(130, 50);
            this.btnAnaMenu.TabIndex = 21;
            this.btnAnaMenu.Text = "Anasayfaya Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Visible = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Cursor = System.Windows.Forms.Cursors.No;
            this.txtbox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_sifre.Location = new System.Drawing.Point(387, 316);
            this.txtbox_sifre.MaxLength = 12;
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(189, 30);
            this.txtbox_sifre.TabIndex = 11;
            this.txtbox_sifre.UseSystemPasswordChar = true;
            this.txtbox_sifre.Visible = false;
            this.txtbox_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEnter_KeyPress);
            // 
            // txtbox_kadi
            // 
            this.txtbox_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_kadi.Location = new System.Drawing.Point(387, 280);
            this.txtbox_kadi.MaxLength = 11;
            this.txtbox_kadi.Name = "txtbox_kadi";
            this.txtbox_kadi.Size = new System.Drawing.Size(189, 30);
            this.txtbox_kadi.TabIndex = 10;
            this.txtbox_kadi.Visible = false;
            this.txtbox_kadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumber_KeyPress);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(308, 319);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(64, 25);
            this.lbl_sifre.TabIndex = 20;
            this.lbl_sifre.Text = "Şifre:";
            this.lbl_sifre.Visible = false;
            // 
            // lbl_kadi
            // 
            this.lbl_kadi.AutoSize = true;
            this.lbl_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kadi.Location = new System.Drawing.Point(233, 283);
            this.lbl_kadi.Name = "lbl_kadi";
            this.lbl_kadi.Size = new System.Drawing.Size(139, 25);
            this.lbl_kadi.TabIndex = 19;
            this.lbl_kadi.Text = "Kullanıcı Adı:";
            this.lbl_kadi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emin_Dal.Properties.Resources.ed_yazılım;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btn_Kullanici_Onay);
            this.Controls.Add(this.btn_Kullanici_Giris);
            this.Controls.Add(this.btn_Boss_Onay);
            this.Controls.Add(this.btn_Boss_Giris);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.txtbox_kadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kullanici_Onay;
        private System.Windows.Forms.Button btn_Kullanici_Giris;
        private System.Windows.Forms.Button btn_Boss_Onay;
        private System.Windows.Forms.Button btn_Boss_Giris;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label lbl_kadi;
        public System.Windows.Forms.TextBox txtbox_kadi;
    }
}

