<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddFlight.aspx.cs" Inherits="AddFlight" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblFlightNo" runat="server" style="z-index: 1; left: 372px; top: 260px; position: absolute" Text="FlightNo"></asp:Label>
    <asp:TextBox ID="txtFlightNo" runat="server" style="z-index: 1; left: 487px; top: 259px; position: absolute; width: 105px"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtAirline" runat="server" style="z-index: 1; left: 487px; top: 292px; position: absolute; width: 105px; right: 499px"></asp:TextBox>
    <asp:TextBox ID="txtDestination" runat="server" style="z-index: 1; left: 487px; top: 327px; position: absolute; width: 105px"></asp:TextBox>
    <br />
    <asp:Label ID="lblAirline" runat="server" style="z-index: 1; left: 374px; top: 296px; position: absolute; right: -692px" Text="Airline"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblDestination" runat="server" style="z-index: 1; left: 374px; top: 328px; position: absolute; width: 65px; height: 3px;" Text="Destination"></asp:Label>
    <asp:Button ID="btnReturn" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 718px; top: 343px; position: absolute" Text="Return to Homepage" />
    <br />
    <br />
    <asp:Label ID="lblArrival" runat="server" style="z-index: 1; left: 374px; top: 364px; position: absolute" Text="Arrival"></asp:Label>
    <asp:TextBox ID="txtArrival" runat="server" style="z-index: 1; left: 488px; top: 364px; position: absolute; width: 105px"></asp:TextBox>
    <br />
    <asp:TextBox ID="txtArrivalTime" runat="server" style="z-index: 1; left: 489px; top: 396px; position: absolute; width: 105px"></asp:TextBox>
    <br />
    <asp:Label ID="lblArrivalTime" runat="server" style="z-index: 1; left: 373px; top: 396px; position: absolute; right: -1352px" Text="Arrival Airport"></asp:Label>
    <br />
    <asp:TextBox ID="txtDeparture" runat="server" style="z-index: 1; left: 490px; top: 428px; position: absolute; width: 105px; margin-bottom: 0px"></asp:TextBox>
    <br />
    <asp:Label ID="lblDeparture" runat="server" style="z-index: 1; left: 374px; top: 432px; position: absolute" Text="Departure "></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblDepartureAirport" runat="server" style="z-index: 1; left: 372px; top: 467px; position: absolute; right: -1246px" Text="Departure Airport"></asp:Label>
    <asp:TextBox ID="txtDepartureTime" runat="server" style="z-index: 1; left: 490px; top: 464px; position: absolute; width: 105px;"></asp:TextBox>
    <br />
    <br />
<asp:Label ID="Label1" runat="server" style="z-index: 1; left: 375px; top: 525px; position: absolute" Text="lblError"></asp:Label>
    <br />
    <asp:Label ID="lblActiveFlight" runat="server" style="z-index: 1; left: 373px; top: 496px; position: absolute" Text="Active Flight"></asp:Label>
    <asp:CheckBox ID="chkActiveFlight" runat="server" style="z-index: 1; left: 497px; top: 496px; position: absolute" />
<asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 548px; top: 550px; position: absolute; right: 877px" Text="Cancel" />
<asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 388px; top: 555px; position: absolute; " Text="OK" />
<br />
    <br />
</asp:Content>

