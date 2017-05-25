using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.Usuarios
{
        
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public DateTime Datacadastro { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cargo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public List<Aluguel> aluguelCliente { get; set; }

        public Funcionario(FuncionarioDTO funcionarioDTO)
        {           
        }

        public int pegaId()
        {
            int contador = 0;

            foreach (var id in FakeDb.listFuncionario)
            {
                contador++;
                return contador;
            }
            return 0;
        }

        public SeletorTipoDeUsuario checkTipo(Funcionario usuario)
        {
            foreach (var funcionario in FakeDb.listFuncionario)
            {
                if (usuario is Admin)
                {
                    return SeletorTipoDeUsuario.Admin ;
                }
                else if (usuario is Bibliotecario)
                {
                    return SeletorTipoDeUsuario.Bibliotecario;
                }
                else if (usuario is Cliente)
                {
                    return SeletorTipoDeUsuario.Cliente;
                }
            }
            return SeletorTipoDeUsuario.NenhumTipo;
        }

        public bool checaSeUsuarioEhAdmin(Funcionario funcionarioBiblioteca)
        {
            var usuario = FakeDb.listFuncionario.FirstOrDefault(funcionario => funcionario.Nome == funcionarioBiblioteca.Login && funcionario is Admin);
            bool usuarioEhAdmin = usuario != null;
            return usuarioEhAdmin;
        }

        public int contaAlugueisFuncionario(Funcionario funcionario)
        {
            foreach (var user in FakeDb.listFuncionario)
            {
                int count = 0;

                if (funcionario.Nome == user.Nome && user.aluguelCliente.Count > 0)
                {
                    count = user.aluguelCliente.Count;
                    return count;
                }
            }
            return 1;
        }

        public bool EhAdminOuBibliotecario(Funcionario usuario)
        {
            if (checkTipo (usuario) == SeletorTipoDeUsuario.Admin || checkTipo(usuario) == SeletorTipoDeUsuario.Bibliotecario)
            {
                return true;
            }
            return false;
        }
    }
}
