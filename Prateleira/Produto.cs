using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;

namespace WindowsFormsApp3.Prateleira

{
    public abstract class Produto
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }
        public string Genero { get; private set; }
        public int Ano { get; private set; }
        public double Valor { get; private set; }
        public int Estoque { get; set; }
        public int ContaAgenda { get; private set; }

        public Produto(ProdutoDTO produtoDTO)
        {
        }

        public bool checaDisponibilidade(Produto produto)
        {
         if (FakeDb.listProduto.Contains(produto) && produto.Estoque >= 1)
            {
                return true;
            }
            return false;
        }

        public bool EhMaiorQue2010 { get { return this.Ano > 2010; } }

        internal bool NomeEhIgual(string titulo)
        {
            return this.Nome == titulo;
        }

        internal bool EhUmLivro(Produto titulo)
        {
            return titulo is Livro;
        }

        internal bool EhUmaRevista(Produto titulo)
        {
            return titulo is Revista;
        }

        internal bool EhUmDvd(Produto titulo)
        {
            return titulo is Dvd;
        }

        internal bool TemMesmoNomeEMaiorQue2010(string titulo)
        {
            return this.EhMaiorQue2010 && this.NomeEhIgual(titulo);
        }

        public Produto PegaUmLivro(string titulo)
        {
            var pegarUmLivro = FakeDb.listProduto.FirstOrDefault(produto => produto.NomeEhIgual(titulo));
            return pegarUmLivro;
        }
    }
}
