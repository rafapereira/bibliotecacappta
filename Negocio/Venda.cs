using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;


namespace WindowsFormsApp3
{
    public class Venda
    {
        public Produto ProdutoVendido { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario Cliente { get; private set; }
        public DateTime DataVenda { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }

        public Venda(VendaDTO vendaDTO)
        {
            this.ProdutoVendido = vendaDTO.ProdutoVendido;
            this.FuncionarioBiblioteca = vendaDTO.FuncionarioBiblioteca;
            this.Cliente = vendaDTO.Cliente;
            this.Quantidade = vendaDTO.Quantidade;
            this.Valor = vendaDTO.Valor;
        }

    }
}
