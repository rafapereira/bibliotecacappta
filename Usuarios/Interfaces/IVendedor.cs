﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.Usuarios.Interfaces
{
    public interface IVendedor
    {
        Venda CriaVenda(VendaDTO vendaDTO);
    }
}
