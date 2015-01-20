<%@ Page Title="" Language="C#" MasterPageFile="~/MainLeaout.Master" AutoEventWireup="true" CodeBehind="EmployInfoEntry.aspx.cs" Inherits="HR.EmployInfoEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript" >
    function out() {
        var id = document.getElementById("ContentPlaceHolder1_TextBoxEployID").value;
        var firstName = document.getElementById("ContentPlaceHolder1_TextBoxFirstName").value;
        if (id.length == 0) {
            alert("please entry employee id");

        }
        else {
            alert("ok");

        }
        if (firstName == "") {
            alert("please entry First name");

        }




    }

</script>



    <style type="text/css">
    .style1
    {
        width: 80%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="background-color: #2D3E5B; color: #FFFFFF; font-size: x-large" 
        align="center">
Employee Information
</div>

    <div style="border: medium inset #C0C0C0">

    <table class="style1">
        <tr>
            <td>
                EmployID</td>
            <td>
                <asp:TextBox ID="TextBoxEployID" runat="server" AutoPostBack="True" 
                    ontextchanged="TextBoxEployID_TextChanged"></asp:TextBox>
            </td>
            <td colspan="2">
                First Name</td>
            <td>
                <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Last Name</td>
            <td>
                <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">
                Father&#39;s Name</td>
            <td>
                <asp:TextBox ID="TextBoxFatherName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Mother Name</td>
            <td>
                <asp:TextBox ID="TextBoxMotherName" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">
                Birth Date</td>
            <td>
                <asp:TextBox ID="TextBoxBirthDate" runat="server" 
                    TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Gender</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonListGender" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td colspan="2">
                Permanent Address</td>
            <td>
                <asp:TextBox ID="TextBoxPermanentAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Permanet Police Staton ID</td>
            <td>
                <asp:DropDownList ID="DropDownListPSID" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                Nationality</td>
            <td>
                <asp:TextBox ID="TextBoxNtionality" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="Save" 
                    onclick="ButtonSave_Click"  OnclientClick="javascript:out();" />
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
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
<div style="background-color: #FFFFFF; color: #008000" align="center">
<asp:Literal ID="LiteralMassege" runat="server"></asp:Literal>
</div>
</asp:Content>
