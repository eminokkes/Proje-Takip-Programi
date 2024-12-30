namespace Emin_Dal
{
    partial class Yönetici_Ekranı
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
            this.btnBossEkle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.btnIsTanim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBossEkle
            // 
            this.btnBossEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBossEkle.Location = new System.Drawing.Point(340, 300);
            this.btnBossEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnBossEkle.Name = "btnBossEkle";
            this.btnBossEkle.Size = new System.Drawing.Size(125, 50);
            this.btnBossEkle.TabIndex = 2;
            this.btnBossEkle.Text = "Yönetici Ekle";
            this.btnBossEkle.UseVisualStyleBackColor = true;
            this.btnBossEkle.Click += new System.EventHandler(this.btnBossEkle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(190, 300);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 50);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Kullanıcı Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaMenu.Location = new System.Drawing.Point(14, 389);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(130, 50);
            this.btnAnaMenu.TabIndex = 21;
            this.btnAnaMenu.Text = "Anasayfaya Dön";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // btnIsTanim
            // 
            this.btnIsTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsTanim.Location = new System.Drawing.Point(490, 300);
            this.btnIsTanim.Margin = new System.Windows.Forms.Padding(4);
            this.btnIsTanim.Name = "btnIsTanim";
            this.btnIsTanim.Size = new System.Drawing.Size(125, 50);
            this.btnIsTanim.TabIndex = 22;
            this.btnIsTanim.Text = "Görev Tanımlama";
            this.btnIsTanim.UseVisualStyleBackColor = true;
            this.btnIsTanim.Click += new System.EventHandler(this.btnIsTanim_Click);
            // 
            // Yönetici_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emin_Dal.Properties.Resources.ed_yazılım;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btnIsTanim);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.btnBossEkle);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Yönetici_Ekranı";
            this.Text = "Yönetici_Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBossEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Button btnIsTanim;
    }
}