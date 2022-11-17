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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> funcionarios = funcionario.listafuncionarios();
            dgvFuncionario.DataSource = funcionarios;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtCPF.Text == "" && txtConta.Text == "")
            {
                MessageBox.Show("Não existe nenhum dado para cadastrar!");
                this.txtNome.Focus();
            }
            else
            {
                Funcionario funcionario = new Funcionario();
                if (funcionario.RegistroRepetido(txtNome.Text, txtCPF.Text, txtConta.Text) != false)
                {
                    MessageBox.Show("Este funcionário já existe em nossa base de dados!");
                    this.txtNome.Focus();
                    txtCPF.Text = "";
                    txtConta.Text = "";
                }
                else
                {
                    funcionario.Inserir(txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtConta.Text, txtPIX.Text, txtGenero.Text, txtData.Text, txtFuncao.Text);
                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                    List<Funcionario> funcionarios = funcionario.listafuncionarios();
                    dgvFuncionario.DataSource = funcionarios;
                    txtNome.Text = "";
                    txtCelular.Text = "";
                    txtEndereco.Text = "";
                    txtComplemento.Text = "";
                    txtCidade.Text = "";
                    txtCEP.Text = "";
                    txtCPF.Text = "";
                    txtConta.Text = "";
                    txtPIX.Text = "";
                    txtGenero.Text = "";
                    txtData.Text = "";
                    txtFuncao.Text = "";

                }


            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            Funcionario funcionario = new Funcionario();
            funcionario.Atualizar(Id, txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtConta.Text, txtPIX.Text, txtGenero.Text, txtData.Text, txtFuncao.Text);
            MessageBox.Show("Funcionário atualizado com sucesso!");
            List<Funcionario> funcionarios = funcionario.listafuncionarios();
            dgvFuncionario.DataSource = funcionarios;
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEndereco.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtCEP.Text = "";
            txtCPF.Text = "";
            txtConta.Text = "";
            txtPIX.Text = "";
            txtGenero.Text = "";
            txtData.Text = "";
            txtFuncao.Text = "";
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            Funcionario funcionario = new Funcionario();
            funcionario.Excluir(Id);
            MessageBox.Show("Funcionário excluído com sucesso!");
            List<Funcionario> funcionarios = funcionario.listafuncionarios();
            dgvFuncionario.DataSource = funcionarios;
            txtNome.Text = "";
            txtCPF.Text = "";
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
                Funcionario funcionario = new Funcionario();
                funcionario.Localizar(Id);
                txtNome.Text = funcionario.nome;
                txtCelular.Text = funcionario.celular;
                txtEndereco.Text = funcionario.endereco;
                txtComplemento.Text = funcionario.complemento;
                txtCidade.Text = funcionario.cidade;
                txtCEP.Text = funcionario.cep;
                txtCPF.Text = funcionario.cpf;
                txtConta.Text = funcionario.cc;
                txtPIX.Text = funcionario.pix;
                txtGenero.Text = funcionario.genero;
                txtData.Text = funcionario.data_nascimento;
                txtFuncao.Text = funcionario.funcao;
                
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                row.Selected = true;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCelular.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                txtComplemento.Text = row.Cells[4].Value.ToString();
                txtCidade.Text = row.Cells[5].Value.ToString();
                txtCEP.Text = row.Cells[6].Value.ToString();
                txtCPF.Text = row.Cells[7].Value.ToString();
                txtConta.Text = row.Cells[8].Value.ToString();
                txtPIX.Text = row.Cells[9].Value.ToString();
                txtGenero.Text = row.Cells[10].Value.ToString();
                txtData.Text = row.Cells[11].Value.ToString();
                txtFuncao.Text = row.Cells[12].Value.ToString();
            }
        }
    }
}
