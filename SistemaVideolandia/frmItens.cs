using DAL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaVideolandia
{
    public partial class frmItens : Form
    {
        public frmItens()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
            GeneroDAL generoDAL = new GeneroDAL();

            dgvGeneros.DataSource = generoDAL.ListarGeneros();

            ArtistaDAL artistaDAL = new ArtistaDAL();

            dgvArtista.DataSource = artistaDAL.ListarArtistas();

            cmbGenerofilme.DataSource = generoDAL.ListarGeneros();

            cmbDiretorfilme.DataSource = artistaDAL.ListarArtistas();

            cmbAtorfilme1.DataSource = artistaDAL.ListarArtistas();
            cmbAtorfilme1.SelectedIndex = -1;

            cmbAtorfilme2.DataSource = artistaDAL.ListarArtistas();
            cmbAtorfilme2.SelectedIndex = -1;

            cmbAtorfilme3.DataSource = artistaDAL.ListarArtistas();
            cmbAtorfilme3.SelectedIndex = -1;
            cmbAtorfilme4.DataSource = artistaDAL.ListarArtistas();
            cmbAtorfilme4.SelectedIndex = -1;


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrargenero_Click(object sender, EventArgs e)
        {
            Generos objgeneros = new Generos();

            objgeneros.Nome = txtNomegenero.Text;

            GeneroDAL gDAL = new GeneroDAL();
            gDAL.InserirGenero(objgeneros);

            MessageBox.Show("Gênero inserido com sucesso!");

            txtNomegenero.Text = "";

            
        }

        private void btnBuscargenero_Click(object sender, EventArgs e)
        {
            string Nome = txtBuscargenero.Text;
            GeneroDAL gdal = new GeneroDAL();

            Generos objgenero = gdal.BuscarGenero(Nome);

            if (objgenero != null)
            {
                txtBuscargenero.Text = objgenero.Nome;
                txtNomegenero.Text = objgenero.Nome;
                txtCodigogenero.Text = Convert.ToString(objgenero.Codigo);

            }
            else
            {
                MessageBox.Show("Gênero não encontrado.");
                txtBuscargenero.Text = "";
            }

        
        }

        private void btnExcluirgenero_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigogenero.Text);

            GeneroDAL gdal = new GeneroDAL();
            gdal.ExcluirGenero(Codigo);


            MessageBox.Show("Gênero excluido com sucesso.");

            txtCodigogenero.Text = "";

        }

        private void btnAlterargenero_Click(object sender, EventArgs e)
        {
            Generos objgenero = new Generos();
            objgenero.Codigo = Convert.ToInt32(txtCodigogenero.Text);
            objgenero.Nome = txtNomegenero.Text;

            GeneroDAL gdal = new GeneroDAL();
            gdal.AlterarGenero(objgenero);

            MessageBox.Show("Carro atualizado com sucesso!");

            txtBuscargenero.Text = "";
            txtNomegenero.Text = "";


        }

        private void btnListargeneros_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
          

          
        }

        private void btnCadastrartista_Click(object sender, EventArgs e)
        {
            Artistas objartistas = new Artistas();

            objartistas.Nome = txtNomeartista.Text;
            objartistas.Paisnascimento = txtPaisartista.Text;
            objartistas.Dtnascimento = txtdtNascimentoartista.Value;
            objartistas.Urlfoto = picArtista.Text;

            ArtistaDAL aDAL = new ArtistaDAL();
            aDAL.InserirArtista(objartistas);

            MessageBox.Show("Artista inserido com sucesso!");

            Limpar();

            ArtistaDAL adal = new ArtistaDAL();
            
            cmbDiretorfilme.DataSource = aDAL.ListarArtistas();


        }

        private void Limpar()
        {
            txtNomeartista.Text = string.Empty;
            txtBuscartista.Text = string.Empty;
            txtPaisartista.Text = string.Empty;
            txtPaisartista.Text = string.Empty;
            txtdtNascimentoartista.Value = DateTime.Now;
            txtCbarrasfilme.Text = string.Empty;
            txtAnofilme.Text = string.Empty;
            txtCodigofilme.Text = string.Empty;
            txtPrecofilme.Text = string.Empty;
            txtTitulofilme.Text = string.Empty;
            txtValorcustofilme.Text = string.Empty;
            txtCodigoartista.Text = string.Empty;




        }

        private void btnExcluirartista_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigoartista.Text);

            ArtistaDAL gdal = new ArtistaDAL();
            gdal.ExcluirArtista(Codigo);


            MessageBox.Show("Artista excluido com sucesso.");

            Limpar();
        }

        private void btnBuscartista_Click(object sender, EventArgs e)
        {
            string Nome = txtBuscartista.Text;
            ArtistaDAL adal = new ArtistaDAL();

            Artistas objartista = adal.BuscarArtista(Nome);

            if (objartista != null)
            {
                txtNomeartista.Text = objartista.Nome;
                txtPaisartista.Text = objartista.Paisnascimento;
                txtdtNascimentoartista.Value = objartista.Dtnascimento;
                txtCodigoartista.Text = Convert.ToString(objartista.Codigo);

            }
            else
            {
                MessageBox.Show("Artista não encontrado.");
                Limpar();
            }

        }

        private void btnAlterartista_Click(object sender, EventArgs e)
        {
            Artistas objartista = new Artistas ();
            objartista.Codigo = Convert.ToInt32(txtCodigoartista.Text);
            objartista.Nome = txtNomeartista.Text;
            objartista.Paisnascimento = txtPaisartista.Text;
            objartista.Dtnascimento = txtdtNascimentoartista.Value;
            //inserir foto mais tarde
            objartista.Urlfoto = string.Empty;

            ArtistaDAL adal = new ArtistaDAL();
            adal.AlterarArtista(objartista);

            MessageBox.Show("Cadastro do artista atualizado com sucesso!");

            Limpar();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBuscarfilme_Click(object sender, EventArgs e)
        {
            string busca = txtBuscarfilme.Text;
            FilmeDAL fdal = new FilmeDAL();

            Filme objfilme = fdal.BuscarFilme(busca);

            if (objfilme != null)
            {
                txtCbarrasfilme.Text = Convert.ToString(objfilme.CdBarras);
                txtTitulofilme.Text = objfilme.Titulo;
                cmbGenerofilme.SelectedValue = objfilme.CodGenero;
                txtAnofilme.Text = Convert.ToString(objfilme.Ano);
                cmbTipofilme.Text = objfilme.Tipo;
                txtPrecofilme.Text = Convert.ToString(objfilme.Preco);
                cmbSituacaofilme.Text = objfilme.Situacao;
                dtAdquirido.Value = objfilme.dtAdquirido;
                txtValorcustofilme.Text = Convert.ToString(objfilme.Custo);
                cmbDiretorfilme.Text = Convert.ToString(objfilme.CodDiretor);
                cmbDiretorfilme.Text = Convert.ToString(objfilme.Ator);

                //inserir foto mais tarde.

            }
            else
            {
                MessageBox.Show("Filme não encontrado.");
                Limpar();
            }
        }

        private void txtCbarrasfilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarfilme_Click(object sender, EventArgs e)
        {
            Filme objfilme = new Filme();

            objfilme.CdBarras = txtCbarrasfilme.Text;
            objfilme.Titulo = txtTitulofilme.Text;
            objfilme.CodGenero = Convert.ToInt32(cmbGenerofilme.SelectedValue);
            objfilme.Ano = Convert.ToInt32(txtAnofilme.Text);
            objfilme.Tipo = cmbTipofilme.Text;
            objfilme.Preco = Convert.ToDecimal(txtPrecofilme.Text);
            objfilme.Situacao =  cmbSituacaofilme.Text;
            objfilme.dtAdquirido = dtAdquirido.Value;
            objfilme.Custo = Convert.ToDecimal(txtValorcustofilme.Text);
            objfilme.CodDiretor = Convert.ToInt32(cmbDiretorfilme.SelectedValue);

            objfilme.Atores = new List<FilmesArtistas>();

           // if (txtPersonagem1.Text)
            objfilme.Urlfoto = string.Empty;

            FilmeDAL fDAL = new FilmeDAL();
            fDAL.InserirFilme(objfilme);

            MessageBox.Show("Filme inserido com sucesso!");

            Limpar();

      }

        private void btnExcluirfilme_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigofilme.Text);

            FilmeDAL fdal = new FilmeDAL();
            fdal.ExcluirFilme(Codigo);


            MessageBox.Show("Filme excluido com sucesso.");

            Limpar();
        }

        private void btnAlterarfilme_Click(object sender, EventArgs e)
        {
            Filme objfilme = new Filme();
            objfilme.Codigo = Convert.ToInt32(txtCodigofilme.Text);
            objfilme.Titulo = txtTitulofilme.Text;
            objfilme.CodGenero = Convert.ToInt32(cmbGenerofilme.SelectedValue);
            objfilme.Ano = Convert.ToInt32(txtAnofilme.Text);
            objfilme.Tipo = cmbTipofilme.Text;
            objfilme.Preco = Convert.ToDecimal(txtPrecofilme.Text);
            objfilme.Situacao = cmbSituacaofilme.Text;
            objfilme.dtAdquirido = dtAdquirido.Value;
            objfilme.Custo = Convert.ToDecimal(txtValorcustofilme.Text);
            objfilme.CodDiretor = Convert.ToInt32(cmbDiretorfilme.Text);

            //inserir foto mais tarde
            objfilme.Urlfoto = string.Empty;

            FilmeDAL fdal = new FilmeDAL();
            fdal.AlterarFilme(objfilme);

            MessageBox.Show("Cadastro do filme atualizado com sucesso!");

            Limpar();
        }

        private void cmbTipofilme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
