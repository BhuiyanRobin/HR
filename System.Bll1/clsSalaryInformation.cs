using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.DAl;

namespace System.Bll1
{
   public class clsSalaryInformation
    {
       private cslConnectionManager CM = new cslConnectionManager();
        public int EmployeeID { get; set; }

        public int GrossSalary { get; set; }

        public int BasicSalary { get; set; }

        public int Madical { get; set; }

        public int HouseRent { get; set; }

        public int Convyence { get; set; }

        public int TotalSalary { get; set; }

        public int IncomeTaxes { get; set; }

        public int NetSalary { get; set; }

        public void saveSalaryInformation()
        {
            string sqlquery = "spSaveSalaryInformation";
            string[] pram = new string[] { "EmployeeID", "GrossSalary", "BasicSalary", "Madical", "HouseRent", "Convyence", "TotalSalary", "IncomeTaxes", "NetSalary" };
            object[] values = new object[] { EmployeeID, GrossSalary, BasicSalary, Madical, HouseRent, Convyence, TotalSalary, IncomeTaxes, NetSalary };
            CM.SaveDataUsingSqlCommand(sqlquery, pram, values);

        }
    }
}
