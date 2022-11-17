using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BotecoTDS07
{
    public partial class FrmVendas : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\continuacao_jao5\continuacao_jao5\continuacao_jao3\continuacao_jao3\continuacao_jao\jao_Boteco\botecotds07\DbBoteco.mdf;Integrated Security=True");
        public FrmVendas()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT Id, nome FROM Cliente ORDER BY nome";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text; // se usa esse comando quando a query esta na programção 
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet(); // ponte para conectar com o combobox
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "id"; // propriedade propria do combobox
            cbxCliente.DisplayMember = "nome"; // propriedade propria do combobox
            cbxCliente.DataSource = ds.Tables["cliente"]; // propriedade propria do combobox
            con.Close();

        }

        public void CarregaCbxProduto()
        {
            if(con.State == ConnectionState.Open)// para fechar a conecção caso esteja aberta
            {
                con.Close();
            }
            string pro = "SELECT Id, nome FROM Produto ORDER BY nome";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            CarregaCbxCliente();
            CarregaCbxProduto();
        }
    }
}
