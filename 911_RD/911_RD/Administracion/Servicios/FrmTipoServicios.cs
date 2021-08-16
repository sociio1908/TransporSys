using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Servicios
{
    public partial class FrmTipoServicios : FrmBase
    {
        public FrmTipoServicios()
        {
            InitializeComponent();
            cargarTabla("");
            txt_servicio.Focus();
            cb_estado.SelectedIndex = 0;
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
                txt_servicio.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
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
                    var list = from mail in db.CATEGORIAS_SERVICIOS
                               select new
                               {
                                   id_categoria = mail.id_categoria_servicio,
                                   categoria = mail.categoria,
                                   descripcion = mail.descripcion,
                                   estado = mail.estado
                               };
                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.categoria.Contains(condicion) || a.descripcion.ToString().Contains(condicion));
                    }
                    dataGridView1.Rows.Add("", "", "");
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_categoria.ToString(), OPuestos.categoria.ToString(), OPuestos.descripcion.ToString(),
                           OPuestos.estado == true ? "ACTIVO" : "INACTIVO");
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
                        CATEGORIAS_SERVICIOS puesto = new CATEGORIAS_SERVICIOS
                        {
                            categoria = txt_servicio.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                            estado = cb_estado.SelectedIndex == 0 ? true : false
                        };

                        db.CATEGORIAS_SERVICIOS.Add(puesto);
                    }
                    else
                    {
                        var puesto = db.CATEGORIAS_SERVICIOS.FirstOrDefault(a => a.id_categoria_servicio.ToString() == id_txt.Text.Trim());
                        if (puesto != null)
                        {
                            puesto.categoria = txt_servicio.Text.Trim();
                            puesto.descripcion = txt_descripcion.Text.Trim();
                            puesto.estado = cb_estado.SelectedIndex == 0 ? true : false;
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
