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
    public partial class RezervListele : Form
    {
        public RezervListele()
        {
            InitializeComponent();
        }

        private void RezervListele_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationAppDataSet.RezervasyonTablosu' table. You can move, or remove it, as needed.
            this.rezervasyonTablosuTableAdapter.Fill(this.hotelReservationAppDataSet.RezervasyonTablosu);

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8VEHG8B;Initial Catalog=HotelReservationApp;Integrated Security=True");

        DataTable tablo = new DataTable();

       
        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select RezervID,GirisTarih,CıkısTarihi,FirmadID,TCNO from RezervasyonTablosu ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into RezervasyonTablosu(GirisTarih,CıkısTarihi,FirmadID,TCNO)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
            Listele();

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["GirisTarih"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["CıkısTarihi"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["FirmadID"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["TCNO"].Value.ToString();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from RezervasyonTablosu where RezervID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            Listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update RezervasyonTablosu set GirisTarih='" + textBox1.Text + "',CıkısTarihi='" + textBox2.Text + "',FirmadID='" + textBox3.Text + "' where TCNO='" + textBox4.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            Listele();
            this.rezervasyonTablosuTableAdapter.Fill(this.hotelReservationAppDataSet.RezervasyonTablosu);

        }
    }
}
