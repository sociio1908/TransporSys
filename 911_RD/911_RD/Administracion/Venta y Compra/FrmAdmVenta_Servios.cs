using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Venta_y_Compra
{
    public partial class FrmAdmVenta_Servios : Form
    {
        public FrmAdmVenta_Servios()
        {
            InitializeComponent();
            LlenarDataGrid("");
        }

        private void FrmAdmVenta_Servios_Load(object sender, EventArgs e)
        {

        }


        public void LlenarDataGrid(string condicion)
        {

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var ventasD = from v in db.VENTA_SERVICIOS
                                  join dv in db.DVENTAS_SERVICIOS on v.num_fact equals dv.num_fact
                                  join s in db.SERVICIOS on dv.id_servicio equals s.id_servicio
                                  join c in db.PACIENTES on v.id_paciente equals c.id_paciente
                                  join tp in db.TIPOSPAGO on v.id_tipo_pago equals tp.id_tipoPago
                                  join nc in db.EMPLEADOS on v.id_empleado equals nc.id_empleado

                                  select new
                                  {
                                      //aqui cargas los campos de tu tabla
                                      Fact = v.num_fact,
                                      id_cliente = c.id_paciente,
                                      NomCli = c.PERSONAS.TERCEROS.nombre,
                                      nom_art = s.nombre,
                                      cant = dv.cantidad,
                                      precio = dv.precio,
                                      total = dv.total,
                                      descuento = dv.descuento,
                                      Fecha = v.fecha,
                                      idArt = dv.id_servicio,
                                      NomEmpl = nc.PERSONAS.TERCEROS.nombre,
                                      v.estado,
                                      tipoP = tp.descripcion
                                  };


                    if (condicion.Equals(""))
                    {

                    }
                    else
                    {
                        ventasD = ventasD.Where(a => a.Fact.ToString().Contains(condicion) || a.Fecha.ToString().Contains(condicion) || a.NomEmpl.ToString().Contains(condicion) || a.idArt.ToString().Contains(condicion));

                    }

                    foreach (var OArticulos in ventasD)
                    {
                        dataGridView1.Rows.Add(OArticulos.Fact.ToString(), OArticulos.nom_art.ToString(), OArticulos.cant.ToString(),
                            OArticulos.tipoP.ToString(), OArticulos.precio.ToString(), OArticulos.total.ToString(), OArticulos.descuento.ToString(), OArticulos.Fecha.ToString(), OArticulos.NomCli.ToString(), OArticulos.NomEmpl.ToString(), OArticulos.estado == true ? "ACTIVO" : "INACTIVO", OArticulos.idArt.ToString());
                    }

                }
                catch (Exception aas)
                {
                    //Posible error
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    var factura = db.VENTA_SERVICIOS.FirstOrDefault(a => a.num_fact.ToString() == num.ToString());
                    idT = Convert.ToInt32(factura.num_fact);

                    if (num2 == idT)
                    {

                        factura.estado = false; //debe ser tru/false
                       

                    }
                    db.SaveChanges();
                    dataGridView1.Rows.Clear();
                    LlenarDataGrid("");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
