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
    public partial class FrmProvincia : FrmBase
    {
        public FrmProvincia()
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
                cb_pais.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) - 1);
                txt_provincia.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                    var list = db.PROVINCIAS;
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.id_provincia.ToString(), conti.id_pais.ToString(), conti.provincia.ToString(), conti.PAISES.pais.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }


        private void InsertarProivincia()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int id_cont = cb_pais.SelectedIndex + 1;
                    if (id_txt.Text.Trim() == "")
                    {
                        PROVINCIAS pais = new PROVINCIAS
                        {
                            provincia = txt_provincia.Text.Trim(),
                            id_pais = id_cont,
                        };
                        db.PROVINCIAS.Add(pais);
                    }
                    else
                    {
                        var paises = db.PROVINCIAS.FirstOrDefault(a => a.id_provincia.ToString() == id_txt.Text.Trim());
                        if (paises != null)
                        {
                            paises.provincia = txt_provincia.Text.Trim();
                            paises.id_pais = id_cont;
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

                    var listS = db.PAISES;
                    foreach (var cont in listS)
                    {
                        cb_pais.Items.Add(cont.pais.ToUpper());
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarProivincia();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>0)
            CargarCampos();
        }
    }
}
