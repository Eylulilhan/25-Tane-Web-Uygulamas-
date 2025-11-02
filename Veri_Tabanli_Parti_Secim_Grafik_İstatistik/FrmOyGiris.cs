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

namespace Veri_Tabanli_Parti_Secim_Grafik_İstatistik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FHT7NMQ\SQLEXPRESS;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void BTNOYGIRIS_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE(ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", TXTA.Text);
            komut.Parameters.AddWithValue("@p3", TXTB.Text  );
            komut.Parameters.AddWithValue("@p4", TXTC.Text);
            komut.Parameters.AddWithValue("@p5", TXTD.Text);
            komut.Parameters.AddWithValue("@p6", TXTE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");

        }

        private void BTNGRAFIKLER_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
