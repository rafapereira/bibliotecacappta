using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeUsuarios
    {
        public static void criaEInsereAdmin(FuncionarioDTO funcionarioDTO)
        {
            Admin admin = new Admin(funcionarioDTO);
            add(admin);
        }

        public static void criaEInsereBibliotecario(FuncionarioDTO funcionarioDTO)
        {
            Bibliotecario bibliotecario = new Bibliotecario(funcionarioDTO);
            add(bibliotecario);
        }

        public static void criaEInsereCliente(FuncionarioDTO funcionarioDTO)
        {
            Cliente cliente = new Cliente(funcionarioDTO);
            add(cliente);
        }

        private static void add(Funcionario funcionario)
        {
            FakeDb.listFuncionario.Add(funcionario);
        }

        public static List<Funcionario> getAll()
        {

            return FakeDb.listFuncionario;
        }

        public static string retornaNomes()
        {
            foreach (var cliente in FakeDb.listFuncionario)
            {
                return cliente.Nome;
            }
            return "sem nome";
        }

        public static Funcionario PegaFuncionario(string nome)
        {
            var usuario = FakeDb.listFuncionario.FirstOrDefault(funcionario => funcionario.Login == nome);
            return usuario;
        }

        public static Funcionario PegaPrimeiroFuncionarioDaLista()
        {
            var primeiroFuncionario = FakeDb.listFuncionario.FirstOrDefault();
            return primeiroFuncionario;
        }

        public static void associaAluguelACliente(string nome, Aluguel aluguel)
        {
            foreach (var user in FakeDb.listFuncionario)
            {
                if (nome == user.Nome)
                {
                    user.aluguelCliente.Add(aluguel);
                }
            }
        }

   }
}
