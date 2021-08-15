using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Venta_y_Compra
{
    public partial class FrmItebis : FrmBase
    {
        public FrmItebis()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void FrmItebis_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarItebis();
        }

        private void InsertarItebis()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        ITEBIS cont = new ITEBIS
                        {
                            porcentaje = Convert.ToDouble(txt_porcentaje.Text.Trim()),
                            createdAt = dateTimePicker1.Value,
                            updatedAt = DateTime.Now,
                        };

                        db.ITEBIS.Add(cont);
                    }
                    else
                    {
                        var ite = db.ITEBIS.FirstOrDefault(a => a.intItebis.ToString() == id_txt.Text.Trim());
                        if (ite != null)
                        {

                            ite.porcentaje = Convert.ToDouble(txt_porcentaje.Text.Trim());
                            ite.createdAt = dateTimePicker1.Value;
                            ite.updatedAt = DateTime.Now;
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

        private void cargarTabla()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    string status;
                    var list = db.ITEBIS;
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.intItebis.ToString(), conti.porcentaje.ToString(), conti.createdAt.ToString(),conti.updatedAt.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_porcentaje.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());

            }
            catch (Exception ea)
            {
                //
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
        }

        private void txt_porcentaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                this.DialogResult = DialogResult.OK;
        }
    }
}
