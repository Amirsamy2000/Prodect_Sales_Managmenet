using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Prodect_Managmenet.BL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_PRODECT : Form
    {

        CLS_PRODUECT prd = new CLS_PRODUECT();
        private static FRM_PRODECT frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FRM_PRODECT getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODECT();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }

                return frm;
            }
        }

        public FRM_PRODECT()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource=prd.Get_All_Prodects();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.Search_Prodect(txtSearch.Text);
            this.dataGridView1.DataSource=dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد فعلا حذف المنتج؟","عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                prd.Delete_Prodect(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت العملية بنجاح", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                ; this.dataGridView1.DataSource = prd.Get_All_Prodects();
            }
            else
            {
                MessageBox.Show("الغاء غملية الحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODECT frm = new FRM_ADD_PRODECT();
          
            frm.ShowDialog();
            
      }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODECT frm = new FRM_ADD_PRODECT();
            frm.txtPro.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = " تعديل بيانات المنتج من نوع"+this.dataGridView1.CurrentRow.Cells[1].Value;
            frm.btnOK.Text = "تعديل";
            
            frm.txtPro.ReadOnly = true;
            frm.state = "update";
           
            byte[]iamge=(byte[])prd.GetImageProdect(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(iamge);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
          


        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_PREVIEW frm = new FRM_PREVIEW();
            byte[] image = (byte[])prd.GetImageProdect(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image=Image.FromStream(ms);
          //  frm.Text= frm.Text+ "من نوع " + this.dataGridView1.CurrentRow.Cells[0].Value.ToString(); ;
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            RPT.Rpt_Single_Prodect myReport = new RPT.Rpt_Single_Prodect();
            myReport.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value);
            FRM_RPT_PRODECT frm = new FRM_RPT_PRODECT();
            frm.crystalReportViewer2.ReportSource = myReport;
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.Rpt_All_prodect myrpt=new RPT.Rpt_All_prodect();
            FRM_RPT_PRODECT frm = new FRM_RPT_PRODECT();
            frm.crystalReportViewer2.ReportSource=myrpt;
            frm.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RPT.Rpt_All_prodect myrpt = new RPT.Rpt_All_prodect();

            ExportOptions exportoptions = new ExportOptions();
            ExcelFormatOptions excelformat = new ExcelFormatOptions();
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();
            exportoptions = myrpt.ExportOptions;
            dfoptions.DiskFileName = @"D:\Products_List.xls";
            exportoptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportoptions.ExportFormatType = ExportFormatType.Excel;
            exportoptions.ExportDestinationOptions = dfoptions;
            exportoptions.ExportFormatOptions = excelformat;
            myrpt.Export();
            MessageBox.Show("List Exported Successfuly !", "Export", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RPT.Rpt_All_prodect myrpt = new RPT.Rpt_All_prodect();

            ExportOptions exportoptions = new ExportOptions();
            PdfFormatOptions pdfformat = new PdfFormatOptions();
            DiskFileDestinationOptions dfoptions = new DiskFileDestinationOptions();

            exportoptions=myrpt.ExportOptions;
            dfoptions.DiskFileName = @"D:\Products_Lists.pdf";
            exportoptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            exportoptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportoptions.ExportFormatOptions= pdfformat;
            exportoptions.ExportDestinationOptions= dfoptions;
            myrpt.Export();
            MessageBox.Show("List Exported Successfuly !", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
