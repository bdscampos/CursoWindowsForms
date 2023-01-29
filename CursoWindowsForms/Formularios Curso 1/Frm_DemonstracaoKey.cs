using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_DemonstracaoKey : Form
    {
        public Frm_DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Lower.Text = "";
            lbl_Upper.Text = "";
            txt_Input.Text = "";
            txt_Msg.Text = "";
        }

        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            txt_Msg.AppendText("\r\n" + "Pressionei a tecla: " + e.KeyCode + "\r\n");
            txt_Msg.AppendText("\t" + "Código da Tecla: " + e.KeyValue + "\r\n");
            txt_Msg.AppendText("\t" + "Nome da Tecla: " + e.KeyData + "\r\n");
            lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
        }
    }
}
