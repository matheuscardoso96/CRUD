using System;

namespace CRUD.view
{
    partial class ClienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscaCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRGIE = new System.Windows.Forms.TextBox();
            this.cbTP = new System.Windows.Forms.ComboBox();
            this.tbCodigoTipoPessoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCodigoEstado = new System.Windows.Forms.Label();
            this.tbCodigoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSNF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOgEx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCpfCnpj = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDataHora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome ou Razão Social";
            // 
            // tbBuscaCodigo
            // 
            this.tbBuscaCodigo.Location = new System.Drawing.Point(389, 20);
            this.tbBuscaCodigo.Name = "tbBuscaCodigo";
            this.tbBuscaCodigo.Size = new System.Drawing.Size(226, 20);
            this.tbBuscaCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buscar por Código";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(265, 20);
            this.tbNome.TabIndex = 6;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 227);
            this.dataGridView1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(621, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(283, 133);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(283, 162);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 10;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(283, 191);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(283, 220);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "RG ou Inscrição Estadual";
            // 
            // tbRGIE
            // 
            this.tbRGIE.Location = new System.Drawing.Point(15, 103);
            this.tbRGIE.Name = "tbRGIE";
            this.tbRGIE.Size = new System.Drawing.Size(130, 20);
            this.tbRGIE.TabIndex = 14;
            this.tbRGIE.TextChanged += new System.EventHandler(this.tbRGIE_TextChanged);
            // 
            // cbTP
            // 
            this.cbTP.FormattingEnabled = true;
            this.cbTP.Location = new System.Drawing.Point(154, 102);
            this.cbTP.Name = "cbTP";
            this.cbTP.Size = new System.Drawing.Size(123, 21);
            this.cbTP.TabIndex = 15;
            this.cbTP.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbCodigoTipoPessoa
            // 
            this.tbCodigoTipoPessoa.Location = new System.Drawing.Point(283, 102);
            this.tbCodigoTipoPessoa.Name = "tbCodigoTipoPessoa";
            this.tbCodigoTipoPessoa.ReadOnly = true;
            this.tbCodigoTipoPessoa.Size = new System.Drawing.Size(75, 20);
            this.tbCodigoTipoPessoa.TabIndex = 16;
            this.tbCodigoTipoPessoa.TextChanged += new System.EventHandler(this.tbCodigoTipoPessoa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "TipoPessoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código Tipo Pessoa";
            // 
            // lbCodigoEstado
            // 
            this.lbCodigoEstado.AutoSize = true;
            this.lbCodigoEstado.Location = new System.Drawing.Point(280, 4);
            this.lbCodigoEstado.Name = "lbCodigoEstado";
            this.lbCodigoEstado.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoEstado.TabIndex = 19;
            this.lbCodigoEstado.Text = "Código";
            // 
            // tbCodigoCliente
            // 
            this.tbCodigoCliente.Location = new System.Drawing.Point(283, 20);
            this.tbCodigoCliente.Name = "tbCodigoCliente";
            this.tbCodigoCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoCliente.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sobrenome ou Nome Fantasia";
            // 
            // tbSNF
            // 
            this.tbSNF.Location = new System.Drawing.Point(15, 62);
            this.tbSNF.Name = "tbSNF";
            this.tbSNF.Size = new System.Drawing.Size(262, 20);
            this.tbSNF.TabIndex = 22;
            this.tbSNF.TextChanged += new System.EventHandler(this.tbSNF_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Orgão Expedidor";
            // 
            // tbOgEx
            // 
            this.tbOgEx.Location = new System.Drawing.Point(12, 149);
            this.tbOgEx.Name = "tbOgEx";
            this.tbOgEx.Size = new System.Drawing.Size(265, 20);
            this.tbOgEx.TabIndex = 24;
            this.tbOgEx.TextChanged += new System.EventHandler(this.tbOgEx_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "CPF ou CNPJ";
            // 
            // tbCpfCnpj
            // 
            this.tbCpfCnpj.Location = new System.Drawing.Point(12, 188);
            this.tbCpfCnpj.Name = "tbCpfCnpj";
            this.tbCpfCnpj.Size = new System.Drawing.Size(265, 20);
            this.tbCpfCnpj.TabIndex = 26;
            this.tbCpfCnpj.TextChanged += new System.EventHandler(this.tbCpfCnpj_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Data e Hora do Registro";
            // 
            // tbDataHora
            // 
            this.tbDataHora.Location = new System.Drawing.Point(12, 227);
            this.tbDataHora.Name = "tbDataHora";
            this.tbDataHora.ReadOnly = true;
            this.tbDataHora.Size = new System.Drawing.Size(121, 20);
            this.tbDataHora.TabIndex = 28;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 285);
            this.Controls.Add(this.tbDataHora);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCpfCnpj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOgEx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSNF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodigoCliente);
            this.Controls.Add(this.lbCodigoEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCodigoTipoPessoa);
            this.Controls.Add(this.cbTP);
            this.Controls.Add(this.tbRGIE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBuscaCodigo);
            this.Controls.Add(this.label2);
            this.Name = "ClienteView";
            this.Text = "Controle de Clientes";
            this.Load += new System.EventHandler(this.ClienteView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscaCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRGIE;
        private System.Windows.Forms.ComboBox cbTP;
        private System.Windows.Forms.TextBox tbCodigoTipoPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCodigoEstado;
        private System.Windows.Forms.TextBox tbCodigoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSNF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOgEx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCpfCnpj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDataHora;
    }
}