<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Bookings_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 406px; top: 291px; position: absolute; width: 187px"></asp:TextBox>
<asp:Button ID="btnFilter" runat="server" style="z-index: 1; left: 618px; top: 290px; position: absolute" Text="Filter" OnClick="btnFilter_Click" />
    <asp:TextBox ID="txtDate2" runat="server" style="z-index: 1; left: 953px; top: 293px; position: absolute">End Date</asp:TextBox>
    <asp:TextBox ID="txtDate1" runat="server" style="z-index: 1; left: 756px; top: 292px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnFDate" runat="server" OnClick="btnFDate_Click" style="z-index: 1; left: 1105px; top: 291px; position: absolute; margin-bottom: 0px" Text="Filter By Date" />
<br />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 911px; top: 545px; position: absolute" Font-Size="Large"></asp:Label>
    <asp:Label ID="lblDash" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 915px; top: 283px; position: absolute; width: 17px; height: 28px; right: 311px;" Text="-"></asp:Label>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:ListBox ID="lstBookings" runat="server" style="z-index: 1; left: 406px; top: 325px; position: absolute; height: 213px; width: 1135px; margin-bottom: 0px;"></asp:ListBox>
<asp:Button ID="btnNew" runat="server" OnClick="btnNew_Click" style="z-index: 1; left: 419px; top: 572px; position: absolute" Text="New Booking" />
<asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 1397px; top: 575px; position: absolute" Text="Cancel Booking" OnClick="btnDelete_Click" />
<asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 947px; top: 571px; position: absolute" Text="Update Booking" OnClick="btnEdit_Click" />
<asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 837px; top: 240px; position: absolute" Text="Bookings Home Page" Font-Underline="True"></asp:Label>
</asp:Content>

