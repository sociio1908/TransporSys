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
    public partial class FrmAdmVentas : Form
    {
        public FrmAdmVentas()
        {
            InitializeComponent();
            LlenarDataGrid();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdmVentas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PUEDE FILTRAR LA BUSQUEDA POR: NO.FACTURA, ARTICULOS, CLIENTE, EMPLEADO, FECHA, ESTADO.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarDataGrid()
        {

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var articulos =  from pro in db.VENTAS
                                    join cat in db.DETALLES_VENTAS on pro.num_fact
                            equals cat.id_detalle
                                   join articulo in db.ARTICULOS on pro.num_fact
                           equals articulo.id_articulo
                                   join cliente in db.CLIENTES on pro.id_cliente
                           equals cliente.id_tercero
                                    
                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        cat.id_detalle,
                                        pro.num_fact,
                                        articulo.nombre,
                                        cat.cantidad,
                                        cat.precio,
                                        cat.total,
                                        cat.descuento,
                                        pro.fecha,
                                        cliente.id_tercero,
                                        pro.EMPLEADOS.id_empleado,
                                        pro.estado
                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar


                    string status;
                    dataGridView1.Rows.Clear();

                    foreach (var OArticulos in articulos)
                    {
                        dataGridView1.Rows.Add(OArticulos.num_fact.ToString(), OArticulos.nombre.ToString(), OArticulos.cantidad.ToString(),
                            OArticulos.precio.ToString(), OArticulos.total.ToString(), OArticulos.descuento.ToString(), OArticulos.fecha.ToString(), OArticulos.id_tercero.ToString(), OArticulos.id_empleado.ToString(), status = OArticulos.estado == true ? "ACTIVO" : "INACTIVO");
                    }

                }
                catch (Exception aas)
                {
                    //Posible error
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    MessageBox.Show(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    var articulo = db.VENTAS.FirstOrDefault(a => a.num_fact.ToString() == dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                    // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                    if (articulo != null)
                    {

                        articulo.estado = false; //debe ser tru/false

                    }

                    db.SaveChanges();
                    Utilidades.LimpiarControles(this);
                    LlenarDataGrid();
                }
                catch (Exception) { }
            }

            MessageBox.Show("");
        }
    }
}
