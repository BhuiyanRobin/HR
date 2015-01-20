using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.DAl;


namespace System.Bll1
{
   public class cslEmployInformation
    {
       private cslConnectionManager CM = new cslConnectionManager();

       public int EmployeeID { get; set; }

       public string FirstName { get; set; }

       public string LastName { get; set; }

       public string FatherName { get; set; }

       public string MotherName { get; set; }

       public DateTime BirthDate { get; set; }

       public string Gender { get; set; }

       public string PermanetAddress { get; set; }

       public int PermanentPSID { get; set; }

       public string Nationality { get; set; }


      
        public void SaveEmployInformation()
        {
            string SqlQuery = "spSaveEmployInformation";
            string[] pram = new string[] { "EmployeeID", "FirstName", "LastName", "FatherName", "MotherName", "BirthDate", "Gender", "PermanetAddress", "PermanentPSID", "Nationality" };
            object[] values = new object[] { EmployeeID, FirstName, LastName, FatherName, MotherName, BirthDate, Gender, PermanetAddress, PermanentPSID, Nationality };
            CM.SaveDataUsingSqlCommand(SqlQuery, pram, values);
        }

        public DataSet dsEmployeeInfo()
        {
            var sqlQuery = "spGetEmployeeInfo " + EmployeeID;
            var tempData = CM.ExecutiveDataSet(sqlQuery);
            tempData.Tables[0].TableName = "Employee";
            if (tempData.Tables["Employee"].Rows.Count > 0)
            {
                FirstName = tempData.Tables["Employee"].Rows[0]["FirsttName"].ToString();
                LastName = tempData.Tables["Employee"].Rows[0]["LastName"].ToString();
                FatherName = tempData.Tables["Employee"].Rows[0]["FatherName"].ToString();
                MotherName = tempData.Tables["Employee"].Rows[0]["MotherName"].ToString();
                BirthDate = Convert.ToDateTime(tempData.Tables["Employee"].Rows[0]["BirthDate"]);
                Gender = tempData.Tables["Employee"].Rows[0]["Gender"].ToString();
                PermanetAddress = tempData.Tables["Employee"].Rows[0]["PermanetAddress"].ToString();
                PermanentPSID = Convert.ToInt32( tempData.Tables["Employee"].Rows[0]["PermanentPSID"]);
                Nationality = tempData.Tables["Employee"].Rows[0]["Nationality"].ToString();
               
            }
            return tempData;
        }
       
    }

}
