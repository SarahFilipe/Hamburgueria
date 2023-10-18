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
    public partial class TelaCadastroFuncionario : Form
    {
        private Funcionario _funcionarioLogado;
        private List<Funcionario> _funcionarios = new List<Funcionario>();
        private Funcionario _funcionarioSelecionado;

        public TelaCadastroFuncionario(Funcionario funcionario)
        {
            InitializeComponent();

            try
            {

                _funcionarios = Funcionario.BuscarFuncionario().ConvertAll(u => (Funcionario)u);
                _funcionarioLogado = funcionario;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ;


        }
        private void TelaCadastroFuncionario_Load(object sender, EventArgs e)
        {

            {

                try
                {
                    ConfiguraDgvFuncionarios();
                    CarregarDgvFuncionarios();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfiguraDgvFuncionarios()
        {
            DgvFuncionarios.Columns.Add("Id", "Id");
            DgvFuncionarios.Columns.Add("Nome", "Nome");
            DgvFuncionarios.Columns.Add("Email", "e-mail");
            DgvFuncionarios.Columns.Add("DtNascimento", "Data Nascimento");
            DgvFuncionarios.Columns.Add("Sexo", "Sexo");
            DgvFuncionarios.Columns.Add("Ativo", "Ativo");
            DgvFuncionarios.Columns.Add("Cargo", "Cargo");
            //--------
            //Configuração dos alinhamentos de cada coluna do DgvUsuarios

            DgvFuncionarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvFuncionarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Sexo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Cargo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvFuncionarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvFuncionarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvFuncionarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Sexo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Cargo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //Configuarar tamanho em altura das linhas
            DgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DgvFuncionarios.ColumnHeadersHeight = 35;
            DgvFuncionarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Definindo uma cor para intercalar linhas
            DgvFuncionarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void CarregarDgvFuncionarios(List<Funcionario> funcionarios = null)
        {

            DgvFuncionarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios == null ? _funcionarios : funcionarios)
            {
                DgvFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Email, funcionario.DtNascimento.ToString("dd/MM/yy"), funcionario.Sexo, funcionario.Ativo, funcionario.Cargo);

                if (!funcionario.Ativo)
                {
                    DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                }

            }

        }

        private void LimparCampos()
        {
            LblId.Text = string.Empty;
            TxtEmail.Clear();
            TxtSexo.Clear();
            TxtCargo.Clear();
            TxtNome.Clear();
            DtpDataNascimento.Value = DateTime.Now;
            CbAtivo.Checked = true;
            CbAtivo.Enabled = false;
            DgvFuncionarios.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            CbbBuscar.SelectedIndex = 0;
            BtnAlterar.BackColor = Color.Silver;
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_funcionarioLogado.Cargo == "Gerente")
                {
                    Funcionario funcionario = new Funcionario(0, TxtNome.Text, TxtEmail.Text, Crypto.Sha256("123"), DtpDataNascimento.Value, TxtSexo.Text, true, TxtCargo.Text);
                    funcionario.CadastrarFuncionario(_funcionarios);

                    CarregarDgvFuncionarios();



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



        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    _funcionarioSelecionado.Nome = TxtNome.Text;
                    _funcionarioSelecionado.Email = TxtEmail.Text;
                    _funcionarioSelecionado.DtNascimento = DtpDataNascimento.Value;
                    _funcionarioSelecionado.Sexo = TxtSexo.Text;
                    _funcionarioSelecionado.Cargo = TxtCargo.Text;


                    _funcionarioSelecionado.Alterar(_funcionarios);
                    CarregarDgvFuncionarios();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Funcionario> ListaFuncionarios = Funcionario.Buscar(_funcionarios, CbbBuscar.SelectedIndex, TxtBuscar.Text);
            CarregarDgvFuncionarios(ListaFuncionarios);
        }

        private void DgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvFuncionarios.Rows.Count < 1 || DgvFuncionarios.SelectedRows.Count < 1)
                return;

            try
            {
                _funcionarioSelecionado = _funcionarios.Find(a => a.Id == (int)DgvFuncionarios.SelectedRows[0].Cells[0].Value);

                LblId.Text = _funcionarioSelecionado.Id.ToString();
                TxtNome.Text = _funcionarioSelecionado.Nome.ToString();
                TxtEmail.Text = _funcionarioSelecionado.Email.ToString();
                TxtCargo.Text = _funcionarioSelecionado.Cargo.ToString();
                TxtSexo.Text = _funcionarioSelecionado.Sexo.ToString();
                DtpDataNascimento.Value = _funcionarioSelecionado.DtNascimento;
                CbAtivo.Checked = _funcionarioSelecionado.Ativo;
                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você deseja reativar o funcionário  {_funcionarioSelecionado.Nome}?"
                                , "Reativar Funcionário"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _funcionarioSelecionado.Ativo = true;
                    _funcionarioSelecionado.Reativar(_funcionarios);
                    CarregarDgvFuncionarios();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }
    }

}

