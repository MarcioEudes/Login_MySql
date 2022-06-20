using Exercicio_MySql_Verificacao_Email_Senha.Conexão;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_MySql_Verificacao_Email_Senha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            bool loginValido = false;

            IUsuario usuario = new Usuario();

            loginValido = usuario.VerificarLogin(txtEmail.Text, txtSenha.Text);


            if (loginValido)
            {
                MessageBox.Show(@"O email e/ou senha existem no banco de dados!", "Veficaçao",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"O email e/ou senha não existem no banco de dados!",
                                   "Verificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
