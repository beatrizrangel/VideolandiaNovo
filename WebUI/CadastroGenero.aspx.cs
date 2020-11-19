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
    public partial class CadastroGenero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarGeneros();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        protected void btnBuscargenero_Click(object sender, EventArgs e)
        {
            int Codigo  = Convert.ToInt32(txtCodigogenero.Text);
            GeneroDAL gdal = new GeneroDAL();

            Generos objgenero = gdal.BuscarGenero(Codigo);

            if (objgenero != null)
            {
                txtNomegenero.Text = objgenero.Nome;
                txtCodigogenero.Text = Convert.ToString(objgenero.Codigo);

            }
            else
            {
                lblMensagem.Text = "Gênero não encontrado.";
                LimparCampos();
            }

        }

        private void LimparCampos()
        {
            txtCodigogenero.Text = string.Empty;
            txtNomegenero.Text = string.Empty;

        }

        protected void btnCadastrargenero_Click(object sender, EventArgs e)
        {
            Generos objgenero = new Generos();
            objgenero.Nome = txtNomegenero.Text;

            GeneroDAL gDAL = new GeneroDAL();
            gDAL.InserirGenero(objgenero);


            lblMensagem.Text = "Gênero cadastrado com sucesso.";
            LimparCampos();
            CarregarGeneros();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CarregarGeneros()
        {
            GeneroDAL gDAL = new GeneroDAL();
            grvGeneros.DataSource = gDAL.ListarGeneros();
            grvGeneros.DataBind();
        }

        public void BuscarGenero(int Codigo)
        {
            GeneroDAL gdal = new GeneroDAL();

            Generos objgenero = gdal.BuscarGenero(Codigo);

            if (objgenero != null)
            {
                txtNomegenero.Text = objgenero.Nome;
                txtCodigogenero.Text = Convert.ToString(objgenero.Codigo);

            }
            else
            {
                lblMensagem.Text = "Gênero não encontrado.";
                LimparCampos();
            }
        }

        private void ExcluirGenero(int Codigo)
        {
            GeneroDAL gDAL = new GeneroDAL();
            gDAL.ExcluirGenero(Codigo);

            CarregarGeneros();
        }

        protected void grvGeneros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string nomeComando = e.CommandName;
            int Codigo = Convert.ToInt32(e.CommandArgument);

            if (nomeComando == "Editar")
            {
                BuscarGenero(Codigo);
            }
            else if (nomeComando == "Excluir")
            {
                ExcluirGenero(Codigo);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Generos objgenero = new Generos();
            objgenero.Codigo = Convert.ToInt32(txtCodigogenero.Text);
            objgenero.Nome = txtNomegenero.Text;

            GeneroDAL gdal = new GeneroDAL();
            gdal.AlterarGenero(objgenero);

          lblMensagem.Text = "Genero atualizado com sucesso!";

            CarregarGeneros();
            LimparCampos();
        }
    }
}