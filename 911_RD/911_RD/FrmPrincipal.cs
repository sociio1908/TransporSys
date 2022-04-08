using _911_RD.Administracion;
using _911_RD.Administracion.Configuracion;
using _911_RD.Administracion.Pacientes;
using _911_RD.Administracion.Servicios;
using _911_RD.Administracion.Vehiculo;
using _911_RD.Administracion.Venta_y_Compra;
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

            AbrirFormEnPanel(new ConPrincipal());
             pnl_menu.Width = 180;

            label13.Text = Utilidades.nomusuario +" " +Utilidades.Apeuser;
            label12.Text = Utilidades.puestouser;

            if ( Utilidades.puestouser == "1")
            {
            //    btn_empleado.Enabled = false;
            //    btn_servicios.Enabled = false;
            //    btn_empleado.Enabled = false;
            //    btn_empleado.Enabled = false;
            //    btn_empleado.Enabled = false;
            //    btn_empleado.Enabled = false;

            }
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
            new FrmLogin().Show();
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
            pnl_menu.Width = 2;
        }


        //Abrir Home Screen
        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ConPrincipal());
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            new FrmPaciente().ShowDialog();

        }
     
        private void btn_empleado_Click(object sender, EventArgs e)
        { 
            new FrmEmpleado().ShowDialog();

        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            new FrmVentas().ShowDialog();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmCompra().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmConfiguracion().ShowDialog();
        }

        private void btn_vehiculos_Click(object sender, EventArgs e)
        {
            new FrmVehiculos().ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new FrmAdmVenta_Servios().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            new FrmAdmVentas().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmAlergias().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new FrmServicios().ShowDialog();
        }

        private void btn_add_art_Click(object sender, EventArgs e)
        {

            new FrmArticulos().ShowDialog();

        }

        private void btn_servicios_Click_1(object sender, EventArgs e)
        {
            new frmServicios().ShowDialog(); 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        new FrmLogin().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new FrmSuplidor().ShowDialog();

        }
    }
}
