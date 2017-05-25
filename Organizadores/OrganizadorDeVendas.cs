using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeVendas
    {
        
        public static List<Venda> GetAll()
        {
            return FakeDb.listVenda;
        }

        public static void CadastraVenda(Venda venda)
        {
            FakeDb.listVenda.Add(venda);
        }

    }
}
