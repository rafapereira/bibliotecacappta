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
using WindowsFormsApp3.Organizadores;
using WindowsFormsApp3.Usuarios;

namespace WindowsFormsApp3.Forms
{
    public partial class FormCadastroUsuario : Form
    {
        FuncionarioDTO funcionarioDTO;

        public FormCadastroUsuario()
        {
            DateTime data = Convert.ToDateTime(dateNascimento.Text);
            funcionarioDTO = new FuncionarioDTO(txtNome.Text, txtEmail.Text, txtRg.Text, txtCpf.Text, data, txtCargo.Text, txtLogin.Text, txtSenha.Text);
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string user = comboTipo.Text;
            
            if (user == "Cliente")
            {
                OrganizadorDeUsuarios.criaEInsereCliente(funcionarioDTO);
            }
            else if (user == "Bibliotecário")
            {
                OrganizadorDeUsuarios.criaEInsereBibliotecario(funcionarioDTO);
            }
            else if (user == "Admin")
            {
               OrganizadorDeUsuarios.criaEInsereAdmin(funcionarioDTO);
            }

            MessageBox.Show("Usuário " + txtNome.Text + " adicionado com sucesso!");
            
            limparTextBoxes(this.Controls);
        }

        private void limparTextBoxes(Control.ControlCollection controles)
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
    }
}
