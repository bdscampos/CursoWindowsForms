namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
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
            this.btn_Cor = new System.Windows.Forms.Button();
            this.btn_Fonte = new System.Windows.Forms.Button();
            this.lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.pic_ArquivoImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ArquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cor
            // 
            this.btn_Cor.Location = new System.Drawing.Point(20, 4);
            this.btn_Cor.Name = "btn_Cor";
            this.btn_Cor.Size = new System.Drawing.Size(75, 23);
            this.btn_Cor.TabIndex = 0;
            this.btn_Cor.Text = "Cor";
            this.btn_Cor.UseVisualStyleBackColor = true;
            this.btn_Cor.Click += new System.EventHandler(this.btn_Cor_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.Location = new System.Drawing.Point(101, 4);
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.btn_Fonte.TabIndex = 1;
            this.btn_Fonte.Text = "Fonte";
            this.btn_Fonte.UseVisualStyleBackColor = true;
            this.btn_Fonte.Click += new System.EventHandler(this.btn_Fonte_Click);
            // 
            // lbl_ArquivoImagem
            // 
            this.lbl_ArquivoImagem.AutoSize = true;
            this.lbl_ArquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.lbl_ArquivoImagem.Name = "lbl_ArquivoImagem";
            this.lbl_ArquivoImagem.Size = new System.Drawing.Size(61, 13);
            this.lbl_ArquivoImagem.TabIndex = 2;
            this.lbl_ArquivoImagem.Text = "<message>";
            // 
            // pic_ArquivoImagem
            // 
            this.pic_ArquivoImagem.Location = new System.Drawing.Point(20, 76);
            this.pic_ArquivoImagem.Name = "pic_ArquivoImagem";
            this.pic_ArquivoImagem.Size = new System.Drawing.Size(209, 156);
            this.pic_ArquivoImagem.TabIndex = 3;
            this.pic_ArquivoImagem.TabStop = false;
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pic_ArquivoImagem);
            this.Controls.Add(this.lbl_ArquivoImagem);
            this.Controls.Add(this.btn_Fonte);
            this.Controls.Add(this.btn_Cor);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(548, 290);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ArquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cor;
        private System.Windows.Forms.Button btn_Fonte;
        private System.Windows.Forms.Label lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox pic_ArquivoImagem;
    }
}
