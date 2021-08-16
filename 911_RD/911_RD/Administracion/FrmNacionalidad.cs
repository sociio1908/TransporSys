using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion.Direccion;

namespace _911_RD.Administracion
{
    public partial class FrmNacionalidad : FrmBase
    {
        public FrmNacionalidad()
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
                txt_nacionalidad.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cb_pais.SelectedIndex = cb_pais.FindString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
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
                    var list = db.NACIONALIDADES;
                    dataGridView1.Rows.Add("", "", "", "");
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.id_nacionalidad.ToString(), conti.id_pais.ToString(), conti.nacionalidad.ToString(), 
                            db.PAISES.FirstOrDefault(a=>a.id_pais==conti.id_pais).pais);
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
                    int id_pais=0;

                    var pa = db.PAISES.FirstOrDefault(a => a.pais.ToString() == cb_pais.SelectedItem.ToString().Trim());
                    id_pais = pa.id_pais;
                    if (id_txt.Text.Trim() == "")
                    {
                        NACIONALIDADES pais = new NACIONALIDADES
                        {
                            nacionalidad = txt_nacionalidad.Text.Trim(),
                            id_pais = id_pais,
                        };
                        db.NACIONALIDADES.Add(pais);
                    }
                    else
                    {
                        var paises = db.NACIONALIDADES.FirstOrDefault(a => a.id_nacionalidad.ToString() == id_txt.Text.Trim());
                        if (paises != null)
                        {
                            paises.nacionalidad = txt_nacionalidad.Text.Trim();
                            paises.id_pais = id_pais;
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarProivincia();
        }

        private void bt_agregar_pais_Click(object sender, EventArgs e)
        {
            FrmPais fm = new FrmPais();
            fm.ShowDialog();
            cargarTabla();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>0)
            CargarCampos();

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
        }
    }
}
