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
    public partial class PaisView : Form
    {
        Pais pais = new Pais();

        public PaisView()
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

        private void PaisView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pais pais = new Pais(int.Parse(tbCodigo.Text),tbNome.Text);
            PaisController pc = new PaisController();
            pc.Inserir(pais);
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();

        }

        private void ChecarTextBox()
        {
            if (tbNome.Text.Length > 0 && tbCodigo.Text.Length > 0)
            {
                btCadastrar.Enabled = true;
                tbCodigo.ReadOnly = false;
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
            PaisController pc = new PaisController();
            dataGridView1.DataSource = pc.Consultar().Tables[0];
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pais = new Pais() {Nome = tbNome.Text, Codigo = int.Parse(tbCodigo.Text)};
                PaisController pc = new PaisController();
                pc.Excluir(pais);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularFormulario();
        }

        private void PopularFormulario()
        {
            PaisController pc = new PaisController();
            pais = (Pais)pc.BuscarCodigo(int.Parse(tbBuscaCodigo.Text));
            tbNome.Text = pais.Nome;
            tbCodigo.Text = pais.Codigo.ToString();
            tbCodigo.ReadOnly = true;
          
            if (pais.Codigo == 0)
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
                Pais pais = new Pais() { Codigo = int.Parse(tbCodigo.Text), Nome = tbNome.Text};
                PaisController pc = new PaisController();
                pc.Alterar(pais);
            }
        }
    }
}
