using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeAlugueis
    {
        public static List<Aluguel> GetAll()
        {
            return FakeDb.listAluguel;
        }

        public static void CadastraAluguel(Aluguel aluguel)
        {
            FakeDb.listAluguel.Add(aluguel);
        }

        public static void devolve(Aluguel aluguel)
        {
        }

        public static int checaEmDia (Aluguel aluguel)
        {
            TimeSpan ts = DateTime.Now.Subtract(aluguel.DataLocacao);
            int aluguelDiasCorridos = ts.Days;

            return aluguelDiasCorridos;
        }

        public static List<Aluguel> RetornaAlugueisVencidos()
        {
            var alugueisVencidos = FakeDb.listAluguel.Where(aluguel => checaEmDia(aluguel) > 7).ToList();
            return alugueisVencidos;
        }

        public static List<Aluguel> RetornaAlugueisEmDia()
        {
            var alugueisEmDia = FakeDb.listAluguel.Where(aluguel => checaEmDia(aluguel) <= 7).ToList();
            return alugueisEmDia;
        }
    }
}
