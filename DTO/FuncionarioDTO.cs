using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DTO
{
    public class FuncionarioDTO
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

         public FuncionarioDTO(string nome, string email, string rg, string cpf, DateTime nascimento, string cargo, string login, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Nascimento = nascimento;
            this.Cargo = cargo;
            this.Login = login;
            this.Senha = senha;
        }
    }
}
