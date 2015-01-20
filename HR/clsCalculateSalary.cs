using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HR
{
    public class clsCalculateSalary
    {
        public decimal basicSalary { get; set; }
        public decimal GrossSalary { get; set; }

        

        public decimal houseRent { get; set; }

        public decimal medical { get; set; }

        public decimal conveyance { get; set; }

        public decimal inComeTax { get; set; }
        public decimal NetSalary { get; set; }
        public decimal Total { get; set; }

        public decimal GrosssalryCalculate()
        {
            return GrossSalary = basicSalary/100*60;
        }

        public decimal madicaCalculate()
        {
            return medical = basicSalary/100*10;
        }

        public decimal houserentcalculate()
        {
            return houseRent = basicSalary/100*30;
        }

        public decimal ConveyanceCalculae()
        {
            return conveyance = basicSalary/100*5;
        }


        //internal decimal NetSalary()
        //{
        //    decimal dcmCalculatedNetSalary;
        //    GrossSalary = (basicSalary / 100) * 60;
        //    houseRent = (basicSalary / 100)*50;
        //    medical = (basicSalary / 100) * 10;
        //    conveyance = (basicSalary / 100) * 5;
        //    calculateIncomeTax();
        //    dcmCalculatedNetSalary = CalculateNetSalary();
        //    return dcmCalculatedNetSalary;
        //}

        public decimal TaxCalculate()
        {
            if (basicSalary > 20000)

            {
                inComeTax = (basicSalary / 100 * 10);
                CalculateNetSalary();

            }
            return inComeTax;
       

        }
         

        public decimal TotalSalaryCalculate()
        {
            return Total = (basicSalary + houseRent + medical + conveyance);
        }

        
       public decimal CalculateNetSalary()
        {
            
            return NetSalary=(basicSalary + houseRent + medical + conveyance) - inComeTax;
        }
        
    }
}
