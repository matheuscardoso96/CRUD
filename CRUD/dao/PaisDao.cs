using MySql.Data.MySqlClient;
using CRUD.conexao;
using CRUD.model;
using System.Windows.Forms;
using System.Data;

namespace CRUD.dao
{
    class PaisDao : IDao

    {
        public ConectarMySql Conexao { get; set; } = new ConectarMySql();

        public void Alterar( object obj)
        {
            Pais pais = (Pais)obj;
            string TextoQuery = "UPDATE pais SET nome_pais = \"" + pais.Nome + "\" WHERE codigo_pais = " + pais.Codigo;
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
            Pais pais = new Pais();
            string TextoQuery = "SELECT * FROM pais where codigo_pais = " + codigo.ToString();
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {

                    pais = new Pais(MyReader.GetInt32(0), MyReader.GetString(1));
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
            return pais;
        }

        public DataSet Consultar()
        {
            string TextoQuery = "Select codigo_pais as \"Código\", nome_pais as \"Pais\" from pais";
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
            Pais pais = (Pais)obj;
            string TextoQuery = "DELETE FROM uf WHERE codigo_ufed = " + pais.Codigo;
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
            Pais pais = (Pais)obj;
            string TextoQuery = "INSERT INTO pais(codigo_pais, nome_pais) VALUES(" + pais.Codigo + ",\"" + pais.Nome + "\")";
            try {
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
