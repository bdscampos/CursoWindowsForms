using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
