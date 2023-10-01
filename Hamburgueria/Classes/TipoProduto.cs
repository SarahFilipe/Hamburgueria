using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.Classes
{
    internal class TipoProduto
    {
        #region Propriedades
        public int Id { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        #endregion

        #region Construtores

        public TipoProduto()
        {

        }

        public TipoProduto(int id, string descricao, bool ativo)
        {
            Id = id;
            Descricao = descricao;
            Ativo = ativo;
        }

        #endregion

        #region Métodos

        public static List<TipoProduto> BuscarTudo()
        {
            string query = ("Select * from TipoProduto");
            Conexao cn = new Conexao(query);

            List<TipoProduto> tipoProdutos = new List<TipoProduto>();

            try
            {

                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();

                while (cn.dr.Read())
                {
                    tipoProdutos.Add(new TipoProduto()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Descricao = Convert.ToString(cn.dr[1]),
                        Ativo = Convert.ToBoolean(cn.dr[2]),
                    });
                }
                return tipoProdutos;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static List<TipoProduto> Buscar(List<TipoProduto> tiposProdutos, int ValorCbbTipo, string texto)
        {
            switch (ValorCbbTipo)
            {
                case 1:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 2:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 3:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 4:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 5:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                case 6:
                    return tiposProdutos.Where(a => a.Descricao.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();

                default:
                    return tiposProdutos;

            }

        }

        #endregion

    }
}
