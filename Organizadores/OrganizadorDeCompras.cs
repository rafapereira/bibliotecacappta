using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeCompras
    {
        public static List<Compra> GetAll()
        {
            return FakeDb.listCompra;
        }

        internal static void CadastraVenda(Compra compra)
        {
            FakeDb.listCompra.Add(compra);
        }

    }
}
