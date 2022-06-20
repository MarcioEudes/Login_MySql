using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_MySql_Verificacao_Email_Senha.Conexão
{
    public interface IUsuario
    {
       bool VerificarLogin(string email, string senha);
    }
}
