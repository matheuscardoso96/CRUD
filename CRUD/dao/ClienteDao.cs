using MySql.Data.MySqlClient;
using System;
using CRUD.conexao;
using CRUD.model;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace CRUD.dao
{
    class ClienteDao : IDao
    {
        public ConectarMySql Conexao { get; set; } = new ConectarMySql();


        public void Alterar(object obj)
        {
            Cliente cliente = (Cliente)obj;
            string TextoQuery = string.Format ("UPDATE cliente SET codigo_tpes_clie = \"{0}\", nome_razaosocial_clie = \"{1}\", sobrenome_nomefantasia_clie = \"{2}\", rg_ie_clie = \"{3}\", orgao_exp_clie = \"{4}\", cpf_cnpj_clie = \"{5}\" WHERE codigo_clie = {6}", 
                                                cliente.CodigoTipoPessoa, cliente.NomeRazaoSocial, cliente.SobrenomeNomeFantasia,cliente.RgIE,cliente.OrgaoExpedidor,cliente.CpfCnpj,cliente.Codigo);
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
            Cliente cliente = new Cliente();
            string TextoQuery = "SELECT * FROM cliente where codigo_clie = " + codigo.ToString();
            try
            {
                Conexao.Conectar();
                MySqlCommand MyCommand = new MySqlCommand(TextoQuery, Conexao.Connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {

                    cliente = new Cliente(MyReader.GetInt32(0), MyReader.GetInt32(1), MyReader.GetDateTime(2), MyReader.GetString(3), MyReader.GetString(4), MyReader.GetString(5), MyReader.GetString(6), MyReader.GetString(7));
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
            return cliente;
        }

        public DataSet Consultar()
        {
            string TextoQuery = "Select codigo_clie as \"Código Cliente\", codigo_tpes_clie as \"Código Tipo Pessoa\", registro_clie as \"Data de Registro\", nome_razaosocial_clie as \"Nome ou Razão Social\", sobrenome_nomefantasia_clie as \"Sobrenome ou  Nome Fantasia\", rg_ie_clie as \"RG ou Inscrição Estadual\", orgao_exp_clie as \"Orgão Expedidor\", cpf_cnpj_clie as \"CPF ou CNPJ\" FROM cliente";
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
            Cliente cliente = (Cliente)obj;
            string TextoQuery = "DELETE FROM cliente WHERE codigo_clie = " + cliente.Codigo;
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
            Cliente cliente = (Cliente)obj;
            string TextoQuery = "INSERT INTO cliente(codigo_tpes_clie, nome_razaosocial_clie, sobrenome_nomefantasia_clie, rg_ie_clie, orgao_exp_clie, cpf_cnpj_clie) VALUES(" + cliente.CodigoTipoPessoa +", \""+ cliente.NomeRazaoSocial + "\",\"" + cliente.SobrenomeNomeFantasia +"\",\"" + cliente.RgIE +"\",\"" + cliente.OrgaoExpedidor + "\",\"" + cliente.CpfCnpj +"\")";
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

        public List<TipoPessoa> Select()
        {
            List<TipoPessoa> tipoPessoas = new List<TipoPessoa>();
            string TextoQuery = "SELECT * FROM tipopessoa;";
            try
            {
                MySqlDataReader reader = null;
                Conexao.Conectar();
                MySqlCommand command = new MySqlCommand(TextoQuery, Conexao.Connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    tipoPessoas.Add(new TipoPessoa(reader.GetInt32(0), reader.GetString(1)));
                }

            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            Conexao.Fechar();
            return tipoPessoas;
        }
    }
}
