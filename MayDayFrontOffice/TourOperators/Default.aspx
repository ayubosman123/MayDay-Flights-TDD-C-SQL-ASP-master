<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="position: relative; top: 240px; left: 275px" Text="Add" />
    <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" style="position: absolute; z-index: 1; left: 760px; top: 257px" Text="Tour Operators Home Page"></asp:Label>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="position: relative; top: 244px; left: 444px" Text="Edit" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="position: relative; top: 244px; left: 649px" Text="Delete" />
    <asp:Button ID="Button4" runat="server" style="position: relative; top: 306px; left: 354px" Text="Home" OnClick="Button4_Click" />
</asp:Content>

