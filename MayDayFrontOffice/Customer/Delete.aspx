<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
        <asp:Label ID="lblDeleted" runat="server" Text="The Customer Has Now Been Deleted "></asp:Label>
    </h3>
    <p>
        <asp:Button ID="Button1" runat="server" Height="46px" OnClick="Button1_Click" Text="Back to Admin Home Page" Width="253px" />
&nbsp;</p>
</asp:Content>

