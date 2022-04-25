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
                                      idArt = dv.id_articulo,
                                      NomEmpl = v.EMPLEADOS.PERSONAS.TERCEROS.nombre,
                                      v.estado,
                                  };
                    

                    if (condicion.Equals(""))
                    {

                    }
                    else
                    {
                        ventasD = ventasD.Where(a => a.Identficacion.ToString().Contains(condicion) || a.Fact.ToString().Contains(condicion) || a.Fecha.ToString().Contains(condicion)|| a.NomEmpl.ToString().Contains(condicion) || a.idArt.ToString().Contains(condicion));

                    }

                    foreach (var OArticulos in ventasD)
                    {
                        dataGridView1.Rows.Add(OArticulos.Fact.ToString(), OArticulos.nom_art.ToString(), OArticulos.cant.ToString(),
                            OArticulos.precio.ToString(), OArticulos.total.ToString(), OArticulos.descuento.ToString(), OArticulos.Fecha.ToString(), OArticulos.NomCli.ToString(), OArticulos.NomEmpl.ToString(), OArticulos.estado == true ? "ACTIVO" : "INACTIVO", OArticulos.idArt.ToString());
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
            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar la venta ?", "Precaución", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;

                ActualizarStock();
            Cancelar();
            
        }

        private void Cancelar()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                int num = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numfact"].Value.ToString());
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int idT = 0, bart = 0;
                    int num2 = Convert.ToInt32(row.Cells["numfact"].Value.ToString());
                    
                    var factura = db.VENTAS.FirstOrDefault(a => a.num_fact.ToString() == num.ToString());
                    idT = Convert.ToInt32(factura.num_fact);
                    
                    if (num2 == idT)
                    {

                        factura.estado = false; //debe ser tru/false
                        ActualizarStock();

                    }
                    db.SaveChanges();
                    dataGridView1.Rows.Clear();
                    LlenarDataGrid("");
                }
            }
        }

        /*
         var factura = db.VENTAS.FirstOrDefault(a => a.num_fact.ToString() == numfact.ToString());
                        // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                        if (factura != null)
                        {
                            factura.estado = false; //debe ser tru/false
                            
                        }
         
         */



        private void ActualizarStock()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                int num = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["numfact"].Value.ToString());
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int a = Convert.ToInt32(row.Cells["id_articulos"].Value.ToString());
                    int num2 = Convert.ToInt32(row.Cells["numfact"].Value.ToString());

                    
                        int c = Convert.ToInt32(row.Cells["cantidad"].Value.ToString());
                         
                    var result = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                    int t = Convert.ToInt32(result.id_articulo.ToString());
                    
                    var stockactual = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == a);
                    
                    int d = Convert.ToInt32(stockactual.reorden.ToString());
                    
                    

                    double actstock = d + c;
                    
                    if (result != null)
                    {
                        if(a==t && num == num2)
                        {
                            result.reorden = actstock;
                            db.SaveChanges();
                        }
                            
                    }
                 }
               
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LlenarDataGrid(txt_filtro.Text.Trim());
        }
    }
}
