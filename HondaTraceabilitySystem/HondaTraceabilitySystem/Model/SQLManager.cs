using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Honda.Model
{
    public class SQLManager
    {
        public static void ExecuteNonQuery(string SQL)
        {
            //SqlConnection con = new SqlConnection(GlobalData.ConnectionString);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString);
            SqlCommand comm = new SqlCommand(SQL, con);
            try
            {
                con.Open();
                comm.Connection = con;
                comm.CommandType = CommandType.Text;
                comm.CommandText = SQL;
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                con.Close();
                comm.Dispose();
            }
            con.Close();
            comm.Dispose();
        }

        public static DataTable ExecuteReader(string SQL)
        {
            //SqlConnection con = new SqlConnection(GlobalData.ConnectionString);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString);
            DataTable DT = new DataTable();
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(SQL, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(DT);
            }
            catch (SqlException ex)
            {
                con.Close();
                return DT;
            }
            con.Close();
            return DT;
        }

        //Find GridView MC Daily Delivery
        public static DataTable GridItemDetail(MCDelObj objI)
        {
            string SQL = string.Empty;
            DataTable dt = new DataTable();

            objI.DelDate = (!String.IsNullOrEmpty(objI.DelDate) ? objI.DelDate : null);
            objI.DelType = (!String.IsNullOrEmpty(objI.DelType) ? objI.DelType : null);
            objI.KDLot = (!String.IsNullOrEmpty(objI.KDLot) ? objI.KDLot : null);

            SQL = "exec spx_GetDataGrideView_MCDaily "
                + "@inDelDate = '"+objI.DelDate+ "',@inDelType = '" + objI.DelType + "',@inKDLot = '" + objI.KDLot + "',@ERROR_NUMBER = '',@ERROR_MESSAGE = ''	";
            dt = ExecuteReader(SQL);
            return dt;
        }

        //Insert MC Daily Delivery CKD
        public static void Insert_MCDailyDelivery_CKD(MCDelObj objI)
        {
            SqlConnection objConn = new SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString);
            SqlCommand objCmd = new SqlCommand();
            String strStored = "spx_Generate_Daily_Delivery_MC_CKD";
            objCmd.Parameters.Add(new SqlParameter("@inDelDate", SqlDbType.VarChar)).Value = objI.DelDate;
            objCmd.Parameters.Add(new SqlParameter("@inUserID", SqlDbType.VarChar)).Value = "admin-e";
            objCmd.Parameters.Add(new SqlParameter("@ERROR_NUMBER", SqlDbType.VarChar)).Value = "";
            objCmd.Parameters.Add(new SqlParameter("@ERROR_MESSAGE", SqlDbType.VarChar)).Value = "";
            objConn.Open();
            objCmd.Connection = objConn;
            objCmd.CommandText = strStored;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.ExecuteNonQuery();
            objConn.Close();
            objConn = null;
        }

        //Delete MC Daily Delivery
        public static void Delete_MCDailyDelivery(MCDelObj objI)
        {
            SqlConnection objConn = new SqlConnection(ConfigurationManager.ConnectionStrings["IM"].ConnectionString);
            SqlCommand objCmd = new SqlCommand();
            String strStored = "spx_Delete_Daily_Delivery_MC";
            objCmd.Parameters.Add(new SqlParameter("@inDelDate", SqlDbType.VarChar)).Value = objI.DelDate;            
            objCmd.Parameters.Add(new SqlParameter("@inDelType", SqlDbType.VarChar)).Value = objI.DelType;
            objCmd.Parameters.Add(new SqlParameter("@inKDLot", SqlDbType.VarChar)).Value = objI.KDLot;
            objCmd.Parameters.Add(new SqlParameter("@ERROR_NUMBER", SqlDbType.VarChar)).Value = "";
            objCmd.Parameters.Add(new SqlParameter("@ERROR_MESSAGE", SqlDbType.VarChar)).Value = "";
            objConn.Open();
            objCmd.Connection = objConn;
            objCmd.CommandText = strStored;
            objCmd.CommandType = CommandType.StoredProcedure;
            objCmd.ExecuteNonQuery();
            objConn.Close();
            objConn = null;
        }
    }
}