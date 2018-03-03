<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminHomepage.aspx.cs" Inherits="admin_customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2>
         <asp:Label ID="lblAdminHomePage" runat="server" style="text-decoration: underline" Text="Admin Home Page"></asp:Label>
     </h2>
     <br />
            <asp:ListBox ID="lstAddresses" runat="server" style="z-index: 1; height: 155px; width: 1090px; left: 382px; top: 246px; position: absolute;" OnSelectedIndexChanged="lstAddresses_SelectedIndexChanged"></asp:ListBox>
                        <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 88px; left: 845px; top: 524px; position: absolute;"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; width: 307px; left: 400px; top: 416px; position: absolute;" Text="Please Enter a Surname and Postcode"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 390px; top: 441px; position: absolute; margin-top: 1px;" Width="239px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 579px; top: 480px; position: absolute;" Text="Apply"  Height="27px" Width="162px" OnClick="btnApply_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" height="25px" style="z-index: 1; left: 389px; top: 483px; position: absolute;" Text="Display All"  Width="174px" OnClick="btnDisplayAll_Click"/>
            <br />
            <br />
     <asp:Button ID="btnAdd" runat="server" Height="30px" OnClick="btnAdd_Click1" Text="Add Customer" Width="115px" style="z-index: 1; left: 906px; top: 459px; position: absolute" />
           
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 1052px; top: 459px; position: absolute;" Text="Edit Customer" height="30px" width="115px" OnClick="btnEdit_Click1"  />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; right: 214px; left: 1181px; top: 459px; position: absolute;" Text="Delete Customer" height="30px" width="115px"/>
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <br />
     <asp:Button ID="btnBacktoHomePage" runat="server" Height="39px" Text="Back to Home Page" Width="159px" OnClick="btnBacktoHomePage_Click" style="z-index: 1; left: 825px; top: 558px; position: absolute" />
     
     &nbsp;

</asp:Content>

