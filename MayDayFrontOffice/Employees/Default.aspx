<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   
    <asp:Label ID="lblLogin" runat="server" style="z-index: 1; left: 857px; top: 221px; position: absolute; width: 69px; font-size: 17pt; height: 30px" Text="Login"></asp:Label>
<asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 917px; top: 304px; position: absolute; width: 174px"></asp:TextBox>
  
     
      <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 918px; top: 345px; position: absolute; width: 174px" TextMode="Password"></asp:TextBox>

<asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 743px; top: 306px; position: absolute; font-size: 14pt" Text="Username:"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 742px; top: 346px; position: absolute; font-size: 14pt" Text="Password:"></asp:Label>
     
    <asp:Button ID="btnLogin" runat="server" style="z-index: 1; left: 860px; top: 410px; position: absolute; font-size: 12pt; height: 31px; width: 62px" Text="Login" OnClick="btnLogin_Click" />

    
<p>
   
</p>
     
</asp:Content>

