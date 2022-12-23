using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Prodect_Managmenet.DAL
{
    public  class DateAccessLayer
    {

        SqlConnection  SqlConnection;

        // this constructor inisialized the  connection  object 
        public DateAccessLayer()
        {
            string mode=Properties.Settings.Default.Mode;

            if (mode == "Windows")
            {
                SqlConnection = new SqlConnection(@"Server="+ Properties.Settings.Default.Server+ ";Database="+ Properties.Settings.Default.Database+ ";Integrated Security=true");
            }
            else
            {
                SqlConnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ";Database=" + Properties.Settings.Default.Database + ";Integrated Security=fasle; User ID="+ Properties.Settings.Default.Id+";Password="+ Properties.Settings.Default.Password+"");

            }
        }

        //this method to open connection 

        public void Open() {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }

        }


        //this method to close connection 
        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        //this method to Read Date form Database

        public DataTable SelectData(string stored_procedure,SqlParameter[]param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType=CommandType.StoredProcedure;
            sqlcmd.CommandText=stored_procedure;
            sqlcmd.Connection=SqlConnection;
            if (param!=null) {
            for(int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da=new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // this method tpo insert , delete and update Data from DATABASE

        public void ExcuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();
        }
    }
}
  