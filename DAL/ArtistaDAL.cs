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
    public class ArtistaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VideolandiaConnectionString"].ConnectionString;

        public int InserirArtista(Artistas objartista)
        {

            int codigo;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TArtistas VALUES (@Nome,@Paisnascimento, @dtNascimento); SELECT @@IDENTITY";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", objartista.Nome);
            cmd.Parameters.AddWithValue("@Paisnascimento", objartista.Paisnascimento);
            cmd.Parameters.AddWithValue("@Dtnascimento", objartista.Dtnascimento);

            codigo = Convert.ToInt32(cmd.ExecuteScalar());


            conn.Close();

            return codigo;


        }


        public void ExcluirArtista(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TArtistas WHERE art_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Artistas BuscarArtista(int Codigo)
        {
            Artistas objartista = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TArtistas WHERE art_cod = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", Codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objartista = new Artistas();
                objartista.Codigo = Convert.ToInt32(dr["art_cod"]);
                objartista.Nome = dr["art_nome"].ToString();
                objartista.Dtnascimento = Convert.ToDateTime(dr["art_dtnascimento"]);
                objartista.Paisnascimento = dr["art_paisnascimento"].ToString();


            }
            conn.Close();
            return objartista;
        }




        public void AlterarArtista(Artistas objartista)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE TArtistas SET art_nome = @nome, art_paisnascimento = @pnascimento,art_dtnascimento = @nascimento WHERE art_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", objartista.Codigo);
            cmd.Parameters.AddWithValue("@nome", objartista.Nome);
            cmd.Parameters.AddWithValue("@pnascimento", objartista.Paisnascimento);
            cmd.Parameters.AddWithValue("@nascimento", objartista.Dtnascimento);



            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Artistas> ListarArtistas()
        {

            List<Artistas> ListarArtistas = new List<Artistas>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TArtistas";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Artistas objartista = null;
                while (dr.Read())
                {
                    objartista = new Artistas();
                    objartista.Codigo = Convert.ToInt32(dr["art_cod"]);
                    objartista.Nome = dr["art_nome"].ToString();
                    objartista.Paisnascimento = dr["art_paisnascimento"].ToString();
                    objartista.Dtnascimento = Convert.ToDateTime(dr["art_dtnascimento"]);
      


                    ListarArtistas.Add(objartista);
                }
            }

            conn.Close();
            return ListarArtistas;
        }
    }
}
