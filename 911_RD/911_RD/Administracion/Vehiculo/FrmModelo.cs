using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Vehiculo
{
    public partial class FrmModelo : FrmBase
    {
        public FrmModelo()
        {
            InitializeComponent();

            cargarTabla();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarPuesto();
        }


        private void InsertarPuesto()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                  using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        MODELO model = new MODELO
                        {
                            modelo1 = txt_modelo.Text.Trim(),
                        };

                        db.MODELO.Add(model);
                 
                    }
                    else
                    {
                        var mod = db.MODELO.FirstOrDefault(a => a.id_modelo.ToString() == id_txt.Text.Trim());
                        if (mod != null)
                        {
                            mod.modelo1 = txt_modelo.Text.Trim();
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

        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_modelo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void cargarTabla()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    var list = db.MODELO;
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_modelo.ToString(), OPuestos.modelo1.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }
    }
}
