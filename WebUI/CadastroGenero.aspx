<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CadastroGenero.aspx.cs" Inherits="WebUI.CadastroGenero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <h2>Cadastro de gênero</h2>
    <asp:Label ID="Label1" runat="server" Text="Código:  "></asp:Label>
    <asp:TextBox ID="txtCodigogenero" runat="server" Width="148px"></asp:TextBox>
    
    <asp:Button ID="btnBuscargenero" runat="server" Text="buscar" Width="66px" OnClick="btnBuscargenero_Click" />
<p>
        <asp:Label ID="Label2" runat="server" Text="Nome:  "></asp:Label>
<asp:TextBox ID="txtNomegenero" runat="server" Width="231px"></asp:TextBox>
</p>
<p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</p>
    <p style="margin-left: 40px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Limpar" Width="94px" />
    <asp:Button ID="btnCadastrargenero" runat="server" Text="Salvar" Width="96px" OnClick="btnCadastrargenero_Click" />
         &nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 26px" Text="Alterar" Width="95px" />
&nbsp;<asp:GridView ID="grvGeneros" runat="server" Width="593px" Height="160px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCommand="grvGeneros_RowCommand" AutoGenerateColumns="False">
             <Columns>
                 <asp:BoundField DataField="Codigo" HeaderText="Código" />
                 <asp:BoundField DataField="Nome" HeaderText="Nome" />
                 <asp:TemplateField HeaderText="Editar">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnEditar" runat="server" Height="25px" ImageUrl="~/Imagens/edit.png" CommandName="Editar" CommandArgument='<%# Eval("Codigo") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Excluir">
                <ItemTemplate>
                    <asp:ImageButton ID="ibtnExcluir" runat="server" Height="25px" ImageUrl="~/Imagens/delete.png" CommandName="Excluir" CommandArgument='<%# Eval("Codigo") %>' OnClientClick="return confirm('Deseja excluir o item selecionado?');"  />
                </ItemTemplate>
            </asp:TemplateField>
             </Columns>
        </asp:GridView>
    </p>
  

       
   
</asp:Content>
