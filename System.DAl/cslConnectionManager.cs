using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace System.DAl
{
   public class cslConnectionManager
    {
       private SqlConnection objConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ToString());

       public DataSet ExecutiveDataSet(string sqlquery)
       {
           DataSet dsTemp = new DataSet();
           SqlDataAdapter objAdepter = new SqlDataAdapter(sqlquery, DbConnection.sqlDBconnection());
           objAdepter.Fill(dsTemp);
           return dsTemp;
       }



       public void SaveDataUsingSqlCommand(string SqlQuery, string[] parametarName, object[] paramValue)
       {
           try
           {
               SqlCommand objcommand = new SqlCommand();
               objcommand.Connection = objConnection;
               objcommand.CommandType = CommandType.StoredProcedure;
               objcommand.CommandText = SqlQuery;

               SqlParameter objParm;
               for (int i = 0; i < parametarName.Length; i++)
               {
                   objParm = new SqlParameter();
                   objParm.ParameterName = "@" + parametarName[i];
                   objParm.Value = paramValue[i];
                   objcommand.Parameters.Add(objParm);
               }
               if (objConnection.State == ConnectionState.Closed)
               {
                   objConnection.Open();
               }
               objcommand.ExecuteNonQuery();

               if (objConnection.State == ConnectionState.Open)
               {
                   objConnection.Close();
               }

           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally
           {
               if (DbConnection.sqlDBconnection().State == ConnectionState.Open)
               {
                   DbConnection.sqlDBconnection().Close();
               }
           }
       }
    }
}
