using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeAgenda
    {

            public static List<Agendamento> GetAll()
            {
                 return FakeDb.listAgendamento;
            }

            public static void CadastraAgendamento(Agendamento agendamento)
            {
                FakeDb.listAgendamento.Add(agendamento);
            }          

        }
}
