using MODELS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VideolandiaConnectionString"].ConnectionString;

        public void InserirCliente(Pessoa objcliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TClientes VALUES (@status,@Nome,@Dtnascimento,@sexo,@estadocivil,@rg,@cpf,@Email,@Endereco,@Cidade,@Cep,@Estado,@celular,@telefone)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@status", objcliente.Status);
            cmd.Parameters.AddWithValue("@Nome", objcliente.Nome);
            cmd.Parameters.AddWithValue("@Dtnascimento", objcliente.Dtnascimento);
            cmd.Parameters.AddWithValue("@sexo", objcliente.Sexo);
            cmd.Parameters.AddWithValue("@estadocivil", objcliente.EstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objcliente.Rg);
            cmd.Parameters.AddWithValue("@cpf", objcliente.Cpf);
            cmd.Parameters.AddWithValue("@Email", objcliente.Email);
            cmd.Parameters.AddWithValue("@Endereco", objcliente.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", objcliente.Cidade);
            cmd.Parameters.AddWithValue("@Cep", objcliente.Cep);
            cmd.Parameters.AddWithValue("@Estado", objcliente.Estado);
            cmd.Parameters.AddWithValue("@celular", objcliente.Celular);
            cmd.Parameters.AddWithValue("@telefone", objcliente.Telefone);


            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirCliente(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TClientes WHERE cli_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Pessoa BuscarCliente(string buscar)
        {
            Pessoa objcliente = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TClientes WHERE cli_cod = @codigo OR cli_cpf = @cpf";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", buscar);
            cmd.Parameters.AddWithValue("@cpf", buscar);


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objcliente = new Pessoa();
                objcliente.Codigo = Convert.ToInt32(dr["cli_cod"]);
                objcliente.Nome = dr["cli_nome"].ToString();
                objcliente.Dtnascimento = Convert.ToDateTime(dr["cli_dtnascimento"]);
                objcliente.Sexo = dr["cli_sexo"].ToString();
                objcliente.EstadoCivil = dr["cli_estadocivil"].ToString();
                objcliente.Rg = dr["cli_rg"].ToString();
                objcliente.Cpf = dr["cli_cpf"].ToString();
                objcliente.Email = dr["cli_email"].ToString();
                objcliente.Endereco = dr["cli_endereco"].ToString();
                objcliente.Cidade = dr["cli_cidade"].ToString();
                objcliente.Cep = dr["cli_cep"].ToString();
                objcliente.Estado = dr["cli_estado"].ToString();
                objcliente.Celular = dr["cli_celular"].ToString();
                objcliente.Telefone = dr["cli_telefone"].ToString();

            }
            conn.Close();
            return objcliente;
        }

        public void AlterarCliente(Pessoa cliente)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE TClientes SET cli_nome = @Nome,cli_ativo = @status,cli_dtnascimento = @Dtnascimento,cli_sexo = @sexo,cli_estadocivil = @estadocivil, cli_rg = @rg,cli_cpf = @cpf," +
                "cli_email = @Email,cli_endereco = @Endereco,cli_cidade = @Cidade,cli_cep = @Cep,cli_estado = @Estado,cli_celular = @celular,cli_telefone = @telefone WHERE cli_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@status", cliente.Status);
            cmd.Parameters.AddWithValue("@Dtnascimento", cliente.Dtnascimento);
            cmd.Parameters.AddWithValue("@sexo", cliente.Sexo);
            cmd.Parameters.AddWithValue("@estadocivil", cliente.EstadoCivil);
            cmd.Parameters.AddWithValue("@rg", cliente.Rg);
            cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
            cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
            cmd.Parameters.AddWithValue("@celular", cliente.Celular);
            cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);



            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public List<Pessoa> ListarClientes()
        {

            List<Pessoa> ListarClientes = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TClientes";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objcliente = new Pessoa();
                while (dr.Read())
                {
                    objcliente = new Pessoa();
                    objcliente.Codigo = Convert.ToInt32(dr["cli_cod"]);
                    objcliente.Nome = dr["cli_nome"].ToString();
                    objcliente.Dtnascimento = Convert.ToDateTime(dr["cli_dtnascimento"]);
                    objcliente.Sexo = dr["cli_sexo"].ToString();
                    objcliente.EstadoCivil = dr["cli_estadocivil"].ToString();
                    objcliente.Rg = dr["cli_rg"].ToString();
                    objcliente.Cpf = dr["cli_cpf"].ToString();
                    objcliente.Email = dr["cli_email"].ToString();
                    objcliente.Endereco = dr["cli_endereco"].ToString();
                    objcliente.Cidade = dr["cli_cidade"].ToString();
                    objcliente.Cep = dr["cli_cep"].ToString();
                    objcliente.Estado = dr["cli_estado"].ToString();
                    objcliente.Celular = dr["cli_celular"].ToString();
                    objcliente.Telefone = dr["cli_telefone"].ToString();


                    ListarClientes.Add(objcliente);
                }
            }

            conn.Close();
            return ListarClientes;
        }
    }
}