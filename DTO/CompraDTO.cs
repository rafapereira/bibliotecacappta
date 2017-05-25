﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Negocio;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.DTO
{
    public class CompraDTO
    {
        public Produto ProdutoComprado { get; private set; }
        public Funcionario FuncionarioBiblioteca { get; private set; }
        public Funcionario Cliente { get; private set; }
        public DateTime DataVenda { get; private set; }
        public int Quantidade { get; private set; }
        public double Valor { get; private set; }

        public CompraDTO(RequisitosDeNegocio requisitosDeNegocio)
        {
            this.ProdutoComprado = requisitosDeNegocio.Produto;
            this.FuncionarioBiblioteca = requisitosDeNegocio.FuncionarioBiblioteca;
            this.Cliente = requisitosDeNegocio.Cliente;
            this.Quantidade = requisitosDeNegocio.Quantidade;
            this.Valor = requisitosDeNegocio.Valor;
        }
    }
}
