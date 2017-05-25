using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Organizadores;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Usuarios;
using WindowsFormsApp3.Negocio;

namespace WindowsFormsApp3
{
    public class FakeDb
    {

        public static List<Produto> listProduto = new List<Produto>();
        public static List<Usuarios.Funcionario> listFuncionario = new List<Usuarios.Funcionario>();
        public static List<Venda> listVenda = new List<Venda>();
        public static List<Aluguel> listAluguel = new List<Aluguel>();
        public static List<Agendamento> listAgendamento = new List<Agendamento>();
        public static List<Compra> listCompra = new List<Compra>();
        public static List<Produto> listLivro = new List<Produto>();
        public static List<Produto> listRevista = new List<Produto>();
        public static List<Produto> listDvd = new List<Produto>();
        public static List<Produto> listProdutoAcimaDe2010 = new List<Produto>();
        public static List<Aluguel> listAlugueisVencidos = new List<Aluguel>();
        public static List<Aluguel> listAlugueisEmDia = new List<Aluguel>();
        public static SeletorTipoDeNegocio SeletorTipoDeNegocio;
        public static SeletorTipoDeUsuario SeletorTipoDeUsuario;
        public static SeletorTipoDeProduto SeletorTipoDeProduto;

        public FuncionarioDTO funcionarioDTOAdmin;
        public FuncionarioDTO funcionarioDTOBibliotecario;
        public FuncionarioDTO funcionarioDTOCliente;
        public ProdutoDTO produtoDTOLivro;
        public ProdutoDTO produtoDTORevista;
        public ProdutoDTO produtoDTODvd;
        
        public FakeDb()
        {
            listProdutoAcimaDe2010 = OrganizadorDeProdutos.RetornaLivrosAcimaDe2010();
            criaUsuariosTesteEAdiciona();
            criaProdutosTesteEAdiciona();
            criaTesteAluguelVencido();
            listLivro = OrganizadorDeProdutos.atualizaListaDeLivros();
            listRevista = OrganizadorDeProdutos.atualizaListaDeRevistas();
            listDvd = OrganizadorDeProdutos.atualizaListaDeDvds();
            
        }

        private void criaUsuariosTesteEAdiciona()
        {
            funcionarioDTOAdmin = new FuncionarioDTO("admin", "admin@admin.com.br", "000000", "00000", DateTime.Now, "administrador", "admin", "admin");
            funcionarioDTOBibliotecario = new FuncionarioDTO("admin", "admin@admin.com.br", "000000", "00000", DateTime.Now, "administrador", "admin", "admin");
            funcionarioDTOCliente = new FuncionarioDTO("admin", "admin@admin.com.br", "000000", "00000", DateTime.Now, "administrador", "admin", "admin");

            Admin admin = new Admin(funcionarioDTOAdmin);
            Bibliotecario bibliotecario = new Bibliotecario(funcionarioDTOBibliotecario);
            Cliente cliente = new Cliente(funcionarioDTOCliente);

            listFuncionario.Add(admin);
            listFuncionario.Add(bibliotecario);
            listFuncionario.Add(cliente);
        }

        private void criaProdutosTesteEAdiciona()
        {
            produtoDTODvd = new ProdutoDTO("Em busca da lenha perdida", "José Spinardi", "Aventura", 1990, 20.00, 10);
            produtoDTOLivro = new ProdutoDTO("Deu a louca no Sergio", "Sergio Sergio", "Comédia", 2012, 30.00, 26);
            produtoDTORevista = new ProdutoDTO("C# para iniciantes", "Rafops Pereira", "Tecnologia", 2005, 2.00, 37);

            Dvd dvd = new Dvd(produtoDTODvd);
            Livro livro = new Livro(produtoDTOLivro);
            Revista revista = new Revista(produtoDTORevista);

            listProduto.Add(dvd);
            listProduto.Add(livro);
            listProduto.Add(revista);
        }

        private void criaTesteAluguelVencido()
        {
            DateTime dataaluguelvencido = new DateTime(2011, 02, 22);
            Produto livro = OrganizadorDeProdutos.pegaPrimeiroLivroDaLista();
            Funcionario funcionario = OrganizadorDeUsuarios.PegaPrimeiroFuncionarioDaLista();
            RequisitosDeNegocioDTO requisitosDeNegocioDTO = new RequisitosDeNegocioDTO(livro, funcionario, funcionario, 1, 20, dataaluguelvencido);
            RequisitosDeNegocio requisitosDeNegocio = new RequisitosDeNegocio(requisitosDeNegocioDTO);

            AluguelDTO aluguelDTO = new AluguelDTO(requisitosDeNegocio);

            Aluguel aluguel = new Aluguel(aluguelDTO);

            FakeDb.listAluguel.Add(aluguel);
        }

        public static void passaValorParaEnumNoDb(SeletorTipoDeNegocio negocio)
        {
            SeletorTipoDeNegocio = negocio;
        }
    }
}


