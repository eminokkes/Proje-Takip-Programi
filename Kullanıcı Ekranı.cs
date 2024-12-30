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
    public partial class Kullanıcı_Ekranı : Form
    {
        public Kullanıcı_Ekranı()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void Kullanıcı_Ekranı_Load(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            string kayit = "SELECT ID,Is_Adi,Is_Tanimi,Is_Baslangic_Tarihi,Is_Bitis_Tarihi,Is_Asama from Is_Dagilimi WHERE LEFT(Gorevli_Personel,11) = '" + tampon.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGvAra.DataSource = dt;
            //dataGvAra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGvAra.Columns[0].HeaderText = "İş No";
            dataGvAra.Columns[1].HeaderText = "İşin Adı";
            dataGvAra.Columns[2].HeaderText = "İşin Tanımı";
            dataGvAra.Columns[3].HeaderText = "Başlangıç Tarihi";
            dataGvAra.Columns[4].HeaderText = "Bitiş Tarihi";
            dataGvAra.Columns[5].HeaderText = "Tamamlanan %";

            dataGvAra.Columns[0].Width = 30;
            dataGvAra.Columns[1].Width = 155;
            dataGvAra.Columns[2].Width = 155;
            dataGvAra.Columns[3].Width = 80;
            dataGvAra.Columns[4].Width = 80;
            dataGvAra.Columns[5].Width = 80;
            dataGvAra.Columns[0].ReadOnly = true;
            dataGvAra.Columns[1].ReadOnly = true;
            dataGvAra.Columns[2].ReadOnly = true;
            dataGvAra.Columns[3].ReadOnly = true;
            dataGvAra.Columns[4].ReadOnly = true;
            con.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string asama;
            asama = dataGvAra.CurrentRow.Cells["Is_Asama"].Value.ToString();
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            SqlCommand guncelle = new SqlCommand("update Is_Dagilimi set Is_Asama='" + asama + "' where ID='" + dataGvAra.CurrentRow.Cells["ID"].Value + "'", con);
            try
            {
                if (Convert.ToInt16(asama) >= 0 && Convert.ToInt16(asama) <= 100)
                    guncelle.ExecuteNonQuery();
                else
                    MessageBox.Show("Tamamlanan Değer 0 ile 100 arasında olmalıdır.");
            }
            catch
            {
                MessageBox.Show("Tamamlanan Değere Sayıyal Veri Girilmelidir.");
            }
            finally
            {
                con.Close();
                refresh();
            }
        }
        public void refresh()
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            string kayit = "SELECT ID,Is_Adi,Is_Tanimi,Is_Baslangic_Tarihi,Is_Bitis_Tarihi,Is_Asama from Is_Dagilimi WHERE LEFT(Gorevli_Personel,11) = '" + tampon.Text + "'";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGvAra.DataSource = dt;
            con.Close();
        }
    }
}
