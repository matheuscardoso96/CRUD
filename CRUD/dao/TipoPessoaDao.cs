using MySql.Data.MySqlClient;
using CRUD.conexao;
using CRUD.model;
using System.Windows.Forms;
using System.Data;

namespace CRUD.dao
{
    class TipoPessoaDao : IDao
    {
        public ConectarMySql Conexao { get; set; } = new ConectarMySql();

        public void Alterar(object obj)
        {

            TipoPessoa tipoPessoa = (TipoPessoa)obj;
            string TextoQuery = "UPDATE tipopessoa SET descricao_tpes = \"" + tipoPessoa.Descricao + "\" WHERE codigo_tpes = " + tipoPessoa.Codigo;
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
            TipoPessoa tipoPessoa = new TipoPessoa();
            string TextoQuery = "SELECT * FROM tipopessoa WHERE codigo_tpes = " + codigo.ToString();
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {

                    tipoPessoa = new TipoPessoa(MyReader.GetInt32(0), MyReader.GetString(1));
                }

               
                MyReader.Close();
                Conexao.Fechar();
                

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return tipoPessoa;
        }

        public DataSet Consultar()
        {
            string TextoQuery = "Select codigo_tpes as \"Código\", descricao_tpes as \"Tipo Pessoa\" from tipopessoa";
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
            TipoPessoa tipoPessoa = (TipoPessoa)obj;
            string TextoQuery = "DELETE FROM tipopessoa WHERE codigo_tpes = " + tipoPessoa.Codigo;
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
            TipoPessoa tipoPessoa = (TipoPessoa)obj;
            string TextoQuery = "INSERT INTO tipopessoa(codigo_tpes, descricao_tpes) VALUES(default,\"" + tipoPessoa.Descricao + "\")";
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
