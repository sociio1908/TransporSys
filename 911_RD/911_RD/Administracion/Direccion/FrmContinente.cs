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
    public partial class FrmContinente : FrmBase
    {
        public FrmContinente()
        {
            InitializeComponent();
            cargarTabla();

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarContinente();
        }


        private void FrmContinente_Load(object sender, EventArgs e)
        {

        }



        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_continente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
               
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
                    var list = db.CONTINENTES;
                    foreach (var conti in list)
                    {
                        dataGridView1.Rows.Add(conti.id_continente.ToString(), conti.continente.ToString());
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
                        CONTINENTES cont = new CONTINENTES
                        {
                            continente = txt_continente.Text.Trim()
                        };

                        db.CONTINENTES.Add(cont);
                    }
                    else
                    {
                        var conti = db.CONTINENTES.FirstOrDefault(a => a.id_continente.ToString() == id_txt.Text.Trim());
                        if (conti != null)
                        {

                            conti.continente = txt_continente.Text.Trim();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
        }
    }
}
