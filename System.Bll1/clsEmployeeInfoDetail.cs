using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.DAl;


namespace System.Bll1
{
  public  class clsEmployeeInfoDetail
    {
      private cslConnectionManager CM = new cslConnectionManager();

        public int EmployeeID { get; set; }

        public string Religion { get; set; }

        public string MaritalStatus { get; set; }

        public string PresentAddress { get; set; }

        public int PresentPSID { get; set; }

        public string Designation { get; set; }

        public DateTime JoinDate { get; set; }

        public int DepartmentID { get; set; }



        public void saveEmployInfoDetail()
        {
            string sqlQuery = "spSaveEmployeeDitail";
            string[] pram = new string[] { "EmployeeID","Religion","MaritalStatus","PresentAddress","PresentPSID","Designation","JoinDate ","DepartmentID" };
            object[] values = new object[] { EmployeeID,Religion,MaritalStatus,PresentAddress,PresentPSID,Designation,JoinDate ,DepartmentID };
            CM.SaveDataUsingSqlCommand(sqlQuery, pram, values);
        }

    }
}
