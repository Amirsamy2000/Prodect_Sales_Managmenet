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
    public partial class FRM_M_USER : Form
    {
        BL.CLS_USER user=new BL.CLS_USER();
        public FRM_M_USER()
        {
            InitializeComponent();
            dataGridView1.DataSource = user.Get_All_Users();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_USER frm=new FRM_USER();
            frm.user_add_data.Text = "اضافة";
            dataGridView1.DataSource = user.Get_All_Users();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_USER frm = new FRM_USER();
            frm.id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.pwd.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.tpye.Text=this.dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString();
            frm.pwd2.Text = frm.pwd.Text;
            frm.name.Text=this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
   
            frm.user_add_data.Text = "تعديل";
            dataGridView1.DataSource = user.Get_All_Users();
            frm.ShowDialog();
        }

        private void txtsearch_Validated(object sender, EventArgs e)
        {
          
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.Searc_User(txtsearch.Text);
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل تريد حذف المستخدم؟","", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                user.Delete_User(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "حذف مستخدم  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = user.Get_All_Users();
                dataGridView1.Refresh();
            }
           

        }
    }
}
