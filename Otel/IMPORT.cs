using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    
    public partial class IMPORT : Form
    {

        

        public IMPORT()
        {
            InitializeComponent();
        }

        DataSet ds;
        
        

        private void IMPORT_Load(object sender, EventArgs e)
        {

            using (OpenFileDialog dialog = new OpenFileDialog()
            { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = File.Open(dialog.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fileStream);
                    reader.IsFirstRowAsColumnNames = true;
                    ds = reader.AsDataSet();
                    ResultGrid.DataSource = ds.Tables[0];
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8VEHG8B;Initial Catalog=HotelReservationApp;Integrated Security=True");

            for (int i = 0; i < ResultGrid.Rows.Count - 1; i++)
            {
                SqlCommand komut = new SqlCommand(@"INSERT İNTO MusteriTablosu (TCNO , Ad , Soyad, TelefonNo,MailAdres, IndexId) values ('" + ResultGrid.Rows[i].Cells[0].Value + "','" + ResultGrid.Rows[i].Cells[1].Value + "')", baglanti);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            ResultGrid.Rows.Clear();
        }
    }
}





