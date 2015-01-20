using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace System.DAl
{
  public  class DbConnection
    {
      public static SqlConnection sqlDBconnection()
      {
          SqlConnection objConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConnection"].ToString());
          return objConnection;
      }
    }
}
