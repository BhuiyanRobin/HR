<%@ Page Title="" Language="C#" MasterPageFile="~/MainLeaout.Master" AutoEventWireup="true" CodeBehind="LeaveInformation.aspx.cs" Inherits="HR.LeaveInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="color: #666633; font-size: xx-large; font-weight: bold; font-style: oblique; background-color: #C0C0C0" align="center">
Leave Information
</div>
<div align="center">

    <table class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                Employee ID</td>
            <td>
                <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                Leave ID</td>
            <td>
                <asp:TextBox ID="LeaveidTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                Leave Cetagory</td>
            <td>
                <asp:TextBox ID="leaveCetagoryTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td align="left">
                From Date</td>
            <td>
                <asp:TextBox ID="FromDateTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                To Date</td>
            <td>
                <asp:TextBox ID="ToDateTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="saveButton" runat="server" Text="Save" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</div>
</asp:Content>
