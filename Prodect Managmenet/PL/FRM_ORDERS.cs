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
using System.IO;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_ORDERS : Form
    {
        void calTotalPrice()
        {
            if (txt_p_allPrice.Text != String.Empty && txt_p_discount.Text != string.Empty)
            {
                double Discount = Convert.ToDouble(txt_p_discount.Text);
                double price = Convert.ToDouble(txt_p_allPrice.Text);
                double total = price - (price*(Discount / 100));
                txt_p_total.Text = total.ToString();

            }

        }
       void CalPrice()
        {
            if (txt_p_count.Text != string.Empty && txt_p_price.Text != string.Empty)
            {
                txt_p_allPrice.Text = (Convert.ToDouble(txt_p_price.Text) * Convert.ToInt32(txt_p_count.Text)).ToString();
                
            }
        }
        DataTable dt=new DataTable();
        void CreateData() {

            dt.Columns.Add("كود المنتج");
            dt.Columns.Add("اسم  المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية ");
            dt.Columns.Add("المبلع");
            dt.Columns.Add("نسبة الخصم (%) ");
            dt.Columns.Add("المبلغ الحالي");
            data_ords.DataSource = dt;
            /*

               DataGridViewButtonColumn btn=new DataGridViewButtonColumn();
               btn.Text = "بحث";
               btn.HeaderText = "اختار";
               data_ords.Columns.Insert(0, btn);*/




        }



        CLS_ORDERS ords = new CLS_ORDERS();
        public FRM_ORDERS()
        {
            InitializeComponent();
            
            CreateData();
            txt_o_sale.Text = Program.User;
        }

     
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                pbox.Image = null;
                FRM_CUSTOMERS_LIST frm = new FRM_CUSTOMERS_LIST();
                frm.ShowDialog();
            if(frm.data_cust.CurrentRow.Cells[5].Value is DBNull)
            {

                txtid_c.Text = frm.data_cust.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = frm.data_cust.CurrentRow.Cells[1].Value.ToString();
                txtlname.Text = frm.data_cust.CurrentRow.Cells[2].Value.ToString();
                txttel.Text = frm.data_cust.CurrentRow.Cells[3].Value.ToString();
                txtemial.Text = frm.data_cust.CurrentRow.Cells[4].Value.ToString();
                return;
            }
                txtid_c.Text = frm.data_cust.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = frm.data_cust.CurrentRow.Cells[1].Value.ToString();
                txtlname.Text = frm.data_cust.CurrentRow.Cells[2].Value.ToString();
                txttel.Text = frm.data_cust.CurrentRow.Cells[3].Value.ToString();
                txtemial.Text = frm.data_cust.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])frm.data_cust.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(img);
                pbox.Image = Image.FromStream(ms);

            }
           
        

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt= ords.Get_Last_Order_ID();
            txt_o_id.Text=dt.Rows[0][0].ToString();
            btnadd.Enabled = true;
            btnprint.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            btnprint.Enabled = true;
            btnadd.Enabled = false;
            btnnew.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new_row_added();
            FRM_ALL_PRODUCTS frm = new FRM_ALL_PRODUCTS();
            frm.ShowDialog();
            var data = frm.dataGridView1.CurrentRow;
            txt_p_id.Text = data.Cells[0].Value.ToString();
            txt_p_name.Text = data.Cells[1].Value.ToString();
         
            txt_p_price.Text = data.Cells[3].Value.ToString();

            txt_p_count.Focus();





        }

       

       

        private void txt_p_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&e.KeyChar != 8 &&e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)){
                e.Handled = true;
            }
        }

        private void txt_p_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_p_price_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_p_price .Text!= string.Empty)
            {
                txt_p_count.Focus();
            }
        }

        private void txt_p_count_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_p_price.Text != string.Empty)
            {
                txt_p_discount.Focus();
               

            }
        }

        private void txt_p_price_KeyUp(object sender, KeyEventArgs e)
        {
            CalPrice();
        }

        private void txt_p_count_KeyUp(object sender, KeyEventArgs e)
        {
            CalPrice();
        }

        private void txt_p_price_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_p_discount_KeyUp(object sender, KeyEventArgs e)
        {
            calTotalPrice();
        }
        void new_row_added()
        {
             txt_p_id.Text=string.Empty;
            txt_p_name.Text = string.Empty;
            txt_p_price.Text = string.Empty;
            txt_p_count.Text = string.Empty;
            txt_p_allPrice.Text = string.Empty;
            txt_p_discount.Text = string.Empty;
            txt_p_total.Text = string.Empty;
            txt_p_sum.Focus();
        }

        private void txt_p_discount_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
               
                for (int i = 0; i<data_ords.Rows.Count; i++)
                {
                    if(data_ords.Rows[i].Cells[0].Value.ToString() == txt_p_id.Text)
                    {
                        MessageBox.Show("هذا المنتج موجود مسبقا ", "الغاء العملية", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                  
                }
                if ((ords.CHECK_QTE(txt_p_id.Text, Convert.ToInt32(txt_p_count.Text))).Rows.Count <=0)
                {
                    MessageBox.Show("لاتتوفر هذة الكمية ", "كمية غير متوفرة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    new_row_added();
                    return;
                }
                DataRow r = dt.NewRow();
                r[0] = txt_p_id.Text;
                r[1] = txt_p_name.Text;
                r[2] = txt_p_price.Text;
                r[3] = txt_p_count.Text;
                r[4] = txt_p_allPrice.Text;
                r[5] = txt_p_discount.Text;
                r[6] = txt_p_total.Text;
                dt.Rows.Add(r);
                data_ords.DataSource = dt;
                new_row_added();

                txt_p_sum.Text = (from DataGridViewRow row in data_ords.Rows
                                  where row.Cells[6].FormattedValue.ToString() != string.Empty
                                  select Convert.ToDouble(row.Cells[6].Value)).Sum().ToString();


            
            }
        }

        private void data_ords_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_p_id.Text = this.data_ords.CurrentRow.Cells[0].Value.ToString();
                txt_p_name.Text = this.data_ords.CurrentRow.Cells[1].Value.ToString();
                txt_p_price.Text = this.data_ords.CurrentRow.Cells[2].Value.ToString();
                txt_p_count.Text = this.data_ords.CurrentRow.Cells[3].Value.ToString();
                txt_p_allPrice.Text = this.data_ords.CurrentRow.Cells[4].Value.ToString();
                txt_p_discount.Text = this.data_ords.CurrentRow.Cells[5].Value.ToString();
                txt_p_total.Text = this.data_ords.CurrentRow.Cells[6].Value.ToString();
                this.data_ords.Rows.RemoveAt(data_ords.CurrentRow.Index);

                txt_p_count.Focus();

            }
            catch
            {
                return;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.data_ords.Rows.RemoveAt(this.data_ords.CurrentRow.Index);

            }
            catch
            {
                return;
            }

        }

        private void data_ords_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txt_p_sum.Text = (from DataGridViewRow row in data_ords.Rows
                              where row.Cells[6].FormattedValue.ToString() != string.Empty
                              select Convert.ToDouble(row.Cells[6].Value)).Sum().ToString();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_ords_DoubleClick(sender, e);
        }

        private void حذفالعنصرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.data_ords.Rows.RemoveAt(this.data_ords.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            data_ords.Refresh();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = true;
            btnprint.Enabled = true;
           
            txt_o_id.Text=ords.Get_Last_Order_ID().Rows[0][0].ToString();
            btnnew.Enabled = false ;
        }
        void ClearData()
        {
            new_row_added();
            txtid_c.Clear();
            txtlname.Clear();
            txtemial.Clear();
            txttel.Clear();
            txtname.Clear();
            pbox.Image = null;
            txt_o_id.Clear();
           txt__o_dcs.Clear();
            dt.Clear();
            data_ords.Refresh();
        }
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (txt_o_id.Text == string.Empty || txtid_c.Text == string.Empty || data_ords.Rows.Count < 1)
            {
                MessageBox.Show("يجيب تسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ords.Add_Order(
               Convert.ToInt32(txt_o_id.Text),
               txt_O_data.Text,
               Convert.ToInt32(txtid_c.Text),
               txt__o_dcs.Text,
               txt_o_sale.Text
                );

            for(int i = 0; i < data_ords.Rows.Count ; i++)
            {
                ords.ADD_ORDER_DETIALS(
                    Convert.ToInt32(txt_o_id.Text),
                    data_ords.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(data_ords.Rows[i].Cells[3].Value.ToString()),
                     data_ords.Rows[i].Cells[2].Value.ToString(),
                     Convert.ToDouble(data_ords.Rows[i].Cells[5].Value.ToString()),
                      data_ords.Rows[i].Cells[4].Value.ToString(),
                       data_ords.Rows[i].Cells[6].Value.ToString()
                    );

            }
            MessageBox.Show("تمت عملية الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ;
            btnnew.Enabled = true;
            ClearData();
            btnadd.Enabled = false;



        }

        private void txt_O_data_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ords.Get_Last_Order_ID_print().Rows[0][0]);

            // this solutiion
            /*  FRM_RPT_ORDER frm = new FRM_RPT_ORDER();
              RPT.Rpt_Order rpt = new RPT.Rpt_Order();
              rpt.SetParameterValue("@id", id);
              frm.crystalReportViewer1.ReportSource = rpt;*/

            // anthor sol
            this.Cursor=Cursors.WaitCursor;
            FRM_RPT_ORDER frm = new FRM_RPT_ORDER();
            RPT.Rpt_Order rpt = new RPT.Rpt_Order();
            rpt.SetDataSource(ords.GETORDERSDETIAALS(id));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();

        }
    }
}
