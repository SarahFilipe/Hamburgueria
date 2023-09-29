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
      
        public TelaCadastroProduto(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;        
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
                    Produto produto = new Produto(0, TxtNome.Text, TxtDescricao.Text, Convert.ToDouble(TxtPreço.Text), true);
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

                throw;
            }
            
        }
    }
}
