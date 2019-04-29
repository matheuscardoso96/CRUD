using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.model
{
    class Cliente
    {
        public int Codigo { get; set; }
        public int CodigoTipoPessoa { get; set; }
        public DateTime Registro { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string SobrenomeNomeFantasia { get; set; }
        public string RgIE { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string CpfCnpj { get; set; }


        public Cliente()
        {
        }

        public Cliente(int codigo, int codigoTipoPessoa, DateTime registro, string nomeRazaoSocial, string sobrenomeNomeFantasia, string rgIE, string orgaoExpedidor, string cpfCnpj)
        {
            Codigo = codigo;
            CodigoTipoPessoa = codigoTipoPessoa;
            Registro = registro;
            NomeRazaoSocial = nomeRazaoSocial;
            SobrenomeNomeFantasia = sobrenomeNomeFantasia;
            RgIE = rgIE;
            OrgaoExpedidor = orgaoExpedidor;
            CpfCnpj = cpfCnpj;
        }
    }
}
