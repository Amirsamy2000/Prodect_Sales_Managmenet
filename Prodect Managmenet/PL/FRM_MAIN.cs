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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;

        static void frm_FormClosed(object sender,FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm=new FRM_MAIN();
                    frm.FormClosed+=new FormClosedEventHandler(frm_FormClosed);
                }
               
                return frm;
            }
        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm=this;
            this.users.Enabled=false;
            this.customers.Enabled=false;
            this.prodect.Enabled=false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled=false;
            this.انشاءنسخةاحاطتيهToolStripMenuItem.Enabled = false; 

        }

      

       

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void اضافةصنفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODECT frm = new FRM_ADD_PRODECT();
            frm.ShowDialog(); 
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODECT frm= new FRM_PRODECT();
            frm.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER frm=new FRM_CUSTOMER();
            frm.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATS frm=new FRM_CATS();
            frm.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDERS frm = new FRM_ORDERS();
            frm.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ALL_ORDER frm = new FRM_ALL_ORDER();
            frm.ShowDialog();
        }

        private void اضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_COUSROMER frm = new FRM_ADD_COUSROMER();
            frm.ShowDialog();

        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER frm = new FRM_USER();
            frm.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_M_USER frm = new FRM_M_USER();
            frm.ShowDialog();
        }

        private void انشاءنسخةاحاطتيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_STORE frm = new FRM_STORE();
            frm.ShowDialog();
                }

        private void اعداداتالاتصالبلسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SETIT frm=new FRM_SETIT();
            frm.ShowDialog();
        }
    }
}
