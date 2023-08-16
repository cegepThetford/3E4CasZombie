<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Attaquer.aspx.cs" Inherits="WebApplication1.Attaquer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h1>Attaquer!!</h1>
<h2>Type d'arme à utiliser:</h2>
    <asp:RadioButtonList ID="rblArmes" runat="server" Width="491px">
    </asp:RadioButtonList>

    <asp:Button ID="btnAttaquer" runat="server" onclick="btnAttaquer_Click" 
        Text="Attaquer!" />

</asp:Content>
