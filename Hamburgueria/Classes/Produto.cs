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

        public int CodTipoProduto { get; set; }

        public TipoProduto TipoProduto { get; set; }

        public string NomeProduto { get; set; }
       
        public string Descricao { get; set; }

        public double ValorProduto { get; set; }

        public bool Ativo { get; set; }


        #endregion



        #region Construtores 
        public Produto()
        {


        }
        public Produto(int id, int tipoProduto, string nomeProduto, string descricao, double precoProduto, bool ativo)
        {
            Id = id;
            CodTipoProduto = tipoProduto;  
            NomeProduto = nomeProduto;
            Descricao = descricao;
            ValorProduto = precoProduto;
            Ativo = ativo;
        }

        #endregion



        #region Metodo

        public void Cadastrar(List<Produto> produtos)
        {

            string query = ($"insert into Produto VALUES ({CodTipoProduto}, '{NomeProduto}', '{Descricao}', {ValorProduto}, 1)");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                this.Id = Convert.ToInt32(cn.comando.ExecuteScalar());

                produtos.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public void Alterar(List<Produto> produtos)
        {

            string query = ($"update Produto set Id = '{Id}', '{CodTipoProduto}', NomeProduto = '{NomeProduto}', Descricao = '{Descricao}', PrecoPedido = '{ValorProduto}', ativo = '{Ativo}'  where Id = {Id} ");
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Deletar(List<Produto> produtos)
        {
            string query = ($"update Produto set Ativo = '{0}' where Id = {Id} ");
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;

            }
        }
        public static List<Produto> Buscar(List<Produto> produtos, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 1:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 2:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 3:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 4:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 5:
                    return produtos.Where(a => a.TipoProduto.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                default:
                    return produtos;

            }

        }
        #endregion
    }
}
