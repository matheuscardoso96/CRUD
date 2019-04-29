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
    class UfController
    {
        public void Inserir(Uf estado)
        {
            UfDao ufdao = new UfDao();
            ufdao.Inserir(estado);
        }

        public void Alterar(Uf estado)
        {
            UfDao ufdao = new UfDao();
            ufdao.Alterar(estado);
        }

        public void Excluir(Uf estado)
        {
            UfDao ufdao = new UfDao();
            ufdao.Excluir(estado);
        }

        public DataSet Consultar()
        {
            UfDao ufdao = new UfDao();
            DataSet consulta = ufdao.Consultar();
            return consulta;
        }

        public object BuscarCodigo(int codigo)
        {
            UfDao ufDao = new UfDao();
            Uf estado = (Uf)ufDao.BuscaCodigo(codigo);
            return estado;
        }

        public List<Pais> Select()
        {
            UfDao pdao = new UfDao();
            List<Pais> pais = pdao.Select();
            return pais;

        }
    }
}
