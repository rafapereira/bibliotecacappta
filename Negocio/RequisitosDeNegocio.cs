using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.Negocio
{
    public class RequisitosDeNegocio
    {
        public Produto Produto { get; private set; }
        public Funcionario Cliente { get; private set; }
        public string EmailCliente { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }

        public RequisitosDeNegocio(RequisitosDeNegocioDTO requisitosDeNegocioDTO)
        {
            this.Produto = requisitosDeNegocioDTO.Produto;
            this.Cliente = requisitosDeNegocioDTO.Cliente;
            this.EmailCliente = requisitosDeNegocioDTO.EmailCliente;
            this.FuncionarioBiblioteca = requisitosDeNegocioDTO.FuncionarioBiblioteca;
            this.Quantidade = requisitosDeNegocioDTO.Quantidade;
            this.Valor = requisitosDeNegocioDTO.Valor;
            this.Data = requisitosDeNegocioDTO.Data;
        }
    }
}
