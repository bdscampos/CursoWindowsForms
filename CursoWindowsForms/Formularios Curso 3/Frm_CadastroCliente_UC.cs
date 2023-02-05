using CursoWindowsFormsLibrary;
using CursoWindowsFormsLibrary.Models;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

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
                MessageBox.Show("Cliente cadastrado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripButton_Click(object sender, EventArgs e)
        {

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
    }
}
