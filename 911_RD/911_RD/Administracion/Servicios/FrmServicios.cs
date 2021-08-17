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
    public partial class FrmServicios : FrmBase
    {
        public FrmServicios()
        {
            InitializeComponent();
            cargarTabla("");
            txt_nom.Focus();
            lbl_precio.Text = "";
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
                txt_id_tipo_servicio.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_id_und.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_nom.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_cat_servicio.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_precio.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txt_und.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[8].Value.ToString()=="ACTIVO" ?  cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
              
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
                    var list = from ser in db.SERVICIOS
                               join cat in db.CATEGORIAS_SERVICIOS on ser.id_categoria_servicio equals cat.id_categoria_servicio
                               join und in db.UNIDADES_DE_MEDIDA on ser.id_unidad_de_medida equals und.id_unidad_de_medida
                               select new
                               {
                                   id_categoria = ser.id_categoria_servicio,
                                   id_und = ser.id_unidad_de_medida,
                                   id_servicio = ser.id_servicio,
                                   nombre = ser.nombre,
                                   precio = ser.precio,
                                   categoria = cat.categoria,
                                   unidad_medida = und.unidad_de_medida,
                                   descripcion = ser.descripcion,
                                   estado = ser.estado,
                               };

                    if(list!=null)
                     //list = list.Where(a => a.estado==true);

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.nombre.Contains(condicion) || a.descripcion.Contains(condicion) || a.categoria.Contains(condicion) || a.id_servicio.ToString().Contains(condicion));
                    }

                    if (list != null)
                        foreach (var OPuestos in list)
                        {
                            dataGridView1.Rows.Add(OPuestos.id_categoria.ToString(), OPuestos.id_und.ToString(),
                                OPuestos.id_servicio.ToString(), OPuestos.nombre.ToString(),
                                OPuestos.descripcion.ToString(), OPuestos.categoria.ToString(),
                                OPuestos.precio.ToString(), OPuestos.unidad_medida.ToString(),
                                OPuestos.estado==true ? "ACTIVO":"INACTIVO");
                        }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        string servicio = "";
        private void InsertarPuesto()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;

                servicio = "";
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        SERVICIOS puesto = new SERVICIOS
                        {
                            id_categoria_servicio = int.Parse(txt_id_tipo_servicio.Text.Trim()),
                            id_unidad_de_medida = int.Parse(txt_id_und.Text.Trim()),
                            nombre = txt_nom.Text.Trim(),
                            descripcion = txt_nom.Text.Trim(),
                            precio = double.Parse(txt_precio.Text.Trim()),
                            estado = true,
                        };

                        db.SERVICIOS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.SERVICIOS.FirstOrDefault(a => a.id_servicio.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.id_categoria_servicio = int.Parse(txt_id_tipo_servicio.Text.Trim());
                            mail.id_unidad_de_medida = int.Parse(txt_id_und.Text.Trim());
                            mail.nombre = txt_nom.Text.Trim();
                            mail.descripcion = txt_descripcion.Text.Trim();
                            mail.precio = double.Parse(txt_precio.Text.Trim());
                            mail.estado = cb_estado.SelectedIndex == 0 ? true : false;
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


        MetodosCRUD metodoscrud = new MetodosCRUD();

        private void btn_marca_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmTipoServicios frmCargo = new FrmTipoServicios())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_tipo_servicio.Text = frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_cat_servicio.Text = frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmUnidadesMD frmCargo = new FrmUnidadesMD())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_und.Text = frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_und.Text = frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        lbl_precio.Text = "Precio base por "+ frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.RowCount > 0)
                CargarCampos();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Cells[8].Value.ToString() != "ACTIVO")
            {
                MessageBox.Show("ESTE SERVICIO NO ESTA ACTIVO.");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
                cargarTabla(txt_filtro.Text.Trim());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
        }
    }
}
