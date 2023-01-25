namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaSenha));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_MostraSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Limpa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(12, 45);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(218, 20);
            this.txt_Senha.TabIndex = 1;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 22);
            this.lbl_Resultado.TabIndex = 2;
            // 
            // btn_MostraSenha
            // 
            this.btn_MostraSenha.Location = new System.Drawing.Point(245, 71);
            this.btn_MostraSenha.Name = "btn_MostraSenha";
            this.btn_MostraSenha.Size = new System.Drawing.Size(111, 23);
            this.btn_MostraSenha.TabIndex = 3;
            this.btn_MostraSenha.Text = "Mostra Senha";
            this.btn_MostraSenha.UseVisualStyleBackColor = true;
            this.btn_MostraSenha.Click += new System.EventHandler(this.btn_MostraSenha_Click);
            // 
            // Frm_ValidaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btn_MostraSenha);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ValidaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Validação de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_MostraSenha;
    }
}