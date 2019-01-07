using SRMTeste.Util;
using SRMTeste.Dados;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMTeste.Cadastro
{
    public partial class CadClientes : Form
    {
        ConexaoBD db = new ConexaoBD();
        delegate void GridDelegate();

        public CadClientes()
        {
            InitializeComponent();
        }

        #region Eventos
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) BuscarCEP();
        }
        private void CadClientes_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            LimparCampos();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            IncluirCliente();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarCliente();
        }

        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Buscar informacoes do Cliente de acordo com a selecao no grid
            ProcurarCliente(Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value));
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCliente();
        }
        private void btnIncluirCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IncluiClientesPorCSV(openFileDialog1.FileName);
            }
        }
        #endregion

        #region Metodos
        public void BuscarCEP()
        {
            ServicoCEP servico = new ServicoCEP();
            var endereco = servico.BuscarCEP(txtCEP.Text);
            if (endereco.Count == 0)
            {
                MessageBox.Show("CEP não encontrado");
                txtCEP.Focus();
                return;
            }
            foreach (string substring in endereco)
            {
                switch (substring.Split(':')[0].TrimStart())
                {
                    case "logradouro": txtRua.Text = substring.Split(':')[1]; break;
                    case "bairro": txtBairro.Text = substring.Split(':')[1]; break;
                    case "localidade": txtCidade.Text = substring.Split(':')[1]; break;
                    case "uf": txtEstado.Text = substring.Split(':')[1]; break;
                }
            }
        }

        private void CarregarGrid()
        {
            try
            {
                if (this.dgvClientes.InvokeRequired)
                {
                    this.Invoke(new GridDelegate(CarregarGrid));
                }
                else
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = db.BuscarTodosCliente();
                }
            }
            catch (Exception ex)
            {
                TrataExcecao(ex);
            }
        }

        private void LimparCampos()
        {
            cboNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            dtInclusao.Text = string.Empty;
            dtNasc.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtCredito.Text = string.Empty;
        }

        private void IncluirCliente()
        {
            try
            {
                Cliente novoCliente = new Cliente()
                {
                    Cod_Cliente = db.CodigoClienteIncremental(),
                    Nome_Cliente = cboNome.Text,
                    CPF = long.Parse(txtCPF.Text),
                    Data_Cadastro = DateTime.Parse(dtInclusao.Text),
                    Data_Nascimento = DateTime.Parse(dtNasc.Text),
                    Email = txtEmail.Text,
                    Endereco_CEP = txtCEP.Text,
                    Endereco_Cidade = txtCidade.Text,
                    Endereco_Complemento = txtComplemento.Text,
                    Endereco_Bairro = txtBairro.Text,
                    Endereco_Estado = txtEstado.Text,
                    Endereco_Numero = long.Parse(txtNumero.Text),
                    Endereco_Rua = txtRua.Text,
                    Telefone = long.Parse(txtTelefone.Text),
                    Valor_Credito = decimal.Parse(txtCredito.Text)
                };
                db.AdicionarCliente(novoCliente);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                TrataExcecao(ex);
            }
        }

        public void AlterarCliente()
        {
            try
            {
                Cliente cliente = db.BuscarCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value));
                cliente.Nome_Cliente = cboNome.Text;
                cliente.CPF = long.Parse(txtCPF.Text);
                cliente.Data_Cadastro = DateTime.Parse(dtInclusao.Text);
                cliente.Data_Nascimento = DateTime.Parse(dtNasc.Text);
                cliente.Email = txtEmail.Text;
                cliente.Endereco_CEP = txtCEP.Text;
                cliente.Endereco_Cidade = txtCidade.Text;
                cliente.Endereco_Complemento = txtComplemento.Text;
                cliente.Endereco_Bairro = txtBairro.Text;
                cliente.Endereco_Estado = txtEstado.Text;
                cliente.Endereco_Numero = long.Parse(txtNumero.Text);
                cliente.Endereco_Rua = txtRua.Text;
                cliente.Telefone = long.Parse(txtTelefone.Text);
                cliente.Valor_Credito = decimal.Parse(txtCredito.Text);
                db.AlterarCliente(cliente);
                CarregarGrid();
            }
            catch (Exception ex)
            {
                TrataExcecao(ex);
            }
        }

        public void ProcurarCliente(int codCliente)
        {
            Cliente cliente = db.BuscarCliente(codCliente);
            cboNome.Text = cliente.Nome_Cliente;
            txtCPF.Text = cliente.CPF.ToString();
            dtInclusao.Text = cliente.Data_Cadastro.ToString();
            dtNasc.Text = cliente.Data_Nascimento.ToString();
            txtEmail.Text = cliente.Email;
            txtCPF.Text = cliente.CPF.ToString();
            txtCEP.Text = cliente.Endereco_CEP.ToString();
            txtCidade.Text = cliente.Endereco_Cidade;
            txtComplemento.Text = cliente.Endereco_Complemento;
            txtBairro.Text = cliente.Endereco_Bairro;
            txtEstado.Text = cliente.Endereco_Estado;
            txtNumero.Text = cliente.Endereco_Numero.ToString();
            txtRua.Text = cliente.Endereco_Rua;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtCredito.Text = cliente.Valor_Credito.ToString();
        }

        public void ExcluirCliente()
        {
            try
            {
                db.ExcluirCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value));
                CarregarGrid();
            }
            catch(Exception ex)
            {
                TrataExcecao(ex);
            }
        }

        public void IncluiClientesPorCSV(string caminho)
        {
            //Dispara thread para dar a sensação ao usuario de fluidez, tela não congela
            var t = Task.Run(() =>
            {
                foreach (DataRow row in ClsCSV.LerCSV(caminho).Rows)
                {
                    Cliente cliente = new Cliente()
                    {
                        Cod_Cliente = db.CodigoClienteIncremental(),
                        Nome_Cliente = row["Nome_Cliente"].ToString(),
                        CPF = long.Parse(row["CPF"].ToString()),
                        Data_Cadastro = DateTime.Parse(row["Data_Cadastro"].ToString()),
                        Data_Nascimento = DateTime.Parse(row["Data_Nascimento"].ToString()),
                        Email = row["Email"].ToString(),
                        Endereco_CEP = row["Endereco_CEP"].ToString(),
                        Endereco_Cidade = row["Endereco_Cidade"].ToString(),
                        Endereco_Complemento = row["Endereco_Complemento"].ToString(),
                        Endereco_Bairro = row["Endereco_Bairro"].ToString(),
                        Endereco_Estado = row["Endereco_Estado"].ToString(),
                        Endereco_Numero = long.Parse(row["Endereco_Numero"].ToString()),
                        Endereco_Rua = row["Endereco_Rua"].ToString(),
                        Telefone = long.Parse(row["Telefone"].ToString()),
                        Valor_Credito = decimal.Parse(row["Valor_Credito"].ToString())
                    };
                    db.AdicionarCliente(cliente);
                }
            }).ContinueWith((Task v) =>
            {
                MessageBox.Show("Inclusão efetuada com sucesso!");
                CarregarGrid();
            });
        }

        private void TrataExcecao(Exception ex)
        {
            MessageBox.Show("Ocorreu um erro! \n" + ex.Message + ex.StackTrace);
        }
        #endregion
    }

}
