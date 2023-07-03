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
    public partial class EXPORT : Form
    {
        public EXPORT()
        {
            InitializeComponent();
        }

        private void EXPORT_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(@"Data Source=.;Initial Catalog=HotelReservationApp;Integrated Security=True");

            SqlCommand CONNECTİON = new SqlCommand("SELECT * FROM MusteriTablosu", c);
            SqlDataAdapter d = new SqlDataAdapter(CONNECTİON);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();

            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null)
            {

                Clipboard.SetDataObject(copydata);

                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();

                xlapp.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook xlWbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object miseddata = System.Reflection.Missing.Value;
                xlWbook = xlapp.Workbooks.Add(miseddata);

                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();
                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }
    }
}
