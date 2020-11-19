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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarf_Click(object sender, EventArgs e)
        {
            Pessoa objfuncionario = new Pessoa();

            objfuncionario.Status = Convert.ToBoolean(chbStatusf.Checked);
            objfuncionario.Nome = txtNomef.Text;
            objfuncionario.Dtnascimento = dtNascimentof.Value;
            objfuncionario.Sexo = cmbSexof.Text;
            objfuncionario.EstadoCivil = cmbEstadocivilf.Text;
            objfuncionario.Rg = txtRgf.Text;
            objfuncionario.Cpf = txtCpff.Text;
            objfuncionario.Email = txtEmailf.Text;
            objfuncionario.Endereco = txtEnderecof.Text;
            objfuncionario.Cidade = txtCidadef.Text;
            objfuncionario.Cep = txtCepf.Text;
            objfuncionario.Estado = txtEstadof.Text;
            objfuncionario.Celular = txtCelularf.Text;
            objfuncionario.Telefone = txtTelefonef.Text;

            FuncionarioDAL fdal = new FuncionarioDAL();

            fdal.InserirFuncionario(objfuncionario);

            MessageBox.Show("Funcionário inserido com sucesso!");

            LimparCampos();

        }

        private void btnExcluirf_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtExcluirf.Text);

            FuncionarioDAL fundal = new FuncionarioDAL();
            fundal.ExcluirFuncionario(Codigo);


            MessageBox.Show("Funcionário excluido com sucesso.");
            LimparCampos();
        }

        private void btnAlterarf_Click(object sender, EventArgs e)
        {
            Pessoa objfuncionario = new Pessoa();

            objfuncionario.Codigo = Convert.ToInt32(txtExcluirf.Text);
            objfuncionario.Nome = txtNomef.Text;
            objfuncionario.Status = Convert.ToBoolean(chbStatusf.Checked);
            objfuncionario.Dtnascimento = Convert.ToDateTime(dtNascimentof.Value);
            objfuncionario.Sexo = cmbSexof.Text;
            objfuncionario.EstadoCivil = cmbSexof.Text;
            objfuncionario.Rg = txtRgf.Text;
            objfuncionario.Cpf = txtCpff.Text;
            objfuncionario.Email = txtEmailf.Text;
            objfuncionario.Endereco = txtEnderecof.Text;
            objfuncionario.Cidade = txtCidadef.Text;
            objfuncionario.Cep = txtCepf.Text;
            objfuncionario.Estado = txtEstadof.Text;
            objfuncionario.Celular = txtCelularf.Text;
            objfuncionario.Telefone = txtTelefonef.Text;

            FuncionarioDAL fdal = new FuncionarioDAL();
            fdal.AlterarFuncionario(objfuncionario);

            MessageBox.Show("Cadastro do funcionário atualizado com sucesso!");

            LimparCampos();
        }

        private void btnBuscarf_Click(object sender, EventArgs e)
        {
            string buscarf = txtBuscarf.Text;
            FuncionarioDAL fdal = new FuncionarioDAL();

            Pessoa objfuncionario = fdal.BuscarFuncionario(buscarf);

            if (objfuncionario != null)
            {
                txtExcluirf.Text = Convert.ToString(objfuncionario.Codigo);
                txtNomef.Text = objfuncionario.Nome;
                dtNascimentof.Value = objfuncionario.Dtnascimento;
                cmbSexof.Text = objfuncionario.Sexo;
                cmbEstadocivilf.Text = objfuncionario.EstadoCivil;
                txtRgf.Text = objfuncionario.Rg;
                txtCpff.Text = objfuncionario.Cpf;
                txtEmailf.Text = objfuncionario.Email;
                txtEnderecof.Text = objfuncionario.Endereco;
                txtCidadef.Text = objfuncionario.Cidade;
                txtCepf.Text = objfuncionario.Cep;
                txtEstadof.Text = objfuncionario.Estado;
                txtCelularf.Text = objfuncionario.Celular;
                txtTelefonef.Text = objfuncionario.Telefone;
              
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.");
                LimparCampos();
            }
        }

            private void LimparCampos()
            {
                txtNomef.Text = string.Empty;
                dtNascimentof.Value = DateTime.Now;
                cmbSexof.Text = string.Empty;
                cmbEstadocivilf.Text = string.Empty;
                txtRgf.Text = string.Empty;
                txtCpff.Text = string.Empty;
                txtEmailf.Text = string.Empty;
                txtEnderecof.Text = string.Empty;
                txtCidadef.Text = string.Empty;
                txtCepf.Text = string.Empty;
                txtEstadof.Text = string.Empty;
                txtCelularf.Text = string.Empty;
                txtTelefonef.Text = string.Empty;
            }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAL fdal = new FuncionarioDAL();

            dgvFuncionario.DataSource = fdal.ListarFuncionarios();



        }
    }
    }
    

