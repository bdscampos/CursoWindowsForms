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
    public partial class Frm_Principal_Menu_UC : Form
    {
        UserControl Uc;
                
        int controleDemonstracao;
        int controleHelloWorld;
        int controleMascara;
        int controleValidaCpf;
        int controleValidaCpf2;
        int controleValidaSenha;
        int controleArquivoImagem;
        bool controleCadastroCliente;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
            newToolStripMenuItem.Enabled = false;
            deleteTabToolStripMenuItem.Enabled = false;
            openImageToolStripMenuItem.Enabled = false;
            disconnectToolStripMenuItem.Enabled = false;
            byteBankToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_DemonstracaoKey_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleDemonstracao++;
            tp.Name = "Demonstração Key " + controleDemonstracao;
            tp.Text = "Demonstração Key " + controleDemonstracao;
            tp.ImageIndex = 0;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_HelloWorld_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleHelloWorld++;
            tp.Name = "Hello World " + controleHelloWorld;
            tp.Text = "Hello World " + controleHelloWorld;
            tp.ImageIndex = 1;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
            
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_Mascara_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleMascara++;
            tp.Name = "Mascara " + controleMascara;
            tp.Text = "Mascara " + controleMascara;
            tp.ImageIndex = 2;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
        }

        private void validaCPF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_ValidaCPF_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleValidaCpf++;
            tp.Name = "Valida CPF " + controleValidaCpf;
            tp.Text = "Valida CPF " + controleValidaCpf;
            tp.ImageIndex = 3;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_ValidaCPF2_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleValidaCpf2++;
            tp.Name = "Valida CPF 2 " + controleValidaCpf2;
            tp.Text = "Valida CPF 2 " + controleValidaCpf2;
            tp.ImageIndex = 4;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Uc = new Frm_ValidaSenha_UC();
            Uc.Dock = DockStyle.Fill;
            TabPage tp = new TabPage();
            controleValidaSenha++;
            tp.Name = "Valida Senha " + controleValidaSenha;
            tp.Text = "Valida Senha " + controleValidaSenha;
            tp.ImageIndex = 5;
            tp.Controls.Add(Uc);
            tc_Aplicacoes.TabPages.Add(tp);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tc_Aplicacoes.SelectedTab != null) CloseTab(tc_Aplicacoes.SelectedTab);
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:\\Projetos\\C#\\Alura\\CursoWindowsForms\\CursoWindowsForms\\Images";
            ofd.Filter = "png|*.png";
            ofd.Title = "Open Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Uc = new Frm_ArquivoImagem_UC(ofd.FileName);
                Uc.Dock = DockStyle.Fill;
                TabPage tp = new TabPage();
                controleArquivoImagem++;
                tp.Name = "Arquivo Imagem " + controleArquivoImagem;
                tp.Text = "Arquivo Imagem " + controleArquivoImagem;
                tp.ImageIndex = 6;
                tp.Controls.Add(Uc);
                tc_Aplicacoes.TabPages.Add(tp);
                
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!controleCadastroCliente)
            {
                Uc = new Frm_CadastroCliente_UC();
                Uc.Dock = DockStyle.Fill;
                TabPage tp = new TabPage();
                controleCadastroCliente = true;
                tp.Name = "Cadastro de Cliente";
                tp.Text = "Cadastro de Cliente";
                tp.ImageIndex = 7;
                tp.Controls.Add(Uc);
                tc_Aplicacoes.TabPages.Add(tp);
            } 
            else
            {
                MessageBox.Show("Não é possível abrir mais de um cadastro de cliente", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login f = new Frm_Login();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                if (Utils.ValidaSenhaLogin(f.password))
                {
                    newToolStripMenuItem.Enabled = true;
                    deleteTabToolStripMenuItem.Enabled = true;
                    openImageToolStripMenuItem.Enabled = true;
                    disconnectToolStripMenuItem.Enabled = true;
                    byteBankToolStripMenuItem.Enabled = true;
                    connectToolStripMenuItem.Enabled = false;

                    MessageBox.Show("Bem vindo(a) " + f.username + "!", "Login bem sucedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    MessageBox.Show("Usuário ou senha incorreto", "Falha de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Questao("QuestionMark", "Deseja desconectar do sistema?");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.Yes)
            {
                for (int i = tc_Aplicacoes.TabPages.Count - 1; i >= 0 ; i--)
                {
                    tc_Aplicacoes.TabPages.RemoveAt(i);
                }
                newToolStripMenuItem.Enabled = false;
                deleteTabToolStripMenuItem.Enabled = false;
                openImageToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = false;
                byteBankToolStripMenuItem.Enabled = false;
                connectToolStripMenuItem.Enabled = true;
                tc_Aplicacoes.Enabled = false;
            }
        }

        private void tc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
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
            if (tc_Aplicacoes.SelectedTab != null) CloseTab(tc_Aplicacoes.SelectedTab);
        }

        private void tspm2_Click(object sender, EventArgs e)
        {
            if (tc_Aplicacoes.SelectedTab != null && tc_Aplicacoes.SelectedIndex > 0)
            {
                DeleteLeftTabs(tc_Aplicacoes.SelectedIndex);
            }
        }

        private void tspm3_Click(object sender, EventArgs e)
        {
            if (tc_Aplicacoes.SelectedTab != null)
            {
                DeleteRightTabs(tc_Aplicacoes.SelectedIndex);
            }
        }

        private void tspm4_Click(object sender, EventArgs e)
        {
            if (tc_Aplicacoes.SelectedTab != null)
            {
                DeleteLeftTabs(tc_Aplicacoes.SelectedIndex);
                DeleteRightTabs(tc_Aplicacoes.SelectedIndex);
            }
        }

        private ToolStripMenuItem DesenhaItemMenu(string text, string image)
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = text;
            toolStripMenuItem.Image = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(image);

            return toolStripMenuItem;
        }

        private void DeleteLeftTabs(int index)
        {
            for (int i = index - 1; i >= 0; i--)
            {
                CloseTab(tc_Aplicacoes.TabPages[i]);
            }
        }

        private void DeleteRightTabs(int index)
        {
            for (int i = tc_Aplicacoes.TabPages.Count - 1; i > index; i--)
            {
                CloseTab(tc_Aplicacoes.TabPages[i]);
            }
        }

        private void CloseTab(TabPage tb)
        {
            if (tb.Name == "Cadastro de Cliente") controleCadastroCliente = false;
            tc_Aplicacoes.TabPages.Remove(tb);
        }

        


    }
}
