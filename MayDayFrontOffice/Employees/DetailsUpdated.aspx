<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DetailsUpdated.aspx.cs" Inherits="DetailsUpdated" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style7 {
            position: absolute;
            top: 237px;
            left: 817px;
            z-index: 1;
            font-size: x-large;
        }
        .auto-style8 {
            position: absolute;
            top: 425px;
            left: 849px;
            z-index: 1;
            font-size: medium;
            width: 93px;
            right: 568px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br /><br /><br /><br /><br /><br /><br />
        <asp:Label ID="lblUpdated" runat="server" CssClass="auto-style7" Text="Details updated!"></asp:Label>
        <asp:Button ID="btnBack" runat="server" CssClass="auto-style8" OnClick="btnBack_Click" Text="Back" />
        <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />

    </p>
</asp:Content>

