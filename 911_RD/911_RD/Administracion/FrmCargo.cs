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
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            InsertarCargao();

        }





        private void InsertarCargao()
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

            }

        }


    }
}
