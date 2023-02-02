using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms.Formularios_Curso_3
{
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip cts = new ContextMenuStrip();
                ToolStripMenuItem tspm1 = DesenhaItemMenu("Fechar aba", "DeleteTab");
                ToolStripMenuItem tspm2 = DesenhaItemMenu("Fechar abas a esquerda", "DeleteLeft");
                ToolStripMenuItem tspm3 = DesenhaItemMenu("Fechar abas a direita", "DeleteRight");
                ToolStripMenuItem tspm4 = DesenhaItemMenu("Fechar todas as outras abas", "DeleteAll");
                cts.Items.Add(tspm1);
                cts.Items.Add(tspm2);
                cts.Items.Add(tspm3);
                cts.Items.Add(tspm4);
                cts.Show(this, e.X, e.Y);
                tspm1.Click += new System.EventHandler(tspm1_Click);
                tspm2.Click += new System.EventHandler(tspm2_Click);
                tspm3.Click += new System.EventHandler(tspm3_Click);
                tspm4.Click += new System.EventHandler(tspm4_Click);
            }

        }

        private void tspm1_Click(object sender, EventArgs e)
        {
        
        }

        private void tspm2_Click(object sender, EventArgs e)
        {
        
        }
        
        private void tspm3_Click(object sender, EventArgs e)
        {
        
        }
        
        private void tspm4_Click(object sender, EventArgs e)
        {
        
        }

        private ToolStripMenuItem DesenhaItemMenu(string text, string image)
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = text;
            toolStripMenuItem.Image = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(image);

            return toolStripMenuItem;
        }


    }
}
