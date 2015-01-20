<%@ Page Title="" Language="C#" MasterPageFile="~/MainLeaout.Master" AutoEventWireup="true" CodeBehind="SalaryInformation.aspx.cs" Inherits="HR.SalaryInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 50%;
        }
    .style2
    {
        width: 147px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center" 
        style="color: #666633; font-size: xx-large; background-color: #CCCCCC;">
Salary Information
</div>
<div style="top: 5mm">

    <table class="style1" align="center" frame="border" 
        style="border-style: ridge; border-color: #999999;">
        <tr>
            <td>
                Employee ID</td>
            <td>
                <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                Basic Salary</td>
            <td class="style2">
                <asp:TextBox ID="BasicSalaryTextBox" runat="server" 
                    ontextchanged="BasicSalaryTextBox_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gross Salary</td>
            <td>
                <asp:TextBox ID="GrossTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                Madical</td>
            <td style="margin-left: 40px" class="style2">
                <asp:TextBox ID="MadicalTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                House Rent</td>
            <td>
                <asp:TextBox ID="HouseRentTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                Conveyance</td>
            <td style="margin-left: 40px" class="style2">
                <asp:TextBox ID="ConveyanceTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Income Taxe</td>
            <td>
                <asp:TextBox ID="IncometexTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                Total Salary</td>
            <td style="margin-left: 40px" class="style2">
                <asp:TextBox ID="TotalSalaryTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Net Salary</td>
            <td>
                <asp:TextBox ID="NetSalaryTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td style="margin-left: 40px" class="style2">
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SaveButton" runat="server" onclick="SaveButton_Click" 
                    Text="Save" />
            </td>
            <td>
                &nbsp;</td>
            <td colspan="2">
                <asp:Literal ID="MassageLiteral" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="margin-left: 40px" class="style2">
                &nbsp;</td>
        </tr>
    </table>

</div>
</asp:Content>
