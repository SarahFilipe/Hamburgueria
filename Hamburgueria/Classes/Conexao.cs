using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.Classes
{
    internal class Conexao
    {
        #region Variáveis

        //String de Conexão                                 Informações CHUMBADAS - HardCode
        private static string _strConexao = @"Data Source=VPR0687139W10-1;Initial Catalog=ComoComerSeuBurgao; Integrated Security=True";
        private static string _strConexao1 = @"Data Source=CRIS\SQLEXPRESS2023;Initial Catalog=ComoComerSeuBurgao; Integrated Security=True";


        //Variáveis de uso (podem ou não serem usadas ao decorrer do projeto)
        public SqlConnection conexao = new SqlConnection(_strConexao1);
        public SqlCommand comando; // Armazenar a query
        public SqlDataAdapter da; // Adaptador para alguns componentes 
        public SqlDataReader dr; // Recebe os select's
        public DataSet ds; // trabalha com múltiplas tabelas

        #endregion

        #region Construtores

        public Conexao(string query)
        {
            comando = new SqlCommand(query, conexao); // Comando montado
            da = new SqlDataAdapter(query, conexao); // Caso necessário, está pronto
            ds = new DataSet(); // Se necessário
        }

        #endregion

        #region Métodos

        // Um método para abri conexão com o banco

        public void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }

            conexao.Open();
        }

        // Um método para fechar conexão com o banco

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        #endregion
    }
}
