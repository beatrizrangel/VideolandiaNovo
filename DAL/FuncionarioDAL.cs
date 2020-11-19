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
    public class FuncionarioDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VideolandiaConnectionString"].ConnectionString;

        public void InserirFuncionario(Pessoa objfuncionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TFuncionarios VALUES (@status,@Nome,@Dtnascimento,@sexo,@estadocivil,@rg,@cpf,@Email,@Endereco,@Cidade,@Cep,@Estado,@celular,@telefone)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@status", objfuncionario.Status);
            cmd.Parameters.AddWithValue("@Nome", objfuncionario.Nome);
            cmd.Parameters.AddWithValue("@Dtnascimento", objfuncionario.Dtnascimento);
            cmd.Parameters.AddWithValue("@sexo", objfuncionario.Sexo);
            cmd.Parameters.AddWithValue("@estadocivil", objfuncionario.EstadoCivil);
            cmd.Parameters.AddWithValue("@rg", objfuncionario.Rg);
            cmd.Parameters.AddWithValue("@cpf", objfuncionario.Cpf);
            cmd.Parameters.AddWithValue("@Email", objfuncionario.Email);
            cmd.Parameters.AddWithValue("@Endereco", objfuncionario.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", objfuncionario.Cidade);
            cmd.Parameters.AddWithValue("@Cep", objfuncionario.Cep);
            cmd.Parameters.AddWithValue("@Estado", objfuncionario.Estado);
            cmd.Parameters.AddWithValue("@celular", objfuncionario.Celular);
            cmd.Parameters.AddWithValue("@telefone", objfuncionario.Telefone);


            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void ExcluirFuncionario(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TFuncionarios WHERE fun_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Pessoa BuscarFuncionario(string buscar)
        {
            Pessoa objfuncionario = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TFuncionarios WHERE fun_cod = @codigo OR fun_cpf = @cpf";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", buscar);
            cmd.Parameters.AddWithValue("@cpf", buscar);


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objfuncionario = new Pessoa();
                objfuncionario.Codigo = Convert.ToInt32(dr["fun_cod"]);
                objfuncionario.Nome = dr["fun_nome"].ToString();
                objfuncionario.Dtnascimento = Convert.ToDateTime(dr["fun_dtnascimento"]);
                objfuncionario.Sexo = dr["fun_sexo"].ToString();
                objfuncionario.EstadoCivil = dr["fun_estadocivil"].ToString();
                objfuncionario.Rg = dr["fun_rg"].ToString();
                objfuncionario.Cpf = dr["fun_cpf"].ToString();
                objfuncionario.Email = dr["fun_email"].ToString();
                objfuncionario.Endereco = dr["fun_endereco"].ToString();
                objfuncionario.Cidade = dr["fun_cidade"].ToString();
                objfuncionario.Cep = dr["fun_cep"].ToString();
                objfuncionario.Estado = dr["fun_estado"].ToString();
                objfuncionario.Celular = dr["fun_celular"].ToString();
                objfuncionario.Telefone = dr["fun_telefone"].ToString();

            }
            conn.Close();
            return objfuncionario;
        }

        public void AlterarFuncionario(Pessoa funcionario)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE TFuncionarios SET fun_nome = @Nome,fun_ativo = @status,fun_dtnascimento = @Dtnascimento,fun_sexo = @sexo,fun_estadocivil = @estadocivil, fun_rg = @rg,fun_cpf = @cpf," +
                "fun_email = @Email,fun_endereco = @Endereco,fun_cidade = @Cidade,fun_cep = @Cep,fun_estado = @Estado,fun_celular = @celular,fun_telefone = @telefone WHERE fun_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Codigo", funcionario.Codigo);
            cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@status", funcionario.Status);
            cmd.Parameters.AddWithValue("@Dtnascimento", funcionario.Dtnascimento);
            cmd.Parameters.AddWithValue("@sexo", funcionario.Sexo);
            cmd.Parameters.AddWithValue("@estadocivil", funcionario.EstadoCivil);
            cmd.Parameters.AddWithValue("@rg", funcionario.Rg);
            cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
            cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            cmd.Parameters.AddWithValue("@Endereco", funcionario.Endereco);
            cmd.Parameters.AddWithValue("@Cidade", funcionario.Cidade);
            cmd.Parameters.AddWithValue("@Cep", funcionario.Cep);
            cmd.Parameters.AddWithValue("@Estado", funcionario.Estado);
            cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
            cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);



            cmd.ExecuteNonQuery();

            conn.Close();
        }


        public List<Pessoa> ListarFuncionarios()
        {

            List<Pessoa> ListarFuncionarios = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TFuncionarios";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objfuncionario = new Pessoa();
                while (dr.Read())
                {
                    objfuncionario = new Pessoa();
                    objfuncionario.Codigo = Convert.ToInt32(dr["fun_cod"]);
                    objfuncionario.Nome = dr["fun_nome"].ToString();
                    objfuncionario.Dtnascimento = Convert.ToDateTime(dr["fun_dtnascimento"]);
                    objfuncionario.Sexo = dr["fun_sexo"].ToString();
                    objfuncionario.EstadoCivil = dr["fun_estadocivil"].ToString();
                    objfuncionario.Rg = dr["fun_rg"].ToString();
                    objfuncionario.Cpf = dr["fun_cpf"].ToString();
                    objfuncionario.Email = dr["fun_email"].ToString();
                    objfuncionario.Endereco = dr["fun_endereco"].ToString();
                    objfuncionario.Cidade = dr["fun_cidade"].ToString();
                    objfuncionario.Cep = dr["fun_cep"].ToString();
                    objfuncionario.Estado = dr["fun_estado"].ToString();
                    objfuncionario.Celular = dr["fun_celular"].ToString();
                    objfuncionario.Telefone = dr["fun_telefone"].ToString();


                    ListarFuncionarios.Add(objfuncionario);
                }
            }

            conn.Close();
            return ListarFuncionarios;

        }
    }
}
