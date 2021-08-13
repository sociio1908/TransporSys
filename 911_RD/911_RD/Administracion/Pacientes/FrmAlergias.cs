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
    public partial class FrmAlergias : FrmBase
    {
        public FrmAlergias()
        {
            InitializeComponent();
            cargarTabla("");
            txt_alergia.Focus();
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
                txt_alergia.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cargarTelefonos(int.Parse(id_txt.Text));
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
                    var list = from mail in db.ALERGIAS
                               select new
                               {
                                   id_alergia = mail.id_alergia,
                                   alergia = mail.alergia,
                                   descripcion = mail.descripcion
                               };

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.alergia.Contains(condicion) || a.id_alergia.ToString().Contains(condicion));
                    }

                    if (list != null)
                        foreach (var OPuestos in list)
                        {
                            dataGridView1.Rows.Add(OPuestos.id_alergia.ToString(), OPuestos.alergia.ToString(), OPuestos.descripcion.ToString());
                        }


                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        string _alergia = "";
        private void InsertarPuesto()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;

                _alergia = "";
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        ALERGIAS puesto = new ALERGIAS
                        {
                            alergia = txt_alergia.Text.Trim().ToLower(),
                            descripcion = txt_descripcion.Text.Trim().ToLower(),
                        };

                        db.ALERGIAS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.ALERGIAS.FirstOrDefault(a => a.id_alergia.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.alergia = txt_alergia.Text.Trim();
                            mail.descripcion = txt_descripcion.Text.Trim().ToLower();
                            _alergia = mail.id_alergia.ToString();
                        }
                    }
                    db.SaveChanges();

                    if (id_txt.Text.Trim() == "")
                        _alergia = db.ALERGIAS.Max(x => x.id_alergia).ToString();

                    if (_alergia != "" && tabla_med.Rows.Count > 0)
                    {
                        MessageBox.Show("ENTROO ALERGIA: " + _alergia);
                        AsiganarMed(int.Parse(_alergia));

                    }
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
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

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 0)
                cargarTabla(txt_filtro.Text.Trim());
        }

        private void btn_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmMedicamentos frmCargo = new FrmMedicamentos())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        bool existe = false;
                        if (tabla_med.RowCount > 0)
                        {
                            // Primero averigua si el registro existe:

                            for (int i = 0; i < tabla_med.RowCount; i++)
                            {
                                if (tabla_med.Rows[i].Cells[0].Value.ToString() == frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    MessageBox.Show("Ya le pertenece este medicamento.");
                                    existe = true;
                                    break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                                }
                            }
                            // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:

                        }
                        if (existe == false)
                        {
                            tabla_med.Rows.Add(frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                            frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString()+": "+
                            frmCargo.dataGridView1.CurrentRow.Cells[4].Value.ToString());

                        }

                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void tabla_tel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_med, "id_alergia", "MEDICAMENTOS_VS_ALERGIAS");
        }
        MetodosCRUD metodoscrud = new MetodosCRUD();

        void AsiganarMed(int id_alergia)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int _id = 0;
                    if (tabla_med.RowCount > 0)
                    {
                        foreach (DataGridViewRow i in tabla_med.Rows)
                        {
                            _id = int.Parse(i.Cells[0].Value.ToString());
                            var res = db.MEDICAMENTOS_VS_ALERGIAS.FirstOrDefault(a => a.id_medicamento == _id && a.id_alergia == id_alergia);
                            if (res == null)
                            {
                                MessageBox.Show("ENTRO AQUI: " + _id);
                                MessageBox.Show("ENTRO AQUI: " + _id);
                                MEDICAMENTOS_VS_ALERGIAS _ALERGIAS = new MEDICAMENTOS_VS_ALERGIAS{
                                    id_medicamento = _id,
                                    id_alergia = id_alergia
                                };
                                db.MEDICAMENTOS_VS_ALERGIAS.Add(_ALERGIAS);
                            }
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ass)
            {
                //   MessageBox.Show("ERROR TEL: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
        }
        void removerFila(DataGridView tabla, string campo, string table)
        {
            try
            {
                int _id = 0;
                if (tabla.SelectedRows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Quiere remover este campo ?", "Opcion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                        return;

                    foreach (DataGridViewRow row in tabla.SelectedRows)
                    {
                        tabla.Rows.RemoveAt(row.Index);
                        _id = int.Parse(row.Cells[0].Value.ToString());
                    }
                    MessageBox.Show(": " + _id);
                }

                if (_id > 0)
                    metodoscrud.borrarVsGen(_id.ToString(), "id_medicamento", _alergia, "id_alergia", table);
            }
            catch (Exception ass)
            {

                //  MessageBox.Show("ERROR DIR: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
        }


        private void cargarTelefonos(int id_alergia)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var telefono = from telVs in db.MEDICAMENTOS_VS_ALERGIAS
                                   where id_alergia == telVs.id_alergia
                                   join tel in db.MEDICAMENTOS on telVs.id_medicamento equals tel.id_medicamento
                                   select new
                                   {
                                       id_medicamento = tel.id_medicamento,
                                       medicamento = tel.medicamento,
                                       descripcion = tel.descripcion,
                                   };

                    if (telefono != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        tabla_med.Rows.Clear();
                        foreach (var tel in telefono.ToList())
                        {
                            tabla_med.Rows.Add(
                             tel.id_medicamento.ToString(),
                             tel.medicamento.ToString()+": "+
                             tel.descripcion.ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
