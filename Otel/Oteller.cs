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

namespace Otel
{
    public partial class Oteller : Form
    {
        public Oteller()
        {
            InitializeComponent();
        }

        private void Oteller_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationAppDataSet4.OtelTablosu' table. You can move, or remove it, as needed.
            this.otelTablosuTableAdapter.Fill(this.hotelReservationAppDataSet4.OtelTablosu);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8VEHG8B;Initial Catalog=HotelReservationApp;Integrated Security=True");

        DataTable tablo = new DataTable();


        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select OtelID,OdaID,TelefonNO,Adres,IndexId from OtelTablosu ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into OtelTablosu(OtelID,OtelAdı,TelefonNO,Adres)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update OtelTablosu set OtelAdı='" + textBox2.Text + "',TelefonNO='" + textBox3.Text + "',Adres='" + textBox4.Text + "' where OtelID='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            Listele();
        }
    }
}
