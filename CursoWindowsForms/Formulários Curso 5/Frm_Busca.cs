using CursoWindowsFormsLibrary.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Formulários_Curso_5
{
    public partial class Frm_Busca : Form
    {

        public List<List<string>> ListaBusca { get; }
        public string idSelected { get; set; }

        public Frm_Busca(List<List<string>> listaBusca)
        {
            InitializeComponent();
            ListaBusca = listaBusca;
            this.Text = "Busca de Clientes";
            tsp_Busca.Items[0].ToolTipText = "Efetuar a busca";
            tsp_Busca.Items[1].ToolTipText = "Fechar a busca";
            lst_Busca.Sorted = true;
            PreencheLista();
        }

        private void PreencheLista()
        {
            lst_Busca.Items.Clear();
            for (int i = 0; i < ListaBusca.Count; i++)
            {
                ItemBox x = new ItemBox();
                x.id = ListaBusca[i][0];
                x.nome = ListaBusca[i][1];
                lst_Busca.Items.Add(x);
            }
        }

        private void closeToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (lst_Busca.SelectedIndex != -1)
            {
                ItemBox ib = (ItemBox)lst_Busca.Items[lst_Busca.SelectedIndex];
                if (ib != null)
                {
                    idSelected = ib.id;
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        class ItemBox
        {
            public string id { get; set; }
            public string nome { get; set; }

            public override string ToString()
            {
                return nome;
            }

            
        }
    }
}
