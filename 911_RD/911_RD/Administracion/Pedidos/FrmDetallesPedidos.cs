using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD.Administracion.Pedidos
{
    public partial class FrmDetallesPedidos : Form
    {
        public FrmDetallesPedidos()
        {
            InitializeComponent();
            LlenarDataGrid(Utilidades.nump); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarDataGrid(int nump)
        {
            dataGridView1.Rows.Clear();
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var pedidosD = from p in db.PEDIDOS
                                   join dp in db.DETALLES_PEDIDOS on p.num_pedido equals dp.num_pedido
                                   join art in db.ARTICULOS on dp.id_articulo equals art.id_articulo
                                   select new
                                   {
                                       numpedido = p.num_pedido,
                                       nombre = art.nombre,
                                       cantidad = dp.cantidad,
                                       precio = dp.precio,
                                       total = dp.precio * dp.cantidad, 
                                   };

                    if (nump == 0) return; 
                    pedidosD = pedidosD.Where(a => a.numpedido == nump);  
                    foreach (var OArticulos in pedidosD)
                    { 
                        dataGridView1.Rows.Add(OArticulos.numpedido.ToString(), OArticulos.nombre.ToString(), OArticulos.cantidad.ToString(),
                            OArticulos.precio.ToString(), OArticulos.total.ToString());
                    } 
                }
                catch (Exception aas)
                {
                    //Posible error
                }
            }
        }


    }
}
