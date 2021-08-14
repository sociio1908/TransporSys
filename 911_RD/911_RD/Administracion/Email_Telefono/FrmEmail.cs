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
    public partial class FrmEmail : FrmBase
    {
        public FrmEmail()
        {
            InitializeComponent();
            cargarTabla("");
            txt_email.Focus();
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
                txt_email.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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
                    var list = from mail in db.EMAILS
                               select new
                               {
                                   id_email = mail.id_email,
                                   email= mail.email
                               };

                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.email.Contains(condicion) || a.id_email.ToString().Contains(condicion));
                    }

                    if (list!=null)
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_email.ToString(), OPuestos.email.ToString());
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
                        EMAILS puesto = new EMAILS
                        {
                            email = txt_email.Text.Trim().ToLower(),
                        };

                        db.EMAILS.Add(puesto);
                    }
                    else
                    {
                        var mail = db.EMAILS.FirstOrDefault(a => a.id_email.ToString() == id_txt.Text.Trim());
                        if (mail != null)
                        {
                            mail.email = txt_email.Text.Trim();
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
    }
}
