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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationAppDataSet3.OdaTablosu' table. You can move, or remove it, as needed.
            this.odaTablosuTableAdapter.Fill(this.hotelReservationAppDataSet3.OdaTablosu);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8VEHG8B;Initial Catalog=HotelReservationApp;Integrated Security=True");

        DataTable tablo = new DataTable();


        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select OdaID,OdaAdı,Konum,Hizmet,IndexId from OdaTablosu ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into OdaTablosu(OdaID,OdaAdı,Konum,Hizmet)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update OdaTablosu set OdaAdı='" + textBox2.Text + "',Konum='" + textBox3.Text + "',Hizmet='" + textBox4.Text + "' where OdaID='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            Listele();
        }

        
    }
}
