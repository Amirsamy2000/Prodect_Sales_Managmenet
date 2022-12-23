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
    internal class CLS_ORDERS
    {

        public DataTable Get_Last_Order_ID()
        {
            DataTable dt = new DataTable();
            DateAccessLayer da = new DateAccessLayer();
            dt = da.SelectData("Get_Last_Order_ID", null);
            return dt;
        }

        public DataTable SEARCHORDERS(string cer)
        {
            DataTable dt = new DataTable();
            DateAccessLayer da = new DateAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cer", SqlDbType.NVarChar, 50);
            param[0].Value = cer;
            dt = da.SelectData("SEARCHORDERS", param);
            return dt;
        }
        public DataTable Get_Last_Order_ID_print()
        {
            DataTable dt = new DataTable();
            DateAccessLayer da = new DateAccessLayer();
           

            dt = da.SelectData("Get_Last_Order_ID_print", null);
            return dt;
        }
        public void Add_Order(            int id_ord,string data,int id_cust,string dsec_ord,string saleman  )    
                   {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@ID_ORDERS", SqlDbType.Int);
            param[0].Value = id_ord;

            param[1] = new SqlParameter("@DATE_ORDERS", SqlDbType.DateTime);
            param[1].Value = data;

            param[2] = new SqlParameter("@ID_CUSTOMERS", SqlDbType.Int);
            param[2].Value = id_cust;

            param[3] = new SqlParameter("@DESC_ORDER", SqlDbType.NVarChar,250);
            param[3].Value =dsec_ord ;

            param[4] = new SqlParameter("@SALAMAN", SqlDbType.NVarChar, 75);
            param[4].Value = saleman;

            

            da.ExcuteCommand("Add_Order", param);
            da.Close();

        }

        public void ADD_ORDER_DETIALS(
          int id_ord,string id_prodect,int qte,string price,double discount,string count,string total
           )
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_ORDERS", SqlDbType.Int);
            param[0].Value = id_ord;

            param[1] = new SqlParameter("@ID_PRODECT", SqlDbType.VarChar,50);
            param[1].Value = id_prodect;

            param[2] = new SqlParameter("@QTE", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@DISCOUNT", SqlDbType.Float);
            param[4].Value = discount;

            param[5] = new SqlParameter("@AMOUNT", SqlDbType.NVarChar, 75);
            param[5].Value = count;

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 50);
            param[6].Value = total;
            da.ExcuteCommand("ADD_ORDER_DETIALS", param);
            da.Close();

        }

        public DataTable CHECK_QTE(string id ,int qte)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            param[1] = new SqlParameter("@qte", SqlDbType.Int);
            param[1].Value = qte;
            DataTable dt = new DataTable();
            dt = da.SelectData("CHECK_QTE", param);
            return dt;
        }
        public DataTable GETORDERSDETIAALS(int id)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
    
            DataTable dt = new DataTable();
            dt = da.SelectData("GETORDERSDETIAALS", param);
            return dt;
        }
    }
}
