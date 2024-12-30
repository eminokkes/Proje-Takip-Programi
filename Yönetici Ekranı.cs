using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emin_Dal
{
    public partial class Yönetici_Ekranı : Form
    {
        public Yönetici_Ekranı()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle obj = new Kullanıcı_Ekle();
            obj.Show();
            this.Hide();
        }

        private void btnBossEkle_Click(object sender, EventArgs e)
        {

            Yönetici_Ekle obj = new Yönetici_Ekle();
            obj.Show();
            this.Hide();

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void btnIsTanim_Click(object sender, EventArgs e)
        {
            İş_Dağılımı obj = new İş_Dağılımı();
            obj.Show();
            this.Hide();
        }
    }
}
