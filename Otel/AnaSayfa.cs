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
using System.Xml.Serialization;

namespace Otel
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        Form2 f2 = (Form2)Application.OpenForms["Form2"];

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            
            if (f2.yetki == "0") 
            {
                MessageBox.Show("admin girişi başarılı");
            }
            if (f2.yetki == "1") 
            {
                MessageBox.Show("operator1 girişi başarılı");
                Odalar.Hide();
                Oteller.Hide(); 
                Firmalar.Hide();
                button1.Hide();
            }
            if (f2.yetki == "2") 
            {
                MessageBox.Show("operator2 girişi başarılı");
                Musteri.Hide();
                RezervList.Hide();
                button1.Hide();
            }
            
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=HotelReservationApp;Integrated Security=True");
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void Musteri_Click(object sender, EventArgs e)
        {
            Musteri ekle= new Musteri();
            FormGetir(ekle);

        }

        private void RezervList_Click(object sender, EventArgs e)
        {
            RezervListele listele=new RezervListele();
            FormGetir(listele);

        }

        private void Firmalar_Click(object sender, EventArgs e)
        {
            Firmalar listele=new Firmalar();
            FormGetir(listele);
        }

        private void Odalar_Click(object sender, EventArgs e)
        {
            Odalar listele=new Odalar();
            FormGetir(listele);
        }

        private void Oteller_Click(object sender, EventArgs e)
        {
            Oteller listele=new Oteller();
            FormGetir(listele);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMPORT frm = new IMPORT();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXPORT frm = new EXPORT();
            frm.Show();        
        }
    }
}
