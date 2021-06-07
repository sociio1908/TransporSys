using _911_RD.Administracion;
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
            AbrirFormEnPanel(new ConPrincipal());
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

        private void pnl_resumen_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.pnl_contenedor.Controls.Count > 0)
                this.pnl_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_contenedor.Controls.Add(fh);
            this.pnl_contenedor.Tag = fh;
            fh.Show();
        }


        //Abrir Home Screen
        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConPrincipal());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new FrmCliente());
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPaciente());

        }
    }
}
