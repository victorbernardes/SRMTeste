namespace SRMTeste.Cadastro
{
    partial class CadClientes
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.lblDtInclusao = new System.Windows.Forms.Label();
            this.cboNome = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.dtNasc = new System.Windows.Forms.DateTimePicker();
            this.dtInclusao = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tspUtil = new System.Windows.Forms.ToolStrip();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluirCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(58, 31);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(58, 72);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(58, 112);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 2;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(290, 112);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero:";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(497, 112);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 4;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(290, 147);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(497, 147);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(290, 72);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(212, 13);
            this.lblCEP.TabIndex = 7;
            this.lblCEP.Text = "CEP (busca automatica pressione ENTER):";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(290, 31);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(92, 13);
            this.lblDtNasc.TabIndex = 8;
            this.lblDtNasc.Text = "Data Nascimento:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(58, 184);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(290, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.AutoSize = true;
            this.lblValorCredito.Location = new System.Drawing.Point(290, 217);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(70, 13);
            this.lblValorCredito.TabIndex = 12;
            this.lblValorCredito.Text = "Valor Crédito:";
            // 
            // lblDtInclusao
            // 
            this.lblDtInclusao.AutoSize = true;
            this.lblDtInclusao.Location = new System.Drawing.Point(58, 217);
            this.lblDtInclusao.Name = "lblDtInclusao";
            this.lblDtInclusao.Size = new System.Drawing.Size(76, 13);
            this.lblDtInclusao.TabIndex = 11;
            this.lblDtInclusao.Text = "Data Inclusao:";
            // 
            // cboNome
            // 
            this.cboNome.FormattingEnabled = true;
            this.cboNome.Location = new System.Drawing.Point(150, 28);
            this.cboNome.Name = "cboNome";
            this.cboNome.Size = new System.Drawing.Size(121, 21);
            this.cboNome.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(150, 69);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(121, 20);
            this.txtCPF.TabIndex = 14;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(150, 109);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(121, 20);
            this.txtRua.TabIndex = 15;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(366, 144);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(121, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(150, 184);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(121, 20);
            this.txtTelefone.TabIndex = 17;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(589, 65);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(121, 20);
            this.txtCEP.TabIndex = 19;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(366, 109);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 20;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(589, 109);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(121, 20);
            this.txtComplemento.TabIndex = 21;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(589, 144);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(121, 20);
            this.txtEstado.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(366, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(366, 210);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(121, 20);
            this.txtCredito.TabIndex = 24;
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(431, 29);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(121, 20);
            this.dtNasc.TabIndex = 25;
            // 
            // dtInclusao
            // 
            this.dtInclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInclusao.Location = new System.Drawing.Point(150, 211);
            this.dtInclusao.Name = "dtInclusao";
            this.dtInclusao.Size = new System.Drawing.Size(121, 20);
            this.dtInclusao.TabIndex = 26;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(61, 311);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(677, 230);
            this.dgvClientes.TabIndex = 27;
            this.dgvClientes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellEnter);
            // 
            // tspUtil
            // 
            this.tspUtil.Location = new System.Drawing.Point(0, 0);
            this.tspUtil.Name = "tspUtil";
            this.tspUtil.Size = new System.Drawing.Size(800, 25);
            this.tspUtil.TabIndex = 28;
            this.tspUtil.Text = "toolStrip1";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(150, 147);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(121, 20);
            this.txtBairro.TabIndex = 30;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(58, 150);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(123, 260);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(92, 32);
            this.btnIncluir.TabIndex = 31;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(258, 260);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(92, 32);
            this.btnAlterar.TabIndex = 32;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(384, 260);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(92, 32);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluirCSV
            // 
            this.btnIncluirCSV.Location = new System.Drawing.Point(525, 260);
            this.btnIncluirCSV.Name = "btnIncluirCSV";
            this.btnIncluirCSV.Size = new System.Drawing.Size(185, 32);
            this.btnIncluirCSV.TabIndex = 34;
            this.btnIncluirCSV.Text = "Incluir com Planilha";
            this.btnIncluirCSV.UseVisualStyleBackColor = true;
            this.btnIncluirCSV.Click += new System.EventHandler(this.btnIncluirCSV_Click);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnIncluirCSV);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.tspUtil);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.dtInclusao);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.cboNome);
            this.Controls.Add(this.lblValorCredito);
            this.Controls.Add(this.lblDtInclusao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDtNasc);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "CadClientes";
            this.Text = "CadClientes";
            this.Load += new System.EventHandler(this.CadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblValorCredito;
        private System.Windows.Forms.Label lblDtInclusao;
        private System.Windows.Forms.ComboBox cboNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.DateTimePicker dtNasc;
        private System.Windows.Forms.DateTimePicker dtInclusao;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ToolStrip tspUtil;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluirCSV;
    }
}