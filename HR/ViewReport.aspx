<%@ Page Title="" Language="C#" MasterPageFile="~/MainLeaout.Master" AutoEventWireup="true" CodeBehind="ViewReport.aspx.cs" Inherits="HR.ViewReport" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <table class="style1">
        
        
        <tr>
            <td>
                Employee ID
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="ViewReportButton" runat="server" Text="View Report" 
                    onclick="ViewReportButton_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="true" />
            </td>
        </tr>
        <tr>
        <td>
            &nbsp;</td>
        </tr>
    </table>
</asp:Content>
