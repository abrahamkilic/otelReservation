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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HotelReservationApp;Integrated Security=True");

        private void browsebutton_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                backupbutton.Enabled = true;




            }
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {





            string database = con.Database;
            if (textBox1.Text == string.Empty)
            {

                MessageBox.Show("please enter backup file location");

            }
            else
            {

                string cmd = $"Backup Database {database} TO DISK='{textBox1.Text}\\-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.bak'";
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);

                command.ExecuteNonQuery();
                MessageBox.Show("database backup done succesfully");
                con.Close();
                backupbutton.Enabled = false;



            }
        }

        private void browse2button_Click(object sender, EventArgs e)
        {



            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQl server databse backup files|*.bak";

            dlg.Title = "Database restore";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                textBox2.Text = dlg.FileName;
                restorebutton.Enabled = true;




            }
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {



            string database = con.Database.ToString();
            con.Open();

            try
            {

                string stri = string.Format("alter database [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");

                SqlCommand cmd1 = new SqlCommand(stri, con);

                cmd1.ExecuteNonQuery();

                string str2 = "Use Master Restore Database[" + database + "] FROM DISK =  '" + textBox2.Text + "'WITH REPLACE;";

                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");

                SqlCommand cmd3 = new SqlCommand(str3, con);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Database restore done succesfully");
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }












        }

        
    }
}
