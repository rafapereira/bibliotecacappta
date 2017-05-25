using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.DTO
{
    public class ProdutoDTO
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public string Genero { get; private set; }
        public int Ano { get; private set; }
        public double Valor { get; private set; }
        public int Estoque { get; set; }

        public ProdutoDTO(string nome, string autor, string genero, int ano, double valor, int estoque)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Genero = genero;
            this.Ano = ano;
            this.Valor = valor;
            this.Estoque = estoque;
        }
    }
}
