namespace Emin_Dal
{
    partial class İş_Dağılımı
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Yonet = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dtpickBasla = new System.Windows.Forms.DateTimePicker();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblDogumT = new System.Windows.Forms.Label();
            this.lblYer = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.tbxIsAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.richTbxIsTanimi = new System.Windows.Forms.RichTextBox();
            this.dtpickBitis = new System.Windows.Forms.DateTimePicker();
            this.cbxPersonel = new System.Windows.Forms.ComboBox();
            this.dataGvAra = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAra)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Yonet
            // 
            this.btn_Yonet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yonet.Location = new System.Drawing.Point(200, 256);
            this.btn_Yonet.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Yonet.Name = "btn_Yonet";
            this.btn_Yonet.Size = new System.Drawing.Size(130, 50);
            this.btn_Yonet.TabIndex = 20;
            this.btn_Yonet.Text = "Geri";
            this.btn_Yonet.UseVisualStyleBackColor = true;
            this.btn_Yonet.Click += new System.EventHandler(this.btn_Yonet_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Location = new System.Drawing.Point(62, 256);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(130, 50);
            this.btnAnaMenu.TabIndex = 21;
            this.btnAnaMenu.Text = "Anasayfaya Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // dtpickBasla
            // 
            this.dtpickBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpickBasla.Location = new System.Drawing.Point(627, 203);
            this.dtpickBasla.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickBasla.Name = "dtpickBasla";
            this.dtpickBasla.Size = new System.Drawing.Size(270, 26);
            this.dtpickBasla.TabIndex = 4;
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.BackColor = System.Drawing.Color.Black;
            this.lblIcerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIcerik.ForeColor = System.Drawing.Color.White;
            this.lblIcerik.Location = new System.Drawing.Point(444, 239);
            this.lblIcerik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(142, 20);
            this.lblIcerik.TabIndex = 69;
            this.lblIcerik.Text = "* İş Bitiş Tarihi:";
            // 
            // lblDogumT
            // 
            this.lblDogumT.AutoSize = true;
            this.lblDogumT.BackColor = System.Drawing.Color.Black;
            this.lblDogumT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumT.ForeColor = System.Drawing.Color.White;
            this.lblDogumT.Location = new System.Drawing.Point(444, 205);
            this.lblDogumT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogumT.Name = "lblDogumT";
            this.lblDogumT.Size = new System.Drawing.Size(186, 20);
            this.lblDogumT.TabIndex = 68;
            this.lblDogumT.Text = "* İş Başlangıç Tarihi:";
            // 
            // lblYer
            // 
            this.lblYer.AutoSize = true;
            this.lblYer.BackColor = System.Drawing.Color.Black;
            this.lblYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYer.ForeColor = System.Drawing.Color.White;
            this.lblYer.Location = new System.Drawing.Point(444, 173);
            this.lblYer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYer.Name = "lblYer";
            this.lblYer.Size = new System.Drawing.Size(168, 20);
            this.lblYer.TabIndex = 67;
            this.lblYer.Text = "* Görevli Personel:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Black;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(444, 71);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(120, 20);
            this.lblAd.TabIndex = 66;
            this.lblAd.Text = "* İşin Tanımı:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.BackColor = System.Drawing.Color.Black;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(444, 37);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(91, 20);
            this.lblTC.TabIndex = 65;
            this.lblTC.Text = "* İşin Adı:";
            // 
            // tbxIsAdi
            // 
            this.tbxIsAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxIsAdi.Location = new System.Drawing.Point(627, 37);
            this.tbxIsAdi.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIsAdi.MaxLength = 22;
            this.tbxIsAdi.Name = "tbxIsAdi";
            this.tbxIsAdi.Size = new System.Drawing.Size(270, 26);
            this.tbxIsAdi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(788, 271);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 35);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // richTbxIsTanimi
            // 
            this.richTbxIsTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTbxIsTanimi.Location = new System.Drawing.Point(627, 70);
            this.richTbxIsTanimi.Name = "richTbxIsTanimi";
            this.richTbxIsTanimi.Size = new System.Drawing.Size(270, 96);
            this.richTbxIsTanimi.TabIndex = 2;
            this.richTbxIsTanimi.Text = "";
            // 
            // dtpickBitis
            // 
            this.dtpickBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpickBitis.Location = new System.Drawing.Point(627, 237);
            this.dtpickBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpickBitis.Name = "dtpickBitis";
            this.dtpickBitis.Size = new System.Drawing.Size(270, 26);
            this.dtpickBitis.TabIndex = 5;
            // 
            // cbxPersonel
            // 
            this.cbxPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPersonel.FormattingEnabled = true;
            this.cbxPersonel.Location = new System.Drawing.Point(627, 172);
            this.cbxPersonel.Name = "cbxPersonel";
            this.cbxPersonel.Size = new System.Drawing.Size(270, 24);
            this.cbxPersonel.TabIndex = 3;
            // 
            // dataGvAra
            // 
            this.dataGvAra.AllowUserToResizeColumns = false;
            this.dataGvAra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGvAra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGvAra.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGvAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGvAra.Location = new System.Drawing.Point(12, 313);
            this.dataGvAra.Name = "dataGvAra";
            this.dataGvAra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGvAra.RowHeadersVisible = false;
            this.dataGvAra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGvAra.RowTemplate.Height = 24;
            this.dataGvAra.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGvAra.Size = new System.Drawing.Size(958, 520);
            this.dataGvAra.TabIndex = 70;
            this.dataGvAra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGvAra_CellContentClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(643, 271);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(103, 35);
            this.btn_guncelle.TabIndex = 102;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // İş_Dağılımı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emin_Dal.Properties.Resources.ed_yazılım_logo;
            this.ClientSize = new System.Drawing.Size(982, 953);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.dataGvAra);
            this.Controls.Add(this.cbxPersonel);
            this.Controls.Add(this.dtpickBitis);
            this.Controls.Add(this.richTbxIsTanimi);
            this.Controls.Add(this.btn_Yonet);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dtpickBasla);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblDogumT);
            this.Controls.Add(this.lblYer);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.tbxIsAdi);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "İş_Dağılımı";
            this.Text = "İş_Dağılımı";
            this.Load += new System.EventHandler(this.İş_Dağılımı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Yonet;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DateTimePicker dtpickBasla;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblDogumT;
        private System.Windows.Forms.Label lblYer;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox tbxIsAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RichTextBox richTbxIsTanimi;
        private System.Windows.Forms.DateTimePicker dtpickBitis;
        private System.Windows.Forms.ComboBox cbxPersonel;
        private System.Windows.Forms.DataGridView dataGvAra;
        private System.Windows.Forms.Button btn_guncelle;
    }
}