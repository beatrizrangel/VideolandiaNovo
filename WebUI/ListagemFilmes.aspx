<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListagemFilmes.aspx.cs" Inherits="WebUI.DetalhesFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Resultado encontrados:</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Filme, artista ou gênero:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="318px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Buscar" Width="102px" />
    </p>
    <asp:GridView ID="GridView1" runat="server" Height="331px" Width="697px">
    </asp:GridView>
    </p>
</asp:Content>
