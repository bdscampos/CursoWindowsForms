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
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            if (Utils.Valida(msk_Cpf.Text)) {
                lbl_Resultado.Text = "Válido";
                lbl_Resultado.ForeColor = Color.Green;
            } else
            {
                lbl_Resultado.Text = "Inválido";
                lbl_Resultado.ForeColor = Color.Red;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            msk_Cpf.Text = "";
        }
    }
}
