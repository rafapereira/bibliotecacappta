using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.DTO;
using WindowsFormsApp3.Usuarios;
using WindowsFormsApp3.Prateleira;
using WindowsFormsApp3.Negocio;

namespace WindowsFormsApp3
{
    public class GerenciadorDeForm
    {
        private GroupBox boxLogin;
        private GroupBox boxAdmin;
        private GroupBox boxGeral;
        private GroupBox boxCadastros;
        private GroupBox boxUsuario;
        public ComboBox comboCliente { get; private set; }
        public ComboBox comboTipoAdmin { get; private set; }
        public ComboBox comboLivroTitulo { get; private set; }
        private ComboBox comboLivroAutor;
        private ComboBox comboLivroGenero;
        private TextBox txtLivroDisponiveis;
        public TextBox txtLivroValor { get; private set; }
        public TextBox txtVendaQuantidade { get; private set; }
        public TextBox txtEmailCliente { get; set; }
        public DateTimePicker dateAgendamento { get; private set; }
        private Button buttonVenda;
        private Button buttonAluga;
        private Button buttonAgenda;
        private Button buttonComprar;
        private Label labelLivros;
        private Label labelRevistas;
        private Label labelDvds;
        
        public GerenciadorDeForm(GerenciadorDeFormDTO gerenciadorDeFormDTO)
        {
            this.boxLogin = gerenciadorDeFormDTO.boxLogin;
            this.boxAdmin = gerenciadorDeFormDTO.boxAdmin;
            this.boxGeral = gerenciadorDeFormDTO.boxGeral;
            this.boxCadastros = gerenciadorDeFormDTO.boxCadastros;
            this.boxUsuario = gerenciadorDeFormDTO.boxUsuario;
            this.comboCliente = gerenciadorDeFormDTO.comboCliente;
            this.comboTipoAdmin = gerenciadorDeFormDTO.comboTipoAdmin;
            this.comboLivroTitulo = gerenciadorDeFormDTO.comboLivroTitulo;
            this.comboLivroAutor = gerenciadorDeFormDTO.comboLivroAutor;
            this.comboLivroGenero = gerenciadorDeFormDTO.comboLivroGenero;
            this.txtLivroDisponiveis = gerenciadorDeFormDTO.txtLivroDisponiveis;
            this.txtLivroValor = gerenciadorDeFormDTO.txtLivroValor;
            this.txtVendaQuantidade = gerenciadorDeFormDTO.txtVendaQuantidade;
            this.txtEmailCliente = gerenciadorDeFormDTO.txtEmailCliente;
            this.dateAgendamento = gerenciadorDeFormDTO.dateAgendamento;
            this.buttonVenda = gerenciadorDeFormDTO.buttonVenda;
            this.buttonAluga = gerenciadorDeFormDTO.buttonAluga;
            this.buttonAgenda = gerenciadorDeFormDTO.buttonAluga;
            this.buttonComprar = gerenciadorDeFormDTO.buttonAluga;
            this.labelLivros = gerenciadorDeFormDTO.labelLivros;
            this.labelRevistas = gerenciadorDeFormDTO.labelRevistas;
            this.labelDvds = gerenciadorDeFormDTO.labelDvds;
        }

        public void acessoAdmin()
        {
            boxLogin.Visible = false;
            boxAdmin.Visible = true;
            boxCadastros.Visible = true;
            buttonVenda.Visible = true;
            buttonAluga.Visible = true;
            buttonAgenda.Visible = true;
            buttonComprar.Visible = false;
        }

        public void acessoBibliotecario()
        {
            boxLogin.Visible = false;
            boxAdmin.Visible = true;
            boxCadastros.Visible = false;
            buttonVenda.Visible = false;
            buttonAluga.Visible = true;
            buttonAgenda.Visible = true;
            buttonComprar.Visible = false;
        }

        public void acessoCliente()
        {
            boxLogin.Visible = false;
            boxAdmin.Visible = true;
            boxCadastros.Visible = false;
            buttonVenda.Visible = false;
            buttonAluga.Visible = false;
            buttonAgenda.Visible = false;
            buttonComprar.Visible = true;
        }

        public void desconecta()
        {
            boxLogin.Visible = true;
            boxAdmin.Visible = false;
            boxGeral.Visible = false;
        }

