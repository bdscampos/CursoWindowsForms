using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void btn_Hora_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "00:00";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus();
            lbl_Conteudo.Text = "";
        }

        private void btn_CEP_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "00000-000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus(); 
            lbl_Conteudo.Text = "";
        }

        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "$ 000,000,000.00";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus();
            lbl_Conteudo.Text = "";
        }

        private void btn_Data_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "00/00/0000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus();
            lbl_Conteudo.Text = "";
        }

        private void btn_Senha_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = true;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "000000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus();
            lbl_Conteudo.Text = "";
        }

        private void btn_Telefone_Click(object sender, EventArgs e)
        {
            msk_TextBox.UseSystemPasswordChar = false;
            msk_TextBox.Text = "";
            msk_TextBox.Mask = "(00) 0000-00000";
            lbl_MascaraAtiva.Text = msk_TextBox.Mask;
            msk_TextBox.Focus();
            lbl_Conteudo.Text = "";
        }

        private void btn_VerConteudo_Click(object sender, EventArgs e)
        {
            lbl_Conteudo.Text = msk_TextBox.Text;
        }
    }
}
