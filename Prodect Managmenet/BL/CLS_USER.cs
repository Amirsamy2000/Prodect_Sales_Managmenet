using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Prodect_Managmenet.DAL;

namespace Prodect_Managmenet.BL
{
    
    internal class CLS_USER
    {
        public void ADD_USER(string id, string pwd, string user,  string name)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

          

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@user", SqlDbType.VarChar, 50);
            param[2].Value = user;

            param[3] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[3].Value = name;

            da.ExcuteCommand("ADD_USER", param);
            da.Close();

        }


        public void Update_User(string id, string pwd, string user, string name)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;



            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = user;

            param[3] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[3].Value = name;

            da.ExcuteCommand("Update_User", param);
            da.Close();

        }

        public void Delete_User(string id)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            da.ExcuteCommand("Delete_User", param);
            da.Close();

        }
        public DataTable Get_All_Users()
        {
            DateAccessLayer da = new DateAccessLayer();
            DataTable dt = new DataTable();
            dt = da.SelectData("Get_All_Users", null);
            da.Close();
            return dt;
        }

        public DataTable Searc_User(string cer)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cer", SqlDbType.NVarChar, 50);
            param[0].Value = cer;
            DataTable dt = new DataTable();
            dt = da.SelectData("Searc_User", param);
            da.Close();
            return dt;
        }

    }
   
    
}
