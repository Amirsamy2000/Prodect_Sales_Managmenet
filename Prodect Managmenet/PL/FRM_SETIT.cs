using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_SETIT : Form
    {
        public FRM_SETIT()
        {
            InitializeComponent();
            server.Text = Properties.Settings.Default.Server;
            database.Text= Properties.Settings.Default.Database;
            if (Properties.Settings.Default.Mode == "Windows")
            {
                rbwindows.Checked = true;
                username.Clear();
                password.Clear();
                username.ReadOnly = true;
                password.ReadOnly = true;

            }
            else
            {
                rbsql.Checked = true;
                username.Text = Properties.Settings.Default.Id;
                password.Text = Properties.Settings.Default.Password;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = server.Text;
            Properties.Settings.Default.Database = database.Text;
            Properties.Settings.Default.Mode = rbsql.Checked == true ? "SQL" : "Windows";
                
                Properties.Settings.Default.Id = username.Text;
            Properties.Settings.Default.Password=password.Text;
            Properties.Settings.Default.Save();

        }

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            username.ReadOnly = false;
            password.ReadOnly = false;
        }
    }
}

