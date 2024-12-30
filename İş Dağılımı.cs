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
    public partial class İş_Dağılımı : Form
    {
        public İş_Dağılımı()
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar.ToString() == " ")
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
                string asama = "0";
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Is_Dagilimi (Is_Adi,Is_Tanimi,Gorevli_Personel,Is_Baslangic_Tarihi,Is_Bitis_Tarihi,Is_Asama) VALUES(@Is_Adi,@Is_Tanimi,@Gorevli_Personel,@Is_Baslangic_Tarihi,@Is_Bitis_Tarihi,@Is_Asama)", con);
                if (tbxIsAdi.Text != "")
                    command.Parameters.Add(new SqlParameter("@Is_Adi", tbxIsAdi.Text));
                if (richTbxIsTanimi.Text != "")
                    command.Parameters.Add(new SqlParameter("@Is_Tanimi", richTbxIsTanimi.Text));
                command.Parameters.Add(new SqlParameter("@Gorevli_Personel", cbxPersonel.SelectedItem.ToString()));
                if (dtpickBasla.Value >= DateTime.Today)
                    command.Parameters.Add(new SqlParameter("@Is_Baslangic_Tarihi", dtpickBasla.Value));
                if (dtpickBitis.Value >= dtpickBasla.Value)
                    command.Parameters.Add(new SqlParameter("@Is_Bitis_Tarihi", dtpickBitis.Value));
                command.Parameters.Add(new SqlParameter("@Is_Asama", asama));
                command.ExecuteNonQuery();
                MessageBox.Show("Ekleme Başarılı");
                tbxIsAdi.Clear();
                richTbxIsTanimi.Clear();
                cbxPersonel.SelectedIndex = -1;
                dtpickBasla.Value = DateTime.Today;
                dtpickBitis.Value = DateTime.Today;
            }
            catch
            {
                if (tbxIsAdi.Text == "" || richTbxIsTanimi.Text == "")
                    MessageBox.Show("Lütfen * bulunan alanları doldurunuz.");
                else if (dtpickBasla.Value < DateTime.Today)
                    MessageBox.Show("Başlangıç Tarihi eski tarihli olamaz.");
                else if (dtpickBitis.Value < dtpickBasla.Value)
                    MessageBox.Show("Bitiş Tarihi, Başlangıç Tarihinden erken olamaz.");
                else
                    MessageBox.Show("Lütfen * bulunan alanları doldurunuz.");
            }
            finally
            {
                con.Close();
                refresh();
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

        private void İş_Dağılımı_Load(object sender, EventArgs e)
        {
            dtpickBasla.Value = DateTime.Today;
            dtpickBitis.Value = DateTime.Today;
            string ad;
            string soyad;
            string tc;
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Kullanici", con);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                ad = DR["Ad"].ToString();
                soyad = DR["Soyad"].ToString();
                tc = DR["TC"].ToString();
                cbxPersonel.Items.Add(tc + " " + ad + " " + soyad);
            }
            con.Close();

            con.Open();
            string kayit = "SELECT ID,Gorevli_Personel,Is_Adi,Is_Tanimi,Is_Baslangic_Tarihi,Is_Bitis_Tarihi,Is_Asama from Is_Dagilimi";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGvAra.DataSource = dt;
            //dataGvAra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGvAra.Columns[0].HeaderText = "İş No";
            dataGvAra.Columns[1].HeaderText = "Görevli Personel";
            dataGvAra.Columns[2].HeaderText = "İşin Adı";
            dataGvAra.Columns[3].HeaderText = "İşin Tanımı";
            dataGvAra.Columns[4].HeaderText = "Başlangıç Tarihi";
            dataGvAra.Columns[5].HeaderText = "Bitiş Tarihi";
            dataGvAra.Columns[6].HeaderText = "Tamamlanan %";
            dataGvAra.Columns[0].Width = 30;
            dataGvAra.Columns[1].Width = 150;
            dataGvAra.Columns[2].Width = 150;
            dataGvAra.Columns[3].Width = 150;
            dataGvAra.Columns[4].Width = 68;
            dataGvAra.Columns[5].Width = 68;
            dataGvAra.Columns[6].Width = 68;
            dataGvAra.Columns[0].ReadOnly = true;
            dataGvAra.Columns[1].ReadOnly = true;
            dataGvAra.Columns[2].ReadOnly = true;
            dataGvAra.Columns[3].ReadOnly = true;
            dataGvAra.Columns[4].ReadOnly = true;
            dataGvAra.Columns[5].ReadOnly = true;
            con.Close();
        }

        public void refresh()
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            string kayit = "SELECT ID,Gorevli_Personel,Is_Adi,Is_Tanimi,Is_Baslangic_Tarihi,Is_Bitis_Tarihi,Is_Asama from Is_Dagilimi";
            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGvAra.DataSource = dt;
            con.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string ad, tanim, asama;
            ad = tbxIsAdi.Text;
            tanim = richTbxIsTanimi.Text;
            asama = dataGvAra.CurrentRow.Cells[6].Value.ToString();
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-7HOH3FM\SQLEXPRESS;Database=EDYAZILIM;User Id=sa;Password=06121707;");
            con.Open();
            if (tbxIsAdi.Text != "" && richTbxIsTanimi.Text != "" && dtpickBitis.Value >= dtpickBasla.Value)
            {
                SqlCommand guncelle = new SqlCommand("update Is_Dagilimi set Is_Adi='" + ad + "',Is_Tanimi='" + tanim + "',Gorevli_Personel='" + cbxPersonel.SelectedItem.ToString() + /*"',Is_Baslangic_Tarihi='" + dtpickBasla.Value + "',Is_Bitis_Tarihi='" + dtpickBitis.Value +*/ "',Is_Asama='" + asama + "' where ID='" + dataGvAra.CurrentRow.Cells["ID"].Value + "'", con);
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
        }

        private void dataGvAra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxIsAdi.Text = dataGvAra.CurrentRow.Cells[2].Value.ToString();
            richTbxIsTanimi.Text = dataGvAra.CurrentRow.Cells[3].Value.ToString();
            cbxPersonel.Text = dataGvAra.CurrentRow.Cells[1].Value.ToString();
            dtpickBasla.Value = Convert.ToDateTime(dataGvAra.CurrentRow.Cells[4].Value.ToString());
            dtpickBitis.Value = Convert.ToDateTime(dataGvAra.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
