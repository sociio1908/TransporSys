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

namespace _911_RD
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
         
        }


 


        private void btn_suplidor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSuplidor frmcliente = new FrmSuplidor())
                {
                    DialogResult dr = frmcliente.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_suplidor.Text = frmcliente.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        txt_nombre_suplidor.Text = frmcliente.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_traer_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmArticulos frmarticulos = new FrmArticulos())
                {
                    DialogResult dr = frmarticulos.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id.Text = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_nombre.Text = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txt_precio.Text = frmarticulos.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        txt_stock.Text = frmarticulos.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception asdd)
            {

            }
        }

        private void LimpiarProductos()
        {
            txt_id.Text = ""; 
            txt_nombre.Text = "";
            txt_stock.Text = "";
            txt_cant_pedir.Text = "";
            txt_costo.Text = "";
            txt_precio.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {

                if (Utilidades.ValidarFormulario(this, errorProvider1) || txt_cant_pedir.Text.Trim() == "" || txt_costo.Text.Trim() == "")
                    return;

                bool existe = false;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int bart = 0, idT = 0;
                    bart = int.Parse(dataGridView1.Rows[i].Cells["id_articulos"].Value.ToString());
                    idT = int.Parse(txt_id.Text.Trim());

                    if (bart == idT)
                    {
                        int q = 0, w = 0, suma = 0;
                        q = Convert.ToInt32(dataGridView1.Rows[i].Cells["cantidad"].Value);
                        w = Convert.ToInt32(txt_cant_pedir.Text.Trim());
                        suma = q + w;
                        dataGridView1.Rows[i].Cells["cantidad"].Value = suma;
                        SumarFilas();
                        existe = true;
                        break;
                    }
                }

                // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:
                if (existe == false)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = txt_id.Text.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = txt_nombre.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txt_cant_pedir.Text.ToString();
                    dataGridView1.Rows[n].Cells[3].Value = txt_costo.Text.ToString();
                    dataGridView1.Rows[n].Cells[4].Value = (double.Parse(txt_costo.Text.Trim()) * double.Parse(txt_cant_pedir.Text.Trim())).ToString();
                    SumarFilas();
                }

                LimpiarProductos();
            }catch(Exception dfkj)
            {

            }
            
            }

        private void SumarFilas()
        {
        
            if (dataGridView1.Rows.Count > 0)
            {
                double a = 0, b = 0, c = 0, d = 0, f = 0, impTotal = 0, multotal = 0,
                    subtotal = 0, itbTotal = 0, desTotal = 0, restotal = 0, total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    a = Convert.ToDouble(row.Cells["cantidad"].Value);
                    b = Convert.ToDouble(row.Cells["precio"].Value);
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
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
                return;
            }

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            SumarFilas();
            if (dataGridView1.Rows.Count == 0)
            {
                txt_subtotal.Text = "0.0";
                txt_impuesto.Text = "0.0";
                txt_impTotal.Text = "0.0";
            }

        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            if (txt_id_suplidor.Text == "")
            {
                MessageBox.Show("SELECCIONE UN SUPLIDOR.");
                return;
            }

            if (Utilidades.ValidarFormulario(this, errorProvider1) || dataGridView1.Rows.Count<1 )
                return;

            CrearPedido();
            InsertarDetalle();
            LimpiarTOdo();
            MessageBox.Show("PEDIDO REALIZADO CON EXITO.");
        }

        private void CrearPedido()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                    try
                    {
                    PEDIDOS comp = new PEDIDOS
                    {
                        id_suplidor = int.Parse(txt_id_suplidor.Text),
                        total = double.Parse(txt_impTotal.Text.Trim()),
                        creado = DateTime.Now,
                        estado = 0,
                        };
                        db.PEDIDOS.Add(comp);
                        db.SaveChanges();
                }
                    catch (Exception) { }
                }

        }



        int numP = 0;
        private void InsertarDetalle()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                numP = db.PEDIDOS.Max(j => j.num_pedido);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                        DETALLES_PEDIDOS Dpedido = new DETALLES_PEDIDOS
                            {
                                num_pedido = numP,
                                id_articulo = int.Parse(row.Cells[0].Value.ToString()),
                                cantidad = double.Parse(row.Cells[2].Value.ToString()),
                                precio = double.Parse(row.Cells[3].Value.ToString()),
                            };
                            db.DETALLES_PEDIDOS.Add(Dpedido);
                        }
                        db.SaveChanges();
                }
            }


        void LimpiarTOdo()
        {
            txt_subtotal.Text = "0.0";
            txt_impuesto.Text = "0.0";
            txt_impTotal.Text = "0.0";
            txt_id_suplidor.Text = "";
            txt_nombre_suplidor.Text = "";
            LimpiarProductos();
            dataGridView1.Rows.Clear();
        }

    }
}
