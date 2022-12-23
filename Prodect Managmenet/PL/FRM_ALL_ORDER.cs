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
    public partial class FRM_ALL_ORDER : Form
    {
        BL.CLS_ORDERS ord = new BL.CLS_ORDERS();

        public FRM_ALL_ORDER()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = ord.SEARCHORDERS("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ord.SEARCHORDERS(txtsearch.Text);
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

            // this solutiion
            /*  FRM_RPT_ORDER frm = new FRM_RPT_ORDER();
              RPT.Rpt_Order rpt = new RPT.Rpt_Order();
              rpt.SetParameterValue("@id", id);
              frm.crystalReportViewer1.ReportSource = rpt;*/

            // anthor sol
            this.Cursor = Cursors.WaitCursor;
           int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            FRM_RPT_ORDER frm = new FRM_RPT_ORDER();
            RPT.Rpt_Order rpt = new RPT.Rpt_Order();
            rpt.SetDataSource(ord.GETORDERSDETIAALS(id));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }
    }
}
