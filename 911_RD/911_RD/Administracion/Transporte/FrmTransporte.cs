using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion.Vehiculo;

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
                                      join ca in db.CALLES on dir.id_calle equals ca.id_calle
                                      join provi in db.PROVINCIAS on ciu.id_provincia equals provi.id_provincia
                                      join pai in db.PAISES on provi.id_pais equals pai.id_pais
                                      select new
                                      {
                                          id_direccion = dir.id_direccion,
                                          descripcion = dir.referencia,
                                          ciudad = ciu.ciudad,
                                          calle = ca.nombre,
                                          pais = pai.pais,
                                      };

                    if (condicion.Equals("") == false)
                    {
                        direcciones = direcciones.Where(di => di.descripcion.ToString().Contains(condicion) || di.calle.ToString().Contains(condicion) || di.ciudad.Contains(condicion));
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
                             dire.calle.ToString(),
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

   

        private void btn_Cargo_Click(object sender, EventArgs e)
        {
            FrmDireccionNativa direcciones = new FrmDireccionNativa();
            direcciones.ShowDialog();
            dataGridView1.Rows.Clear();
        }

        void CargarCampos(DataGridView dataGrid, string txt)
        {
            try
            {
                if (txt_id_desde.Text=="")
                {
                    txt_id_desde.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    txt_desde.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[2].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                    txt_desde.Text = "";
                }
                else if (txt_id_hasta.Text == "" && txt_id_desde.Text != "" && (txt_id_desde.Text != dataGrid.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    txt_id_hasta.Text = dataGrid.SelectedRows[0].Cells[0].Value.ToString();
                    txt_desde.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[2].Value.ToString() + ", " +
                    dataGrid.SelectedRows[0].Cells[3].Value.ToString();
                    txt_desde.Text = "";
                }

            }
            catch (Exception ea)
            {
                //
            }


        }

        

        void Fecha(DateTime fecha, DateTime hora)
        {

            DateTime fechaConvertida = fecha.AddHours(hora.Hour).AddMinutes(hora.Minute).AddSeconds(hora.Second);


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
            if (Utilidades.ValidarFormulario(this, errorProvider1))
            {
                MessageBox.Show("Seleccione la direccion.");
                return;
            }

            this.DialogResult = DialogResult.OK;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(fecha_tra.Value.ToString());
        }

        private void btn_und_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmEmpleado frmCargo = new FrmEmpleado())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_emp.Text = frmCargo.id_conductor;
                        txt_emp.Text = frmCargo.txt_nombre.Text;
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmVehiculos frmCargo = new FrmVehiculos())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_vehiculo.Text = frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }
    }
}
