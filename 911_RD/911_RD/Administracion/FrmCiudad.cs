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
    public partial class FrmCiudad : FrmBase
    {
        public FrmCiudad()
        {
            InitializeComponent();
            cargarTabla();
            CargarCombo();
        }


        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cb_provincia.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) - 1);
                txt_ciudad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception ea)
            {
                //
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
                    var list = db.CIUDADES;
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.id_ciudad.ToString(), conti.id_provincia.ToString(), conti.ciudad.ToString(), conti.PROVINCIAS.provincia.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }


        private void InsertarCiudad()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int id_cont = cb_provincia.SelectedIndex + 1;
                    if (id_txt.Text.Trim() == "")
                    {
                        CIUDADES pais = new CIUDADES
                        {
                            ciudad = txt_ciudad.Text.Trim(),
                            id_provincia = id_cont,
                        };
                        db.CIUDADES.Add(pais);
                    }
                    else
                    {
                        var paises = db.CIUDADES.FirstOrDefault(a => a.id_provincia.ToString() == id_txt.Text.Trim());
                        if (paises != null)
                        {
                            paises.ciudad = txt_ciudad.Text.Trim();
                            paises.id_provincia = id_cont;
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


        void CargarCombo()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var listS = db.PROVINCIAS;
                    foreach (var cont in listS)
                    {
                        cb_provincia.Items.Add(cont.provincia.ToUpper());
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarCiudad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0)
                CargarCampos();
        }
    }
}
