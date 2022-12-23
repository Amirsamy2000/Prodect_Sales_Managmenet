using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prodect_Managmenet.PL
{
    public partial class FRM_ADD_COUSROMER : Form
    {
        BL.CLS_CUSTOMER cust=new BL.CLS_CUSTOMER(); 
        public FRM_ADD_COUSROMER()
        {
            InitializeComponent();
        }

        private void FRM_ADD_COUSROMER_Load(object sender, EventArgs e)
        {

        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.PNG;*.JPG;*.GIF;*.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }
        void clearDate()
        {
            txtemial.Clear();
            txtlname.Clear();
            txttel.Clear();
            txtname.Clear();
            pbox.Image = null;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbox.Image == null)
                {

                }

                byte[] img;
                MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    img = ms.ToArray();
                    cust.Add_Customer(
                        txtname.Text, txtlname.Text, txttel.Text, txtemial.Text, img, "with_image"
                        );
                    MessageBox.Show("تمت الاضافة بنجاح", "اضافةعميل جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearDate();
            }
            catch
            {
                return;
            }
        }
    }
}
