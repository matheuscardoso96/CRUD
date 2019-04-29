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
    public partial class ClienteView : Form
    {
        List<TipoPessoa> tp = new List<TipoPessoa>();
        Cliente cliente = new Cliente();

        public ClienteView()
        {
            InitializeComponent();
            btCadastrar.Enabled = false;
            btExcluir.Enabled = false;
            btAlterar.Enabled = false;
            CarregarLista();
            tbCodigoCliente.ReadOnly = true;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClienteView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente() {Codigo = 0, CodigoTipoPessoa = int.Parse(tbCodigoTipoPessoa.Text), Registro = DateTime.Now, NomeRazaoSocial = tbNome.Text, SobrenomeNomeFantasia = tbSNF.Text, RgIE = tbRGIE.Text, OrgaoExpedidor = tbOgEx.Text, CpfCnpj = tbCpfCnpj.Text };
            ClientController cc = new ClientController();
            cc.Inserir(cliente);
            
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            tbCodigoCliente.ReadOnly = false;
            ChecarTextBox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void ChecarTextBox()
        {
            if (tbNome.Text.Length > 0 && tbCodigoTipoPessoa.Text.Length > 0 && tbRGIE.TextLength > 0
                && tbSNF.Text.Length > 0 && tbCpfCnpj.Text.Length > 0 && tbOgEx.Text.Length > 0)
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
            if (tbNome.Text.Length > 0 && tbCodigoTipoPessoa.Text.Length > 0 && tbRGIE.TextLength > 0
                && tbSNF.Text.Length > 0 && tbCpfCnpj.Text.Length > 0 && tbOgEx.Text.Length > 0)
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
           
            string s = cbTP.GetItemText(cbTP.SelectedItem).ToString();

            CbTipoPessoa(s);

            ComboTextBox();
        }

        private void CbTipoPessoa(string s)
        {
            var consulta = tp.Where(p => p.Descricao == s).Select(p => new { p.Codigo, p.Descricao }).Single();

            tbCodigoTipoPessoa.Text = consulta.Codigo.ToString();

            ComboTextBox();
        }



        private void CarregarLista()
        {
            ClientController cc = new ClientController();
            tp = cc.Select();
            foreach (TipoPessoa tps in tp)
            {
                cbTP.Items.Add(tps.Descricao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopularFormulario();
        }

        private void PopularFormulario()
        {
            ClientController cc = new ClientController();
            cliente = (Cliente)cc.BuscarCodigo(int.Parse(tbBuscaCodigo.Text));
            tbCodigoCliente.Text = cliente.Codigo.ToString();
            tbNome.Text = cliente.NomeRazaoSocial;
            tbSNF.Text = cliente.SobrenomeNomeFantasia;
            tbRGIE.Text = cliente.RgIE;
            tbOgEx.Text = cliente.OrgaoExpedidor;
            tbCpfCnpj.Text = cliente.CpfCnpj;
            tbDataHora.Text = cliente.Registro.ToString();

            BotaoEstatusBusca();

            try
            {
                var consulta = tp.Where(p => p.Codigo == cliente.CodigoTipoPessoa).Select(p => new { p.Codigo, p.Descricao }).Single();
                tbCodigoTipoPessoa.Text = consulta.Codigo.ToString();
                cbTP.Text = consulta.Descricao;

                tbCodigoCliente.ReadOnly = true;
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
                Cliente cliente = new Cliente() { Codigo = int.Parse(tbCodigoCliente.Text), CodigoTipoPessoa = int.Parse(tbCodigoTipoPessoa.Text), Registro = DateTime.Now, NomeRazaoSocial = tbNome.Text, SobrenomeNomeFantasia = tbSNF.Text, RgIE = tbRGIE.Text, OrgaoExpedidor = tbOgEx.Text, CpfCnpj = tbCpfCnpj.Text };
                ClientController cc = new ClientController();
                cc.Alterar(cliente);
            }


        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            ClientController cc = new ClientController();
            dataGridView1.DataSource = cc.Consultar().Tables[0];
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente remover esse registro?", "Alerta", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cliente cliente = new Cliente() { Codigo = int.Parse(tbCodigoCliente.Text), CodigoTipoPessoa = int.Parse(tbCodigoTipoPessoa.Text), Registro = DateTime.Now, NomeRazaoSocial = tbNome.Text, SobrenomeNomeFantasia = tbSNF.Text, RgIE = tbRGIE.Text, OrgaoExpedidor = tbOgEx.Text, CpfCnpj = tbCpfCnpj.Text };
                ClientController cc = new ClientController();
                cc.Excluir(cliente);
            }
        }

        private void tbSNF_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void tbRGIE_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void tbCodigoTipoPessoa_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void tbOgEx_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }

        private void tbCpfCnpj_TextChanged(object sender, EventArgs e)
        {
            ChecarTextBox();
        }
    }
}
