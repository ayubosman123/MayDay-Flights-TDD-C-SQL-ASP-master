<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EmployeeMenu.aspx.cs" Inherits="EmployeeMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblWelcome" runat="server" style="z-index: 1; left: 924px; top: 221px; position: absolute; font-size: 20pt" Text="Welcome"></asp:Label>
    </p>
    <br />
    <br />
    <br />
    <br />
    <br />
    <a href="EditEmployee.aspx"><asp:Label ID="lblEdit" runat="server" style="font-size: 15pt" Text="Edit personal details" CssClass="auto-style7"></asp:Label> </a>
    <a href="ViewDetails.aspx"><asp:Label ID="lblViewPersonalDetails" runat="server" style="font-size: 15pt" Text="View personal details" CssClass="auto-style8"></asp:Label></a>
    <br />
    <br />
    <a href="Default.aspx">. <asp:Label ID="lblLogOut" runat="server" style="font-size: 15pt" Text="Log out" CssClass="auto-style9"></asp:Label> </a>
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
    </asp:Content>

<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style7 {
            z-index: 1;
            left: 898px;
            top: 296px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 894px;
            top: 341px;
            position: absolute;
        }
        .auto-style9 {
            z-index: 1;
            left: 950px;
            top: 386px;
            position: absolute;
        }
    </style>
</asp:Content>


