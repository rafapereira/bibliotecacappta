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

namespace WindowsFormsApp3
{
    public partial class FormMenuAlugueis : Form
    {
        public FormMenuAlugueis()
        {
            InitializeComponent();

            FakeDb.listAlugueisVencidos = OrganizadorDeAlugueis.RetornaAlugueisVencidos();
            FakeDb.listAlugueisEmDia = OrganizadorDeAlugueis.RetornaAlugueisEmDia();
        }

        private void comboEmDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencheComboEmDia();
        }

        private void comboVencidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            preencheComboVencidos();
        }


        private void preencheComboEmDia()
        {
            foreach (var aluguel in FakeDb.listAlugueisEmDia)
            {
                ComplementaCombos(aluguel);
            }
        }

        private void preencheComboVencidos()
        {
            foreach (var aluguel in FakeDb.listAlugueisVencidos)
            {
                ComplementaCombos(aluguel);
            }
        }

        private void enviaEmail()
        {
            FormEmail formemail = new FormEmail(txtEmailCliente.Text);
            formemail.ShowDialog();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            enviaEmail();
        }

        private void ComplementaCombos(Aluguel aluguel)
        {
            txtAlugadoPor.Text = aluguel.QuemAlugou.Nome;
            txtEmailCliente.Text = aluguel.QuemAlugou.Email;
            txtDataLocacao.Text = Convert.ToString(aluguel.DataLocacao);
        }
    }
}
