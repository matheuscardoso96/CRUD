using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD.model;
using CRUD.view;
using CRUD.dao;
using System.Data;

namespace CRUD.controller
{
    class PaisController
    {

        public void Inserir(Pais pais)
        {
            PaisDao pdao = new PaisDao();
            pdao.Inserir(pais);
        }

        public void Alterar(Pais pais)
        {
            PaisDao pdao = new PaisDao();
            pdao.Alterar(pais);
        }

        public void Excluir(Pais pais)
        {
            PaisDao pdao = new PaisDao();
            pdao.Excluir(pais);
        }

        public object BuscarCodigo(int codigo)
        {
            PaisDao pdao = new PaisDao();
            Pais pais = (Pais)pdao.BuscaCodigo(codigo);
            return pais;
        }

        public DataSet Consultar()
        {
            PaisDao pdao = new PaisDao();
            DataSet consulta = pdao.Consultar();
            return consulta;
        }


    }
}
