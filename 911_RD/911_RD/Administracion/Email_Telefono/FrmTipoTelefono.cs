using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Email_Telefono
{
    public partial class FrmTipoTelefono : FrmBase
    {
        public FrmTipoTelefono()
        {
            InitializeComponent();
            cargarTabla();
            txt_tipo.Focus();
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
                txt_tipo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                    var list = db.TIPOS_TELEFONOS;
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_tipo_telefono.ToString(), OPuestos.tipo_telefono.ToString(), OPuestos.descripcion.ToString());
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


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        TIPOS_TELEFONOS puesto = new TIPOS_TELEFONOS
                        {
                            tipo_telefono = txt_tipo.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                        };

                        db.TIPOS_TELEFONOS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.TIPOS_TELEFONOS.FirstOrDefault(a => a.id_tipo_telefono.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.tipo_telefono = txt_tipo.Text.Trim();
                            mail.descripcion = txt_descripcion.Text.Trim();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
