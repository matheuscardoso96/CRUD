using MySql.Data.MySqlClient;
using CRUD.conexao;
using CRUD.model;
using System.Windows.Forms;
using System.Data;

namespace CRUD.dao
{
    class TipoEnderecoDao : IDao
    {
        public ConectarMySql Conexao { get; set; } = new ConectarMySql();

        public void Alterar(object obj)
        {
            
            TipoEndereco tipoEndereco = (TipoEndereco)obj;
            string TextoQuery = "UPDATE tipoendereco SET descricao_tend = \"" + tipoEndereco.Descricao + "\" WHERE codigo_tend = " + tipoEndereco.Codigo;
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                MyReader.Close();
                Conexao.Fechar();
                MessageBox.Show("Cadastro Atualizado.");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public object BuscaCodigo(int codigo)
        {
            TipoEndereco tipoEndereco = new TipoEndereco();
            string TextoQuery = "SELECT * FROM tipoendereco where codigo_tend = " + codigo.ToString();
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {

                    tipoEndereco = new TipoEndereco(MyReader.GetInt32(0), MyReader.GetString(1));
                }

                // estado = new Uf(MyReader.GetInt32(0), MyReader.GetString(2), MyReader.GetString(3), MyReader.GetInt32(1));
                MyReader.Close();
                Conexao.Fechar();
                //  MessageBox.Show("Cadastro efetuado.");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return tipoEndereco;
        }

        public DataSet Consultar()
        {
            string TextoQuery = "Select codigo_tend as \"Código\", descricao_tend as \"Tipo Endereço\" from tipoendereco";
            DataSet ds = new DataSet();
            try
            {
                Conexao.Conectar();
                MySqlDataAdapter mySqlData = new MySqlDataAdapter(TextoQuery, Conexao.Connection);
                mySqlData.Fill(ds);

                Conexao.Fechar();

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return ds;
        }

        public void Excluir(object obj)
        {
            TipoEndereco tipoEndereco = (TipoEndereco)obj;
            string TextoQuery = "DELETE FROM tipoendereco WHERE codigo_tend = " + tipoEndereco.Codigo;
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                MyReader.Close();
                Conexao.Fechar();
                MessageBox.Show("Registro Removido.");
                

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void Inserir(object obj)
        {
            TipoEndereco tipoEndereco = (TipoEndereco)obj;
            string TextoQuery = "INSERT INTO tipoendereco(codigo_tend, descricao_tend) VALUES(default,\"" + tipoEndereco.Descricao + "\")";
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                MyReader.Close();
                Conexao.Fechar();
                MessageBox.Show("Cadastro efetuado.");

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            //This is command class which will handle the query and connection object.


        }
    }
}
