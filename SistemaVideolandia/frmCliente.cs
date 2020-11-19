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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ClienteDAL cdal = new ClienteDAL();
            dgvCliente.DataSource = cdal.ListarClientes();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarc_Click(object sender, EventArgs e)
        {
          
                string buscar = txtBuscarc.Text;
                ClienteDAL cdal = new ClienteDAL();

                Pessoa objcliente = cdal.BuscarCliente(buscar);

                if (objcliente != null)
                {
                    txtExcluirc.Text = Convert.ToString(objcliente.Codigo);
                    txtNomec.Text = objcliente.Nome;
                    dtNascimentoc.Value = objcliente.Dtnascimento;
                    cmbSexoc.Text = objcliente.Sexo;
                    cmbEstadocivilc.Text = objcliente.EstadoCivil;
                    txtRgc.Text = objcliente.Rg;
                    txtCpfc.Text = objcliente.Cpf;
                    txtEmailc.Text = objcliente.Email;
                    txtEnderecoc.Text = objcliente.Endereco;
                    txtCidadec.Text = objcliente.Cidade;
                    txtCepc.Text = objcliente.Cep;
                    txtEstadoc.Text = objcliente.Estado;
                    txtCelularc.Text = objcliente.Celular;
                    txtTelefonec.Text = objcliente.Telefone;

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.");
                    LimparCampos();
                }
            }
            private void LimparCampos()
        {
            txtNomec.Text = string.Empty;
            dtNascimentoc.Value = DateTime.Now;
            cmbSexoc.Text = string.Empty;
            cmbEstadocivilc.Text = string.Empty;
            txtRgc.Text = string.Empty;
            txtCpfc.Text = string.Empty;
            txtEmailc.Text = string.Empty;
            txtEnderecoc.Text = string.Empty;
            txtCidadec.Text = string.Empty;
            txtCepc.Text = string.Empty;
            txtEstadoc.Text = string.Empty;
            txtCelularc.Text = string.Empty;
            txtTelefonec.Text = string.Empty;
            txtExcluirc.Text = string.Empty;
            txtBuscarc.Text = string.Empty;

        }

        private void btnCadastrarc_Click(object sender, EventArgs e)
        {
            Pessoa objcliente = new Pessoa();

            objcliente.Status = Convert.ToBoolean(chbStatusc.Checked);
            objcliente.Nome = txtNomec.Text;
            objcliente.Dtnascimento = dtNascimentoc.Value;
            objcliente.Sexo = cmbSexoc.Text;
            objcliente.EstadoCivil = cmbEstadocivilc.Text;
            objcliente.Rg = txtRgc.Text;
            objcliente.Cpf = txtCpfc.Text;
            objcliente.Email = txtEmailc.Text;
            objcliente.Endereco = txtEnderecoc.Text;
            objcliente.Cidade = txtCidadec.Text;
            objcliente.Cep = txtCepc.Text;
            objcliente.Estado = txtEstadoc.Text;
            objcliente.Celular = txtCelularc.Text;
            objcliente.Telefone = txtTelefonec.Text;

            ClienteDAL cdal = new ClienteDAL();

            cdal.InserirCliente(objcliente);

            MessageBox.Show("Cliente inserido com sucesso!");

            LimparCampos();
        }

        private void btnExcluirc_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtExcluirc.Text);

            ClienteDAL cdal = new ClienteDAL();
            cdal.ExcluirCliente(Codigo);


            MessageBox.Show("Cliente excluido com sucesso.");
            LimparCampos();
        }

        private void btnAlterarc_Click(object sender, EventArgs e)
        {
            Pessoa objCliente = new Pessoa();

            objCliente.Codigo = Convert.ToInt32(txtExcluirc.Text);
            objCliente.Nome = txtNomec.Text;
            objCliente.Status = Convert.ToBoolean(chbStatusc.Checked);
            objCliente.Dtnascimento = Convert.ToDateTime(dtNascimentoc.Value);
            objCliente.Sexo = cmbSexoc.Text;
            objCliente.EstadoCivil = cmbSexoc.Text;
            objCliente.Rg = txtRgc.Text;
            objCliente.Cpf = txtCpfc.Text;
            objCliente.Email = txtEmailc.Text;
            objCliente.Endereco = txtEnderecoc.Text;
            objCliente.Cidade = txtCidadec.Text;
            objCliente.Cep = txtCepc.Text;
            objCliente.Estado = txtEstadoc.Text;
            objCliente.Celular = txtCelularc.Text;
            objCliente.Telefone = txtTelefonec.Text;
      

            ClienteDAL cdal = new ClienteDAL();
            cdal.AlterarCliente(objCliente);

            MessageBox.Show("Cadastro do funcionário atualizado com sucesso!");

            LimparCampos();
        }
    }
 }
