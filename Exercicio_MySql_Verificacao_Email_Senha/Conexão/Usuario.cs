using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_MySql_Verificacao_Email_Senha.Conexão
{
    public class Usuario : IUsuario
    {
        public bool VerificarLogin(string email, string senha)
        {
            bool loginValido = false;

            string conexaoMySql = "Server=localhost;Database=pessoas;Uid=root;Pwd=root;";

            MySqlConnection conexao = new MySqlConnection(conexaoMySql);

            string query = $@"select * from usuario
            where email = '{email}' and senha = '{senha}'";

            DataTable tabela = new DataTable();
            try
            {
                conexao.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                adapter.Fill(tabela);

                if (tabela.Rows.Count != 0)
                {
                    loginValido = true;
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

            return loginValido;
        }
    }
}
