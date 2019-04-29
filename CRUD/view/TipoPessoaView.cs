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
    public partial class TipoPessoaView : Form
    {
        TipoPessoa tipoPessoa = new TipoPessoa();

        public TipoPessoaView()
        {
            InitializeComponent();
            btCadastrar.Enabled = false;
            btExcluir.Enabled = false;
            btAlterar.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TipoPessoaView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text.Length == 0)
                tbCodigo.Text = "0";
            TipoPessoa tipoPessoa = new TipoPessoa(int.Parse(tbCodigo.Text),tbNome.Text);
            TipoPessoaController tpC = new TipoPessoaController();
            tpC.Inserir(tipoPessoa);
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
            TipoPessoaController tpC = new TipoPessoaController();
            dataGridView1.DataSource = tpC.Consultar().Tables[0];
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tipoPessoa = new TipoPessoa() {Descricao = tbNome.Text, Codigo = int.Parse(tbCodigo.Text)};
                TipoPessoaController tpC = new TipoPessoaController();
                tpC.Excluir(tipoPessoa);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularFormulario();
        }

        private void PopularFormulario()
        {
            TipoPessoaController tpC = new TipoPessoaController();
            tipoPessoa = (TipoPessoa)tpC.BuscarCodigo(int.Parse(tbBuscaCodigo.Text));
            tbNome.Text = tipoPessoa.Descricao;
            tbCodigo.Text = tipoPessoa.Codigo.ToString();
            tbCodigo.ReadOnly = true;
          
            if (tipoPessoa.Codigo == 0)
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
                TipoPessoa tipoPessoa = new TipoPessoa() { Codigo = int.Parse(tbCodigo.Text), Descricao = tbNome.Text};
                TipoPessoaController tpC = new TipoPessoaController();
                tpC.Alterar(tipoPessoa);
            }
        }
    }
}
