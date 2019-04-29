using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.model
{
    class TipoPessoa
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public TipoPessoa()
        {
        }

        public TipoPessoa(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
