namespace CursoWindowsForms
{
    partial class Frm_Principal_Menu_UC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal_Menu_UC));
            this.mnu_Principal = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mascaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byteBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.img_imagens = new System.Windows.Forms.ImageList(this.components);
            this.mnu_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_Principal
            // 
            this.mnu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.byteBankToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.mnu_Principal.Location = new System.Drawing.Point(0, 0);
            this.mnu_Principal.Name = "mnu_Principal";
            this.mnu_Principal.Size = new System.Drawing.Size(857, 24);
            this.mnu_Principal.TabIndex = 0;
            this.mnu_Principal.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.newToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.mascaraToolStripMenuItem,
            this.validaCPF1ToolStripMenuItem,
            this.validaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_DemonstracaoKey;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_HelloWorld;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.helloWorldToolStripMenuItem.Text = "Hello World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // mascaraToolStripMenuItem
            // 
            this.mascaraToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Mascara;
            this.mascaraToolStripMenuItem.Name = "mascaraToolStripMenuItem";
            this.mascaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.mascaraToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mascaraToolStripMenuItem.Text = "Máscara";
            this.mascaraToolStripMenuItem.Click += new System.EventHandler(this.mascaraToolStripMenuItem_Click);
            // 
            // validaCPF1ToolStripMenuItem
            // 
            this.validaCPF1ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF;
            this.validaCPF1ToolStripMenuItem.Name = "validaCPF1ToolStripMenuItem";
            this.validaCPF1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.validaCPF1ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.validaCPF1ToolStripMenuItem.Text = "Valida CPF 1";
            this.validaCPF1ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF1ToolStripMenuItem_Click);
            // 
            // validaCPF2ToolStripMenuItem
            // 
            this.validaCPF2ToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaCPF2;
            this.validaCPF2ToolStripMenuItem.Name = "validaCPF2ToolStripMenuItem";
            this.validaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.validaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.validaCPF2ToolStripMenuItem.Text = "Valida CPF 2";
            this.validaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.validaCPF2ToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Frm_ValidaSenha;
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.validaSenhaToolStripMenuItem.Text = "Valida Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteTabToolStripMenuItem.Text = "Delete Tab";
            this.deleteTabToolStripMenuItem.Click += new System.EventHandler(this.deleteTabToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // byteBankToolStripMenuItem
            // 
            this.byteBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.byteBankToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.money;
            this.byteBankToolStripMenuItem.Name = "byteBankToolStripMenuItem";
            this.byteBankToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.byteBankToolStripMenuItem.Text = "ByteBank";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Cadastros;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.user;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImageToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Image = global::CursoWindowsForms.Properties.Resources.Folder;
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // tc_Aplicacoes
            // 
            this.tc_Aplicacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Aplicacoes.ImageList = this.img_imagens;
            this.tc_Aplicacoes.Location = new System.Drawing.Point(0, 24);
            this.tc_Aplicacoes.Name = "tc_Aplicacoes";
            this.tc_Aplicacoes.SelectedIndex = 0;
            this.tc_Aplicacoes.Size = new System.Drawing.Size(857, 527);
            this.tc_Aplicacoes.TabIndex = 1;
            this.tc_Aplicacoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tc_Aplicacoes_MouseDown);
            // 
            // img_imagens
            // 
            this.img_imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_imagens.ImageStream")));
            this.img_imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.img_imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.img_imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.img_imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            this.img_imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.img_imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.img_imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            this.img_imagens.Images.SetKeyName(6, "Folder.png");
            this.img_imagens.Images.SetKeyName(7, "user.png");
            // 
            // Frm_Principal_Menu_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 551);
            this.Controls.Add(this.tc_Aplicacoes);
            this.Controls.Add(this.mnu_Principal);
            this.MainMenuStrip = this.mnu_Principal;
            this.Name = "Frm_Principal_Menu_UC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.mnu_Principal.ResumeLayout(false);
            this.mnu_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_Principal;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mascaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPF1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_Aplicacoes;
        private System.Windows.Forms.ImageList img_imagens;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}
