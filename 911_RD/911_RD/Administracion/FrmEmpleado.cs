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
    public partial class FrmEmpleado : FrmBase
    {
        public FrmEmpleado()
        {
            InitializeComponent();
            cb_estado.SelectedIndex = 0;
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                return;

            try
            {

                //Meto insert/Update

            }
            catch(Exception dfg)
            {

            }


        }

        private void btn_Cargo_Click(object sender, EventArgs e)
        {

            FrmCargo frmCargo = new FrmCargo();
            frmCargo.ShowDialog();


        }
    }
}
