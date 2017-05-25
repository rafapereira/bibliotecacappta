using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.DTO
{
   public class RequisitosDeNegocioDTO
    {
        public Produto Produto { get; private set; }
        public Funcionario Cliente { get; private set; }
        public string EmailCliente { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public RequisitosDeNegocioDTO(Produto produto, Funcionario cliente, Funcionario funcionarioBiblioteca, int quantidade, double valor, DateTime data)
        {
            this.Produto = produto;
            this.Cliente = cliente;
            this.EmailCliente = cliente.Email;
            this.FuncionarioBiblioteca = funcionarioBiblioteca;
            this.Quantidade = Quantidade;
            this.Valor = valor;
            this.Data = data;
        }
    }
}
