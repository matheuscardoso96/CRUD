using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CRUD.util
{
    class GetPropriedadesConexao
    {

        public string Servidor { get; private set; }
        public string NomeDoBanco { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public string Encoding { get; private set; }

        public GetPropriedadesConexao(string src)
        {
            string[] propriedades = new string[3];

            try
            {

                propriedades = File.ReadAllText(src).Split(',');

            }
            catch (IOException e)
            {
                MessageBox.Show("Arquivo de propriedades não encontrado!\n" + e.Message);

            }

            Servidor = propriedades[0];
            NomeDoBanco = propriedades[1];
            Usuario = propriedades[2];
            Senha = propriedades[3];
            Encoding = propriedades[4];
        }

        public static string[] GetPropriedades(string src)
        {
            string[] propriedades = new string[3];

            try
            {

                propriedades = File.ReadAllText(src).Split(',');

            }
            catch (IOException e)
            {
                MessageBox.Show("Arquivo de propriedades não encontrado!");

            }

            return propriedades;

        }
    }
}
