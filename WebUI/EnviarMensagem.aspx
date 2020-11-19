<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EnviarMensagem.aspx.cs" Inherits="WebUI.EnviarMensagem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #TextArea1 {
            height: 77px;
            width: 414px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <h2>Entre em contato conosco:</h2></p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="191px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; E-mail:
        <asp:TextBox ID="TextBox2" runat="server" Width="262px"></asp:TextBox>
    </p>
    <p>
        Assunto:
        <asp:TextBox ID="TextBox3" runat="server" Width="510px"></asp:TextBox>
    </p>
    <p>
        Mensagem:</p>
    <p>
        <textarea id="TextArea1" name="S1"></textarea></p>
    <p style="margin-left: 520px">
        <asp:Button ID="Button1" runat="server" Text="Enviar" Width="94px" />
    </p>
</asp:Content>
