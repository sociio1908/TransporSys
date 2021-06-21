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
    public partial class FrmCargo : FrmBase
    {
        public FrmCargo()
        {
            InitializeComponent();
            cargarTabla();
            txt_puesto.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarPuesto();
   
        }

        private  void CargarCampos()
        {
            if (dataGridView1.Rows.Count < 1)
                return;

            txt_id.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txt_puesto.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txt_descripcion.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txt_salario.Text = dataGridView1.SelectedCells[3].Value.ToString();
            if (dataGridView1.SelectedCells[4].Value.ToString()=="True"){
                cb_estado.SelectedIndex = 0;
            }
            else
            {
                cb_estado.SelectedIndex = 1;
            }

        }

        private void cargarTabla()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                   var list = db.PUESTOS;
                    string status = "ACTIVO";
                    foreach(var OPuestos in list)
                    {
                        if (!OPuestos.estado)
                             status = "INACTIVO";
                        dataGridView1.Rows.Add(OPuestos.id_puesto.ToString(), OPuestos.puesto.ToString(), OPuestos.descripcion.ToString(),
                            OPuestos.salario.ToString(), status);
                    }
                }
                catch (Exception dfg)
                {
                   // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
         }


        private void InsertarPuesto()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
                    return;

                using (TransporSysEntities db = new TransporSysEntities())
                {
                    PUESTOS oPuestos = new PUESTOS();
                    //cargamos los datos al objeto
                    oPuestos.puesto = txt_puesto.Text.Trim();
                    oPuestos.descripcion = txt_descripcion.Text.Trim();
                    oPuestos.salario = Convert.ToDouble(txt_salario.Text.Trim());
                    oPuestos.estado = true;
                    //agregamos el objeto de la tabla al objeto de la bd
                    db.PUESTOS.Add(oPuestos);
                    //guardamos los cambios
                    db.SaveChanges();
                }
                MessageBox.Show(lbl_titulo + " se ha guardado exitosamente");

            }
            catch (Exception dfg)
            {
              //  MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos();
        }
    }
}
