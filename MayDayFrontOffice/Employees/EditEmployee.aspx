<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditEmployee.aspx.cs" Inherits="EditEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        &nbsp;<br />
    </p>
 
    <asp:Label ID="lblUpdate" runat="server" style="z-index: 1; left: 696px; top: 222px; position: absolute; font-size: large" Text="Please update details:"></asp:Label>
    <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 428px; top: 270px; position: absolute" Text="Name:"></asp:Label>
    
    <asp:Label ID="lblContactNumber" runat="server" style="z-index: 1; left: 427px; top: 310px; position: absolute; bottom: 319px" Text="Contact number:"></asp:Label>
    
    <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 570px; top: 269px; position: absolute; width: 231px"></asp:TextBox>
    <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 567px; top: 379px; position: absolute" Width="170px"></asp:TextBox>
    
    <asp:TextBox ID="txtContactNumber" runat="server" style="z-index: 1; left: 570px; top: 308px; position: absolute; width: 176px"></asp:TextBox>
    <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 426px; top: 349px; position: absolute" Text="Address:"></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 568px; top: 346px; position: absolute; width: 331px"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 427px; top: 383px; position: absolute" Text="Role:"></asp:Label>
    
    <asp:TextBox ID="txtSalary" runat="server" style="z-index: 1; left: 566px; top: 415px; position: absolute"></asp:TextBox>
   
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 425px; top: 416px; position: absolute" Text="Salary:"></asp:Label>
    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" style="z-index: 1; left: 716px; top: 502px; position: absolute" Text="Update personal details" />

   
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 997px; top: 503px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
   
</asp:Content>

