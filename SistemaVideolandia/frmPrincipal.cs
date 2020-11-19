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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.MdiParent = this;
            funcionario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItens itens = new frmItens();
            itens.MdiParent = this;
            itens.Show();
        }
    }
}
