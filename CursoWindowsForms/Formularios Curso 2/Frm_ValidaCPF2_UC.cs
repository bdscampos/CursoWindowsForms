using CursoWindowsFormsLibrary;
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
    public partial class Frm_ValidaCPF2_UC : UserControl
    {
        public Frm_ValidaCPF2_UC()
        {
            InitializeComponent();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            msk_Cpf.Text = "";
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            string cpf = msk_Cpf.Text;
            cpf = cpf.Replace(".", "").Replace("-", "").Trim();
            if (cpf == "")
            {
                MessageBox.Show("CPF não pode estar em branco", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cpf.Length != 11) MessageBox.Show("CPF deve ter 11 digítos", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Form f = new Frm_Questao("QuestionMark", "Deseja validar o CPF?");
                f.ShowDialog();
                if (f.DialogResult == DialogResult.Yes)
                //if (MessageBox.Show("Deseja validar o CPF?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Utils.Valida(msk_Cpf.Text))
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
