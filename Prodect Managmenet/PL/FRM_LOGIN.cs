using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prodect_Managmenet.BL;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_LOGIN : Form
    {
        CLS_LOGIN log = new CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            DataTable dt = log.LOGIN(txtID.Text,txtPWD.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "admin")
                {
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.انشاءنسخةاحاطتيهToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.users.Enabled = true;
                    FRM_MAIN.getMainForm.prodect.Enabled = true;
                    FRM_MAIN.getMainForm.customers.Enabled = true;
                    Program.User = dt.Rows[0][3].ToString();
                    this.Close();
                }
                else
                {
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.انشاءنسخةاحاطتيهToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.users.Enabled = false;
                    FRM_MAIN.getMainForm.prodect.Enabled = true;
                    FRM_MAIN.getMainForm.customers.Enabled = true;
                    Program.User = dt.Rows[0][3].ToString();
                    this.Close();
                }
               
              
              

               
            }
            else
            {
                MessageBox.Show("LOGIN IS FAILED");

            }


        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPWD.Focus();
            }
        }
    }
}
