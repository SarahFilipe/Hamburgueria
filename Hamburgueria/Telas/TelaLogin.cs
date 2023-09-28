using Hamburgueria.Classes;
using Hamburgueria.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            TxtEmail.Text = "admin@gmail.com";
            TxtSenha.Text = "123";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           

            try
            {
                Funcionario funcionarioLogado = Funcionario.RealizarLogin(TxtEmail.Text, TxtSenha.Text);

                if (funcionarioLogado.Senha == Crypto.Sha256("123"))
                {

                    TelaPrincipal tlPrincipal = new TelaPrincipal(funcionarioLogado);
                    this.Hide();
                    tlPrincipal.ShowDialog();
                    this.Show();
                    TxtSenha.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
