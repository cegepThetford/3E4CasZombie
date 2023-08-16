<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostAttaque.aspx.cs" Inherits="WebApplication1.PostAttaque" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>L'attaque du <%= creature.GetType().Name %></h2>
<% if (nbDommages == 0)
   {
     if(de.aManque()) { %>
     <p><b>avec un(e) <%= arme.Nom %> a complètement manqué la créature</b></p>

<% } else { %>
       <p><b>avec un(e) <%= arme.Nom %> n'a fait aucun dommage à la créature.</b></p>
    <% } 
   }
   else
   { %>
  <p><b>avec un(e) <%= arme.Nom %> a causé <%= nbDommages %> point(s) de dégâts</b></p>
<% } %>
<p><a href="/attaquer.aspx">Attaquer</a> de nouveau la créature.</p>
</asp:Content>
