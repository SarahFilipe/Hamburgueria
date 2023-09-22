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

    }
}
