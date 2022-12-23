using System;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


using System.Windows.Forms;

using System.Data.SqlClient;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_CATS : Form
    {
        SqlConnection sqlcon=new SqlConnection(@"Server=DESKTOP-596FMBQ;Database=prodect_DB;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt=new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmd;
        public FRM_CATS()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as 'كود الصنف',DESCRIPTION_CAT as 'وصف الصنف' from CATEGORY", sqlcon);
            da.Fill(dt);
             datacat.DataSource = dt;
            txtcatID.DataBindings.Add("text", dt, "كود الصنف");
            txtcatDes.DataBindings.Add("text", dt, "وصف الصنف");
            bmb = this.BindingContext[dt];
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("You Want Delete This Row", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            RPT.Rpt_Single_Cat rpt = new RPT.Rpt_Single_Cat();
            rpt.SetParameterValue("@ID", Convert.ToInt32(txtcatID.Text));
            ExportOptions exportOptions = new ExportOptions();
            PdfFormatOptions pdfFormatOptions = new PdfFormatOptions();
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            diskFileDestinationOptions.DiskFileName = @"D:\LIST_SINGLE_CAT.pdf";
            exportOptions = rpt.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
            exportOptions.ExportFormatOptions = pdfFormatOptions;
           
            rpt.Export();
            MessageBox.Show("List Exported Successfuly !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
           
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count-1;
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void buttobtnnextn2_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnpe_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            //  txtcatID.Text = Convert.ToString(bmb.Count );
            int id =Convert.ToInt32(dt.Rows[dt.Rows.Count-1][0])+1;
            txtcatID.Text = id.ToString();
              btnadd.Enabled = true;
                btnnew.Enabled = false;
            txtcatDes.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd =new SqlCommandBuilder(da);
            da.Update(dt);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            MessageBox.Show("Added Successfuly!", "Adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Editing  Successfuly!", "Edititng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lab.Text = (bmb.Position + 1) + " / " + bmb.Count;
        }

        private void btnprintall_Click(object sender, EventArgs e)
        {
            RPT.Rpt_All_Cats myreport = new RPT.Rpt_All_Cats();
            FRM_RPT_CAT frm=new FRM_RPT_CAT();
            myreport.Refresh();
            frm.RPT_CATS.ReportSource = myreport;
            frm.ShowDialog();

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            RPT.Rpt_Single_Cat rpt = new RPT.Rpt_Single_Cat();
            
            rpt.SetParameterValue("@ID", Convert.ToInt32(txtcatID.Text));
            FRM_RPT_CAT frm = new FRM_RPT_CAT();
          
            frm.RPT_CATS.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void btnsaveall_Click(object sender, EventArgs e)
        {
            RPT.Rpt_All_Cats rpt = new RPT.Rpt_All_Cats();
            ExportOptions exportOptions = new ExportOptions();
           PdfFormatOptions pdfFormatOptions = new PdfFormatOptions();
            DiskFileDestinationOptions diskFileDestinationOptions = new DiskFileDestinationOptions();
            diskFileDestinationOptions.DiskFileName = @"D:\LIST_ALL_CATS.pdf";
            exportOptions = rpt.ExportOptions;
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOptions.ExportDestinationOptions = diskFileDestinationOptions;
            exportOptions.ExportFormatOptions = pdfFormatOptions;
            rpt.Refresh();
            rpt.Export();
            MessageBox.Show("List Exported Successfuly !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void buttobtnclosen13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

