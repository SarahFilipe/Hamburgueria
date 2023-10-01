using Hamburgueria.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgueria.Telas
{
    public partial class TelaCadastroProduto : Form
    {
        private Funcionario _funcionarioLogado;
        private List<Produto> _produtos = new List<Produto>();
        private List<TipoProduto> _tiposprodutos = new List<TipoProduto>();

        public TelaCadastroProduto(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvProdutos();
                CbbTipo.DataSource = TipoProduto.BuscarTudo();
                CbbTipo.DisplayMember = "Descricao";
                CbbTipo.ValueMember = "Id";
                CbbBuscar.DataSource = TipoProduto.BuscarTudo();
                CbbBuscar.DisplayMember = "Descricao";
                CbbBuscar.ValueMember = "Id";
                CarregaDgvProdutos();
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_funcionarioLogado.Cargo == "Gerente")
                {
                    Produto produto = new Produto(0, (int)CbbTipo.SelectedValue, TxtNome.Text, TxtDescricao.Text, Convert.ToDouble(TxtPreço.Text), true);
                    produto.Cadastrar(_produtos);
                }
                else
                {
                    BtnCadastrar.Enabled = false;
                    MessageBox.Show($"Você não possui permissão para tal ação!!!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ConfiguraDgvProdutos()
        {
            DgvProdutos.Columns.Add("Id", "Id");
            DgvProdutos.Columns.Add("NomeProduto", "Nome");
            DgvProdutos.Columns.Add("TipoProduto", "Tipo");
            DgvProdutos.Columns.Add("PrecoProduto", "Preço");
            DgvProdutos.Columns.Add("Ativo", "Ativo");
            //--------
            //Configuração dos alinhamentos de cada coluna do DgvUsuarios

            DgvProdutos.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProdutos.Columns["NomeProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvProdutos.Columns["TipoProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProdutos.Columns["PrecoProduto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvProdutos.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvProdutos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvProdutos.Columns["NomeProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvProdutos.Columns["TipoProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvProdutos.Columns["PrecoProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvProdutos.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            //Configuarar tamanho em altura das linhas
            DgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvProdutos.ColumnHeadersHeight = 35;
            DgvProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void CarregaDgvProdutos(List<Produto> produtos = null)
        {
            DgvProdutos.Rows.Clear();


            foreach (Produto produto in produtos == null ? _produtos : produtos)
            {
                DgvProdutos.Rows.Add(produto.Id, produto.NomeProduto, produto.CodTipoProduto, produto.ValorProduto, produto.Ativo);

                if (!produto.Ativo)
                {
                    DgvProdutos.Rows[DgvProdutos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void LimparCampos()
        {
            LblId.Text = string.Empty;            
            TxtNome.Clear();                        
            CbAtivo.Checked = true;
            CbAtivo.Enabled = false;
            DgvProdutos.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;            
            CbbBuscar.SelectedValue = 1;
            BtnAlterar.BackColor = Color.Silver;
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<TipoProduto> ListaAlunosFiltrada = TipoProduto.Buscar(_tiposprodutos, (int)CbbBuscar.SelectedValue, TxtBuscar.Text);
        }
    }
}
