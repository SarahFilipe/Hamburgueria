using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hamburgueria.Classes
{
    public class Funcionario
    {
        #region Propriedades 
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public DateTime DtNascimento { get; set; }

        public string Sexo { get; set; }

        public bool Ativo { get; set; }

        public string Cargo { get; set; }

        #endregion

        #region Construtores 

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, string email, string senha, DateTime dtNascimento, string sexo, bool ativo, string cargo)
        {
            id = Id;
            Nome = nome;
            Email = email;
            Senha = senha;
            DtNascimento = dtNascimento;
            this.Sexo = sexo;
            this.Ativo = ativo;
            this.Cargo = cargo;
        }


        #endregion

        #region Metodos 

        public static Funcionario RealizarLogin(string email, string senha)
        {
            Conexao cn;
            Funcionario funcionario = new Funcionario();

            try
            {


                string query = ($"select * from Funcionarios where Email = '{email}'");
                cn = new Conexao(query);

                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();

                if (cn.dr.HasRows == true)
                {
                    while (cn.dr.Read())
                    {

                        funcionario.Id = Convert.ToInt32(cn.dr[0]);
                        funcionario.Nome = cn.dr[1].ToString();
                        funcionario.Email = cn.dr[2].ToString();
                        funcionario.Senha = cn.dr[3].ToString();
                        funcionario.DtNascimento = Convert.ToDateTime(cn.dr[4]);
                        funcionario.Sexo = cn.dr[5].ToString();
                        funcionario.Ativo = Convert.ToBoolean(cn.dr[6]);
                        funcionario.Cargo = (cn.dr[7]).ToString();

                    }

                }
                else
                {
                    // Não teve retorno de linhas
                    throw new Exception("E-mail inexistente!");

                }

                if (funcionario.Senha == Crypto.Sha256(senha))
                {
                    if (funcionario.Ativo)
                    {
                        //com acesso
                        return funcionario;
                    }
                    else
                    {
                        // usuario bloqueado
                        throw new Exception("Usuário bloqueado");

                    }
                }
                else
                {
                    // senha errada
                    throw new Exception("Senha incorreta");
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        public void CadastrarFuncionario(List<Funcionario> funcionarios)
        {
            string querry = ($"Insert into Funcionarios values ('{Nome}','{Email}','{Senha}', '{DtNascimento}', '{Sexo}', 1, '{Cargo}');");
            querry += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(querry);

            try
            {
                cn.AbrirConexao();
                this.Id = Convert.ToInt32(cn.comando.ExecuteScalar());

                funcionarios.Add(this);
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

        public void Alterar(List<Funcionario> funcionarios)
        {

            string query = ($"update Funcionario set Nome = '{Nome}', Email = '{Email}', Senha = '{Senha}', DataNascimento = '{DtNascimento}', Sexo = '{Sexo}', 1 , Cargo = {Cargo} where Id = {Id} ");
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
        public void Deletar(List<Funcionario> funcionarios)
        {


            string query = ($"update Funcionario set Ativo = '{0}' where Id = {Id}");
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

    }

    #endregion
}

