<%@ Page Title="" Language="C#" MasterPageFile="~/MainLeaout.Master" AutoEventWireup="true" CodeBehind="EmployeeInfoDetail.aspx.cs" Inherits="HR.EmployeeInfoDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="background-color: #35496A; width: auto; height: auto; font-size: x-large; color: #FFFFFF" 
        align="center">
  Employee Detail Information
</div>
<div align="center" style="border: medium inset #C0C0C0" >

    <table class="style1">
        <tr>
            <td align="left">
                EmpolyeeID</td>
            <td>
                <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left">
                Religion</td>
            <td>
                <asp:DropDownList ID="ReligionDropDownList" runat="server" Width="128px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Islam</asp:ListItem>
                    <asp:ListItem>Hindu</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="left">
                Marital Status</td>
            <td>
                <asp:RadioButtonList ID="MaritalStatusRadioButtonList" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Married</asp:ListItem>
                    <asp:ListItem>UnMarried</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td align="left">
                Present Address</td>
            <td>
                <asp:TextBox ID="PresentAddressTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left">
                Designation</td>
            <td>
                <asp:DropDownList ID="DesignationDropDownList" runat="server" Width="128px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>Officer</asp:ListItem>
                    <asp:ListItem>Director</asp:ListItem>
                    <asp:ListItem>GM</asp:ListItem>
                    <asp:ListItem>Manager</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="left">
                Join Date</td>
            <td>
                <asp:TextBox ID="JoinDateTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="left">
                Department ID</td>
            <td>
                <asp:DropDownList ID="DepermentIDDropDownList" runat="server" Width="128px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="left">
                PresentPSID</td>
            <td>
                <asp:DropDownList ID="PSIDDropDownList" runat="server" Width="128px">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SaveButton" runat="server" Text="Save" 
                    onclick="SaveButton_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Literal ID="MassageLiteral" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>

</div>
</asp:Content>
