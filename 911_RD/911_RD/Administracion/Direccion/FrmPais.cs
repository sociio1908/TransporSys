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
    public partial class FrmPais : FrmBase
    {
        public FrmPais()
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
                cb_continente.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) - 1);
                txt_pais.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
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
                    var list = db.PAISES;
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.id_pais.ToString(), conti.id_continente.ToString(), conti.pais.ToString(), conti.CONTINENTES.continente.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }


        private void InsertarPais()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int id_cont = cb_continente.SelectedIndex + 1;
                    if (id_txt.Text.Trim() == "")
                    {
                        PAISES pais = new PAISES
                        {
                            pais = txt_pais.Text.Trim(),
                            id_continente = id_cont,
                        };
                        db.PAISES.Add(pais);
                    }
                    else
                    {
                        var paises = db.PAISES.FirstOrDefault(a => a.id_continente.ToString() == id_txt.Text.Trim());
                        if (paises != null)
                        {
                            paises.pais = txt_pais.Text.Trim();
                            paises.id_continente = id_cont;
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

                    var listS = db.CONTINENTES;
                    foreach (var cont in listS)
                    {
                        cb_continente.Items.Add(cont.continente.ToUpper());
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarPais();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
        }
    }
}
