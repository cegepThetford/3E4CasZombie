<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Etat.aspx.cs" Inherits="WebApplication1.Etat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Créature: 
        <%= creature.GetType().Name %></h2>
    <h3>Points de vie: 
        <%= creature.NbPtsVie %></asp:Label>
    </h3>
</asp:Content>
