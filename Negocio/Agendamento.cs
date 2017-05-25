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
    public class Agendamento
    {
        public DateTime DataAgenda { get; private set; }
        public Funcionario Cliente { get; private set; }
        public Produto ProdutoAgendado { get; private set; }

        public Agendamento(AgendamentoDTO agendamentoDTO)
        {
            this.DataAgenda = agendamentoDTO.DataAgenda;
            this.Cliente = agendamentoDTO.Cliente;
            this.ProdutoAgendado = agendamentoDTO.ProdutoAgendado;
        }
    }
}
