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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            List<Produto> produtos = produto.listaprodutos();
            dgvProduto.DataSource = produtos;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtTipo.Text == "")
            {
                MessageBox.Show("Não existe nenhum dado para cadastrar!");
                this.txtNome.Focus();
            }
            else
            {
                Produto produto = new Produto();
                if (produto.RegistroRepetido(txtNome.Text, txtTipo.Text) != false)
                {
                    MessageBox.Show("Este produto já existe em nossa base de dados!");
                    this.txtNome.Focus();
                    txtTipo.Text = "";
                }
                else
                {
                    int Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
                    produto.Inserir(txtNome.Text, txtTipo.Text, Quantidade, txtPreco.Text);
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    List<Produto> produtos = produto.listaprodutos();
                    dgvProduto.DataSource = produtos;
                    txtNome.Text = "";
                    txtTipo.Text = "";
                }


            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            int Quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
            Produto produto = new Produto();
            produto.Atualizar(Id, txtNome.Text, txtTipo.Text, Quantidade, txtPreco.Text);
            MessageBox.Show("Produto atualizado com sucesso!");
            List<Produto> produtos = produto.listaprodutos();
            dgvProduto.DataSource = produtos;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtID.Text = "";
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            Produto produto = new Produto();
            produto.Excluir(Id);
            MessageBox.Show("Produto excluído com sucesso!");
            List<Produto> pessoas = produto.listaprodutos();
            dgvProduto.DataSource = pessoas;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtID.Text = "";
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Por favor digite um ID!!!");
                this.txtID.Focus();
            }
            else
            {
                int Id = Convert.ToInt32(txtID.Text.Trim());
                Produto  produto = new Produto();
                produto.Localizar(Id);
                txtNome.Text = produto.nome;
                txtTipo.Text = produto.tipo;
                txtQuantidade.Text = produto.quantidade.ToString();
                txtPreco.Text = produto.preco.ToString();
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void dgvProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                row.Selected = true;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
