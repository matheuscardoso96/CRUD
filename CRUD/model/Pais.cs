using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.model
{
    class Pais
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Pais()
        {
        }

        public Pais(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
