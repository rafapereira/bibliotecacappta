using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.Prateleira
{
    public class Revista : Produto
    {
                
        public Revista(ProdutoDTO produtoDTO) : base(produtoDTO)
        {
        }

    }
}
