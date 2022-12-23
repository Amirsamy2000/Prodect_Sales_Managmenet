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
    public partial class FRM_ALL_PRODUCTS : Form
    {
        BL.CLS_PRODUECT allpro=new BL.CLS_PRODUECT();
        DataTable dt = new DataTable();
        public FRM_ALL_PRODUCTS()
        {
            InitializeComponent();
            dt = allpro.Get_All_Prodects();
            dataGridView1.DataSource = dt;

        }

        private void FRM_ALL_PRODUCTS_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
