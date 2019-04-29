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
    public partial class UfView : Form
    {
        List<Pais> ps = new List<Pais>();
        Uf estado = new Uf();

        public UfView()
        {
            InitializeComponent();
            btCadastrar.Enabled = false;
            btExcluir.Enabled = false;
            btAlterar.Enabled = false;
            CarregarLista();
            tbCodigoEstado.ReadOnly = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UfView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uf estado = new Uf() {Codigo_Pais = int.Parse(tbCodigoPais.Text), Nome = tbNome.Text, Sigla = tbSigla.Text };
            UfController uc = new UfController();
            uc.Inserir(estado);
            
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            tbCodigoEstado.ReadOnly = false;
            ChecarTextBox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void ChecarTextBox()
        {
            if (tbNome.Text.Length > 0 && tbCodigoPais.Text.Length > 0 && tbSigla.TextLength > 0)
            {
                btCadastrar.Enabled = true;
            }
            else
            {
                btCadastrar.Enabled = false;
            }
        }

        private void ComboTextBox()
        {
            if (tbNome.Text.Length > 0 && tbCodigoPais.Text.Length > 0 && tbSigla.TextLength > 0)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string s = cbPais.GetItemText(cbPais.SelectedItem).ToString();

            CbPais(s);

            ComboTextBox();
        }

        private void CbPais(string s)
        {
            var consulta = ps.Where(p => p.Nome == s).Select(p => new { p.Codigo, p.Nome }).Single();

            tbCodigoPais.Text = consulta.Codigo.ToString();

            ComboTextBox();
        }



        private void CarregarLista()
        {
            UfController uc = new UfController();
            ps = uc.Select();
            foreach (Pais p in ps)
            {
                cbPais.Items.Add(p.Nome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularFormulario();
        }

        private void PopularFormulario()
        {
            UfController uc = new UfController();
            estado = (Uf)uc.BuscarCodigo(int.Parse(tbBuscaCodigo.Text));
            tbNome.Text = estado.Nome;
            tbCodigoEstado.Text = estado.Codigo.ToString();
            tbSigla.Text = estado.Sigla;
            BotaoEstatusBusca();

            try
            {
                var consulta = ps.Where(p => p.Codigo == estado.Codigo_Pais).Select(p => new { p.Codigo, p.Nome }).Single();
                tbCodigoPais.Text = consulta.Codigo.ToString();
                cbPais.Text = consulta.Nome;

                tbCodigoEstado.ReadOnly = true;
            }
            catch (Exception e)
            {

                btAlterar.Enabled = false;
                btExcluir.Enabled = false;

                MessageBox.Show("Código inexistente.");
            }
            

            
            
            
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
                Uf estado = new Uf() { Codigo = int.Parse(tbCodigoEstado.Text), Codigo_Pais = int.Parse(tbCodigoPais.Text), Nome = tbNome.Text, Sigla = tbSigla.Text };
                UfController uc = new UfController();
                uc.Alterar(estado);
            }


        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            UfController uc = new UfController();
            dataGridView1.DataSource = uc.Consultar().Tables[0];
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Uf estado = new Uf() { Codigo = int.Parse(tbCodigoEstado.Text), Codigo_Pais = int.Parse(tbCodigoPais.Text), Nome = tbNome.Text, Sigla = tbSigla.Text };
                UfController uc = new UfController();
                uc.Excluir(estado);
            }
        }

        private void tbCodigoPais_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void tbSigla_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }
    }
}
