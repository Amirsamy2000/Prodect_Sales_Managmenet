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
   
    public partial class FRM_USER : Form
    {
        public string state = "add";
        BL.CLS_USER user = new BL.CLS_USER();
        public FRM_USER()
        {
            InitializeComponent();
        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(user_add_data.Text== "اضافة ")
            {
                if (id.Text != string.Empty || name.Text != string.Empty || pwd.Text != string.Empty || pwd2.Text != string.Empty)
                {
                    user.ADD_USER(
                       id.Text,
                          pwd.Text,
                          tpye.Text,
                       name.Text


                        );
                    MessageBox.Show("تمت عملية حفظ بنجاح", "اضافة مستخدم  جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pwd.Clear();
                    id.Clear();
                    name.Clear();
                    pwd2.Clear();
                }
                else
                {
                    MessageBox.Show("يجب ادخل جميع الحقول", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pwd.Clear();
                    id.Clear();
                    name.Clear();
                    pwd2.Clear();

                }
            }
            else
            {
                if (id.Text != string.Empty || name.Text != string.Empty || pwd.Text != string.Empty || pwd2.Text != string.Empty)
                {
                    user.Update_User(
                       id.Text,
                          pwd.Text,
                          tpye.Text,
                       name.Text
                        );
                    MessageBox.Show("تمت عملية التعديل بنجاح", "تعديل بيانات مستخدم  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pwd.Clear();
                    id.Clear();
                    name.Clear();
                    pwd2.Clear();
                }
                else
                {
                    MessageBox.Show("يجب ادخل جميع الحقول", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pwd.Clear();
                    id.Clear();
                    name.Clear();
                    pwd2.Clear();

                }


            }
           
        }

        private void pwd2_Leave(object sender, EventArgs e)
        {
            if (pwd2.Text != pwd.Text)
            {
                MessageBox.Show("كلمة السر غير مطابقة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pwd2.Text = string.Empty;
                return;
                
            }
        }
    }
}
