using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Prodect_Managmenet.DAL;
using System.Windows.Forms;

namespace Prodect_Managmenet.BL
{
    internal class CLS_PRODUECT
    {
      
       
        public DataTable Get_All_Cat()
        {
            DateAccessLayer da = new DateAccessLayer();
            DataTable dt=new DataTable();
            dt = da.SelectData("Get_All_Cat", null);
            da.Close();
            return dt;
        }

        public void Add_New_Prodect(

            int ID_cat,string Label_prodect,string ID_prodect
            ,int Qte,string price,byte[] img
            )
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = ID_cat;

            param[1] = new SqlParameter("@ID_PRODECT", SqlDbType.VarChar, 25);
            param[1].Value = ID_prodect;

            param[2] = new SqlParameter("@LABEL_PRODECT", SqlDbType.NVarChar,30);
            param[2].Value = Label_prodect;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = Qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar,50);
            param[4].Value = price;

            param[5] = new SqlParameter("@IMG_PRODECT", SqlDbType.Image);
            param[5].Value = img;

            da.ExcuteCommand("Add_New_Prodect", param);
            da.Close();
          
          
          
        }

        public DataTable VerityID_Prodect(string id)
        {
            DateAccessLayer da = new DateAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = id;
             dt = da.SelectData("VerityID_Prodect", param);
            return dt;
        }

        public DataTable Get_All_Prodects()
        {
            DateAccessLayer da = new DateAccessLayer();
            DataTable dt = new DataTable();
            dt=da.SelectData("Get_All_Prodects", null);
            return dt;
        }

       public DataTable Search_Prodect(string Word)
        {
            DateAccessLayer da = new DateAccessLayer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@word", SqlDbType.NVarChar,50);
            param[0].Value = Word;
            dt = da.SelectData("Search_Prodect", param);
            da.Close();
            return dt;

        }


        public void Delete_Prodect(string id)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,50);
            param[0].Value=id;
            da.ExcuteCommand("Delete_Prodect", param);
            da.Close();
        }
       
        public  DataTable GetImageProdect(string id)
        {
           
            DateAccessLayer da=new DateAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = da.SelectData("GetImageProdect", param);
            da.Close();
            return dt;

        }

        public void UpdateProdect(int id_cat,string id_prodect,string lable,int qte,string price,byte [] image)
        {
            DateAccessLayer da = new DateAccessLayer();
            da.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@ID_PRODECT", SqlDbType.VarChar, 50);
            param[1].Value = id_prodect;

            param[2] = new SqlParameter("@LABEL_PRODECT", SqlDbType.NVarChar, 50);
            param[2].Value = lable;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@PRICE", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@IMG_PRODECT", SqlDbType.Image);
            param[5].Value = image;

            da.ExcuteCommand("UpdateProdect", param);
            da.Close();

        }
    }
}
