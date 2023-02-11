using CursoWindowsForms.Formulários_Curso_5;
using CursoWindowsFormsLibrary;
using CursoWindowsFormsLibrary.Database;
using CursoWindowsFormsLibrary.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            btn_Busca.Text = "Buscar";

            gb_Codigo.Text = "Código";
            gb_DadosPessoais.Text = "Dados Pessoais";
            gb_Endereco.Text = "Endereço";
            gb_Outros.Text = "Outros";

            chk_TemPai.Text = "Pai desconhecido";

            lbl_Cidade.Text = "Cidade";
            lbl_Bairro.Text = "Bairro";
            lbl_CEP.Text = "CEP";
            lbl_Complemento.Text = "Complemento";
            lbl_CPF.Text = "CPF";
            lbl_Estado.Text = "Estado";
            lbl_Genero.Text = "Genero";
            lbl_Logradouro.Text = "Logradouro";
            lbl_NomeCliente.Text = "Nome";
            lbl_NomePai.Text = "Nome do Pai";
            lbl_NomeMae.Text = "Nome da Mãe";
            lbl_Profissao.Text = "Profissão";
            lbl_RendaFamiliar.Text = "Renda Familiar";
            lbl_Telefone.Text = "Telefone";

            rb_Masculino.Text = "Masculino";
            rb_Feminino.Text = "Feminino";
            rb_Indefinido.Text = "Indefinido";

            cmb_Estado.Items.Clear();
            cmb_Estado.Items.Add("Acre (AC)");
            cmb_Estado.Items.Add("Alagoas (AL)");
            cmb_Estado.Items.Add("Amapá (AP)");
            cmb_Estado.Items.Add("Amazonas (AM)");
            cmb_Estado.Items.Add("Bahia (BA)");
            cmb_Estado.Items.Add("Ceará (CE)");
            cmb_Estado.Items.Add("Distrito Federal (DF)");
            cmb_Estado.Items.Add("Espírito Santo (ES)");
            cmb_Estado.Items.Add("Goiás (GO)");
            cmb_Estado.Items.Add("Maranhão (MA)");
            cmb_Estado.Items.Add("Mato Grosso (MT)");
            cmb_Estado.Items.Add("Mato Grosso do Sul (MS)");
            cmb_Estado.Items.Add("Minas Gerais (MG)");
            cmb_Estado.Items.Add("Pará (PA)");
            cmb_Estado.Items.Add("Paraíba (PB)");
            cmb_Estado.Items.Add("Paraná(PR)");
            cmb_Estado.Items.Add("Pernambuco (PE)");
            cmb_Estado.Items.Add("Piauí (PI)");
            cmb_Estado.Items.Add("Rio de Janeiro (RJ)");
            cmb_Estado.Items.Add("Rio Grande do Norte (RN)");
            cmb_Estado.Items.Add("Rio Grande do Sul (RS)");
            cmb_Estado.Items.Add("Rondônia (RO)");
            cmb_Estado.Items.Add("Roraima (RR)");
            cmb_Estado.Items.Add("Santa Catarina (SC)");
            cmb_Estado.Items.Add("São Paulo (SP)");
            cmb_Estado.Items.Add("Sergipe (SE)");
            cmb_Estado.Items.Add("Tocantins (TO)");

            tsp_Principal.Items[0].ToolTipText = "Incluir novo cliente na base de dados";
            tsp_Principal.Items[1].ToolTipText = "Buscar um cliente na base de dados";
            tsp_Principal.Items[2].ToolTipText = "Atualizar cliente na base de dados";
            tsp_Principal.Items[3].ToolTipText = "Apagar um cliente da base de dados";
            tsp_Principal.Items[4].ToolTipText = "Limpar o formulário de cadastro";
        }

        private void chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TemPai.Checked)
            {
                txt_NomePai.Text = "";
                txt_NomePai.Enabled = false;
            }
            else
            {
                txt_NomePai.Enabled = true;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                cliente = LeituraFormulario();
                cliente.ValidaClasse();
                cliente.ValidaComplemento();
                cliente.IncluirFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario");
            }
            catch (ValidationException exc)
            {
                MessageBox.Show(exc.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Cliente.Unit LeituraFormulario()
        {
            bool temPai;
            int genero = 0;
            double renda = 0;
            
            if (chk_TemPai.Checked)
            {
                temPai = true;
            }
            else
            {
                temPai = false;
            }
            if (rb_Masculino.Checked)
            {
                genero = 0;
            }
            else if (rb_Feminino.Checked)
            {
                genero = 1;
            }
            else if (rb_Indefinido.Checked)
            {
                genero = 2;
            }

            if (Information.IsNumeric(txt_RendaFamiliar.Text))
            {
                double rendaConvertida = Convert.ToDouble(txt_RendaFamiliar.Text);
                if (rendaConvertida > 0)
                {
                    renda = rendaConvertida;
                }
            }



            return new Cliente.Unit(txt_Codigo.Text, txt_NomeCliente.Text, txt_NomePai.Text, 
                txt_NomeMae.Text, temPai, txt_CPF.Text, genero, txt_CEP.Text, txt_Logradouro.Text, txt_Complemento.Text,
                txt_Bairro.Text, txt_Cidade.Text, cmb_Estado.Items[cmb_Estado.SelectedIndex].ToString(), 
                txt_Telefone.Text, txt_Profissao.Text, renda);
        }

        private void LimpaFormulario()
        {
            txt_Codigo.Clear();
            txt_NomeCliente.Clear();
            txt_NomePai.Clear();
            txt_NomeMae.Clear();
            chk_TemPai.Checked = false;
            txt_CPF.Clear();
            rb_Feminino.Checked = false;
            rb_Indefinido.Checked = false;
            rb_Masculino.Checked = false;
            txt_CEP.Clear();
            txt_Logradouro.Clear();
            txt_Complemento.Clear();
            txt_Bairro.Clear();
            txt_Cidade.Clear();
            cmb_Estado.SelectedItem = null;
            txt_Telefone.Clear();
            txt_Profissao.Clear();
            txt_RendaFamiliar.Clear();
        }

        private void PreencheFormulario(Cliente.Unit cliente)
        {
            try
            {
                switch (cliente.Genero)
                {
                    case 0:
                        rb_Masculino.Checked = true;
                        break;
                    case 1:
                        rb_Feminino.Checked = true;
                        break;
                    case 2:
                        rb_Indefinido.Checked = true;
                        break;
                    default: break;
                }
                if (cliente.NaoTemPai)
                {
                    chk_TemPai.Checked = true;
                }
                else
                {
                    chk_TemPai.Checked = false;
                }
                txt_Codigo.Text = cliente.Id;
                txt_NomeCliente.Text = cliente.Nome;
                txt_NomeMae.Text = cliente.NomeMae;
                txt_NomePai.Text = cliente.NomePai;
                txt_CPF.Text = cliente.CPF;
                txt_Cidade.Text = cliente.Cidade;
                txt_Profissao.Text = cliente.Profissao;
                txt_Logradouro.Text = cliente.Logradouro;
                txt_CEP.Text = cliente.CEP;
                txt_RendaFamiliar.Text = cliente.RendaFamiliar.ToString();
                txt_Cidade.Text = cliente.Cidade;
                txt_Bairro.Text = cliente.Bairro;
                txt_Complemento.Text = cliente.Complemento;
                txt_Telefone.Text = cliente.Telefone;
                foreach (string estado in cmb_Estado.Items)
                {
                    if (estado.Contains(cliente.Estado))
                    {
                        cmb_Estado.SelectedItem = estado;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Falha ao localizar o cliente", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente não pode ser vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit cliente = new Cliente.Unit();
                    PreencheFormulario(cliente.BuscarClienteFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario", txt_Codigo.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente não pode ser vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit cliente = new Cliente.Unit();
                    cliente = LeituraFormulario();
                    cliente.ValidaClasse();
                    cliente.ValidaComplemento();
                    cliente.AlterarFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario");
                }
                catch (ValidationException exc)
                {
                    MessageBox.Show(exc.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {

            if (txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do cliente não pode ser vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    Cliente.Unit cliente = new Cliente.Unit();
                    cliente = cliente.BuscarClienteFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario", txt_Codigo.Text);
                    if (cliente != null)
                    {
                        PreencheFormulario(cliente);
                        if (MessageBox.Show("Deseja realmente excluir o cliente?", "ByteBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (cliente.ApagarFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario"))
                            {
                                LimpaFormulario();
                                MessageBox.Show("Cliente excluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Falha ao excluir o cliente", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
        }

        private void txt_CEP_Leave(object sender, EventArgs e)
        {
            if (txt_CEP.Text != "" && txt_CEP.Text.Length == 8)
            {
                var json = Utils.GeraJSONCEP(txt_CEP.Text);
                Cep.Unit cep = new Cep.Unit();
                cep = Cep.DeserializeClassUnit(json);
                
                txt_Logradouro.Text = cep.logradouro;
                txt_Cidade.Text = cep.localidade;
                txt_Bairro.Text = cep.bairro;
                foreach (string estado in cmb_Estado.Items)
                {
                    if (estado.Contains("(" + cep.uf + ")"))
                    {
                        cmb_Estado.SelectedItem = estado;
                        break;
                    }
                    else
                    {
                        cmb_Estado.SelectedItem = null;
                    }
                }
            }
        }

        private void btn_Busca_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit cliente = new Cliente.Unit();
                List<string> list = cliente.BuscarTudoFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario");
                if (list != null)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    foreach (string item in list)
                    {
                        cliente = Cliente.DeserializeClassUnit(item);
                        ListaBusca.Add(new List<String> { cliente.Id, cliente.Nome });
                    }
                    Frm_Busca Fform = new Frm_Busca(ListaBusca);
                    if (Fform.ShowDialog() == DialogResult.OK)
                    {
                        string idSelected = Fform.idSelected;
                        cliente = cliente.BuscarClienteFichario("D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\Fichario", idSelected);
                        if (cliente != null)
                        {
                            PreencheFormulario(cliente);
                        }
                        else
                        {
                            MessageBox.Show("Cliente não localizado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Falha ao buscar clientes", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
