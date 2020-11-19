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
    public class FilmeDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VideolandiaConnectionString"].ConnectionString;

        public int InserirFilme(Filme objfilme)
        {

            int codigo;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TFilmes VALUES (@Codigobarras,@Nome,@generofilme,@diretorfilme,@ano,@tipo,@preco,@dtadquirido,@custo,@foto); SELECT @@IDENTITY";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Codigobarras", objfilme.CdBarras);
            cmd.Parameters.AddWithValue("@Nome", objfilme.Titulo);
            cmd.Parameters.AddWithValue("@generofilme1", objfilme.CodGenero1);
            cmd.Parameters.AddWithValue("@generofilme1", objfilme.CodGenero2);
            cmd.Parameters.AddWithValue("@diretorfilme", objfilme.CodDiretor);
            cmd.Parameters.AddWithValue("@ano", objfilme.Ano);
            cmd.Parameters.AddWithValue("@tipo", objfilme.Tipo);
            cmd.Parameters.AddWithValue("@preco", objfilme.Preco);
            cmd.Parameters.AddWithValue("@dtadquirido", objfilme.dtAdquirido);
            cmd.Parameters.AddWithValue("@custo", objfilme.Custo);




            int Codigo = Convert.ToInt32(cmd.ExecuteScalar());

            foreach (var ator in objfilme.Generos)
            {
                sql = "INSERT INTO TFilmesArtistas VALUES (@codigofilme,@codigoartista,@personagem)";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Codigofilme", Codigo);
                cmd.Parameters.AddWithValue("@codigoartista", ator.CodigoArtista);
                cmd.Parameters.AddWithValue("@personagem", ator.Personagem);

                cmd.ExecuteNonQuery();
            }


            conn.Close();


        }


        public void ExcluirFilme(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TFilmes WHERE flm_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Filme BuscarFilme(string buscar)
        {
            Filme objfilme = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TFilmes WHERE flm_codigobarras = @cdbarras OR flm_nome = @titulo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdbarras",buscar );
            cmd.Parameters.AddWithValue("@nome", buscar);


            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objfilme = new Filme ();
                objfilme.Codigo = Convert.ToInt32(dr["flm_cod"]);
                objfilme.CdBarras = dr["flm_codigobarras"].ToString();
                objfilme.Titulo = dr["flm_nome"].ToString();
                objfilme.CodGenero1 = Convert.ToInt32(dr["flm_gen_cod1"]);
                objfilme.CodGenero2 = Convert.ToInt32(dr["flm_gen_cod2"]);
                objfilme.CodDiretor = Convert.ToInt32(dr["flm_cod_dir"]);
                objfilme.Ano = Convert.ToInt32(dr["flm_ano"]);
                objfilme.Tipo = dr["flm_tipo"].ToString();
                objfilme.Preco = Convert.ToDecimal(dr["flm_preco"]);
                objfilme.Custo = Convert.ToDecimal(dr["flm_custo"]);


            }
            conn.Close();
            return objfilme;
        }




        public void AlterarFilme (Filme filme)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE TFilmes SET @Codigobarras,@Nome,@generofilme,@diretorfilme,@ano,@tipo,@preco,@dtadquirido,@custo,@foto WHERE flm_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", filme.Codigo);
            cmd.Parameters.AddWithValue("@Codigobarras", filme.CdBarras);
            cmd.Parameters.AddWithValue("@Nome", filme.Titulo);
            cmd.Parameters.AddWithValue("@generofilme", filme.CodGenero1);
            cmd.Parameters.AddWithValue("@generofilme", filme.CodGenero2);
            cmd.Parameters.AddWithValue("@diretorfilme", filme.CodDiretor);
            cmd.Parameters.AddWithValue("@ano", filme.Ano);
            cmd.Parameters.AddWithValue("@tipo", filme.Tipo);
            cmd.Parameters.AddWithValue("@preco", filme.Preco);
            cmd.Parameters.AddWithValue("@dtadquirido",filme.dtAdquirido);
            cmd.Parameters.AddWithValue("@custo",filme.Custo);



            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Filme> ListarFilmes()
        {

            List<Filme> ListarFilmes = new List<Filme>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TFilmes";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
               Filme objfilme = new Filme();
                while (dr.Read())
                {
                    objfilme = new Filme();
                    objfilme.Codigo = Convert.ToInt32(dr["flm_cod"]);
                    objfilme.CdBarras = dr["flm_codigobarras"].ToString();
                    objfilme.Titulo = dr["flm_nome"].ToString();
                    objfilme.CodGenero1 = Convert.ToInt32(dr["flm_gen_cod1"]);
                    objfilme.CodGenero2 = Convert.ToInt32(dr["flm_gen_cod2"]);
                    objfilme.CodDiretor = Convert.ToInt32(dr["flm_cod_dir"]);
                    objfilme.Ano = Convert.ToInt32(dr["flm_ano"]);
                    objfilme.Tipo = dr["flm_tipo"].ToString();
                    objfilme.Preco = Convert.ToDecimal(dr["flm_preco"]);
                    objfilme.Custo = Convert.ToDecimal(dr["flm_custo"]);


                    ListarFilmes.Add(objfilme);
                }
            }

            conn.Close();
            return ListarFilmes;
        }
    }
}
