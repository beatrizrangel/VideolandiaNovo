<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalhesArtista.aspx.cs" Inherits="WebUI.DetalhesArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <h2 style="margin-left: 40px"><asp:Label ID="Label1" runat="server" Text="Nomeartista"></asp:Label></h2>
    <center>
        <asp:Image ID="Image1" runat="server" Height="160px" Width="187px" />
        </center>
    <p style="margin-left: 80px">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
</p>
    </p>
</asp:Content>
