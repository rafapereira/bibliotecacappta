using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Negocio;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.DTO
{
    public class AluguelDTO
    {
        public Produto ProdutoAlugado { get; private set; }
        public DateTime DataLocacao { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario QuemAlugou { get; private set; }
        public string Email { get; set; }

        public AluguelDTO(RequisitosDeNegocio requisitosDeNegocio)
        {
            this.ProdutoAlugado = requisitosDeNegocio.Produto;
            this.DataLocacao = DateTime.Now;
            this.FuncionarioBiblioteca = requisitosDeNegocio.FuncionarioBiblioteca;
            this.QuemAlugou = requisitosDeNegocio.Cliente;
            this.Email = requisitosDeNegocio.Cliente.Email;
        }
    }
}
