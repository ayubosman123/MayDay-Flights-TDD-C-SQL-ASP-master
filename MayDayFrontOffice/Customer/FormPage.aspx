<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FormPage.aspx.cs" Inherits="EditCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <p style="text-decoration: underline; " class="auto-style8">
                <strong>Form Page</strong></p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label1" runat="server" Text="Forename" CssClass="auto-style7"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="TextBox1" runat="server" Width="155px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label2" runat="server" Text="Surname" CssClass="auto-style7"></asp:Label>
    </strong>
    <span class="auto-style7"><strong>&nbsp;&nbsp; </strong> </span>
    <strong>
    <asp:TextBox ID="TextBox2" runat="server" Width="158px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label10" runat="server" Text="Date Of Birth" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="TextBox3" runat="server" Width="90px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label3" runat="server" Text="House/Flat Number" CssClass="auto-style7"></asp:Label>
    </strong>&nbsp;<strong><asp:TextBox ID="TextBox4" runat="server" Width="54px" CssClass="auto-style7"></asp:TextBox>
    <asp:Button ID="btnBacktoCustomerHomePage" runat="server" OnClick="btnBacktoCustomerHomePage_Click" style="position: relative; top: -106px; left: 256px; width: 292px; height: 27px" Text="Back to Customer Home Page" />
    <asp:Button ID="btnBackToAdminHomePage" runat="server" OnClick="btnBackToAdminHomePage_Click" Text="Back to Admin Home Page" style="margin-left: 146px; margin-bottom: 0px; position: absolute; top: 327px; left: 649px; width: 291px; height: 28px; margin-top: 0px;" />
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label4" runat="server" Text="Postcode" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="TextBox5" runat="server" Width="87px" CssClass="auto-style7"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBacktoLoginPage" runat="server" OnClick="btnBacktoLoginPage_Click" style="text-align: center; position: relative; top: -44px; left: 7px; width: 289px; margin-top: 0px; height: 29px;" Text="Back to Login Page " />
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label5" runat="server" Text="Gender" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>:&nbsp;&nbsp;&nbsp;
    </strong></span><strong>
    <asp:CheckBox ID="chkMale" runat="server" Text="Male" CssClass="auto-style7" />
    </strong><span class="auto-style7"><strong>&nbsp;&nbsp;&nbsp;&nbsp;
    </strong></span><strong>
    <asp:CheckBox ID="chkFemale" runat="server" Text="Female" CssClass="auto-style7" />
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label6" runat="server" Text="Contact Number" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;</strong></span><strong><asp:TextBox ID="TextBox6" runat="server" Width="161px" CssClass="auto-style7"></asp:TextBox>
    </strong>
</p>
<p style="font-size: large">
    <strong>
    <asp:Label ID="Label7" runat="server" Text="Email" CssClass="auto-style7"></asp:Label>
    </strong><span class="auto-style7"><strong>&nbsp;
    </strong></span><strong>
    <asp:TextBox ID="TextBox7" runat="server" Width="226px" CssClass="auto-style7"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnEnter" runat="server" Height="39px" OnClick="btnEnter_Click" Text="Enter" Width="176px" />
    </strong>
</p>
    <p style="font-size: large">
&nbsp;</p>
            <p style="font-size: large">
                &nbsp;</p>
<p style="font-size: large">
    &nbsp;</p>
<p style="font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>
<p style="text-decoration: underline; font-size: large">
    &nbsp;</p>

</asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            font-size: small;
        }
        .auto-style8 {
            font-size: medium;
            text-align: center;
        }
    </style>
</asp:Content>


