using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_DemonstracaoKey_Click(object sender, EventArgs e)
        {
            new Frm_DemonstracaoKey().ShowDialog();
        }

        private void btn_HelloWorld_Click(object sender, EventArgs e)
        {
            new Frm_HelloWorld().ShowDialog();
        }

        private void btn_Mascara_Click(object sender, EventArgs e)
        {
            new Frm_Mascara().ShowDialog();
        }

        private void btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            new Frm_ValidaCPF().ShowDialog();
        }

        private void btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            new Frm_ValidaCPF2().ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            new Frm_ValidaSenha().ShowDialog();
        }
    }
}
