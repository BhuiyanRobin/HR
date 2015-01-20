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
    public partial class EmployInfoEntry : System.Web.UI.Page
    {
        private cslEmployInformation objEmployInformation = new cslEmployInformation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveEmployInformation();
            ClearControl();
        }


        private void SaveEmployInformation()
        {
            try
            {
                objEmployInformation.EmployeeID = Int32.Parse(TextBoxEployID.Text);
                objEmployInformation.FirstName = TextBoxFirstName.Text;
                objEmployInformation.LastName = TextBoxLastName.Text;
                objEmployInformation.FatherName = TextBoxFatherName.Text;
                objEmployInformation.MotherName = TextBoxMotherName.Text;
                objEmployInformation.BirthDate = DateTime.Parse(TextBoxBirthDate.Text);
                objEmployInformation.Gender = RadioButtonListGender.SelectedItem.Text;
                objEmployInformation.PermanetAddress = TextBoxPermanentAddress.Text;
                objEmployInformation.PermanentPSID =Int32.Parse (DropDownListPSID.SelectedItem.Value);
                objEmployInformation.Nationality = TextBoxNtionality.Text;
                objEmployInformation.SaveEmployInformation();
                LiteralMassege.Text = "Saved Information";

            }
            catch (Exception ex)
            {

                LiteralMassege.Text=ex.Message;
            }
            
        }

        protected void TextBoxEployID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                objEmployInformation.EmployeeID = Convert.ToInt32(TextBoxEployID.Text);
                var dsEmployeeInfo = objEmployInformation.dsEmployeeInfo();
                TextBoxFirstName.Text = objEmployInformation.FirstName;
                TextBoxLastName.Text = objEmployInformation.LastName;
                TextBoxFatherName.Text = objEmployInformation.FatherName;
                TextBoxMotherName.Text = objEmployInformation.MotherName;
                TextBoxBirthDate.Text = objEmployInformation.BirthDate.ToString("dd-mm-yyyy");
                RadioButtonListGender.Text = objEmployInformation.Gender;
                TextBoxPermanentAddress.Text = objEmployInformation.PermanetAddress;
                DropDownListPSID.SelectedItem.Value = objEmployInformation.PermanentPSID.ToString();
                TextBoxNtionality.Text = objEmployInformation.Nationality;

            }
            catch (Exception ex)
            {
                LiteralMassege.Text = ex.Message;

               // Response.Write(ex.Message);
            }
          
        }
        private void ClearControl()
        {
            TextBoxEployID.Text = "";
            TextBoxFirstName.Text = "";
            TextBoxLastName.Text = "";
            TextBoxFatherName.Text = "";
            TextBoxMotherName.Text = "";
            TextBoxBirthDate.Text = "";
            RadioButtonListGender.Text = "";
            TextBoxPermanentAddress.Text = "";
            TextBoxNtionality.Text = "";
        }
    
    }
}