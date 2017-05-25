using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using WindowsFormsApp3.Organizadores;

namespace WindowsFormsApp3
{
    public partial class FormEmail : Form
    {
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();
        
        public FormEmail(string clienteemail)
        {
            InitializeComponent();
            txtEmailAdmin.Text = "admin@admin.com.br";
            txtEmailDestinatario.Text = clienteemail;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Email = new MailMessage();
            Email.To.Add(new MailAddress(txtEmailDestinatario.Text));
            Email.From = new MailAddress(txtEmailAdmin.Text);
            Email.Subject = txtTitulo.Text;
            Email.IsBodyHtml = true;
            Email.Body = txtMessage.Text;
            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            using (cliente)
                try
                { 
                cliente.Credentials = new System.Net.NetworkCredential(txtEmailAdmin.Text, txtPassword.Text);
                cliente.EnableSsl = true;
                cliente.Send(Email);
                }
                catch
                {
                    MessageBox.Show("ERRO AO ENVIAR E-MAIL");
                    this.Close();
                }
            this.Close();
            MessageBox.Show("E-mail enviado com sucesso", "E-mail enviado");
        }
    }
}
