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
    public partial class FrmCombustible : FrmBase
    {
        public FrmCombustible()
        {
            InitializeComponent();
            cb_estado.SelectedIndex = 0;
            cargarTabla("");

        }


    private void InsertarCombustible()
    {
        try
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                return;


            using (TransporSysEntities db = new TransporSysEntities())
            {
                if (id_txt.Text.Trim() == "")
                {
                    COMBUSTIBLE model = new COMBUSTIBLE
                    {
                        descripcion = txt_combustible.Text.Trim(),
                        precio = double.Parse(txt_precio.Text.Trim()),
                        estado = true
                    };

                    db.COMBUSTIBLE.Add(model);

                }
                else
                {
                    var mod = db.COMBUSTIBLE.FirstOrDefault(a => a.id_combustible.ToString() == id_txt.Text.Trim());
                    if (mod != null)
                    {
                        mod.descripcion = txt_combustible.Text.Trim();
                        mod.precio = double.Parse(txt_precio.Text.Trim());
                        mod.estado = cb_estado.SelectedIndex == 0 ? true : false;
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

    private void CargarCampos()
    {
        try
        {
            id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_combustible.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_precio.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
        }
        catch (Exception ea)
        {
            //
        }
    }


        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {

            InsertarCombustible();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_filtro.Text.Trim());
        }


        private void cargarTabla(string condicion)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                try
                {
                    dataGridView1.Rows.Clear();
                    var list = from mail in db.COMBUSTIBLE
                               select new
                               {
                                   id_combustible = mail.id_combustible,
                                   descripcion = mail.descripcion,
                                   precio = mail.precio,
                                   estado = mail.estado
                               };
                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.descripcion.Contains(condicion) || a.id_combustible.ToString().Contains(condicion));
                    }
                    dataGridView1.Rows.Add("", "", "");
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_combustible.ToString(), OPuestos.descripcion.ToString(),
                            OPuestos.precio.ToString(), OPuestos.estado == true ? "ACTIVO" : "INACTIVO");
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
        }
    }
}
