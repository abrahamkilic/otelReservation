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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=HotelReservationApp;Integrated Security=True");

        DataTable tablo = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriTablosu(TCNO,Ad,Soyad,TelefonNo,MailAdres)  values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Yapıldı");
            Listele();


        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select TCNO,Ad,Soyad,TelefonNo,MailAdres,IndexId from MusteriTablosu ", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["TCNO"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["TelefonNo"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["MailAdres"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriTablosu where TCNO='" + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriTa blosu set Ad='"+textBox2.Text+"',Soyad='"+textBox3.Text+"',TelefonNo='"+textBox4.Text +"',MailAdres='"+textBox5.Text + "' where TCNO='" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi");
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tablo.DefaultView;
            dv.RowFilter = "TCNO LIKE '" + textBox6.Text + "%'";
            dataGridView1.DataSource = dv;
            if (textBox6.Text == "")
            {
                Listele();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tablo.DefaultView;
            dv.RowFilter = "Ad LIKE '" + textBox7.Text + "%'";
            dataGridView1.DataSource = dv;
            if (textBox7.Text == "")
            {
                Listele();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataView dv = tablo.DefaultView;
            dv.RowFilter = "TelefonNo LIKE '" + textBox8.Text + "%'";
            dataGridView1.DataSource = dv;
            if (textBox8.Text == "")
            {
                Listele();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}