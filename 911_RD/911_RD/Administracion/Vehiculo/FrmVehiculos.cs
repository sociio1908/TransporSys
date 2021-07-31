using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace _911_RD.Administracion.Vehiculo
{
    public partial class FrmVehiculos : _911_RD.Administracion.FrmBase
    {
        public FrmVehiculos()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmMarca frmMarca = new FrmMarca())
                {
                    DialogResult dr = frmMarca.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_marca.Text = frmMarca.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_marca.Text = frmMarca.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                   
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmModelo frmModelo = new FrmModelo())
                {
                    DialogResult dr = frmModelo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_modelo.Text = frmModelo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_modelo.Text = frmModelo.dataGridView1.CurrentRow.Cells[1].Value.ToString();

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
                using (FrmCombustible frmombustible = new FrmCombustible())
                {
                    DialogResult dr = frmombustible.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_combustible.Text = frmombustible.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_combustible.Text = frmombustible.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        MetodosCRUD metodosCRUD = new MetodosCRUD();
        private void txt_num_chasis_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txt_num_placa_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
                        VEHICULO model = new VEHICULO
                        {
                            id_marca = int.Parse(txt_id_marca.Text.Trim()),
                            id_modelo = int.Parse(txt_id_modelo.Text.Trim()),
                            num_chasis = txt_num_chasis.Text.Trim(),
                            fecha_ingreso = fecha_ingreso.Value,
                            ano_fabricacion = fecha_fabricacion.Value,
                            gasto_galon_combustible_kilometro = Double.Parse(txt_gasto_combustible.Text.Trim()),
                            id_combustible = int.Parse(txt_id_combustible.Text.Trim()),
                            num_gps = txt_num_gps.Text.Trim(),
                            num_placa = txt_num_placa.Text.Trim(),
                            estado=true
                        };

                        db.VEHICULO.Add(model);

                    }
                    else
                    {
                        var mod = db.VEHICULO.FirstOrDefault(a => a.id_vehiculo.ToString() == id_txt.Text.Trim());
                        if (mod != null)
                        {
                            mod.id_marca = int.Parse(txt_id_marca.Text.Trim());
                            mod.id_modelo = int.Parse(txt_id_modelo.Text.Trim());
                            mod.num_chasis = txt_num_chasis.Text.Trim();
                            mod.fecha_ingreso = fecha_ingreso.Value;
                            mod.ano_fabricacion = fecha_fabricacion.Value;
                            mod.gasto_galon_combustible_kilometro = Double.Parse(txt_gasto_combustible.Text.Trim());
                            mod.id_combustible = int.Parse(txt_id_combustible.Text.Trim());
                            mod.num_gps = txt_num_gps.Text.Trim();
                            mod.num_placa = txt_num_placa.Text.Trim();
                            mod.estado = cb_estado.SelectedIndex==0 ? true: false;
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

        private void CargarCampos()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                    txt_marca.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txt_id_marca.Text = db.MARCA.FirstOrDefault(a => a.marca1.ToString() == txt_marca.Text.Trim()).id_marca.ToString();
                    
                    txt_modelo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txt_id_modelo.Text = db.MODELO.FirstOrDefault(a => a.modelo1.ToString() == txt_modelo.Text.Trim()).id_modelo.ToString();

                    txt_num_chasis.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txt_num_placa.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txt_num_gps.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    fecha_fabricacion.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());

                    txt_combustible.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    txt_id_combustible.Text = db.COMBUSTIBLE.FirstOrDefault(a => a.descripcion.ToString() == txt_combustible.Text.Trim()).id_combustible.ToString();

                    txt_gasto_combustible.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    fecha_ingreso.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
                    cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;

                }
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
                    var list = db.VEHICULO;
                    foreach (var OPuestos in list)
                    {
                            string combustible = db.COMBUSTIBLE.FirstOrDefault(a => a.id_combustible == OPuestos.id_combustible).descripcion.ToString();
                            dataGridView1.Rows.Add(OPuestos.id_vehiculo.ToString(), OPuestos.MARCA.marca1.ToString(), OPuestos.MODELO.modelo1.ToString(), OPuestos.num_chasis.ToString(),
                            OPuestos.num_placa.ToString(), OPuestos.num_gps.ToString(), OPuestos.ano_fabricacion.ToString(), combustible, OPuestos.gasto_galon_combustible_kilometro.ToString(), OPuestos.fecha_ingreso.ToString()
                           ,OPuestos.estado==true? "ACTIVO": "INACTIVO"
                        );
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                InsertarPuesto();
            }
            catch (Exception asd)
            {

            }
        }

        private void txt_num_chasis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (metodosCRUD.ValidarChasis_Placa(txt_num_chasis.Text.Trim()) && id_txt.Text.Trim() == "")
                {
                    txt_error_chasis.Visible = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    txt_error_chasis.Visible = false;
                    btn_guardar.Enabled = true;
                }

            }
            catch (Exception asd)
            {

            }

        }

        private void txt_num_placa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (metodosCRUD.ValidarChasis_Placa(txt_num_placa.Text.Trim()) && id_txt.Text.Trim()=="")
                {
                    txt_error_placa.Visible = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    txt_error_placa.Visible = false;
                    btn_guardar.Enabled = true;
                }

            }
            catch (Exception asd)
            {

            }
        }

        private void txt_num_gps_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (metodosCRUD.ValidarChasis_Placa(txt_num_gps.Text.Trim()) && id_txt.Text.Trim() == "")
                {
                    txt_error_gps.Visible = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    txt_error_gps.Visible = false;
                    btn_guardar.Enabled = true;
                }

            }
            catch (Exception asd)
            {

            }
        }

        private void fecha_fabricacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();

        }
    }
}
