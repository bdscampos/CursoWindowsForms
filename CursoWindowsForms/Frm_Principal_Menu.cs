using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu : Form
    {
        public Frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_DemonstracaoKey().ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_HelloWorld().ShowDialog();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Mascara().ShowDialog();
        }

        private void validaCPF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_ValidaCPF().ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_ValidaCPF2().ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_ValidaSenha().ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
