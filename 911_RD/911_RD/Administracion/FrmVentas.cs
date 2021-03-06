using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            int nf = Convert.ToInt32(txt_numfactura.Text.Trim());
            int q = nf + 6;
            txt_numfactura.Text = q.ToString();
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


        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private void txt_codBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_traer_Click(object sender, EventArgs e)
        {

            using (FrmArticulos frmarticulos = new FrmArticulos())
            {
                DialogResult dr = frmarticulos.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txt_id.Text = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txt_nombre.Text = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_des.Text = frmarticulos.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_stock.Text = frmarticulos.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txt_precio.Text = frmarticulos.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txt_codBarra.Text = frmarticulos.dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    codigo_de_barra();
                }
            }
        }

        private void codigo_de_barra()
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            pnl_cod.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txt_codBarra.Text, Color.Black, Color.White, 237, 70);

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
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

        private void btn_3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            txt_cantidad.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (txt_cantidad.Text == "0")
            {
                MessageBox.Show("LA CANTIDAD DEL PRODUCTO NO PUEDE SER 0");
            }
            else
            {
                int a = Convert.ToInt32(txt_stock.Text);
                int b = Convert.ToInt32(txt_cantidad.Text);
                if (b > a)
                {
                    MessageBox.Show("LA CANTIDAD A VENDER NO PUEDE SER MAYOR A LA DISPONIBLE");
                }
                else
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = txt_id.Text.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = txt_nombre.Text;
                    dataGridView1.Rows[n].Cells[2].Value = txt_cantidad.Text.ToString();
                    dataGridView1.Rows[n].Cells[3].Value = txt_precio.Text.ToString();
                    dataGridView1.Rows[n].Cells[4].Value = txt_descuento.Text.ToString();
                    txt_id.Text = "";
                    txt_nombre.Text = "";
                    txt_cantidad.Text = "0";
                    txt_precio.Text = "";
                    //txt_descuento.Text = "";
                    txt_stock.Text = "";
                    txt_des.Text = "";
                    txt_codBarra.Text = "";


                    SumarFilas();
                }
            }

        }

        private void SumarFilas()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double a = 0, b = 0, impTotal = 0, total = 0, subtotal = 0, itb = 0.18, itbTotal = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    a = Convert.ToDouble(row.Cells["cantidad"].Value);
                    b = Convert.ToDouble(row.Cells["precio"].Value);
                    total = a * b;
                    row.Cells["total"].Value = total.ToString();
                    subtotal += Convert.ToDouble(row.Cells["total"].Value);
                    itbTotal += total * itb;
                    impTotal = subtotal + itbTotal;

                }
                txt_subtotal.Text = subtotal.ToString();
                txt_impuesto.Text = itbTotal.ToString();
                txt_impTotal.Text = impTotal.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarFact();
            InsertarDetalle();
            ActualizarStock();
            dataGridView1.Rows.Clear();
        }



        private void CargarFact()
        {
            using (TransporSysEntities4 db = new TransporSysEntities4())
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    VENTAS vent = new VENTAS
                    {
                        //ningun campo vacio
                        num_fact = Convert.ToInt32(txt_numfactura.Text.Trim()),
                        id_cliente = 1,
                        id_empleado = 1,
                        fecha = DateTime.Now,
                        estado = true,
                    };
                    db.VENTAS.Add(vent);
                    db.SaveChanges();
                }

                MessageBox.Show("");
            }


        }

        private void InsertarDetalle()
        {
            using (TransporSysEntities4 db = new TransporSysEntities4())
            {
                if (dataGridView1.Rows.Count > 0)
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        DETALLES_VENTAS Dvent = new DETALLES_VENTAS
                        {

                            num_fact = Convert.ToInt32(txt_numfactura.Text.Trim()),
                            id_articulo = Convert.ToInt32(row.Cells[0].Value.ToString()),
                            cantidad = Convert.ToDouble(row.Cells[2].Value.ToString()),
                            precio = Convert.ToDouble(row.Cells[3].Value.ToString()),
                            itbis = Convert.ToDouble(txt_impuesto.Text.Trim()),
                            descuento = 0,
                            total = Convert.ToDouble(txt_impTotal.Text.Trim())
                        };
                        db.DETALLES_VENTAS.Add(Dvent);

                    }
                    db.SaveChanges();
                }

                MessageBox.Show("");
            }


        }

        private void ActualizarStock()
        {
            using (var db = new TransporSysEntities4())
            {

                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    int a = Convert.ToInt32(row.Cells["id_articulos"].Value.ToString());
                    int c = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                    
                    var result = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                    var stockactual = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                    int d = Convert.ToInt32(stockactual.reorden.ToString());
                    double actstock = d-c;
                    if (result != null)
                    {
                        result.reorden = actstock;
                        db.SaveChanges();
                    }
                }
                
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            SumarFilas();
        }
    }
}
