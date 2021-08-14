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
    public partial class FrmTelefono : FrmBase
    {
        public FrmTelefono()
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
                txt_id_tipo_tel.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_tipo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_telefono.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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
                    var list = from mail in db.TELEFONOS
                               select new
                               {
                                   id_telefono = mail.id_telefono,
                                   id_tipo_telefono = mail.id_tipo_telefono,
                                   telefono = mail.telefono
                               };

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.telefono.Contains(condicion) || a.id_telefono.ToString().Contains(condicion));
                    }

                    if (list != null)
                        foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_telefono.ToString(), OPuestos.id_tipo_telefono.ToString(), db.TIPOS_TELEFONOS.FirstOrDefault(a=> a.id_tipo_telefono == OPuestos.id_tipo_telefono).tipo_telefono, OPuestos.telefono.ToString());
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
                        TELEFONOS puesto = new TELEFONOS
                        {
                            id_tipo_telefono = int.Parse(txt_id_tipo_tel.Text.Trim()),
                            telefono = txt_telefono.Text.Trim(),
                        };

                        db.TELEFONOS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.TELEFONOS.FirstOrDefault(a => a.id_telefono.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.id_tipo_telefono = int.Parse(txt_id_tipo_tel.Text.Trim());
                            mail.telefono = txt_telefono.Text.Trim();
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

        private void btn_tipo_tel_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmTipoTelefono frmCargo = new FrmTipoTelefono())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_tipo_tel.Text = frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
            if(dataGridView1.RowCount>0)
            cargarTabla(txt_filtro.Text.Trim());
        }
    }
}
