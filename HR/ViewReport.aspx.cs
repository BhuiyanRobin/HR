using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Design;
using CrystalDecisions.CrystalReports.Engine;

namespace HR
{
    public partial class ViewReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                //var objSqlConnection = new SqlConnection("SERVER = Sony-pc; User ID = sa; pwd = unlock1; database = HRSNew");
                //string sqlString = "spReportSalary @employeeID = " + Convert.ToInt32(TextBox1.Text);
                //var objAdapter = new SqlDataAdapter(sqlString, objSqlConnection);
                //var dsReport = new DataSet();
                //objAdapter.Fill(dsReport);

                //ReportDocument rd = new ReportDocument();
                ////rd.Name = @"EmployeeSalarySlipNew.rpt";
                //rd.Load(@"D:\ReportPractice\EmployeeSalarySlipNew.rpt");
                //rd.SetDataSource(dsReport);
                ////rd.ParameterFields[0].Name = "@employeeID";
                
                //rd.SetParameterValue(0, 3);
                //CrystalReportViewer1.ReportSource = rd;
                //CrystalReportViewer1.DataBind();

                //ReportViewer1.LocalReport.DataSources.Clear();
                //ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                //ReportViewer1.LocalReport.ReportPath = @"D:\ReportPractice\EmployeeSalarySlipNew.rpt";
                //Microsoft.Reporting.WebForms.ReportDataSource ds = new Microsoft.Reporting.WebForms.ReportDataSource("mydatasource", dsReport.Tables[0]);
                //ReportViewer1.LocalReport.DataSources.Add(ds);
                //ReportViewer1.DataBind();

                ReportDocument rd = new ReportDocument();
                rd.Load(@"D:\ReportPractice\EmployeeSalarySlipNew.rpt");
                rd.SetDatabaseLogon("sa", "unlock1", "Sony-pc", "HRSNEW");
                CrystalReportViewer1.ReportSource = rd;
                CrystalReportViewer1.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }
    }
}