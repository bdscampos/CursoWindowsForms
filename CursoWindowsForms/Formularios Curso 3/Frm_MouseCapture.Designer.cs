namespace CursoWindowsForms
{
    partial class Frm_MouseCapture
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
            this.btn_Mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mouse
            // 
            this.btn_Mouse.Location = new System.Drawing.Point(101, 88);
            this.btn_Mouse.Name = "btn_Mouse";
            this.btn_Mouse.Size = new System.Drawing.Size(209, 104);
            this.btn_Mouse.TabIndex = 0;
            this.btn_Mouse.UseVisualStyleBackColor = true;
            this.btn_Mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Mouse_MouseDown);
            // 
            // Frm_MouseCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 306);
            this.Controls.Add(this.btn_Mouse);
            this.Name = "Frm_MouseCapture";
            this.Text = "Frm_MouseCapture";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mouse;
    }
}