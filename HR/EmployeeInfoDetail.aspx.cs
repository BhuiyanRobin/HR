using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Bll1;

namespace HR
{
    public partial class EmployeeInfoDetail : System.Web.UI.Page
    {
        private clsEmployeeInfoDetail objEmployInfodetail = new clsEmployeeInfoDetail();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            SaveEmployInfoDetail();
            clearControl();
        }


        private void SaveEmployInfoDetail()
        {
            try
            {
                objEmployInfodetail.EmployeeID = Int32.Parse(IDTextBox.Text);
                objEmployInfodetail.Religion = ReligionDropDownList.SelectedItem.Text;
                objEmployInfodetail.MaritalStatus = MaritalStatusRadioButtonList.SelectedItem.Text;
                objEmployInfodetail.PresentAddress = PresentAddressTextBox.Text;
                objEmployInfodetail.PresentPSID = Int32.Parse(PSIDDropDownList.SelectedItem.Value);
                objEmployInfodetail.Designation = DesignationDropDownList.SelectedItem.Text;
                objEmployInfodetail.JoinDate = DateTime.Parse(JoinDateTextBox.Text);
                objEmployInfodetail.DepartmentID = Int32.Parse(DepermentIDDropDownList.SelectedItem.Value);

                objEmployInfodetail.saveEmployInfoDetail();

                MassageLiteral.Text = "save information";

            }
            catch (Exception ex)
            {

                MassageLiteral.Text = ex.Message;
            }
        }
        private void clearControl()
        {
            IDTextBox.Text = "";
           // MaritalStatusRadioButtonList.SelectedItem.Text = "";
            PresentAddressTextBox.Text = "";
           // PSIDDropDownList.SelectedItem.Value = "";
          //  DesignationDropDownList.SelectedItem.Text = "";
            JoinDateTextBox.Text = "";
           // DepermentIDDropDownList.SelectedItem.Value = "";
                
        }


        
    }
}