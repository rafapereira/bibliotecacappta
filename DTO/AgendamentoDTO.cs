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
    public class AgendamentoDTO
    {
        public DateTime DataAgenda { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario Cliente { get; private set; }
        public Produto ProdutoAgendado { get; private set; }

        public AgendamentoDTO(RequisitosDeNegocio requisitosDeNegocio)
        {
            this.DataAgenda = requisitosDeNegocio.Data;
            this.FuncionarioBiblioteca = requisitosDeNegocio.FuncionarioBiblioteca;
            this.Cliente = requisitosDeNegocio.Cliente;
            this.ProdutoAgendado = requisitosDeNegocio.Produto;
        }
    }
}
