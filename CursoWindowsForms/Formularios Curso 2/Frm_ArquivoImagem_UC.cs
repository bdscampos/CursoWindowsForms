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
    public partial class Frm_ArquivoImagem_UC : UserControl
    {
        public Frm_ArquivoImagem_UC(string nomeArquivo)
        {
            InitializeComponent();
            lbl_ArquivoImagem.Text = nomeArquivo;
            pic_ArquivoImagem.Image = Image.FromFile(nomeArquivo);
        }

        private void btn_Cor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            lbl_ArquivoImagem.ForeColor = dlg.Color;
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowDialog();
            lbl_ArquivoImagem.Font = dlg.Font;
        }
    }
}
