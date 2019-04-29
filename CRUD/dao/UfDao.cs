using MySql.Data.MySqlClient;
using System;
using CRUD.conexao;
using CRUD.model;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace CRUD.dao
{
    class UfDao : IDao
    {
        public ConectarMySql Conexao { get; set; } = new ConectarMySql();


        public void Alterar( object obj)
        {
            Uf estado = (Uf)obj;
            string TextoQuery = "UPDATE uf SET codigo_pais_ufed = \""+ estado.Codigo_Pais + "\", sigla_ufed = \""+ estado.Sigla +"\", nome_ufed = \"" + estado.Nome
                                + "\" WHERE codigo_ufed = " + estado.Codigo;
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

        public object BuscaCodigo( int codigo)
        {
            Uf estado = new Uf();
            string TextoQuery = "SELECT * FROM uf where codigo_ufed = " + codigo.ToString();
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {

                    estado = new Uf(MyReader.GetInt32(0), MyReader.GetString(2), MyReader.GetString(3), MyReader.GetInt32(1));
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
            return estado;
        }

        public DataSet Consultar()
        {
            string TextoQuery = "Select codigo_ufed as \"Código Estado\", codigo_pais_ufed as \" Código Pais\"," +
                "sigla_ufed as \"Sigla\", nome_ufed \"Nome\"  FROM uf";
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
            Uf estado = (Uf)obj;
            string TextoQuery = "DELETE FROM uf WHERE codigo_ufed = " + estado.Codigo;
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
            Uf estado = (Uf)obj;
            string TextoQuery = "INSERT INTO uf(codigo_ufed, codigo_pais_ufed, sigla_ufed, nome_ufed) VALUES(default," + estado.Codigo_Pais + ",\"" + estado.Sigla + "\",\""+ estado.Nome + "\")";
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
        }

        public List<Pais> Select()
        {
            List<Pais> pais = new List<Pais>();
            string TextoQuery = "SELECT * FROM pais;";
            try
            {
                MySqlDataReader reader = null;
                Conexao.Conectar();
                MySqlCommand command = new MySqlCommand(TextoQuery, Conexao.Connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    pais.Add(new Pais(reader.GetInt32(0), reader.GetString(1)));
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            Conexao.Fechar();
            return pais;
        }
    }
}
