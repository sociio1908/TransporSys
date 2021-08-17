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
            LlenarDataGrid("");
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

        public void LlenarDataGrid(string condicion)
        {

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var ventasD = from v in db.VENTAS
                                    join dv in db.DETALLES_VENTAS on v.num_fact equals dv.num_fact
                                    join a in db.ARTICULOS on dv.id_articulo equals a.id_articulo
                                    join c in db.CLIENTES on v.id_cliente equals c.id_cliente
                                    join t in db.TERCEROS on c.id_tercero equals t.id_tercero
                                    join tVs in db.TERCEROS_VS_IDENTIFICACIONES on t.id_tercero equals tVs.id_tercero
                                    join ide in db.IDENTIFICACIONES on tVs.id_identificacion equals ide.id_identificacion
                                    
                                    
                                  select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        Fact = v.num_fact,
                                        id_cliente = c.id_cliente,
                                        NomCli = t.nombre,
                                        Identficacion = ide.identificacion,
                                        nom_art = a.nombre,
                                        cant = dv.cantidad,
                                        precio = dv.precio,
                                        total = dv.total,
                                        descuento = dv.descuento,
                                        Fecha = v.fecha,
                                     //   cliente.id_tercero,
                                        NomEmpl = v.id_empleado,
                                        v.estado,
                                    };
                    dataGridView1.Rows.Clear();

                    if (ventasD != null)
                        ventasD = ventasD.Where(a => a.Identficacion.ToString().Contains(condicion) || a.Fact.ToString().Contains(condicion) || a.Fecha.ToString().Contains(condicion)  );

                    foreach (var OArticulos in ventasD)
                    {
                        dataGridView1.Rows.Add(OArticulos.Fact.ToString(), OArticulos.nom_art.ToString(), OArticulos.cant.ToString(),
                            OArticulos.precio.ToString(), OArticulos.total.ToString(), OArticulos.descuento.ToString(), OArticulos.Fecha.ToString(), OArticulos.NomCli.ToString(), OArticulos.NomEmpl.ToString(), OArticulos.estado == true ? "ACTIVO" : "INACTIVO");
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
                    LlenarDataGrid("");
                }
                catch (Exception) { }
            }

            MessageBox.Show("");
        }
    }
}
