using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prodect_Managmenet.DAL;

namespace Prodect_Managmenet.BL
{
    internal class CLS_CUSTOMER
    {
 
        public void Add_Customer(string name,string lname,string tel,string emial,byte[]img,string cer)
        {
            DateAccessLayer dl = new DateAccessLayer();
            dl.Open();
            SqlParameter[] param = new SqlParameter[6];
          

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 25);
            param[0].Value = name;

            param[1] = new SqlParameter("@lname", SqlDbType.NVarChar, 25);
            param[1].Value = lname;

            param[2] = new SqlParameter("@tel", SqlDbType.NChar);
            param[2].Value = tel;

            param[3] = new SqlParameter("@emial", SqlDbType.VarChar, 25);
            param[3].Value = emial;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@cirtion", SqlDbType.VarChar,50);
            param[5].Value = cer;
            dl.ExcuteCommand("Add_Customer", param);

        }
   
        public DataTable Get_All_Customers()
        {
            DataTable dt = new DataTable();
            DateAccessLayer da = new DateAccessLayer();
            dt = da.SelectData("Get_All_Customers", null);
            return dt;
        }

        public void Update_Customer(int id,string name, string lname, string tel, string emial, byte[] img,string cer)
        {
            DateAccessLayer dl = new DateAccessLayer();
            dl.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 25);
            param[0].Value = id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 25);
            param[1].Value = name;

            param[2] = new SqlParameter("@lname", SqlDbType.NVarChar, 25);
            param[2].Value = lname;

            param[3] = new SqlParameter("@tel", SqlDbType.NChar);
            param[3].Value = tel;

            param[4] = new SqlParameter("@emial", SqlDbType.VarChar, 25);
            param[4].Value = emial;

            param[5] = new SqlParameter("@img", SqlDbType.Image);
            param[5].Value = img;

            param[6] = new SqlParameter("@cirtion", SqlDbType.VarChar, 50);
            param[6].Value = cer;
            dl.ExcuteCommand("Update_Customer", param);
            dl.Close();
        }


        public void Delete_Customer(int id)
        {
            DateAccessLayer dl = new DateAccessLayer();
            dl.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dl.ExcuteCommand("Delete_Customer", param);
            dl.Close();
        }

        public DataTable Search_Customer(string cer)
        {
            DateAccessLayer da=new DateAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cer", SqlDbType.NVarChar, 50);
            param[0].Value = cer; 
            DataTable dt=new DataTable();
            dt = da.SelectData("Search_Customer", param);
            return dt;
        }
    }
}
