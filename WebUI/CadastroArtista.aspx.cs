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
    public partial class CadastroArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarArtistas();
            }
        }

        private void CarregarArtistas()
        {
            ArtistaDAL aDAL = new ArtistaDAL();
            grvArtista.DataSource = aDAL.ListarArtistas();
            grvArtista.DataBind();
        }



        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            Artistas objartista = new Artistas();
            objartista.Nome = txtNomeartista.Text;
            objartista.Paisnascimento = txtPaisartista.Text;
            objartista.Dtnascimento = Convert.ToDateTime(txtdtNascimentoartista.Text);

            ArtistaDAL aDAL = new ArtistaDAL();


            int codigoGerado = aDAL.InserirArtista(objartista);

            if (fuFotoArtista.HasFile)
            {
                string nomeArquivo = codigoGerado + ".jpg";
                string caminhoPasta = Server.MapPath(@"Fotos\Artistas\");
                fuFotoArtista.SaveAs(caminhoPasta + nomeArquivo);
            }
            LimparCampos();

            lblMensagem.Text = "Artista cadastrado(a) com sucesso.";

            CarregarArtistas();
        }
        private void LimparCampos()
        {
            txtCodigoartista.Text = string.Empty;
            txtNomeartista.Text = string.Empty;
            txtdtNascimentoartista.Text = string.Empty;
            txtPaisartista.Text = string.Empty;

            lblMensagem.Text = string.Empty;

        }
        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btnBuscarartista_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigoartista.Text);
            ArtistaDAL adal = new ArtistaDAL();

            Artistas objartista = adal.BuscarArtista(Codigo);

            if (objartista != null)
            {
                txtCodigoartista.Text = objartista.Codigo.ToString();
                txtNomeartista.Text = objartista.Nome;
                txtdtNascimentoartista.Text = objartista.Dtnascimento.ToString("d");
                txtPaisartista.Text = objartista.Paisnascimento;

            }
            else
            {
                lblMensagem.Text = "Artista não encontrado.";
                LimparCampos();
            }

        }

        private void BuscarArtista(int Codigo)
        {
            ArtistaDAL aDAL = new ArtistaDAL();

            Artistas objartista = aDAL.BuscarArtista(Codigo);

            if (objartista != null)
            {
                txtCodigoartista.Text = objartista.Codigo.ToString();
                txtNomeartista.Text = objartista.Nome;
                txtdtNascimentoartista.Text = objartista.Dtnascimento.ToString("d");
                txtPaisartista.Text = objartista.Paisnascimento;

            }
            else
            {
                lblMensagem.Text = "Artista não encontrado.";
                LimparCampos();
            }
        }

        private void ExcluirArtista(int Codigo)
        {
            ArtistaDAL aDAL = new ArtistaDAL();
            aDAL.ExcluirArtista(Codigo);

            CarregarArtistas();
        }

        protected void grvArtista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void grvArtista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            {
                string nomeComando = e.CommandName;
                int Codigo = Convert.ToInt32(e.CommandArgument);

                if (nomeComando == "Editar")
                {
                    BuscarArtista(Codigo);
                }
                else if (nomeComando == "Excluir")
                {
                    ExcluirArtista(Codigo);
                }
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Artistas objartista = new Artistas();
            objartista.Codigo = Convert.ToInt32(txtCodigoartista.Text);
            objartista.Nome = txtNomeartista.Text;
            objartista.Dtnascimento = Convert.ToDateTime(txtdtNascimentoartista.Text);
            objartista.Paisnascimento = txtPaisartista.Text;
            

            ArtistaDAL adal = new ArtistaDAL();
            adal.AlterarArtista(objartista);

            lblMensagem.Text = "Artista atualizado(a) com sucesso!";

            CarregarArtistas();
            LimparCampos();
        }
    }
}
