using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class Filme
    {
         public int Codigo { get; set; }
        public String CdBarras { get; set; }
        public String Titulo { get; set; }
        public int CodGenero1 { get; set; }
        public int CodGenero2 { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public String Tipo { get; set; }
        public DateTime dtAdquirido { get; set; }
        public decimal Custo { get; set; }
        public String Situacao { get; set; }
        public int CodDiretor { get; set; }
        public String Ator { get; set; }
        public List<Generos> Generos { get; set; }

    }
}
