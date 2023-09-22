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
    public partial class TelaPrincipal : Form
    {
        private Funcionario _funcionarioLogado;
        public TelaPrincipal(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            if (_funcionarioLogado.Cargo != "Gerente")
            {
                TsiCadastro.Visible = false;
            }
            LblUserLogado.Text = _funcionarioLogado.Nome;
        }

        public void TsiFuncionarios_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncionario tlcadastrofuncionario = new TelaCadastroFuncionario(_funcionarioLogado);
            tlcadastrofuncionario.MdiParent = this;
            tlcadastrofuncionario.Show();
        }

        public void TsiProdutos_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto tlcadastroproduto = new TelaCadastroProduto(_funcionarioLogado);
                      
            tlcadastroproduto.MdiParent = this;
            tlcadastroproduto.Show();
        }

    
    }
}
