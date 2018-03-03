<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerHomepage.aspx.cs" Inherits="CustomerHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:Button ID="btnChangeLoginDetails" runat="server" Height="58px" Text="Change Login Details" Width="201px" OnClick="btnChangeLoginDetails_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnUpdateDetails" runat="server" Height="60px" Text="Update Details" Width="200px" OnClick="btnUpdateDetails_Click" />
</p>
    <p>
        <asp:Button ID="btnBacktoLoginPage" runat="server" Height="60px" Text="Back to Login Page" Width="200px" OnClick="btnBacktoHomePage_Click" />
    &nbsp;&nbsp;&nbsp;
    &nbsp;<br />
</p>
<p>
</p>
</asp:Content>

