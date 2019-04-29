using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CRUD.util;

namespace CRUD.conexao
{
    class ConectarMySql
    {
        public MySqlConnection Connection { get; private set; } = null;
        public GetPropriedadesConexao MyConn { get; set; }

        public ConectarMySql()
        {
            MyConn = new GetPropriedadesConexao("Propiedades/conexao.txt");
            Connection = new MySqlConnection(MyConn.Servidor + ";" + MyConn.NomeDoBanco + ";" + MyConn.Usuario + ";" + MyConn.Senha + ";" + MyConn.Encoding + ";");
        }


        public void Conectar()
        {
            Connection.Open();

        }

        public void Fechar()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
            
        }


    }
}
