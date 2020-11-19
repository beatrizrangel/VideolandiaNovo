<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListagemArtista.aspx.cs" Inherits="WebUI.ListagemArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Resultados encontrados:</h2>Nome do artista ou país de nascimento :
    <asp:TextBox ID="TextBox1" runat="server" Width="306px"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="buscar" Width="90px" />
    </p>
    <p style="height: 201px; margin-left: 40px">
        <asp:GridView ID="GridView1" runat="server" Height="187px" style="margin-left: 0px" Width="620px">
        </asp:GridView>
    </p>
</asp:Content>
