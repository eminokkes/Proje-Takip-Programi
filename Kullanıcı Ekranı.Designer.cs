namespace Emin_Dal
{
    partial class Kullanıcı_Ekranı
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
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dataGvAra = new System.Windows.Forms.DataGridView();
            this.tampon = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAra)).BeginInit();
            this.SuspendLayout();
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
            // dataGvAra
            // 
            this.dataGvAra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGvAra.AllowUserToAddRows = false;
            this.dataGvAra.AllowUserToDeleteRows = false;
            this.dataGvAra.AllowUserToResizeColumns = false;
            this.dataGvAra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGvAra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGvAra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGvAra.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGvAra.CausesValidation = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGvAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvAra.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGvAra.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGvAra.EnableHeadersVisualStyles = false;
            this.dataGvAra.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGvAra.Location = new System.Drawing.Point(14, 114);
            this.dataGvAra.Margin = new System.Windows.Forms.Padding(15);
            this.dataGvAra.Name = "dataGvAra";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.dataGvAra.ShowCellErrors = false;
            this.dataGvAra.ShowCellToolTips = false;
            this.dataGvAra.ShowEditingIcon = false;
            this.dataGvAra.ShowRowErrors = false;
            this.dataGvAra.Size = new System.Drawing.Size(805, 265);
            this.dataGvAra.TabIndex = 1;
            // 
            // tampon
            // 
            this.tampon.AutoSize = true;
            this.tampon.Location = new System.Drawing.Point(764, 422);
            this.tampon.Name = "tampon";
            this.tampon.Size = new System.Drawing.Size(55, 17);
            this.tampon.TabIndex = 100;
            this.tampon.Text = "tampon";
            this.tampon.Visible = false;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(690, 389);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(130, 50);
            this.btn_guncelle.TabIndex = 101;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // Kullanıcı_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Emin_Dal.Properties.Resources.ed;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.tampon);
            this.Controls.Add(this.dataGvAra);
            this.Controls.Add(this.btnAnaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kullanıcı_Ekranı";
            this.Text = "Kullanıcı_Ekranı";
            this.Load += new System.EventHandler(this.Kullanıcı_Ekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvAra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView dataGvAra;
        public System.Windows.Forms.Label tampon;
        private System.Windows.Forms.Button btn_guncelle;
    }
}