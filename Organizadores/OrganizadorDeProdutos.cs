using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.Organizadores
{
    public static class OrganizadorDeProdutos
    {

        public static List<Produto> pegaTudo()
        {
            return FakeDb.listProduto;
        }

        public static void CriaEInsereLivro(ProdutoDTO produtoDTO)
        {
            Livro livro = new Livro(produtoDTO);
            add(livro);
        }

        public static void CriaEInsereRevista(ProdutoDTO produtoDTO)
        {

            Revista revista = new Revista(produtoDTO);
            add(revista);
        }

        public static void CriaEInsereDvd(ProdutoDTO produtoDTO)
        {
            Dvd dvd = new Dvd(produtoDTO);
            add(dvd);
        }

        public static void add(Produto produto)
        {
            FakeDb.listProduto.Add(produto);
        }

        public static void decrementaEstoque(string titulo, int quantidade)
        {
            foreach (var produto in FakeDb.listProduto)
            {
                if (titulo == produto.Nome && quantidade == 1)
                {
                    produto.Estoque--;
                }
                else
                {
                    produto.Estoque = produto.Estoque - quantidade;
                }
            }
        }
        
        //var livrosMenorQue2010 = FakeDb.listProduto.Where(produto => produto.EhMaiorQue2010 == false).ToList();
        //var pegarUmLivro = FakeDb.listProduto.FirstOrDefault(produto => produto.NomeEhIgual("titulo"));

        public static Produto pegaPrimeiroLivroDaLista()
        {
            var pegaLivro = FakeDb.listLivro.FirstOrDefault();
            return pegaLivro;
        }

        public static List<Produto> atualizaListaDeLivros()
        {
            var filtro = FakeDb.listProduto.Where(produto => produto.EhUmLivro(produto)).ToList();
            return filtro;
        }

        public static List<Produto> atualizaListaDeRevistas()
        {
            var filtro = FakeDb.listProduto.Where(produto => produto.EhUmaRevista(produto)).ToList();
            return filtro;
        }

        public static List<Produto> atualizaListaDeDvds()
        {
            var filtro = FakeDb.listProduto.Where(produto => produto.EhUmDvd(produto)).ToList();
            return filtro;
        }

        public static List<Produto> RetornaLivrosAcimaDe2010()
        {
            var livrosMeaiorQue2010 = FakeDb.listProduto.Where(produto => produto.EhMaiorQue2010 == true).ToList();
            return livrosMeaiorQue2010;
        }
    }
}


