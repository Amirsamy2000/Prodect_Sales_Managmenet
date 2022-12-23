using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prodect_Managmenet.DAL;
using Prodect_Managmenet.BL;
using System.IO;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_CUSTOMER : Form
    {
        int id, pos;
       
        CLS_CUSTOMER cust=new CLS_CUSTOMER();
        public FRM_CUSTOMER()
        {
            InitializeComponent();
           this.dataGridView2.DataSource = cust.Get_All_Customers();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            laball.Text = cust.Get_All_Customers().Rows.Count.ToString() + " / " +(pos+1).ToString();

            btnadd.Enabled = false;
       
        }

        private void FRM_CUSTOMER_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                byte[] img;
                if (pbox.Image == null)
                {
                    img = new byte[0] { };
                    cust.Add_Customer(
                   txtname.Text, txtlname.Text, txttel.Text, txtemial.Text, img, "without_image"
                   );
                    MessageBox.Show("تمت الاضافة بنجاح", "اضافةعميل جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView2.DataSource = cust.Get_All_Customers();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    img = ms.ToArray();
                    cust.Add_Customer(
                        txtname.Text, txtlname.Text, txttel.Text, txtemial.Text, img, "with_image"
                        );
                    MessageBox.Show("تمت الاضافة بنجاح", "اضافةعميل جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView2.DataSource = cust.Get_All_Customers();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                btnadd.Enabled = false;
                btnnew.Enabled = true;
            }
            
           
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.PNG;*.JPG;*.GIF;*.BMP;";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtlname.Clear();
            txtemial.Clear();
            txttel.Clear();
            pbox.Image=null;
            txtname.Focus();
            btnadd.Enabled = true;
            btnnew.Enabled = false;
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlname.Focus();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttel.Focus();
            }
        }

        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemial.Focus();
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                pbox.Image = null;
                txtname.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                txtlname.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txttel.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
                txtemial.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
                byte[] img = (byte[])this.dataGridView2.CurrentRow.Cells[5].Value;

                MemoryStream ms = new MemoryStream(img);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("هذا العميل المراد تعديله غير موجود ");
                return;
            }
            byte[] img;
            if (pbox.Image == null)
            {
                img =new byte[0];
                cust.Update_Customer(
                    Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value.ToString()),
                    txtname.Text,
                    txtlname.Text,
                    txttel.Text,
                    txtemial.Text,
                    img,
                    "without_image"
                    ) ;
                MessageBox.Show("تمت التعديل بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView2.DataSource = cust.Get_All_Customers();

            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                img=ms.ToArray();
                cust.Update_Customer(
                  Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value.ToString()),
                  txtname.Text,
                  txtlname.Text,
                  txttel.Text,
                  txtemial.Text,
                  img,
                  "with_image"
                  );
                MessageBox.Show("تمت التعديل بنجاح", "تعديل بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView2.DataSource = cust.Get_All_Customers();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("هذا العميل المراد حذفه غير موجود ");
                return;
            }
            cust.Delete_Customer(Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value));
            MessageBox.Show("هل تريد حذف العميل ", "حذف عميل", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 

            MessageBox.Show("تمت الحذف بنجاح", "حذف عميل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView2.DataSource = cust.Get_All_Customers();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivagetor(0);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            laball.Text = cust.Get_All_Customers().Rows.Count.ToString() + " / " + (pos + 1).ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           dt= cust.Search_Customer(txtsrea.Text);
            this.dataGridView2.DataSource = dt;
        }

        private void txtsrea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button10_Click( sender,  e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = cust.Get_All_Customers().Rows.Count - 1;
            Nivagetor(pos);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            laball.Text = cust.Get_All_Customers().Rows.Count.ToString() + " / " + (pos + 1).ToString();

        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (pos == 0)
            {
                MessageBox.Show("هذا اول عنصر");
                return;
            }
            pos -= 1;
            Nivagetor(pos);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            laball.Text = cust.Get_All_Customers().Rows.Count.ToString() + " / " + (pos + 1).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pos == (cust.Get_All_Customers().Rows.Count - 1))
            {
                MessageBox.Show("هذ اخر عنصر");
                return;
            }
            pos += 1;
            Nivagetor(pos);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            laball.Text = cust.Get_All_Customers().Rows.Count.ToString() + " / " + (pos + 1).ToString();

        }

        void Nivagetor(int index)
        {
            try
            {
                DataTable dt = cust.Get_All_Customers();
                txtname.Text = dt.Rows[index][1].ToString();
                txtlname.Text = dt.Rows[index][2].ToString();
                txttel.Text = dt.Rows[index][3].ToString();
                txtemial.Text = dt.Rows[index][4].ToString();
                id = Convert.ToInt32(dt.Rows[index][0]);
                byte[] img = (byte[])dt.Rows[index][5];
                MemoryStream ms = new MemoryStream(img);
                pbox.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }
    }
}
