using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.DTO
{
    public class GerenciadorDeFormDTO
    {
        public GroupBox boxLogin;
        public GroupBox boxAdmin;
        public GroupBox boxGeral;
        public GroupBox boxCadastros;
        public GroupBox boxUsuario;
        public ComboBox comboCliente { get; private set; }
        public ComboBox comboTipoAdmin { get; private set; }
        public ComboBox comboLivroTitulo { get; private set; }
        public ComboBox comboLivroAutor;
        public ComboBox comboLivroGenero;
        public TextBox txtLivroDisponiveis;
        public TextBox txtLivroValor { get; private set; }
        public TextBox txtVendaQuantidade { get; private set; }
        public TextBox txtEmailCliente { get; set; }
        public DateTimePicker dateAgendamento { get; private set; }
        public Button buttonVenda;
        public Button buttonAluga;
        public Button buttonAgenda;
        public Button buttonComprar;
        public Label labelLivros;
        public Label labelRevistas;
        public Label labelDvds;

        public GerenciadorDeFormDTO(GroupBox boxLogin, GroupBox boxAdmin, GroupBox boxGeral, GroupBox boxCadastros, GroupBox boxUsuario, ComboBox comboCliente, ComboBox comboTipoAdmin, ComboBox comboLivroTitulo, ComboBox comboLivroAutor, ComboBox comboLivroGenero, TextBox txtLivroDisponiveis, TextBox txtLivroValor, TextBox txtEmailCliente, DateTimePicker dateAgendamento, TextBox txtVendaQuantidade, Button buttonVenda, Button buttonAluga, Button buttonAgenda, Button buttonComprar, Label labelLivros, Label labelRevistas, Label labelDvds)
        {
            this.boxLogin = boxLogin;
            this.boxAdmin = boxAdmin;
            this.boxGeral = boxGeral;
            this.boxCadastros = boxCadastros;
            this.boxUsuario = boxUsuario;
            this.comboCliente = comboCliente;
            this.comboTipoAdmin = comboTipoAdmin;
            this.comboLivroTitulo = comboLivroTitulo;
            this.comboLivroAutor = comboLivroAutor;
            this.comboLivroGenero = comboLivroGenero;
            this.txtLivroDisponiveis = txtLivroDisponiveis;
            this.txtLivroValor = txtLivroValor;
            this.txtVendaQuantidade = txtVendaQuantidade;
            this.txtEmailCliente = txtEmailCliente;
            this.dateAgendamento = dateAgendamento;
            this.buttonVenda = buttonVenda;
            this.buttonAluga = buttonAluga;
            this.buttonAgenda = buttonAgenda;
            this.buttonComprar = buttonComprar;
            this.labelLivros = labelLivros;
            this.labelRevistas = labelRevistas;
            this.labelDvds = labelDvds;
        }
    }
}
