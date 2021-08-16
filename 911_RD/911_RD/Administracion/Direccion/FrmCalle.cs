using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Direccion
{
    public partial class FrmCalle : FrmBase
    {
        public FrmCalle()
        {
            InitializeComponent();
            cargarTabla("");
        }

        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_calle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

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
                    var direcciones = from ca in db.CALLES
                                     select new
                                      {
                                         id_calle = ca.id_calle,
                                         nombre = ca.nombre,
                                       };

                    if (condicion.Equals("") == false)
                    {
                        direcciones = direcciones.Where(di => di.nombre.ToString().Contains(condicion) || di.id_calle.ToString().Contains(condicion));
                    }
                    if (direcciones != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        dataGridView1.Rows.Clear();

                        dataGridView1.Rows.Add("", "", "", "");
                        foreach (var dire in direcciones.ToList())
                        {
                            dataGridView1.Rows.Add(
                             dire.id_calle.ToString(),
                             dire.nombre.ToString()
                            );
                        }
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }


        private void InsertarContinente()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        CALLES cont = new CALLES
                        {
                            nombre = txt_calle.Text.Trim()
                        };

                        db.CALLES.Add(cont);
                    }
                    else
                    {
                        var conti = db.CALLES.FirstOrDefault(a => a.id_calle.ToString() == id_txt.Text.Trim());
                        if (conti != null)
                        {

                            conti.nombre = txt_calle.Text.Trim();
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            CargarCampos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarContinente();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
