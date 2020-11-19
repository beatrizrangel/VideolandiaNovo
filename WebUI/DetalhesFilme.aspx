<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DetalhesFilme.aspx.cs" Inherits="WebUI.DetalhesFilme1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Filme
            <asp:Label ID="Label1" runat="server" Text="(ano)"></asp:Label>
    </h2><center>
    <asp:Image ID="Image1" runat="server" Width="201px" />
        </center>
    <p style="margin-left: 40px">
        <asp:GridView ID="GridView1" runat="server" Width="248px">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" Width="246px">
        </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>

</asp:Content>
