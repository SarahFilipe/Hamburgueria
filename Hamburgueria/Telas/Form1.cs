using Hamburgueria.Classes;
using Hamburgueria.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgueria
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioLogado = Funcionario.RealizarLogin(TxtEmail.Text, TxtSenha.Text);

            TelaPrincipal tlPrincipal = new TelaPrincipal(funcionarioLogado);
            this.Hide();
            tlPrincipal.ShowDialog();
            this.Show();
            TxtSenha.Clear();

        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                BtnLogin.PerformClick();
            }

        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }
    }
}
