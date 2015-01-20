using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Bll1;
using System.Data;


namespace HR
{
    public partial class SalaryInformation : System.Web.UI.Page
    {
        private clsSalaryInformation objSalaryInformation = new clsSalaryInformation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSalaryInformation();
            ClearControl();
        }
        private void SaveSalaryInformation()
        {
            try
            {
                objSalaryInformation.EmployeeID = Int32.Parse(IDTextBox.Text);
                objSalaryInformation.GrossSalary = Int32.Parse(GrossTextBox.Text);
                objSalaryInformation.BasicSalary = Int32.Parse(BasicSalaryTextBox.Text);
                objSalaryInformation.Madical = Int32.Parse(MadicalTextBox.Text);
                objSalaryInformation.HouseRent = Int32.Parse(HouseRentTextBox.Text);
                objSalaryInformation.Convyence = Int32.Parse(ConveyanceTextBox.Text);
                objSalaryInformation.TotalSalary = Int32.Parse(TotalSalaryTextBox.Text);
                objSalaryInformation.IncomeTaxes = Int32.Parse(IncometexTextBox.Text);
                objSalaryInformation.NetSalary = Int32.Parse(NetSalaryTextBox.Text);

                objSalaryInformation.saveSalaryInformation();
                MassageLiteral.Text = "save information";
            }
            catch (Exception ex)
            {

                MassageLiteral.Text = ex.Message;
            }
            
        }
       

        protected void BasicSalaryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculateSalary();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            /*
            int Basic = Convert.ToInt32(BasicSalaryTextBox.Text);
            
            int Gross;
            int Madical;
            int House;
            int Conveyance;
            int IncomeTex;
            int Total;
            int TotalSalary;
            int NetSalary;


            Gross = Basic * 30 / 100;
            GrossTextBox.Text = Gross.ToString();

            Madical = Basic * 20 / 100;
            MadicalTextBox.Text = Madical.ToString();

            House = Basic * 25 / 100;
            HouseRentTextBox.Text = House.ToString();

            Conveyance = Basic * 10 / 100;
            ConveyanceTextBox.Text = Conveyance.ToString();

            TotalSalary = Basic + Gross + Madical + House + Conveyance;
            TotalSalaryTextBox.Text = TotalSalary.ToString();

           
            

            Total = Basic + Gross;
            IncomeTex = Total * 5 / 100;

            

            if (Total > 30000)
            {
               // IncomeTex = Total * 5 / 100;
                IncometexTextBox.Text = IncomeTex.ToString();
                NetSalary = TotalSalary - IncomeTex;
                NetSalaryTextBox.Text = NetSalary.ToString();
                
            }
            else
            {
                IncometexTextBox.Text = "";
                NetSalaryTextBox.Text = TotalSalary.ToString();
               
            }
              
            */

           
        }

        private void calculateSalary()
        {
            clsCalculateSalary objSalary = new clsCalculateSalary();
            objSalary.basicSalary = Convert.ToDecimal(BasicSalaryTextBox.Text);
            GrossTextBox.Text = objSalary.GrosssalryCalculate().ToString();
            HouseRentTextBox.Text = objSalary.houserentcalculate().ToString();
            MadicalTextBox.Text = objSalary.madicaCalculate().ToString();
            ConveyanceTextBox.Text = objSalary.ConveyanceCalculae().ToString();
            IncometexTextBox.Text = objSalary.TaxCalculate().ToString();
            TotalSalaryTextBox.Text = objSalary.TotalSalaryCalculate().ToString();
            NetSalaryTextBox.Text = objSalary.CalculateNetSalary().ToString();
        }

        private void ClearControl()
        {
            IDTextBox.Text = "";
            GrossTextBox.Text = "";
            BasicSalaryTextBox.Text = "";
            MadicalTextBox.Text = "";
            HouseRentTextBox.Text = "";
            ConveyanceTextBox.Text = "";
            TotalSalaryTextBox.Text = "";
            IncometexTextBox.Text = "";
            NetSalaryTextBox.Text = "";
        }
    }
}