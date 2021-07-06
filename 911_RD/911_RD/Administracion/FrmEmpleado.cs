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

        private void InsertarEmpleado()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        EMPLEADOS eMPLEADOS = new EMPLEADOS
                        {
                            id = txt_puesto.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                            salario = Convert.ToDouble(txt_salario.Text.Trim()),
                            estado = cb_estado.SelectedIndex == 0 ? true : false
                        };

                        db.PUESTOS.Add(puesto);
                    }
                    else
                    {
                        var puesto = db.PUESTOS.FirstOrDefault(a => a.id_puesto.ToString() == id_txt.Text.Trim());
                        if (puesto != null)
                        {
                            puesto.puesto = txt_puesto.Text.Trim();
                            puesto.descripcion = txt_descripcion.Text.Trim();
                            puesto.salario = Convert.ToDouble(txt_salario.Text.Trim());
                            puesto.estado = cb_estado.SelectedIndex == 0 ? true : false;
                        }
                    }
                    db.SaveChanges();
                }
                Utilidades.LimpiarControles(this);
              //  cargarTabla();
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }

        private void btn_Cargo_Click(object sender, EventArgs e)
        {

            FrmCargo frmCargo = new FrmCargo();
            frmCargo.ShowDialog();


        }
    }
}
