namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey_UC
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
            this.lbl_Lower = new System.Windows.Forms.Label();
            this.lbl_Upper = new System.Windows.Forms.Label();
            this.lbl_Maius = new System.Windows.Forms.Label();
            this.lbl_Minus = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Lower
            // 
            this.lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Lower.Location = new System.Drawing.Point(363, 101);
            this.lbl_Lower.Name = "lbl_Lower";
            this.lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.lbl_Lower.TabIndex = 13;
            // 
            // lbl_Upper
            // 
            this.lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Upper.Location = new System.Drawing.Point(363, 53);
            this.lbl_Upper.Name = "lbl_Upper";
            this.lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.lbl_Upper.TabIndex = 12;
            // 
            // lbl_Maius
            // 
            this.lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Maius.Location = new System.Drawing.Point(315, 53);
            this.lbl_Maius.Name = "lbl_Maius";
            this.lbl_Maius.Size = new System.Drawing.Size(40, 16);
            this.lbl_Maius.TabIndex = 11;
            this.lbl_Maius.Text = "Maius.";
            // 
            // lbl_Minus
            // 
            this.lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Minus.Location = new System.Drawing.Point(315, 101);
            this.lbl_Minus.Name = "lbl_Minus";
            this.lbl_Minus.Size = new System.Drawing.Size(40, 16);
            this.lbl_Minus.TabIndex = 10;
            this.lbl_Minus.Text = "Minus.";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reset.Location = new System.Drawing.Point(323, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Limpa";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Msg
            // 
            this.txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Msg.Location = new System.Drawing.Point(3, 37);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Msg.Size = new System.Drawing.Size(304, 232);
            this.txt_Msg.TabIndex = 8;
            this.txt_Msg.TabStop = false;
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(3, 5);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(100, 20);
            this.txt_Input.TabIndex = 7;
            this.txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Input_KeyDown);
            // 
            // Frm_DemonstracaoKey_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Lower);
            this.Controls.Add(this.lbl_Upper);
            this.Controls.Add(this.lbl_Maius);
            this.Controls.Add(this.lbl_Minus);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Input);
            this.Name = "Frm_DemonstracaoKey_UC";
            this.Size = new System.Drawing.Size(410, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Lower;
        private System.Windows.Forms.Label lbl_Upper;
        private System.Windows.Forms.Label lbl_Maius;
        private System.Windows.Forms.Label lbl_Minus;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.TextBox txt_Input;
    }
}
