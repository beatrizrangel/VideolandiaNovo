using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MODELS;

namespace DAL
{
    public class GeneroDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["VideolandiaConnectionString"].ConnectionString;

        public void InserirGenero(Generos objgenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO TGeneros VALUES (@Nome)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objgenero.Nome);

            cmd.ExecuteNonQuery();

            conn.Close();


        }


        public void ExcluirGenero(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM TGeneros WHERE gen_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
    
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public Generos BuscarGenero(int Codigo)
        {
            Generos objgeneros = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TGeneros WHERE gen_cod = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", Codigo);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                objgeneros = new Generos();
                objgeneros.Codigo = Convert.ToInt32(dr["gen_cod"]);
                objgeneros.Nome = dr["gen_nome"].ToString();

            }
            conn.Close();
            return objgeneros;
        }




        public void AlterarGenero(Generos objgenero)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE TGeneros SET gen_nome = @nome WHERE gen_cod = @codigo";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", objgenero.Nome);
            cmd.Parameters.AddWithValue("@codigo", objgenero.Codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public List<Generos> ListarGeneros()
        {

         List<Generos> ListarGeneros = new List<Generos>();

                SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM TGeneros";

                SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                Generos objgenero = null;
                while(dr.Read())
                {
                    objgenero = new Generos();
                    objgenero.Codigo = Convert.ToInt32(dr["gen_cod"]);
                    objgenero.Nome = dr["gen_nome"].ToString();

                    ListarGeneros.Add(objgenero);
                }
            }

            conn.Close();
            return ListarGeneros;
        }
        
    }
}


