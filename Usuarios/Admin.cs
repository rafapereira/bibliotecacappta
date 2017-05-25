using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Usuarios.Interfaces;

namespace WindowsFormsApp3.Usuarios
{
    public class Admin : Funcionario, IVendedor, IAlugador, ICadastrador, IAgendador
    {
        public Admin(FuncionarioDTO funcionarioDTO) : base(funcionarioDTO)
        {
        }
        
        public Venda CriaVenda(VendaDTO vendaDTO)
        {
            Venda venda = new Venda(vendaDTO);
            return venda;
        }

        public Aluguel CriaAluguel(AluguelDTO aluguelDTO)
        {
            Aluguel aluguel = new Aluguel(aluguelDTO);
            return aluguel;
        }

        public Agendamento CriaAgendamento(AgendamentoDTO agendamentoDTO)
        {
            Agendamento agendamento = new Agendamento(agendamentoDTO);
            return agendamento;
        }
    }
}
