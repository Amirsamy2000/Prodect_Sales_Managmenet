using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Prodect_Managmenet.PL
{
    public partial class FRM_STORE : Form
    {

        SqlConnection SqlConnection = new SqlConnection(@"Server=DESKTOP-596FMBQ;Database=master;Integrated Security=true");
        SqlCommand sqlcomd;
        public FRM_STORE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename.Text=openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

             string query = "ALTER DATABASE prodect_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE prodect_DB From Disk ='" + filename.Text + "' WITH REPLACE";

            sqlcomd = new  SqlCommand(query, SqlConnection);
            SqlConnection.Open();
            sqlcomd.ExecuteNonQuery();
          
            MessageBox.Show("تم استعادة النسخة المحفوظة", "استعادة النسخة المحفوظة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlConnection.Close();
        }
    }
}
