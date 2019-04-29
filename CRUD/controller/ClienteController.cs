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
    class ClientController
    {
        public void Inserir(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Inserir(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Alterar(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.Excluir(cliente);
        }

        public DataSet Consultar()
        {
            ClienteDao clienteDao = new ClienteDao();
            DataSet consulta = clienteDao.Consultar();
            return consulta;
        }

        public object BuscarCodigo(int codigo)
        {
            ClienteDao clienteDao = new ClienteDao();
            Cliente cliente = (Cliente)clienteDao.BuscaCodigo(codigo);
            return cliente;
        }

        public List<TipoPessoa> Select()
        {
            ClienteDao clienteDao = new ClienteDao();
            List<TipoPessoa> tipoPessoas = clienteDao.Select();
            return tipoPessoas;

        }
    }
}
