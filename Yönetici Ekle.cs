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
    public partial class Yönetici_Ekle : Form
    {
        public Yönetici_Ekle()
        {
            InitializeComponent();
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
        private void tbxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString()==" ")
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            try
            {

                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Boss (TC,Ad,Soyad,Dogum_Tarihi,Sifre) VALUES(@TC,@Ad,@Soyad,@Dogum_Tarihi,@Sifre)", con);
                if (Convert.ToInt64(tbxTC.Text) > 9999999999)
                    command.Parameters.Add(new SqlParameter("@TC", tbxTC.Text));
                else
                    MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.");
                command.Parameters.Add(new SqlParameter("@Ad", tbxAd.Text));
                command.Parameters.Add(new SqlParameter("@Soyad", tbxSoyad.Text));
                command.Parameters.Add(new SqlParameter("@Dogum_Tarihi", dtpickTarih.Value));
                if (tbxSifre.Text == tbxSifreOnay.Text)
                    command.Parameters.Add(new SqlParameter("@Sifre", tbxSifre.Text));
                else
                    MessageBox.Show("Şifre ve Şifre Onay aynı olmalıdır.");
                command.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");
                tbxTC.Clear();
                tbxAd.Clear();
                tbxSoyad.Clear();
                dtpickTarih.Value = DateTime.Now;
                tbxSifre.Clear();
                tbxSifreOnay.Clear();
            }
            catch
            {
                if (tbxSifre.Text == tbxSifreOnay.Text && Convert.ToInt64(tbxTC.Text) > 9999999999)
                    MessageBox.Show("Lütfen * bulunan alanları doldurunuz.");

            }
            finally
            {
                con.Close();
            }
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btn_Yonet_Click(object sender, EventArgs e)
        {
            Yönetici_Ekranı obj = new Yönetici_Ekranı();
            obj.Show();
            this.Hide();
        }
    }
}
