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



    public partial class FRM_BACKUP : Form

    {
        SqlConnection SqlConnection = new SqlConnection(@"Server=DESKTOP-596FMBQ;Database=prodect_DB;Integrated Security=true");
        SqlCommand sqlcomd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filename.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filenamepath = filename.Text + "\\Product_DB" + DateTime.Now.ToShortDateString().Replace("/", "-") +
                DateTime.Now.ToLongDateString().Replace(":", "-");
            string query = "Backup Database prodect_DB to Disk ='" + filenamepath + ".bak'";
            sqlcomd = new SqlCommand(query, SqlConnection);
            SqlConnection.Open();
            sqlcomd.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("تم انشاء نسخة احتياطية ", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
