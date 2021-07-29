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
        int id = 0;
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarPuesto();
   
        }

        private void CargarCampos()
        {
            try
            {

            id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txt_puesto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_salario.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
            }catch(Exception ea)
            {
                //
            }
        }

        private void cargarTabla()
        {
            using (TransporSysEntities4 db = new TransporSysEntities4())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    string status;
                   var list = db.PUESTOS;
                    foreach(var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_puesto.ToString(), OPuestos.puesto.ToString(), OPuestos.descripcion.ToString(),
                            OPuestos.salario.ToString(), status = OPuestos.estado == true ? "ACTIVO" : "INACTIVO");
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
                  if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;

            
                using (TransporSysEntities4 db = new TransporSysEntities4())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        PUESTOS puesto = new PUESTOS
                        {
                            puesto = txt_puesto.Text.Trim(),
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
                cargarTabla();
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
               catch (Exception dfg)
               {
             // MessageBox.Show(lbl_titulo + " ERRORRRR");

             }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


          if (e.RowIndex < 0 )
              return;

            CargarCampos();
        
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
    
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ENTRO PAPAAAA");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            Utilidades.LimpiarControles(this);
            cargarTabla();
        }

        private void FrmCargo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Firebrick, 1),
                          this.DisplayRectangle);
        }

        private void txt_salario_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            FrmEmpleado frEmpl = new FrmEmpleado();
            frEmpl.txt_cargo.Text = txt_puesto.Text;
            frEmpl.txt_sueldo.Text = txt_descripcion.Text;
            frEmpl.errorTxtBox2.Text = txt_salario.Text;
            frEmpl.Show();
           
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {

        }
    }
}
