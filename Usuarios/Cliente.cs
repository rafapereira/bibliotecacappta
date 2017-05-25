using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Usuarios.Interfaces;

namespace WindowsFormsApp3.Usuarios
{
    public class Cliente : Funcionario, IComprador
    {
        public int LivrosQuantidade { get; set; }

        public Cliente(FuncionarioDTO funcionarioDTO) : base(funcionarioDTO)
        {
        }

        public Compra CriaCompra(CompraDTO compraDTO)
        {
            Compra compra = new Compra(compraDTO);
            return compra;
        }

    }
}
