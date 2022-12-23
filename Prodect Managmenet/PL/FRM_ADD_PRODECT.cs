using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Prodect_Managmenet.PL
{
    public partial class FRM_ADD_PRODECT : Form
    {
        public string state = "add";
        BL.CLS_PRODUECT prd = new BL.CLS_PRODUECT();
        public FRM_ADD_PRODECT()
        {
            InitializeComponent();
            cat.DataSource = prd.Get_All_Cat();
            cat.DisplayMember = "DESCRIPTION_CAT";
            cat.ValueMember = "ID_CAT";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "Images|*.PNG;*.JPG;*.GIF;*.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] bytes_img = ms.ToArray();
                prd.Add_New_Prodect(
                    Convert.ToInt32(cat.SelectedValue),
                    txtDes.Text,
                     txtPro.Text,
                   Convert.ToInt32(txtQte.Text),
                    txtPrice.Text,
                    bytes_img
                    );

                MessageBox.Show("تمت الاضافة بنجاح", "اضافة منتج جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
            else
            {

                
                MemoryStream ms1 = new MemoryStream();
                pbox.Image.Save(ms1, pbox.Image.RawFormat);
                byte[] imgs=ms1.ToArray();
                prd.UpdateProdect(
               Convert.ToInt32(cat.SelectedValue),
               txtPro.Text,
               txtDes.Text,
               Convert.ToInt32(txtQte.Text),
              txtPrice.Text,
               imgs
                );
                MessageBox.Show("تمت التعديل بنجاح", "تعديل ببيانات المنتج", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }


            FRM_PRODECT.getMainForm.dataGridView1.DataSource = prd.Get_All_Prodects();

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPro_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = prd.VerityID_Prodect(txtPro.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("المنتج موجود بلفعل", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    txtPro.Focus();
                    txtPro.SelectionStart = 0;
                    txtPro.SelectionLength = txtPro.Text.Length;
                }
            }
        }

        private void txtPro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
