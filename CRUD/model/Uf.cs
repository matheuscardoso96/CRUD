using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.model
{
    class Uf
    {
        public int Codigo { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public int Codigo_Pais { get; set; }

        public Uf()
        {
        }

        public Uf(int codigo, string sigla, string nome, int codigo_Pais)
        {
            Codigo = codigo;
            Sigla = sigla;
            Nome = nome;
            Codigo_Pais = codigo_Pais;
        }
    }
}
