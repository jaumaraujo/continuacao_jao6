using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotecoTDS07
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente encerrar o aplicativo ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); // 1 menssagem, 2 titulo, 3 botões, 4 icone
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja realmente encerrar o aplicativo ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); // 1 menssagem, 2 titulo, 3 botões, 4 icone
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxProdutos_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void pbxFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto produto = new FrmProduto();
            produto.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas venda = new FrmVendas();
            venda.Show();
        }

        private void pbxVenda_Click(object sender, EventArgs e)
        {
            FrmVendas venda = new FrmVendas();
            venda.Show();
        }
    }
}
