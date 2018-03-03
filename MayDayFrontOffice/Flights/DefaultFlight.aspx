<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DefaultFlight.aspx.cs" Inherits="DefaultFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblFlightHomePage" runat="server" style="z-index: 1; left: 842px; top: 217px; position: absolute; text-align: center; font-size: xx-large" Text="Flight Homepage"></asp:Label>
<br />
<br />
<br />
<asp:ListBox ID="lstFlights" runat="server" style="z-index: 1; left: 450px; top: 260px; position: absolute; height: 184px; width: 999px"></asp:ListBox>
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
<asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 672px; top: 472px; position: absolute; height: 22px;" Text="Search By Destination"></asp:Label>
<br />
    <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 1076px; top: 467px; position: absolute" Text="Apply" />
<br />
    <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 1141px; top: 467px; position: absolute" Text="Display All" />
<br />
<asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 815px; top: 469px; position: absolute; width: 241px; height: 17px; bottom: 194px"></asp:TextBox>
<br />
<br />
<asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 714px; top: 517px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click1" style="z-index: 1; left: 1174px; top: 523px; position: absolute; width: 55px;" Text="Delete" />
<br />
<asp:Button ID="btnUpdate" runat="server" style="z-index: 1; left: 943px; top: 518px; position: absolute" Text="Update" OnClick="btnUpdate_Click" />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 949px; top: 564px; position: absolute"></asp:Label>
<br />
</asp:Content>

