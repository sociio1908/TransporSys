using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion.PAGOS_COBROS;
using _911_RD.Administracion.Vehiculo;

namespace _911_RD.Administracion.Configuracion
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
               bool a = metodosCRUD.ValidarChasis_Placa("123");

        }

        MetodosCRUD metodosCRUD = new MetodosCRUD();

        private void lbl_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.p_container.Controls.Count > 0)
                this.p_container.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.p_container.Controls.Add(fh);
            this.p_container.Tag = fh;
            fh.Show();
        }

        private void btn_Tipos_Pago_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTiposPago());
        }

        private void btn_combustibles_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new FrmCombustible());
        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEmpresa());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConfiguracionProducto());
        }
    }
}
