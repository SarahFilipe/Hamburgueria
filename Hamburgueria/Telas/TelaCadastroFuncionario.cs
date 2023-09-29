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

        public TelaCadastroFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;
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

            DgvFuncionarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Sexo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvFuncionarios.Columns["Cargo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

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

            if (_funcionarioLogado.Cargo != "Gerente")
            {
                foreach (Funcionario funcionario in funcionarios)
                {
                    if (funcionario.Ativo == true)
                    {
                        DgvFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Email, funcionario.DtNascimento.ToString("dd/MM/yy"), funcionario.Sexo, funcionario.Ativo, funcionario.Cargo);
                    }
                }
            }
            else
            {
                foreach (Funcionario funcionario in funcionarios )
                {
                    DgvFuncionarios.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Email, funcionario.DtNascimento.ToString("dd/MM/yy"), funcionario.Sexo, funcionario.Ativo, funcionario.Cargo);

                    if (!funcionario.Ativo)
                    {
                        DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                    }

                }
            }
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

        private void TelaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            ConfiguraDgvFuncionarios();
            CarregarDgvFuncionarios();
        }
    }
}

