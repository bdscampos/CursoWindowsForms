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
    public partial class Frm_MouseCapture : Form
    {
        public Frm_MouseCapture()
        {
            InitializeComponent();
        }

        private void btn_Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Mouse.Text = e.Button.ToString();
        }
    }
}
