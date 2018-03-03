<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AEBookings.aspx.cs" Inherits="Bookings_AEBookings" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<br />
<asp:TextBox ID="txtFilterCust" runat="server" style="z-index: 1; left: 412px; top: 314px; position: absolute"></asp:TextBox>
<br />
<br />
<br />
<asp:ListBox ID="lstFlights" runat="server" style="z-index: 1; left: 709px; top: 352px; position: absolute; height: 103px; width: 258px; margin-top: 0px"></asp:ListBox>
<asp:ListBox ID="lstTourOps" runat="server" style="z-index: 1; left: 1003px; top: 345px; position: absolute; height: 111px; width: 283px"></asp:ListBox>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<asp:TextBox ID="txtFilterFlights" runat="server" style="z-index: 1; left: 724px; top: 317px; position: absolute"></asp:TextBox>
<asp:TextBox ID="txtFilterTourOps" runat="server" style="z-index: 1; left: 1007px; top: 307px; position: absolute; margin-bottom: 0px"></asp:TextBox>
    <asp:TextBox ID="txtPaymentType" runat="server" style="z-index: 1; left: 1414px; top: 539px; position: absolute"></asp:TextBox>
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 397px; top: 490px; position: absolute"></asp:Label>
<br />
<br />
<asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 511px; top: 541px; position: absolute; margin-bottom: 0px" Text="OK" OnClick="btnOK_Click" />
<asp:Label ID="lblDateBooked" runat="server" style="z-index: 1; left: 1322px; top: 481px; position: absolute" Text="DateBooked"></asp:Label>
<asp:Label ID="lblPaymentType" runat="server" style="z-index: 1; left: 1314px; top: 538px; position: absolute; width: 89px" Text="Payment Type"></asp:Label>
<asp:Label ID="lblAmount" runat="server" style="z-index: 1; left: 1343px; top: 422px; position: absolute" Text="Amount"></asp:Label>
<asp:Label ID="lblRef" runat="server" style="z-index: 1; left: 1340px; top: 366px; position: absolute" Text="Reference"></asp:Label>
<asp:Button ID="btnFilterCust" runat="server" style="z-index: 1; left: 553px; top: 311px; position: absolute; width: 106px" Text="Filter Customers" />
<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 1073px; top: 529px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
<asp:Button ID="btnFilterTourOps" runat="server" EnableViewState="False" style="z-index: 1; left: 1153px; top: 306px; position: absolute; width: 134px" Text="Filter Tour Operators" />
<asp:Button ID="btnFilterFlights" runat="server" style="z-index: 1; left: 869px; top: 314px; position: absolute" Text="Filter Flights" />
<br />
<asp:TextBox ID="txtRef" runat="server" style="z-index: 1; left: 1414px; top: 342px; position: absolute; margin-top: 23px"></asp:TextBox>
<asp:TextBox ID="txtDateBooked" runat="server" style="z-index: 1; left: 1416px; top: 478px; position: absolute"></asp:TextBox>
<asp:TextBox ID="txtAmmount" runat="server" style="z-index: 1; left: 1416px; top: 420px; position: absolute; margin-top: 0px"></asp:TextBox>
<br />
<asp:Label ID="lblTitle" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 911px; top: 242px; position: absolute; width: 255px" Text="New/Edit Booking" Font-Underline="True"></asp:Label>
<asp:ListBox ID="lstCust" runat="server" style="z-index: 1; left: 412px; top: 348px; position: absolute; height: 110px; width: 243px"></asp:ListBox>
</asp:Content>

