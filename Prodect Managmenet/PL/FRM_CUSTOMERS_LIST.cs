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
    public partial class FRM_CUSTOMERS_LIST : Form
    {
        BL.CLS_CUSTOMER cust =new  BL.CLS_CUSTOMER();
        public FRM_CUSTOMERS_LIST()
        {
            InitializeComponent();
            data_cust.DataSource = cust.Get_All_Customers();
            data_cust.Columns[5].Visible = false;
            data_cust.Columns[0].Visible = false;
        }

        private void FRM_CUSTOMERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void data_cust_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
