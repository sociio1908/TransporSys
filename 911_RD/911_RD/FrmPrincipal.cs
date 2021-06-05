using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            pnl_menu.Width = 2;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {

            if (pnl_menu.Width == 2)
            {
                pnl_menu.Width = 180;
                pnl_menu.Visible = true;
            }
            else
            {
                pnl_menu.Width = 2;
                pnl_menu.Visible = false;
            }

        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
