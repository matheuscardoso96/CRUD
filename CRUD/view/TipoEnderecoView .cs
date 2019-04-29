using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD.controller;
using CRUD.model;
using CRUD.view;

namespace CRUD.view
{
    public partial class TipoEnderecoView : Form
    {
        TipoEndereco tipoEndereco = new TipoEndereco();

        public TipoEnderecoView()
        {
            InitializeComponent();
            btCadastrar.Enabled = false;
            btExcluir.Enabled = false;
            btAlterar.Enabled = false;
          //  tbCodigo.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TipoEnderecoView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 0)
            {
                tbCodigo.Text = "0";
            }
            TipoEndereco tipoEndereco = new TipoEndereco(int.Parse(tbCodigo.Text),tbNome.Text);
            TipoEnderecoController teC = new TipoEnderecoController();
            teC.Inserir(tipoEndereco);
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            tbCodigo.ReadOnly = false;
            ChecarTextBox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();

        }

        private void ChecarTextBox()
        {
            if (tbNome.Text.Length > 0)
            {
                btCadastrar.Enabled = true;
            }
            else
            {
                btCadastrar.Enabled = false;
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr !=8)
            {
                e.Handled = true;
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            TipoEnderecoController teC = new TipoEnderecoController();
            dataGridView1.DataSource = teC.Consultar().Tables[0];
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tipoEndereco = new TipoEndereco() {Descricao = tbNome.Text, Codigo = int.Parse(tbCodigo.Text)};
                TipoEnderecoController teC = new TipoEnderecoController();
                teC.Excluir(tipoEndereco);
                tbCodigo.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularFormulario();
        }

        private void PopularFormulario()
        {
            TipoEnderecoController teC = new TipoEnderecoController();
            tipoEndereco = (TipoEndereco)teC.BuscarCodigo(int.Parse(tbBuscaCodigo.Text));
            tbNome.Text = tipoEndereco.Descricao;
            tbCodigo.Text = tipoEndereco.Codigo.ToString();
            tbCodigo.ReadOnly = true;
          
            if (tipoEndereco.Codigo == 0)
            {
                MessageBox.Show("Código inexistente.");
                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
            }

            BotaoEstatusBusca();


        }

        private void BotaoEstatusBusca()
        {
            btAlterar.Enabled = true;
            btExcluir.Enabled = true;
            btConsultar.Enabled = true;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente alterar esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TipoEndereco tipoEndereco = new TipoEndereco() { Codigo = int.Parse(tbCodigo.Text), Descricao = tbNome.Text};
                TipoEnderecoController teC = new TipoEnderecoController();
                teC.Alterar(tipoEndereco);
            }
        }
    }
}
