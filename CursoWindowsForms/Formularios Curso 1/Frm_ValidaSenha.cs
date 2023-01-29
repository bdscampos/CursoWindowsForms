using System;
using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            txt_Senha.Text = "";
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_Resultado.Text = "";
            ChecaForcaSenha checaForcaSenha = new ChecaForcaSenha();
            lbl_Resultado.Text = checaForcaSenha.GetForcaDaSenha(txt_Senha.Text).ToString();

            if (lbl_Resultado.Text == "Inaceitavel" || lbl_Resultado.Text == "Fraca") lbl_Resultado.ForeColor = Color.Red;
            else if (lbl_Resultado.Text == "Aceitavel") lbl_Resultado.ForeColor = Color.Yellow;
            else lbl_Resultado.ForeColor = Color.Green;
        }

        private void btn_MostraSenha_Click(object sender, EventArgs e)
        {
            if (txt_Senha.PasswordChar == '\0')
            {
                txt_Senha.PasswordChar = '*';
                btn_MostraSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '\0';
                btn_MostraSenha.Text = "Mostra Senha";
            }
        }
    }
}
