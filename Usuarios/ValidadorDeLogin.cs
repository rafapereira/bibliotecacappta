using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Usuarios
{
    public static class ValidadorDeLogin
    {
        public static bool LoginESenhaSaoValidos(string txtLogin, string txtSenha)
        {
            var usuario = FakeDb.listFuncionario.Where(funcionario => funcionario.Login == txtLogin && funcionario.Senha == txtSenha).FirstOrDefault();
            bool usuarioExiste = usuario != null;

            return usuarioExiste;
        }
    }
}