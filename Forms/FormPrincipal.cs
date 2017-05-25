using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Organizadores;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Usuarios;
using WindowsFormsApp3.Negocio;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string nomeCliente;
        private Produto produto;
        public static Funcionario usuarioLogado;
        private GerenciadorDeForm gerenciadorDeForm;
        private List<Funcionario> listFuncionario = new List<Funcionario>();

        public Form1()
        {
            InitializeComponent();
            GerenciadorDeFormDTO gerenciadorDeFormDTO = new GerenciadorDeFormDTO(boxLogin, boxAdmin, boxGeral, boxCadastros, boxUsuario, comboCliente, comboTipoProduto, comboLivroTitulo, comboLivroAutor, comboLivroGenero, txtLivroDisponiveis, txtLivroValor, txtEmailCliente, dateAgendamento, txtVendaQuantidade, buttonVenda, buttonAluga, buttonAgenda, buttonComprar, labelLivros, labelRevistas, labelDvds);
            // RequisitosDeNegocioDTO requisitosDeNegociosDTO = new RequisitosDeNegocioDTO(gerenciadorDeForm.c);
            this.gerenciadorDeForm = new GerenciadorDeForm(gerenciadorDeFormDTO);
        }

        private void buttonNewProduto_Click(object sender, EventArgs e)
        {
            comboLivroTitulo.Items.Clear();
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }

        private void buttonNewUsuario_Click(object sender, EventArgs e)
        {
            Forms.FormCadastroUsuario formCadastroUsuario = new Forms.FormCadastroUsuario();
            formCadastroUsuario.ShowDialog();
        }

        private void btnMenuAlugueis_Click(object sender, EventArgs e)
        {
            FormMenuAlugueis formAlugueis = new FormMenuAlugueis();
            formAlugueis.ShowDialog();
        }

        private void buttonAgendamentosEfetuados_Click(object sender, EventArgs e)
        {
            FormAgendamentosEfetuados formAgendamentosEfetuados = new FormAgendamentosEfetuados();
            formAgendamentosEfetuados.ShowDialog();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (ValidadorDeLogin.LoginESenhaSaoValidos(this.txtLogin.Text, this.txtSenha.Text) == true)
            {
                FazLogin();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos.");
            }
        }

        private void buttonLogoffAdmin_Click(object sender, EventArgs e)
        {
            gerenciadorDeForm.desconecta();
        }

        private void comboTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboLivroTitulo.Items.Clear();

            if (usuarioLogado.EhAdminOuBibliotecario(usuarioLogado) == true)
            {
                gerenciadorDeForm.MostraTelasDeAdminEBiblioTecario(FakeDb.SeletorTipoDeProduto);
            }
            else
            {
                gerenciadorDeForm.MostraTelasDeCliente(FakeDb.SeletorTipoDeProduto);
            }
        }

        private void comboLivroTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoProduto.Text == "Livros")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listLivro);
                gerenciadorDeForm.preencheCombos(FakeDb.listLivro);
                buttonVenda.Visible = true;
            }
            else if (comboTipoProduto.Text == "Revistas")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listRevista);
                gerenciadorDeForm.preencheCombos(FakeDb.listRevista);
                buttonVenda.Visible = true;
            }
            else if (comboTipoProduto.Text == "DVDs")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listDvd);
                gerenciadorDeForm.preencheCombos(FakeDb.listDvd);
                buttonVenda.Visible = false;
                buttonComprar.Visible = false;
            }
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            gerenciadorDeForm.mostraBoxUsuario(listFuncionario);
            FakeDb.passaValorParaEnumNoDb(SeletorTipoDeNegocio.Venda);
            dateAgendamento.Enabled = false;
        }

        private void buttonAluga_Click(object sender, EventArgs e)
        {
            gerenciadorDeForm.mostraBoxUsuario(listFuncionario);
            FakeDb.passaValorParaEnumNoDb(SeletorTipoDeNegocio.Aluguel);
            dateAgendamento.Enabled = false;
        }

        private void buttonAgenda_Click(object sender, EventArgs e)
        {
            gerenciadorDeForm.mostraBoxUsuario(listFuncionario);
            FakeDb.passaValorParaEnumNoDb(SeletorTipoDeNegocio.Agendamento);
            dateAgendamento.Enabled = true;
        }

        private void buttonFinalizaVenda_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(gerenciadorDeForm.txtVendaQuantidade.Text);
            double valor = Convert.ToDouble(gerenciadorDeForm.txtLivroValor.Text);
            DateTime data = Convert.ToDateTime(gerenciadorDeForm.dateAgendamento.Text);

        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            gerenciadorDeForm.atualizaTextEmail(this.listFuncionario);
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            comboLivroTitulo.Items.Clear();

            if (comboTipoProduto.Text == "Livros")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listLivro);
                gerenciadorDeForm.preencheCombos(FakeDb.listLivro);
            }
            else if (comboTipoProduto.Text == "Revistas")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listRevista);
                gerenciadorDeForm.preencheCombos(FakeDb.listRevista);
            }
            else if (comboTipoProduto.Text == "DVDs")
            {
                gerenciadorDeForm.atualizaCombos(FakeDb.listDvd);
                gerenciadorDeForm.preencheCombos(FakeDb.listDvd);
            }
            this.produto = this.produto.PegaUmLivro(gerenciadorDeForm.comboLivroTitulo.Text);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txtVendaQuantidade.Text);
            double valor = Convert.ToDouble(txtLivroValor.Text);

            if (FakeDb.listProduto.Contains(produto))
            {
               // db.tabSales.vende(gerenciadorDeForm.comboLivroTitulo.Text, gerenciadorDeForm.comboCliente.Text, 1, valor);
                //db.tabProduct.decrementaEstoque(comboLivroTitulo.Text, quantidade);
                MessageBox.Show("Compra efetuada com sucesso!");
            }
            else
            {
                MessageBox.Show("Livro indisponível.");
            }

        }

        public void FazLogin()
        {
            usuarioLogado = OrganizadorDeUsuarios.PegaFuncionario(txtLogin.Text);
            FakeDb.SeletorTipoDeUsuario = usuarioLogado.checkTipo(usuarioLogado);
            ChecaOTipoDeUsuarioELoga();

            MessageBox.Show("Login efetuado com sucesso!");
        }

        public void ChecaOTipoDeUsuarioELoga()
        {
            switch (FakeDb.SeletorTipoDeUsuario)
            {
                case SeletorTipoDeUsuario.Admin:
                    gerenciadorDeForm.acessoAdmin();
                    break;
                case SeletorTipoDeUsuario.Bibliotecario:
                    gerenciadorDeForm.acessoBibliotecario();
                    break;
                case SeletorTipoDeUsuario.Cliente:
                    this.nomeCliente = txtLogin.Text;
                    gerenciadorDeForm.acessoCliente();
                    break;
            }
        }
    }
}