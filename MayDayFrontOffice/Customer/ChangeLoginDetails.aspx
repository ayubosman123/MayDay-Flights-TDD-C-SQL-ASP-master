<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangeLoginDetails.aspx.cs" Inherits="ChangeLoginDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <asp:Label ID="Label1" runat="server" Text="Old Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtOldpassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
    <asp:TextBox ID="txtNewpassword" runat="server"></asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Button ID="btnChange" runat="server" Text="Change" Width="111px" />
&nbsp;
    <asp:Button ID="btnbacktoCustomerhomepage" runat="server" OnClick="btnbacktoCustomerhomepage_Click" Text="Back to Customer Home Page" />
&nbsp;<asp:Button ID="btnBacktologinpage" runat="server" OnClick="btnBacktologinpage_Click" Text="Back to Login Page" />
</asp:Content>

