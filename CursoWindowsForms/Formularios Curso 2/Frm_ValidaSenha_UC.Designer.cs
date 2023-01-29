namespace CursoWindowsForms
{
    partial class Frm_ValidaSenha_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MostraSenha = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Limpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MostraSenha
            // 
            this.btn_MostraSenha.Location = new System.Drawing.Point(253, 70);
            this.btn_MostraSenha.Name = "btn_MostraSenha";
            this.btn_MostraSenha.Size = new System.Drawing.Size(111, 23);
            this.btn_MostraSenha.TabIndex = 7;
            this.btn_MostraSenha.Text = "Mostra Senha";
            this.btn_MostraSenha.UseVisualStyleBackColor = true;
            this.btn_MostraSenha.Click += new System.EventHandler(this.btn_MostraSenha_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Resultado.Location = new System.Drawing.Point(20, 89);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 22);
            this.lbl_Resultado.TabIndex = 6;
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(20, 44);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(218, 20);
            this.txt_Senha.TabIndex = 5;
            this.txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Senha_KeyDown);
            // 
            // btn_Limpa
            // 
            this.btn_Limpa.Location = new System.Drawing.Point(253, 41);
            this.btn_Limpa.Name = "btn_Limpa";
            this.btn_Limpa.Size = new System.Drawing.Size(111, 23);
            this.btn_Limpa.TabIndex = 4;
            this.btn_Limpa.Text = "Limpa";
            this.btn_Limpa.UseVisualStyleBackColor = true;
            this.btn_Limpa.Click += new System.EventHandler(this.btn_Limpa_Click);
            // 
            // Frm_ValidaSenha_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_MostraSenha);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.btn_Limpa);
            this.Name = "Frm_ValidaSenha_UC";
            this.Size = new System.Drawing.Size(385, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MostraSenha;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Limpa;
    }
}
