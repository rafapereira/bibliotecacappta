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
    public partial class FormAgendamentosEfetuados : Form
    {
        private List<Agendamento> listAgendamentosLocal = new List<Agendamento>();

        public FormAgendamentosEfetuados()
        {
            InitializeComponent();

            this.listAgendamentosLocal = OrganizadorDeAgenda.GetAll();
            alimentaListBoxAgendamentos();
        }
        
        private void listboxAgendamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void alimentaListBoxAgendamentos()
        {
            foreach (var agendamento in FakeDb.listAgendamento)
            {
                this.listboxAgendamentos.Items.Add(agendamento.Cliente + " - " + agendamento.ProdutoAgendado +" - "+ agendamento.DataAgenda);
            }
        }
    }
}
