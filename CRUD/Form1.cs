using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.view;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaisView paisView = new PaisView();
            paisView.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UfView ufView = new UfView();
            ufView.ShowDialog();
        }

        private void tipoDeEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoEnderecoView tipoEnderecoView = new TipoEnderecoView();
            tipoEnderecoView.ShowDialog();
        }

        private void tipoDePessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoPessoaView tipoPessoaView = new TipoPessoaView();
            tipoPessoaView.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.ShowDialog();
        }
    }
}
