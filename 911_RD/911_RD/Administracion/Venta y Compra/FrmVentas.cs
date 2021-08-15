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
           // nofactura();
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
            nofactura();
        }

        private void txt_codBarra_TextChanged(object sender, EventArgs e)
        {
            //LlenarDataGrid();
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
                    txt_porcentaje_itb.Text = frmarticulos.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txt_codBarra.Text = frmarticulos.dataGridView1.CurrentRow.Cells[9].Value.ToString();
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
            Utilidades.ValidarFormulario(this, errorProvider1);
            if (txt_cantidad.Text == "0" || txt_id.Text == "")
            {
                MessageBox.Show("NO HAY PRODUCTO SLECCIONADO o LA CANTIDAD DEL PRODUCTO NO PUEDE SER 0");
            }
            else
            {
                int a = Convert.ToInt32(txt_stock.Text);
                int b = Convert.ToInt32(txt_cantidad.Text);
                if (b > a)
                {
                    MessageBox.Show("LA CANTIDAD A VENDER NO PUEDE SER MAYOR A LA DISPONIBLE");
                }
                else if(dataGridView1.RowCount > 0);

                {
                    // Primero averigua si el registro existe:
                    bool existe = false;
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            int bart = 0, idT = 0;
                            bart = Convert.ToInt32(dataGridView1.Rows[i].Cells["id_articulos"].Value.ToString());
                            idT = Convert.ToInt32(txt_id.Text.Trim());

                        if (bart == idT)
                            {
                                int q = 0, w = 0, suma = 0;
                                q = Convert.ToInt32(dataGridView1.Rows[i].Cells["cantidad"].Value);
                                w = Convert.ToInt32(txt_cantidad.Text.Trim());
                                suma = q + w;
                                dataGridView1.Rows[i].Cells["cantidad"].Value = suma;
                                SumarFilas();
                                txt_id.Text = "";
                                txt_nombre.Text = "";
                                txt_cantidad.Text = "0";
                                txt_precio.Text = "";
                                txt_descuento.Text = "";
                                txt_stock.Text = "";
                                txt_des.Text = "";
                                txt_codBarra.Text = "";
                                txt_porcentaje_itb.Text = "";
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
                            dataGridView1.Rows[n].Cells[2].Value = txt_cantidad.Text.ToString();
                            dataGridView1.Rows[n].Cells[3].Value = txt_precio.Text.ToString();
                            dataGridView1.Rows[n].Cells[4].Value = txt_porcentaje_itb.Text.ToString();
                            dataGridView1.Rows[n].Cells[5].Value = txt_descuentoEmple.Text.ToString();
                            txt_id.Text = "";
                            txt_nombre.Text = "";
                            txt_cantidad.Text = "0";
                            txt_precio.Text = "";
                            txt_descuento.Text = "";
                            txt_stock.Text = "";
                            txt_des.Text = "";
                            txt_codBarra.Text = "";
                            txt_porcentaje_itb.Text = "";

                        //pnl_cod.BackgroundImage.Dispose();


                        SumarFilas();
                        }
                }
                    
                
            }

        }

        private void SumarFilas()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                double a = 0, b = 0, c = 0, d = 0, f = 0 ,impTotal = 0, multotal = 0, 
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarFact();
            InsertarDetalle();
            ActualizarStock();
            dataGridView1.Rows.Clear();
            if (dataGridView1.Rows.Count == 0)
            {
                txt_subtotal.Text = "0.0";
                txt_impuesto.Text = "0.0";
                txt_impTotal.Text = "0.0";
                txt_descuento.Text = "0.0";
            }
            nofactura();
        }



        private void CargarFact()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                if (dataGridView1.Rows.Count <= 0)
                {
                    MessageBox.Show("ESTA VACIO");
                }
                else
                {
                    try
                    {
                        VENTAS vent = new VENTAS
                        {
                            //ningun campo vacio
                            num_fact = Convert.ToInt32(txt_numfactura.Text.Trim()),
                            id_cliente = Convert.ToInt32(txt_id_cliente.Text.Trim()),
                            id_empleado = 1,
                            fecha = DateTime.Now,
                            estado = true,
                        };
                        db.VENTAS.Add(vent);
                        db.SaveChanges();
                    }
                    catch (Exception) { }
                }

                MessageBox.Show("");
            }


        }

        private void InsertarDetalle()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                if (dataGridView1.Rows.Count <= 0)
                {
                    MessageBox.Show("ESTA VACIO");
                }
                else
                {
                    try
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
                                descuento = Convert.ToDouble(txt_descuentoEmple.Text.Trim()),
                                total = Convert.ToDouble(txt_impTotal.Text.Trim())
                            };
                            db.DETALLES_VENTAS.Add(Dvent);

                        }
                        db.SaveChanges();
                    }
                    catch (Exception) { }
                }

                MessageBox.Show("");
            }


        }

        private void ActualizarStock()
        {
            using (var db = new TransporSysEntities())
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int a = Convert.ToInt32(row.Cells["id_articulos"].Value.ToString());
                        int c = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());

                        var result = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                        var stockactual = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                        int d = Convert.ToInt32(stockactual.reorden.ToString());
                        double actstock = d - c;
                        if (result != null)
                        {
                            result.reorden = actstock;
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception)
                {

                }

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("NO HAY ELEMENTOS");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                SumarFilas();
                if (dataGridView1.Rows.Count == 0)
                {
                    txt_subtotal.Text = "0.0";
                    txt_impuesto.Text = "0.0";
                    txt_impTotal.Text = "0.0";
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            SumarFilas();
        }

        public void LlenarDataGrid(string condicion = "")
        {

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var articulos = from pro in db.ARTICULOS
                                    join itb in db.ITEBIS on pro.intItebis equals itb.intItebis
                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        pro.id_articulo,
                                        pro.nombre,
                                        pro.descripcion,
                                        pro.reorden,
                                        pro.precio,
                                        itb.porcentaje,
                                        pro.codigo_barras,
                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar

                    articulos = articulos.Where(pro => (pro.codigo_barras.ToString().Contains(condicion)));


                    foreach (var OArticulos in articulos)
                    {

                        txt_id.Text = OArticulos.id_articulo.ToString();
                        txt_nombre.Text = OArticulos.nombre.ToString();
                        txt_des.Text = OArticulos.descripcion.ToString();
                        txt_stock.Text = OArticulos.reorden.ToString();
                        txt_precio.Text = OArticulos.precio.ToString();
                        txt_codBarra.Text = OArticulos.codigo_barras.ToString();
                        txt_porcentaje_itb.Text = OArticulos.porcentaje.ToString();
                    }

                }
                catch (Exception aas)
                {
                    //Posible error
                }
            }
        }

        private void txt_codBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                LlenarDataGrid(txt_codBarra.Text.Trim());
                codigo_de_barra();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmDescuentos frmunidad = new FrmDescuentos())
                {
                    DialogResult dr = frmunidad.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_descuentoEmple.Text = frmunidad.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    }
                }
            }
            catch (Exception asa)
            {

            }
        }

        private void bt_agregar_cont_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmCliente frmcliente = new FrmCliente())
                {
                    DialogResult dr = frmcliente.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_cliente.Text = frmcliente.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        txt_nombre_cliente.Text = frmcliente.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void nofactura()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                var articulo = db.VENTAS.Max(j => j.num_fact);             

                int c = Convert.ToInt32(articulo);
                int b = c + 1;
                txt_numfactura.Text = b.ToString();
       
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
