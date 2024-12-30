using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emin_Dal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btn_Boss_Giris_Click(object sender, EventArgs e)
        {
            lbl_kadi.Visible = true;
            lbl_sifre.Visible = true;
            txtbox_kadi.Visible = true;
            txtbox_sifre.Visible = true;
            btn_Boss_Onay.Visible = true;
            btn_Boss_Giris.Visible = false;
            btnAnaMenu.Visible = true;
            btn_Kullanici_Giris.Visible = false;
        }

        private void btn_Boss_Onay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            try
            {
                SqlCommand cmd;
                SqlDataReader dr;
                string sorgu = "SELECT * FROM Boss where TC=@user AND Sifre=@pass";
                cmd = new SqlCommand(sorgu, con);
                if (Convert.ToInt64(txtbox_kadi.Text) > 9999999999)
                    cmd.Parameters.AddWithValue("@user", txtbox_kadi.Text);
                else
                    MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.");
                cmd.Parameters.AddWithValue("@pass", txtbox_sifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Yönetici_Ekranı obj = new Yönetici_Ekranı();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
            }
            catch
            {
                if (Convert.ToInt64(txtbox_kadi.Text) > 9999999999)
                    MessageBox.Show("Lütfen * bulunan alanları doldurunuz.");
                txtbox_kadi.Clear();
                txtbox_sifre.Clear();

            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Kullanici_Onay_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            try
            {

                SqlCommand cmd;
                SqlDataReader dr;
                string sorgu = "SELECT * FROM Kullanici where TC=@user AND Sifre=@pass";
                cmd = new SqlCommand(sorgu, con);
                if (Convert.ToInt64(txtbox_kadi.Text) > 9999999999)
                    cmd.Parameters.AddWithValue("@user", txtbox_kadi.Text);
                else
                    MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.");
                cmd.Parameters.AddWithValue("@pass", txtbox_sifre.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Kullanıcı_Ekranı obj = new Kullanıcı_Ekranı();
                    obj.tampon.Text = txtbox_kadi.Text;
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
            }
            catch
            {
                if (Convert.ToInt64(txtbox_kadi.Text) > 9999999999)
                    MessageBox.Show("Lütfen * bulunan alanları doldurunuz.");
                txtbox_kadi.Clear();
                txtbox_sifre.Clear();

            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Kullanici_Giris_Click(object sender, EventArgs e)
        {
            lbl_kadi.Visible = true;
            lbl_sifre.Visible = true;
            txtbox_kadi.Visible = true;
            txtbox_sifre.Visible = true;
            btn_Kullanici_Onay.Visible = true;
            btn_Boss_Giris.Visible = false;
            btnAnaMenu.Visible = true;
            btn_Kullanici_Giris.Visible = false;
        }
        private void tbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void tbxEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if(btn_Kullanici_Onay.Visible==true)
                {
                    btn_Kullanici_Onay_Click(sender, e);
                }
                else
                {
                    btn_Boss_Onay_Click(sender, e);
                }
            }
        }
    }
}
