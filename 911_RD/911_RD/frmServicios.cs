using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion;
using _911_RD.Administracion.Servicios;

namespace _911_RD
{
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
            cargarComboxs();

        }

        private void agregarNumero(string numero)
        {
            //var boton = ((Button)sender);
            if (txt_cantidad.Text == "0")
            {
                txt_cantidad.Text = "";
            }
            txt_cantidad.Text += numero;
        }

        void cargarComboxs()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var listS = db.TIPOSPAGO.Where(a => a.estado == true);
                    cb_tipoPago.Items.Clear();
                    foreach (var sEXOS in listS)
                    {
                        cb_tipoPago.Items.Add(sEXOS.descripcion.ToUpper());
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }


        void Paciente()
        {

            try
            {
                using (FrmPaciente frmCargo = new FrmPaciente())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_cliente.Text = frmCargo.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        txt_nombre_cliente.Text = frmCargo.dataGridView1.CurrentRow.Cells[5].Value.ToString() + " " + frmCargo.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        txt_old.Text = Utilidades.CalcularEdad(Convert.ToDateTime(frmCargo.dataGridView1.CurrentRow.Cells[7].Value.ToString())).ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

        }

        private void bt_agregar_cont_Click(object sender, EventArgs e)
        {
            Paciente();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmServicios_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Paciente();
        }

        private void txt_nombre_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descuentoEmple_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_cliente_TextChanged(object sender, EventArgs e)
        {

        }



        void calTotalFila()
        {
            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    double pre = double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    double cant = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    dataGridView1.Rows[i].Cells[7].Value = (pre * cant).ToString();
                }
                double actual = 0, res = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    actual = double.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                    res = res + actual;
                }

                txt_impTotal.Text = res.ToString();
                txt_subtotal.Text = res.ToString();
            }
            catch (Exception fdj)
            {

            }
        }

        private void btn_traer_Click(object sender, EventArgs e)
        {
            try
            {

                using (FrmServicios frmArt = new FrmServicios())
                {
                    DialogResult dr = frmArt.ShowDialog();
                    if (dr == DialogResult.OK)
                    {

                        bool existe = false;
                        if (dataGridView1.RowCount > 0)
                        {
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                if (dataGridView1.Rows[i].Cells[2].Value.ToString() == frmArt.dataGridView1.CurrentRow.Cells[2].Value.ToString())
                                {
                                    existe = true;
                                    int res = (int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString()) + 1);
                                    dataGridView1.Rows[i].Cells[4].Value = res.ToString();
                                }
                                // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                            }
                        }
                        if (existe == false)
                        {
                            dataGridView1.Rows.Add(
                                frmArt.dataGridView1.CurrentRow.Cells[0].Value.ToString(), //CAT
                                frmArt.dataGridView1.CurrentRow.Cells[1].Value.ToString(), //UND
                                frmArt.dataGridView1.CurrentRow.Cells[2].Value.ToString(), // ID
                                frmArt.dataGridView1.CurrentRow.Cells[3].Value.ToString(), //SER
                                "1", //CANT
                                frmArt.dataGridView1.CurrentRow.Cells[6].Value.ToString(), //PRE
                                "0", //DESC
                                frmArt.dataGridView1.CurrentRow.Cells[6].Value.ToString()  //TOTAL
                                );
                        }
                    }

                }

            }
            catch (Exception asf)
            {


            }

        }



        private void SumarFilas()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double a = 0, b = 0, c = 0, d = 0, f = 0, impTotal = 0, multotal = 0,
                    subtotal = 0, itb = 0, itbTotal = 0, desTotal = 0, restotal = 0, total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    a = Convert.ToDouble(row.Cells["cantidad"].Value);
                    b = Convert.ToDouble(row.Cells["precio"].Value);
                    c = Convert.ToDouble(row.Cells["descuento"].Value);
                    f = Convert.ToDouble(row.Cells["itbis"].Value);
                    d = c / 100;
                    double itbPor = f / 100;
                    double itb_pre = b * itbPor;
                    double precioTotal = b + itb_pre;
                    multotal = a * precioTotal;
                    restotal = multotal * d;
                    total = multotal - restotal;
                    row.Cells["total"].Value = total.ToString();
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                    double z = f / 100;
                    double imp = 0;
                    imp += z;
                    itbTotal += total * imp;
                    impTotal = subtotal;
                    desTotal = desTotal + restotal;
                }
                txt_subtotal.Text = subtotal.ToString();
                txt_impuesto.Text = itbTotal.ToString();
                txt_impTotal.Text = impTotal.ToString();
                txt_descuento.Text = desTotal.ToString();
            }
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_unidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_0.Text);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_7.Text);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_8.Text);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_9.Text);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_6.Text);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_5.Text);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_4.Text);
        }


        private void btn_3_Click_1(object sender, EventArgs e)
        {
            agregarNumero(btn_3.Text);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {

            agregarNumero(btn_2.Text);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            agregarNumero(btn_1.Text);
        }

        private void btn_limpiar_cantidad_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidades.ValidarFormulario(this, errorProvider1);
                if (txt_cantidad.Text == "0" || txt_id.Text == "")
                {
                    MessageBox.Show("NO HAY PRODUCTO SLECCIONADO / LA CANTIDAD DEL PRODUCTO NO PUEDE SER 0.");
                }
                else
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        // Primero averigua si el registro existe:
                        bool existe = false;
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {

                            txt_id.Text = "";
                            txt_servicio.Text = "";
                            txt_des.Text = "";
                            txt_precio.Text = "";
                            txt_unidad.Text = "";



                            SumarFilas();
                        }
                    }


                }

            }
            catch (Exception assd)
            {


            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calTotalFila();
        }

        private void btn_cambiarCant_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;

            if (dataGridView1.SelectedRows[0].Cells[1].Value.ToString() != "" || dataGridView1.SelectedRows[0].Cells[1].Value.ToString() != null)
            {
                if (int.Parse(txt_cantidad.Text.Trim()) > 0)
                {
                    dataGridView1.SelectedRows[0].Cells[4].Value = "";
                    dataGridView1.SelectedRows[0].Cells[4].Value = txt_cantidad.Text.ToString();
                    txt_cantidad.Text = "0";
                }
                else
                {
                    MessageBox.Show("ERROR, FAVOR INGRESE CANTIDAD MAYOR A CERO (0).");
                }
            }
            else
            {
                MessageBox.Show("ERROR, FAVOR SELECCIONE UNA FILA VALIDA.");
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            DialogResult dialogResult = MessageBox.Show("Seguro que quiere remover este servicio ?", "Opcion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calTotalFila();
        }



        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            calTotalFila();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {

            if (Utilidades.ValidarFormulario(this, errorProvider2) || cb_tipoPago.SelectedItem==null || dataGridView1.Rows.Count<0)
            {
                MessageBox.Show("Favor llenar los campos con el error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CrearFActura();
        }



        void CrearFActura()
        {
            try {

                if (dataGridView1.Rows.Count <= 0)
                {
                    MessageBox.Show("DEBE TENER SERVICIOS PARA ESTO.");
                    return;
                }
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    VENTA_SERVICIOS vent = new VENTA_SERVICIOS
                            {
                                //ningun campo vacio
                                id_paciente = int.Parse(txt_id_cliente.Text.Trim()),
                                id_empleado = 21,
                                 id_tipo_pago = cb_tipoPago.SelectedIndex+1,
                                  fecha = DateTime.Now,
                                  estado = true,
                            };
                            db.VENTA_SERVICIOS.Add(vent);
                            db.SaveChanges();

                    int num_fact = db.VENTA_SERVICIOS.Max(a => a.num_fact);
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                DVENTAS_SERVICIOS Dvent = new DVENTAS_SERVICIOS
                                {
                                    id_servicio = int.Parse(row.Cells[2].Value.ToString()),
                                    num_fact = num_fact,
                                    cantidad = Convert.ToDouble(row.Cells[4].Value.ToString()),
                                    precio = Convert.ToDouble(row.Cells[5].Value.ToString()),
                                    itbis = Convert.ToDouble("0"),
                                    descuento = Convert.ToDouble("0"),
                                    total = Convert.ToDouble(txt_impTotal.Text.Trim())
                                };
                                db.DVENTAS_SERVICIOS.Add(Dvent);
                            }
                            db.SaveChanges();

                    Utilidades.LimpiarControles(this);
                    dataGridView1.Rows.Clear();


                }

            }catch(Exception sadjfh)
            {

            }
            
      }


    }
}
