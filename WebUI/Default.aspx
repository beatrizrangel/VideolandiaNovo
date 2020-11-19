<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Catálogo de filmes</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Filme, artista ou gênero:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="297px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="margin-left: 7px" Text="Buscar" Width="91px" />
    </p>
    <asp:GridView ID="GridView1" runat="server" Height="273px" Width="689px">
    </asp:GridView>
    </p>
</asp:Content>
