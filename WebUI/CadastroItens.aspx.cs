using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
using DAL;

namespace WebUI
{
    public partial class CadastroItens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarFilmes();
            }
        }

        private void CarregarFilmes()
        {
            FilmeDAL fDAL = new FilmeDAL();
            grvFilmes.DataSource = fDAL.ListarFilmes();
            grvFilmes.DataBind();
        }

        protected void btnBuscarFilme_Click(object sender, EventArgs e)
        {
            //string busca = txtCodigoFilme.Text;
            //FilmeDAL fdal = new FilmeDAL();

            //Filme objfilme = fdal.BuscarFilme(busca);

            //if (objfilme != null)
            //{
            //    txtCbarrasfilme.Text = Convert.ToString(objfilme.CdBarras);
            //    txtTitulofilme.Text = objfilme.Titulo;
            //    cmbGenerofilme.SelectedValue = objfilme.CodGenero;
            //    txtAnofilme.Text = Convert.ToString(objfilme.Ano);
            //    cmbTipofilme.Text = objfilme.Tipo;
            //    txtPrecofilme.Text = Convert.ToString(objfilme.Preco);
            //    cmbSituacaofilme.Text = objfilme.Situacao;
            //    dtAdquirido.Value = objfilme.dtAdquirido;
            //    txtValorcustofilme.Text = Convert.ToString(objfilme.Custo);
            //    cmbDiretorfilme.Text = Convert.ToString(objfilme.CodDiretor);
            //    cmbDiretorfilme.Text = Convert.ToString(objfilme.Ator);
            //}
        }

        protected void txtCodigoFilme_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Filme objfilme = new Filme();
            objfilme.CdBarras = txtCbarrasFilme.Text;
            objfilme.Titulo = txtTituloFilme.Text;
            objfilme.CodGenero1 = Convert.ToChar(dpd1.SelectedValue);
            objfilme.CodGenero2 = Convert.ToChar(dpd2.SelectedValue);
            objfilme.Ano = Convert.ToInt32(txtAnoFilme.Text);
            objfilme.Preco = Convert.ToDecimal(txtPrecoFilme.Text);
            objfilme.dtAdquirido = Convert.ToDateTime(dtAdquirido.Text);
            objfilme.Custo = Convert.ToDecimal(txtValorcustoFilme.Text);

            objfilme.Generos = new List<Generos>();

            FilmeDAL fDAL = new FilmeDAL();


            int codigoGerado = fDAL.InserirFilme(objfilme);

            if (fuFotoFilme.HasFile)
            {
                string nomeArquivo = codigoGerado + ".jpg";
                string caminhoPasta = Server.MapPath(@"Fotos\Filmes\");
                fuFotoFilme.SaveAs(caminhoPasta + nomeArquivo);
            }


            lblMensagem.Text = "Item cadastrado(a) com sucesso.";

            CarregarFilmes();
        }
    }
}