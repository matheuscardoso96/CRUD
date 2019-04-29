using CRUD.model;
using CRUD.dao;
using System.Data;

namespace CRUD.controller
{
    class TipoEnderecoController
    {
        public void Inserir(TipoEndereco tipoEndereco)
        {
            TipoEnderecoDao teDao = new TipoEnderecoDao();
            teDao.Inserir(tipoEndereco);
        }

        public void Alterar(TipoEndereco tipoEndereco)
        {
            TipoEnderecoDao teDao = new TipoEnderecoDao();
            teDao.Alterar(tipoEndereco);
        }

        public void Excluir(TipoEndereco tipoEndereco)
        {
            TipoEnderecoDao teDao = new TipoEnderecoDao();
            teDao.Excluir(tipoEndereco);
        }

        public object BuscarCodigo(int codigo)
        {
            TipoEnderecoDao teDao = new TipoEnderecoDao();
            TipoEndereco tipoEndereco = (TipoEndereco)teDao.BuscaCodigo(codigo);
            return tipoEndereco;
        }

        public DataSet Consultar()
        {
            TipoEnderecoDao teDao = new TipoEnderecoDao();
            DataSet consulta = teDao.Consultar();
            return consulta;
        }

    }
}
