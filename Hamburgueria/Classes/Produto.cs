using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.Classes
{
    internal class Produto
    {
        #region Propriedades 
        public int Id { get; set; }

        public string NomeProduto { get; set; }
        public string Descricao { get; set; }

        public int PrecoPedido { get; set; }

        public bool Ativo { get; set; }


        #endregion



        #region Construtores 
        public Produto()
        {


        }
        public Produto(int id, string nomeProduto, string descricao, int precoPedido, bool ativo)
        {
            Id = id;
            NomeProduto = nomeProduto;
            Descricao = descricao;
            PrecoPedido = precoPedido;
            Ativo = ativo;
        }

        #endregion



        #region Metodo

        public void Cadastrar()
        {

        }

        #endregion
    }
}
