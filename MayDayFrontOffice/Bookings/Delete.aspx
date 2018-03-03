<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Bookings_Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 920px; top: 436px; position: absolute"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 842px; top: 389px; position: absolute; height: 26px" Text="Booking to be canceled"></asp:Label>
<asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 870px; top: 245px; position: absolute; height: 35px; width: 220px" Text="Cancel Booking" Font-Underline="True"></asp:Label>
<asp:TextBox ID="txtBookRef" runat="server" style="z-index: 1; left: 994px; top: 390px; position: absolute"></asp:TextBox>
<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 729px; top: 510px; position: absolute" Text="OK" OnClick="btnOK_Click" />
<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1096px; top: 514px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>

