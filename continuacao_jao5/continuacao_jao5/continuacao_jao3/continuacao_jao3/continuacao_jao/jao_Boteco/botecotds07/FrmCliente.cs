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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            List<Cliente> pessoas = cliente.listaclientes();
            dgvCliente.DataSource = pessoas;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtCPF.Text == "")
            {
                MessageBox.Show("Não existe nenhum dado para cadastrar!");
                this.txtNome.Focus();
            }
            else
            {
                Cliente cliente = new Cliente();
                if (cliente.RegistroRepetido(txtNome.Text, txtCPF.Text) != false)
                {
                    MessageBox.Show("Este cliente já existe em nossa base de dados!");
                    this.txtNome.Focus();
                    txtCPF.Text = "";
                }
                else
                {
                    cliente.Inserir(txtNome.Text, txtCPF.Text, txtData.Text, txtCelular.Text);
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    List<Cliente> pessoas = cliente.listaclientes();
                    dgvCliente.DataSource = pessoas;
                    txtNome.Text = "";
                    txtCPF.Text = "";
                }


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Atualizar(Id, txtNome.Text, txtCPF.Text, txtData.Text, txtCelular.Text);
            MessageBox.Show("Cliente atualizado com sucesso!");
            List<Cliente> pessoas = cliente.listaclientes();
            dgvCliente.DataSource = pessoas;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtID.Text = "";
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtID.Text.Trim());
            Cliente cliente = new Cliente();
            cliente.Excluir(Id);
            MessageBox.Show("Cliente excluído com sucesso!");
            List<Cliente> pessoas = cliente.listaclientes();
            dgvCliente.DataSource = pessoas;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtID.Text = "";
            btnEditar.Enabled = false;
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
                Cliente cliente = new Cliente();
                cliente.Localizar(Id);
                txtNome.Text = cliente.nome;
                txtCPF.Text = cliente.cpf;
                txtData.Text = cliente.data_nascimento;
                txtCelular.Text = cliente.celular;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                row.Selected = true;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCPF.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}