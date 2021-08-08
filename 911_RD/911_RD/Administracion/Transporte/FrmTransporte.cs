using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Transporte
{
    public partial class FrmTransporte : Form
    {
        public FrmTransporte()
        {
            InitializeComponent();

            Carga();
        }


        void Carga()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                var direcciones = db.DIRECCIONES.FirstOrDefault(a => a.id_ciudad > 0);

            }
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_desde.Text.Trim(), dataGridView1);
        }

        private void cargarTabla(string condicion, DataGridView dataGrid)
        {

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var direcciones = from dir in db.DIRECCIONES
                                      join ciu in db.CIUDADES on dir.id_ciudad equals ciu.id_ciudad
                                      join provi in db.PROVINCIAS on ciu.id_provincia equals provi.id_provincia
                                      join pai in db.PAISES on provi.id_pais equals pai.id_pais
                                      select new
                                      {
                                          id_direccion = dir.id_direccion,
                                          descripcion = dir.descripcion,
                                          ciudad = ciu.ciudad,
                                          pais = pai.pais,
                                      };

                    if (condicion.Equals("") == false)
                    {
                        direcciones = direcciones.Where(di => di.descripcion.ToString().Contains(condicion) || di.ciudad.Contains(condicion));
                    }
                    if (direcciones != null && condicion.Equals("") == false)
                    {
                        //    MessageBox.Show("ENTRO");
                        dataGrid.Rows.Clear();
                        dataGrid.Visible = true;
                        dataGrid.Rows.Add("", "", "", "");
                        foreach (var dire in direcciones.ToList())
                        {
                            dataGrid.Rows.Add(
                             dire.id_direccion.ToString(),
                             dire.descripcion.ToString(),
                             dire.ciudad.ToString(),
                             dire.pais.ToString()
                            );
                        }
                    }
                    else
                    {
                        dataGrid.Visible = false;
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_hasta_TextChanged(object sender, EventArgs e)
        {

            cargarTabla(txt_hasta.Text.Trim(), dataGridView2);
        }

        private void btn_Cargo_Click(object sender, EventArgs e)
        {
            FrmDireccionNativa direcciones = new FrmDireccionNativa();
            direcciones.ShowDialog();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
        }

        void CargarCampos(DataGridView dataGrid, string txt)
        {
            try
            {
                if (txt == "Desde")
                {
                    txt_id_desde.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    txt_desde.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[2].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                }
                else
                {

                    txt_id_hasta.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    txt_hasta.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[2].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && dataGridView1.SelectedRows.Count > 0)
                CargarCampos(dataGridView2, "Hasta");
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && dataGridView1.SelectedRows.Count > 0)
                CargarCampos(dataGridView1, "Desde");
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) || (txt_id_desde.Text.Trim().Equals(txt_id_hasta.Text.Trim())))
            {
                MessageBox.Show("Seleccione la direccion y no pueden ser la misma en caso de ida y vuelta.");

                return;

            }


        }
    }
}
