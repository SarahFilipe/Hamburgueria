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
        Funcionario _funcionarioLogado;

        public TelaCadastroFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;

        }

        private void TelaCadastroFuncionario_Load(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                if (WindowState != FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Maximized;
                    MaximumSize = this.Size;

                    if (WindowState == FormWindowState.Maximized)
                    {

                    }
                }
            }
        }
    }
}
