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
    public partial class FrmTipoIdentificacione : FrmBase
    {
        public FrmTipoIdentificacione()
        {
            InitializeComponent();
            cargarTabla("");
            txt_tipo_identificacion.Focus();
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
                txt_tipo_identificacion.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void cargarTabla(string condicion)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    var list = from mail in db.TIPOS_IDENTIFICACIONES
                               select new
                               {
                                   id_tipo_identificacion = mail.id_tipo_identificacion,
                                   tipo_identificacion = mail.nombre,
                                   descripcion = mail.descripcion
                               };

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.tipo_identificacion.Contains(condicion) || a.descripcion.ToString().Contains(condicion));
                    }
                    dataGridView1.Rows.Add("", "", "");

                    if (list != null)
                        foreach (var OPuestos in list)
                        {
                            dataGridView1.Rows.Add(OPuestos.id_tipo_identificacion.ToString(), OPuestos.tipo_identificacion.ToString(), OPuestos.descripcion);
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
                        TIPOS_IDENTIFICACIONES puesto = new TIPOS_IDENTIFICACIONES
                        {
                            nombre = txt_tipo_identificacion.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                        };

                        db.TIPOS_IDENTIFICACIONES.Add(puesto);
                    }
                    else
                    {
                        var mail = db.TIPOS_IDENTIFICACIONES.FirstOrDefault(a => a.id_tipo_identificacion.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.nombre = txt_tipo_identificacion.Text.Trim();
                            mail.descripcion = txt_descripcion.Text.Trim();
                        }
                    }
                    db.SaveChanges();
                }
                Utilidades.LimpiarControles(this);
                cargarTabla("");
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                CargarCampos();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_filtro.Text.Trim());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
                this.DialogResult = DialogResult.OK;

        }



    }
}
