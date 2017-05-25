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
    public class Compra
    {
        public Produto ProdutoComprado { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario Cliente { get; private set; }
        public DateTime DataVenda { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }

        public Compra(CompraDTO compraDTO)
        {
            this.ProdutoComprado = compraDTO.ProdutoComprado;
            this.FuncionarioBiblioteca = compraDTO.FuncionarioBiblioteca;
            this.Cliente = compraDTO.Cliente;
            this.Quantidade = compraDTO.Quantidade;
            this.Valor = compraDTO.Valor;
        }

    }
}
