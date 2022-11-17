using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BotecoTDS07
{
    class Funcionario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
        public string cc { get; set; }
        public string pix { get; set; }
        public string genero { get; set; }
        public string data_nascimento { get; set; }
        public string funcao { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\continuacao_jao5\continuacao_jao5\continuacao_jao3\continuacao_jao3\continuacao_jao\jao_Boteco\botecotds07\DbBoteco.mdf;Integrated Security=True");

        public List<Funcionario> listafuncionarios()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario f = new Funcionario();
                f.Id = (int)dr["Id"];
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.complemento = dr["complemento"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.cep = dr["cep"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.cc = dr["cc"].ToString();
                f.pix = dr["pix"].ToString();
                f.genero = dr["genero"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.funcao = dr["funcao"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void Inserir(string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "INSERT INTO Funcionario(nome,celular,endereco,complemento,cidade,cep,cpf,cc,pix,genero,data_nascimento,funcao) VALUES (@nome,@celular,@endereco,@complemento,@cidade,@cep,@cpf,@cc,@pix,@genero,@data_nascimento,@funcao)";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@nome", SqlDbType.NChar).Value = nome;
            cmd.Parameters.Add("@celular", SqlDbType.NChar).Value = celular;
            cmd.Parameters.Add("@endereco", SqlDbType.NChar).Value = endereco;
            cmd.Parameters.Add("@complemento", SqlDbType.NChar).Value = complemento;
            cmd.Parameters.Add("@cidade", SqlDbType.NChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.NChar).Value = cep;
            cmd.Parameters.Add("@cpf", SqlDbType.NChar).Value = cpf;
            cmd.Parameters.Add("@cc", SqlDbType.NChar).Value = cc;
            cmd.Parameters.Add("@pix", SqlDbType.NChar).Value = pix;
            cmd.Parameters.Add("@genero", SqlDbType.NChar).Value = genero;
            cmd.Parameters.Add("@data_nascimento", SqlDbType.NChar).Value = data_nascimento;
            cmd.Parameters.Add("@funcao", SqlDbType.NChar).Value = funcao;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Atualizar(int Id, string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "UPDATE Funcionario SET nome=@nome,celular=@celular,endereco=@endereco,complemento=@complemento,cidade=@cidade,cep=@cep,cpf=@cpf,cc=@cc,pix=@pix,genero=@genero,data_nascimento=@data_nascimento,funcao=@funcao WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@nome", SqlDbType.NChar).Value = nome;
            cmd.Parameters.Add("@celular", SqlDbType.NChar).Value = celular;
            cmd.Parameters.Add("@endereco", SqlDbType.NChar).Value = endereco;
            cmd.Parameters.Add("@complemento", SqlDbType.NChar).Value = complemento;
            cmd.Parameters.Add("@cidade", SqlDbType.NChar).Value = cidade;
            cmd.Parameters.Add("@cep", SqlDbType.NChar).Value = cep;
            cmd.Parameters.Add("@cpf", SqlDbType.NChar).Value = cpf;
            cmd.Parameters.Add("@cc", SqlDbType.NChar).Value = cc;
            cmd.Parameters.Add("@pix", SqlDbType.NChar).Value = pix;
            cmd.Parameters.Add("@genero", SqlDbType.NChar).Value = genero;
            cmd.Parameters.Add("@data_nascimento", SqlDbType.NChar).Value = data_nascimento;
            cmd.Parameters.Add("@funcao", SqlDbType.NChar).Value = funcao;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Funcionario WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                celular = dr["celular"].ToString();
                endereco = dr["endereco"].ToString();
                complemento = dr["complemento"].ToString();
                cidade = dr["cidade"].ToString();
                cep = dr["cep"].ToString();
                cpf = dr["cpf"].ToString();
                cc = dr["cc"].ToString();
                pix = dr["pix"].ToString();
                genero = dr["genero"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
                funcao = dr["funcao"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public bool RegistroRepetido(string nome, string cpf, string cc)
        {
            string sql = "SELECT * FROM Funcionario WHERE nome='" + nome + "' AND cpf='" + cpf + "' AND cc='" + cc + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
