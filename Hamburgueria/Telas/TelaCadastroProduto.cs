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
        Funcionario _funcionarioLogado;
        public TelaCadastroProduto(Funcionario funcionario)
        {
            InitializeComponent();
            _funcionarioLogado = funcionario;
        }

      
    }
}
