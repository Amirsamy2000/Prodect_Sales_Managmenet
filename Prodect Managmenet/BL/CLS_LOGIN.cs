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
    internal class CLS_LOGIN
    {
        public DataTable LOGIN(string ID, string PWD)
        {

            DateAccessLayer DL=new DateAccessLayer();
            SqlParameter []param=new SqlParameter[2];
            param[0]=new SqlParameter("@ID",SqlDbType.VarChar,50);
            param[0].Value = ID;
            param[1]= new SqlParameter("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;
            DL.Open();
            DataTable dt=new DataTable();
            dt = DL.SelectData("SP_LOGIN", param);
            DL.Close();
            return dt;
        }
        
    }
}
