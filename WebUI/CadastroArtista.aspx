<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadastroArtista.aspx.cs" Inherits="WebUI.CadastroArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Cadastro de artista</h2>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Código: "></asp:Label>
&nbsp;<asp:TextBox ID="txtCodigoartista" runat="server" Width="121px"></asp:TextBox>
&nbsp;
        <asp:Button ID="btnBuscarartista" runat="server" Text="Buscar" Width="72px" OnClick="btnBuscarartista_Click" />
        </p>
    <asp:Label ID="Label1" runat="server" Text="Nome:  "></asp:Label>
    <asp:TextBox ID="txtNomeartista" runat="server" Width="212px"></asp:TextBox>
&nbsp;&nbsp; Data de nascimento:&nbsp;
    <asp:TextBox ID="txtdtNascimentoartista" runat="server" Width="204px"></asp:TextBox>
    <p>
        <asp:Label ID="Label2" runat="server" Text="País de nascimento:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtPaisartista" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Foto do artista:
        <asp:FileUpload ID="fuFotoArtista" runat="server" Width="245px" />
    &nbsp;
    </p>
    <p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" Width="84px" OnClick="btnAtualizar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnLimpar" runat="server" Text="Limpar" Width="92px" OnClick="btnLimpar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" Width="97px" OnClick="btnCadastrar_Click" />
    </p>
    <p>
        <asp:GridView ID="grvArtista" runat="server" style="margin-left: 11px" Width="669px" AutoGenerateColumns="False" Height="179px" OnRowCommand="grvArtista_RowCommand" OnSelectedIndexChanged="grvArtista_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Codigo" HeaderText="Código" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" />
                <asp:BoundField DataField="Dtnascimento" HeaderText="Dt de nascimento" />
                <asp:BoundField DataField="Paisnascimento" HeaderText="País de nascimento" />
                
            <asp:ImageField DataImageUrlField="Codigo" DataImageUrlFormatString="Fotos/Artistas/{0}.jpg" HeaderText="Foto">
                <ControlStyle Height="50px" />
            </asp:ImageField>
               <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnEditar" runat="server" Height="25px" ImageUrl="~/Imagens/edit.png" CommandName="Editar" CommandArgument='<%# Eval("Codigo") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnExcluir" runat="server" Height="25px" ImageUrl="~/Imagens/delete.png" CommandName="Excluir" CommandArgument='<%# Eval("Codigo") %>' OnClientClick="return confirm('Deseja excluir o artista selecionado?');"  />
                </ItemTemplate>
            </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>

</asp:Content>
