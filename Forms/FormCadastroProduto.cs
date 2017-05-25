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
using WindowsFormsApp3.Prateleira;

namespace WindowsFormsApp3
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
            AlimentaComboProduto();
        }

        private void btnLivroAdd_Click(object sender, EventArgs e)
        {

            adicionaProduto();
            MessageBox.Show("Produto adicionado com sucesso!");

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
        
        private void adicionaProduto()
        {
            int ano = Convert.ToInt32(txtAno.Text);
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            double valor = Convert.ToDouble(txtValorProduto.Text);
            ProdutoDTO produtoDTO = new ProdutoDTO(txtNome.Text, txtAutorDiretor.Text, txtGenero.Text, ano, valor, quantidade);

            if (comboTipo.Text == "Livro")
            {
                Livro livro = new Livro(produtoDTO);
                FakeDb.listProduto.Add(livro);
            }
            else if (comboTipo.Text == "Revista")
            {
                Revista revista = new Revista(produtoDTO);
                FakeDb.listProduto.Add(revista);
            }
            else if (comboTipo.Text == "Dvd")
            {
                Dvd dvd = new Dvd(produtoDTO);
                FakeDb.listProduto.Add(dvd);
            }

        }

       private void AlimentaComboProduto()
        {
            comboTipo.DataSource = Enum.GetValues(typeof(SeletorTipoDeProduto));
        }


    }

}



