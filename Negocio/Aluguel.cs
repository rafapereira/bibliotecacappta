using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Organizadores;

namespace WindowsFormsApp3
{
    public class Aluguel
    {
        public Produto ProdutoAlugado { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataEntrega { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario QuemAlugou { get; private set; }
        public string Email { get; set; }

        public Aluguel(AluguelDTO aluguelDTO)
        {
            this.ProdutoAlugado = aluguelDTO.ProdutoAlugado;
            this.DataLocacao = aluguelDTO.DataLocacao;
            this.FuncionarioBiblioteca = aluguelDTO.FuncionarioBiblioteca;
            this.QuemAlugou = aluguelDTO.QuemAlugou;
            this.Email = aluguelDTO.Email;
        }
    }
}