        public void acessoComboTipoAdminBibliotecario(List<Produto> lista)
        {
            if (comboTipoAdmin.Text == "Livros")
            {
                atualizaCombos(lista);
                labelLivros.Visible = true;
                labelRevistas.Visible = false;
                labelDvds.Visible = false;
                boxGeral.Visible = true;
            }
            else if (comboTipoAdmin.Text == "Revistas")
            {
                atualizaCombos(lista);
                labelRevistas.Visible = true;
                labelLivros.Visible = false;
                labelDvds.Visible = false;
                boxGeral.Visible = true;
            }
            else if (comboTipoAdmin.Text == "DVDs")
            {
                atualizaCombos(lista);
                labelDvds.Visible = true;
                labelLivros.Visible = false;
                labelRevistas.Visible = false;
                boxGeral.Visible = true;
                buttonVenda.Visible = false;
                buttonComprar.Visible = false;
            }
        }

        public void acessoComboTipoCliente(List<Produto> lista)
        {
            if (comboTipoAdmin.Text == "Livros")
            {
                atualizaCombos(lista);
                labelLivros.Visible = true;
                labelRevistas.Visible = false;
                labelDvds.Visible = false;
                boxGeral.Visible = true;
                buttonComprar.Visible = true;
            }
            else if (comboTipoAdmin.Text == "Revistas")
            {
                atualizaCombos(lista);
                labelRevistas.Visible = true;
                labelLivros.Visible = false;
                labelDvds.Visible = false;
                boxGeral.Visible = true;
                buttonComprar.Visible = true;
            }
            else if (comboTipoAdmin.Text == "DVDs")
            {
                atualizaCombos(lista);
                labelDvds.Visible = true;
                labelLivros.Visible = false;
                labelRevistas.Visible = false;
                boxGeral.Visible = true;
                buttonVenda.Visible = false;
                buttonComprar.Visible = false;
            }
        }

        public void atualizaCombos(List<Produto> lista)
        {
            foreach (var livro in lista)
            {
                if (!comboLivroTitulo.Items.Contains(livro.Nome))
                {
                    comboLivroTitulo.Items.Add(livro.Nome);
                }
            }
        }

        public void preencheCombos(List<Produto> lista)
        {
            foreach (var titulo in lista)
            {
                if (this.comboLivroTitulo.Text == titulo.Nome)
                {
                    this.comboLivroAutor.Text = titulo.Autor;
                    comboLivroGenero.Text = titulo.Genero;
                    txtLivroDisponiveis.Text = Convert.ToString(titulo.Estoque);
                    txtLivroValor.Text = Convert.ToString(titulo.Valor);
                }
            }
        }

        public void mostraBoxUsuario(List<Usuarios.Funcionario> listFuncionario)
        {
            boxUsuario.Visible = true;
            comboCliente.Items.Clear();
            
            foreach (var user in listFuncionario)
            {
                comboCliente.Items.Add(user.Nome);
            }
        }

        public void atualizaTextEmail(List<Usuarios.Funcionario> listFuncionario)
        {
            foreach (var user in listFuncionario)
            {
                if (comboCliente.Text == user.Nome)
                {
                    txtEmailCliente.Text = user.Email;
                }
            }
        }

        //TODO Função Limpar TXTBOXES
        public void limparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = String.Empty;
                }

            }
        }

        public void MostraTelasDeAdminEBiblioTecario(SeletorTipoDeProduto seletorTipoDeProduto)
        {
            switch (seletorTipoDeProduto)
            {
                case SeletorTipoDeProduto.Livro:
                    acessoComboTipoAdminBibliotecario(FakeDb.listLivro);
                    break;
                case SeletorTipoDeProduto.Revista:
                    acessoComboTipoAdminBibliotecario(FakeDb.listRevista);
                    break;
                case SeletorTipoDeProduto.Dvd:
                    acessoComboTipoAdminBibliotecario(FakeDb.listDvd);
                    break;
            }
        }

        public void MostraTelasDeCliente(SeletorTipoDeProduto seletorTipoDeProduto)
        {
            switch (seletorTipoDeProduto)
            {
                case SeletorTipoDeProduto.Livro:
                    acessoComboTipoCliente(FakeDb.listLivro);
                    break;
                case SeletorTipoDeProduto.Revista:
                    acessoComboTipoCliente(FakeDb.listRevista);
                    break;
                case SeletorTipoDeProduto.Dvd:
                    acessoComboTipoCliente(FakeDb.listDvd);
                    break;
            }
        }

    }
}