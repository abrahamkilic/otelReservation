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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=HotelReservationApp;Integrated Security=True");

        public string yetki;
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                bool kontrol = false;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from girisbilgileri where Kul_adı='" + textBox1.Text + "'and sif ='" + textBox2.Text + "'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    kontrol = true;
                    yetki = dr["yetki"].ToString();
                }
                if (kontrol==true)
                {
                    AnaSayfa frm = new AnaSayfa();
                    frm.Show();

                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                baglanti.Close();
            }
            catch (Exception )
            {

                throw;
            }
            
            
                
            

             

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
