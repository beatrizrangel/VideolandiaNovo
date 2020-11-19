<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadastroItens.aspx.cs" Inherits="WebUI.CadastroItens" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><h2>&nbsp;Cadastro de itens</h2>
    <p>Código:
        <asp:TextBox ID="txtCodigoFilme" runat="server" OnTextChanged="txtCodigoFilme_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnBuscarFilme" runat="server" Text="buscar" Width="66px" OnClick="btnBuscarFilme_Click" />
    </p>
    <asp:Label ID="Label1" runat="server" Text="Código de barras: "></asp:Label>
    <asp:TextBox ID="txtCbarrasFilme" runat="server" Width="225px"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Título: "></asp:Label>
        <asp:TextBox ID="txtTituloFilme" runat="server" Width="298px"></asp:TextBox>
    <p>Gêneros:
        </p>
    <p>1
        <asp:DropDownList ID="dpd1" runat="server" Height="18px" Width="206px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 2
        <asp:DropDownList ID="dpd2" runat="server" Height="20px" Width="213px">
        </asp:DropDownList>
&nbsp;&nbsp;
    </p>
    <p>
        Ano:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAnoFilme" runat="server" Width="92px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Preço:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPrecoFilme" runat="server" Width="134px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Tipo:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cmbTipoFilme" runat="server" Height="16px" Width="171px">
            <asp:ListItem Value="D">DVD</asp:ListItem>
            <asp:ListItem Value="B">BLU RAY</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Data adquirida:
        <asp:TextBox ID="dtAdquirido" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Valor de custo:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtValorcustoFilme" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Situação: "></asp:Label>
        <asp:DropDownList ID="cmbSituacaoFilme" runat="server" Width="163px">
            <asp:ListItem Value="L">LOCADO</asp:ListItem>
            <asp:ListItem Value="D">Disponível</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Atores participantes:</p>
    <p>
    &nbsp;<asp:DropDownList ID="cmbAtorfilme1" runat="server" Height="24px" Width="186px">
        </asp:DropDownList>
&nbsp;
        <asp:TextBox ID="txtPersonagem1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cmbAtorfilme2" runat="server" Width="174px">
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="txtPersonagem2" runat="server" Width="160px"></asp:TextBox>
    </p>
    <p>
        <asp:DropDownList ID="cmbAtorfilme3" runat="server" Height="24px" Width="186px">
        </asp:DropDownList>
&nbsp;
        <asp:TextBox ID="txtPersonagem3" runat="server"></asp:TextBox>

        <asp:DropDownList ID="cmbAtorfilme4" runat="server" Width="174px">
        </asp:DropDownList>
<asp:TextBox ID="txtPersonagem4" runat="server" Width="165px"></asp:TextBox>
    </p>
    <p>
        Diretor:<asp:DropDownList ID="cmbDiretorFilme" runat="server" Height="24px" Width="186px">
        </asp:DropDownList>
    </p>
    <p>
        &nbsp;Foto de capa:</p>
    <p>
   <asp:FileUpload runat="server" Width="301px" ID="fuFotoFilme" />
    </p>
    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
    <p style="margin-left: 200px">
        <asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="86px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Width="86px" />
&nbsp;
        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" Width="86px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>

    <p style="height: 394px; width: 673px">
        <asp:GridView ID="grvFilmes" runat="server" style="margin-left: 16px" Width="694px" Height="309px">
        </asp:GridView>
    </p>
</asp:Content>
