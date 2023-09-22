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
        public string Id { get; set; }

        public string NomeProduto { get; set; }

        public int PrecoPedido { get; set; }

        public bool Ativo { get; set; }


        #endregion



        #region Construtores 
        public Produto()
        {


        }
        public Produto(string id, string nomeProduto, int precoPedido, bool ativo)
        {
            Id = id;
            NomeProduto = nomeProduto;
            PrecoPedido = precoPedido;
            Ativo = ativo;
        }

        #endregion



        #region Metodo



        #endregion
    }
}
