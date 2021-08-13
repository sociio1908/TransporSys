using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion
{
    public partial class FrmPaciente : FrmBase
    {
        public FrmPaciente()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo");
        }

        private void btn_buscar_direccion_Click(object sender, EventArgs e)
        {
            F_principal ds = new F_principal();
            ds.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fecha_nac_ValueChanged(object sender, EventArgs e)
        {
           if( Utilidades.mayorEdad(fecha_nac.Value) == false)
            {


            }


        }
    }
}
