using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otel
{
    public partial class Firmalar : Form
    {
        public Firmalar()
        {
            InitializeComponent();
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationAppDataSet2.AracıFirmaTablosu' table. You can move, or remove it, as needed.
            this.aracıFirmaTablosuTableAdapter.Fill(this.hotelReservationAppDataSet2.AracıFirmaTablosu);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8VEHG8B;Initial Catalog=HotelReservationApp;Integrated Security=True");

        DataTable tablo = new DataTable();


        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select FirmaID,WebSitesi,OtelID,TelefonNo,MailAdres,IndexId from AracıFirmaTablosu ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update AracıFirmaTablosu set WebSitesi='" + textBox2.Text + "',TelefonNo='" + textBox3.Text + "',MailAdres='" + textBox4.Text + "' where FirmaID='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AracıFirmaTablosu(FirmaID,WebSitesi,TelefonNo,MailAdres)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
            Listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
