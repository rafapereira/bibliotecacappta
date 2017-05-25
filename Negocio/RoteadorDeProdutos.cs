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

namespace WindowsFormsApp3.Negocio
{
    public class RoteadorDeProdutos
    {
        public void RoteiaProduto(RequisitosDeNegocio requisitosDeNegocio)
        {

            switch (FakeDb.SeletorTipoDeNegocio)
            {
                case SeletorTipoDeNegocio.Venda:
                    if (ProduteEhAcimaDe2010EfuncionarioEhAdmin(requisitosDeNegocio.FuncionarioBiblioteca, requisitosDeNegocio.Produto) == true)
                    {
                        VendaDTO vendaDTO = new VendaDTO(requisitosDeNegocio);
                        CriaECadastraVenda(vendaDTO);
                        MessageBox.Show("Venda efetuada com sucesso!");
                    }
                    break;
                case SeletorTipoDeNegocio.Aluguel:
                    if (ClienteTemMenosDe2Alugueis(requisitosDeNegocio.Cliente) == true)
                    {
                        AluguelDTO aluguelDTO = new AluguelDTO(requisitosDeNegocio);
                        CriaECadastraAluguel(aluguelDTO);
                        MessageBox.Show("Aluguel efetuado com sucesso!");
                    }
                    break;
                case SeletorTipoDeNegocio.Agendamento:
                    if (ChecaDisponibilidadeEData(requisitosDeNegocio.Produto, requisitosDeNegocio.Data) == true)
                    {
                        AgendamentoDTO agendamentoDTO = new AgendamentoDTO(requisitosDeNegocio);
                        CriaECadastraAgendamento(agendamentoDTO);
                        MessageBox.Show("Agendamento efetuado com sucesso!");
                    }
                    break;
                case SeletorTipoDeNegocio.Compra:
                    if (ProdutoEhAcimaDe2010EEstaDisponivel(requisitosDeNegocio.Produto))
                    {
                        CompraDTO compraDTO = new CompraDTO(requisitosDeNegocio);
                        CriaECadastraCompra(compraDTO);
                    }
                    break;
                default:
                    MessageBox.Show("Erro!");
                    break;
            }
        }

        private bool ClienteTemMenosDe2Alugueis(Funcionario cliente)
        {
            if (cliente.contaAlugueisFuncionario(cliente) < 2)
            {
                return true;
            }
            return false;
        }

        private bool ProduteEhAcimaDe2010EfuncionarioEhAdmin(Funcionario funcionario, Produto produto)
        {
            if (FakeDb.listProdutoAcimaDe2010.Contains(produto) && funcionario.checaSeUsuarioEhAdmin(funcionario) == true)
            {
                return true;
            }
            return false;
        }

        private bool ProdutoEhAcimaDe2010EEstaDisponivel(Produto produto)
        {
            if (produto.checaDisponibilidade(produto) == true && FakeDb.listProdutoAcimaDe2010.Contains(produto))
            {
                return true;
            }
            return false;
        }

        private bool ChecaDisponibilidadeEData(Produto produto, DateTime data)
        {
            if (produto.checaDisponibilidade(produto) == true && data > DateTime.Now)
            {
                return true;
            }
            return false;
        }

        private void CriaECadastraVenda(VendaDTO vendaDTO)
        {
            OrganizadorDeVendas.CadastraVenda(((Admin)vendaDTO.FuncionarioBiblioteca).CriaVenda(vendaDTO));
        }

        private void CriaECadastraAluguel(AluguelDTO aluguelDTO)
        {
            OrganizadorDeAlugueis.CadastraAluguel(((Admin)aluguelDTO.FuncionarioBiblioteca).CriaAluguel(aluguelDTO));
        }

        private void CriaECadastraAgendamento(AgendamentoDTO agendamentoDTO)
        {
            OrganizadorDeAgenda.CadastraAgendamento(((Admin)agendamentoDTO.FuncionarioBiblioteca).CriaAgendamento(agendamentoDTO));
        }

        private void CriaECadastraCompra(CompraDTO compraDTO)
        {
            OrganizadorDeCompras.CadastraVenda(((Cliente)compraDTO.Cliente).CriaCompra(compraDTO));
        }

    }
}
