<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ViewDetails.aspx.cs" Inherits="ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="height: 397px">
        <br />
        <asp:Label ID="lblCurrentDetails" runat="server" style="font-size: large; z-index: 1; left: 907px; top: 227px; position: absolute" Text="Current Details:"></asp:Label>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 555px; top: 279px; position: absolute" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" MaxLength="50" ReadOnly="True" style="z-index: 1; left: 633px; top: 278px; position: absolute; width: 228px; right: 695px" ViewStateMode="Enabled">Vinay Kumar</asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 554px; top: 316px; position: absolute" Text="Address:"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" MaxLength="100" ReadOnly="True" style="z-index: 1; left: 631px; top: 314px; position: absolute; width: 321px">43 Washington Street, Leicester, LE6 3YT</asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 555px; top: 352px; position: absolute" Text="Contact number:"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server" ReadOnly="True" style="z-index: 1; left: 674px; top: 352px; position: absolute; width: 193px" TextMode="Number">07888888888</asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 557px; top: 385px; position: absolute" Text="Email:"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True" style="z-index: 1; left: 618px; top: 383px; position: absolute; width: 229px" TextMode="Email">v.kumar@mayday.co.uk</asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 557px; top: 418px; position: absolute" Text="Join Date:"></asp:Label>
        <asp:TextBox ID="txtJoinDate" runat="server" ReadOnly="True" style="z-index: 1; left: 640px; top: 418px; position: absolute; width: 161px" TextMode="Date">10/10/2005</asp:TextBox>
        <asp:Label ID="lblSalary" runat="server" style="z-index: 1; left: 557px; top: 450px; position: absolute" Text="Salary(£):"></asp:Label>
        <asp:TextBox ID="txtSalary" runat="server" OnTextChanged="txtSalary_TextChanged" ReadOnly="True" style="z-index: 1; left: 635px; top: 450px; position: absolute" TextMode="Number">18000</asp:TextBox>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 558px; top: 480px; position: absolute" Text="Role:"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" ReadOnly="True" style="z-index: 1; left: 611px; top: 479px; position: absolute">Accountant</asp:TextBox>
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 877px; top: 518px; position: absolute" Text="Back" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 989px; top: 517px; position: absolute" Text="Edit details" />
    </p>
    <br />
</asp:Content>

