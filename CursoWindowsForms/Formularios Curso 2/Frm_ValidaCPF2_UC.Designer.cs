namespace CursoWindowsForms
{
    partial class Frm_ValidaCPF2_UC
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
            this.btn_Valida = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.msk_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Valida
            // 
            this.btn_Valida.Location = new System.Drawing.Point(253, 79);
            this.btn_Valida.Name = "btn_Valida";
            this.btn_Valida.Size = new System.Drawing.Size(111, 23);
            this.btn_Valida.TabIndex = 6;
            this.btn_Valida.Text = "Valida";
            this.btn_Valida.UseVisualStyleBackColor = true;
            this.btn_Valida.Click += new System.EventHandler(this.btn_Valida_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(253, 50);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 23);
            this.btn_Reset.TabIndex = 5;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // msk_Cpf
            // 
            this.msk_Cpf.Location = new System.Drawing.Point(20, 53);
            this.msk_Cpf.Mask = "000,000,000-00";
            this.msk_Cpf.Name = "msk_Cpf";
            this.msk_Cpf.Size = new System.Drawing.Size(218, 20);
            this.msk_Cpf.TabIndex = 4;
            // 
            // Frm_ValidaCPF2_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Valida);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.msk_Cpf);
            this.Name = "Frm_ValidaCPF2_UC";
            this.Size = new System.Drawing.Size(385, 153);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Valida;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.MaskedTextBox msk_Cpf;
    }
}
