using CRUD.model;
using CRUD.dao;
using System.Data;

namespace CRUD.controller
{
    class TipoPessoaController
    {
        public void Inserir(TipoPessoa tipoPessoa)
        {
            TipoPessoaDao tpDao = new TipoPessoaDao();
            tpDao.Inserir(tipoPessoa);
        }

        public void Alterar(TipoPessoa tipoPessoa)
        {
            TipoPessoaDao tpDao = new TipoPessoaDao();
            tpDao.Alterar(tipoPessoa);
        }

        public void Excluir(TipoPessoa tipoPessoa)
        {
            TipoPessoaDao tpDao = new TipoPessoaDao();
            tpDao.Excluir(tipoPessoa);
        }

        public object BuscarCodigo(int codigo)
        {
            TipoPessoaDao tpDao = new TipoPessoaDao();
            TipoPessoa tipoPessoa = (TipoPessoa)tpDao.BuscaCodigo(codigo);
            return tipoPessoa;
        }

        public DataSet Consultar()
        {
            TipoPessoaDao tpDao = new TipoPessoaDao();
            DataSet consulta = tpDao.Consultar();
            return consulta;
        }

    }
}
