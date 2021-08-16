using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Pacientes
{
    public partial class FrmMedicamentos : FrmBase
    {
        public FrmMedicamentos()
        {
            InitializeComponent();
            cargarTabla("");
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
                txt_id_tipo_med.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_tipo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_medicamento.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

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
                    var list = from mail in db.MEDICAMENTOS
                               join tip in db.TIPO_MEDICAMENTOS on mail.id_tipo_medicamento equals tip.id_tipo_medicamento
                               select new
                               {
                                   id_medicamento = mail.id_medicamento,
                                   id_tipo_medicamento = mail.id_tipo_medicamento,
                                   tipo_medicamento = tip.tipo_medicamento,
                                   medicamento = mail.medicamento,
                                   descripcion = mail.descripcion,
                               };

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.medicamento.Contains(condicion) || a.descripcion.ToString().Contains(condicion) || a.tipo_medicamento.ToString().Contains(condicion));
                    }

                    if (list != null)
                        foreach (var OPuestos in list)
                        {
                            dataGridView1.Rows.Add(OPuestos.id_medicamento.ToString(), OPuestos.id_tipo_medicamento.ToString(),
                               OPuestos.tipo_medicamento, OPuestos.medicamento.ToString(), OPuestos.descripcion.ToString());
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
                        MEDICAMENTOS puesto = new MEDICAMENTOS
                        {
                            id_tipo_medicamento = int.Parse(txt_id_tipo_med.Text.Trim()),
                            medicamento = txt_medicamento.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                        };

                        db.MEDICAMENTOS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.MEDICAMENTOS.FirstOrDefault(a => a.id_medicamento.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.id_tipo_medicamento = int.Parse(txt_id_tipo_med.Text.Trim());
                            mail.medicamento = txt_medicamento.Text.Trim();
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

        private void btn_tipo_med_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmTipoMedicamento frmCargo = new FrmTipoMedicamento())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_tipo_med.Text = frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_tipo.Text = frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
            CargarCampos();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
