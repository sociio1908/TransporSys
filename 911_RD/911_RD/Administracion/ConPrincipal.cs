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
    public partial class ConPrincipal : Form
    {
        public ConPrincipal()
        {
            InitializeComponent();
            CargarResumen();
            cargarViajes("");
        }

        void CargarResumen()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    lbl_veha.Text = db.VEHICULO.Count(a => a.id_vehiculo > 0).ToString();
                    lbl_cli.Text = db.CLIENTES.Count(a => a.id_cliente > 0).ToString();
                    lbl_pac.Text = db.PACIENTES.Count(a => a.id_paciente > 0).ToString();
                    lbl_con.Text = db.CONDUCTOR.Count(a => a.id_conductor > 0).ToString();
                }
                catch (Exception esf)
                {

                }
            };
        }

        string estadoT(int esta )
        {
            MessageBox.Show("Entrada: " + esta);
            switch (esta)
            {
                case 0:
                    return "Creado";
                case 1:
                    return "Pospuesto";
                case 2:
                    return  "Procesado";
                case 3:
                    return  "Cancelado";
                case 4:
                    return  "Completado";
                default:
                   return "";
            }

        }

        void cargarViajes(string condicion)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                                  var list = from tra in db.TRANSPORTE
                                             from ve in db.VENTA_SERVICIOS.Where(a=>a.num_fact.ToString() == tra.num_fact)
                                             from pa in db.PACIENTES
                                             from per in db.PERSONAS
                                             from ter in db.TERCEROS
                                             where ve.id_paciente == pa.id_paciente
                                             && pa.id_persona == per.id_persona
                                             && per.id_tercero == ter.id_tercero
                                             select new
                                             {
                                                 id_conductor = tra.id_conductor,
                                                 id_transporte = tra.id_transporte,
                                                 num_fact = tra.num_fact.ToString(),
                                                 pacienteT = ter.nombre + " " + per.apellido,
                                                 fecha = tra.fecha,
                                                 notas_viaje = tra.notas_viaje,
                                                 d_dir_desde = tra.id_dir_desde,
                                                 id_dir_hasta = tra.id_dir_hasta,
                                                 estado = tra.estado,
                                                 id_vehiculo = tra.id_vehiculo
                                             };
               // MessageBox.Show(list.FirstOrDefault().pacienteT);
                    if (condicion.Trim() != "")
                                {
                                    list = list.Where(a => a.num_fact.ToString().Contains(condicion)  ||
                                     a.pacienteT.ToString().Contains(condicion)
                                      || estadoT(a.estado).Contains(condicion));
                                }

                    if (list != null)
                    foreach (var emple in list)
                    {

                            dataGridView1.Rows.Add(
                                emple.id_transporte.ToString(),
                                emple.pacienteT.ToString(),
                                emple.id_conductor.ToString(),
                                emple.num_fact.ToString(),
                                emple.fecha.ToString(),
                                emple.d_dir_desde.ToString(),
                                emple.id_dir_hasta.ToString(),
                                emple.id_vehiculo.ToString(),
                              emple.estado);
                        }
            }
                catch (Exception esf)
            {

            }
        };
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarViajes(txt_filtro.Text.Trim());

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
    }
}
