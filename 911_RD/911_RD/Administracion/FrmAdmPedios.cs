using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace _911_RD.Administracion
{
    public partial class FrmAdmPedios : Form
    {
        public FrmAdmPedios()
        {
            InitializeComponent();
            LlenarDataGrid("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void LlenarDataGrid(string condicion)
        {

            dataGridView1.Rows.Clear();
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var pedidosD = from v in db.PEDIDOS
                                   join dp in db.DETALLES_PEDIDOS on v.num_pedido equals dp.num_pedido
                                   join a in db.ARTICULOS on dp.id_articulo equals a.id_articulo
                                   join s in db.SUPLIDORES on v.id_suplidor equals s.id_suplidor
                                   join t in db.TERCEROS on s.id_tercero equals t.id_tercero
                                   join tVs in db.TERCEROS_VS_IDENTIFICACIONES on t.id_tercero equals tVs.id_tercero
                                   join ide in db.IDENTIFICACIONES on tVs.id_identificacion equals ide.id_identificacion
                                   select new
                                   {
                                       //aqui cargas los campos de tu tabla
                                       numpedido = v.num_pedido,
                                       idsuplidor = s.id_suplidor,
                                       NomSup = t.nombre,
                                       Identficacion = ide.identificacion,
                                       total = v.total,
                                       FechaPedido = v.creado,
                                       FechaEntrega = v.fechaEntrega,
                                       v.estado,
                                   };

                    if (condicion.Trim().Equals("") == false)
                    {
                        pedidosD = pedidosD.Where(a => a.Identficacion.ToString().Contains(condicion) || a.numpedido.ToString().Contains(condicion) || a.NomSup.ToString().Contains(condicion));

                    }
                    int idP = 0;
                    foreach (var OArticulos in pedidosD)
                    {
                        string valor = "";
                        if (OArticulos.estado == 0)
                            valor = "Procesado";
                        if (OArticulos.estado == 1)
                            valor = "Recibido";
                        if (OArticulos.estado == 2)
                            valor = "Cancelado";
                        if (dataGridView1.Rows.Count == 0)
                        {
                            dataGridView1.Rows.Add(OArticulos.numpedido.ToString(), OArticulos.NomSup.ToString(), OArticulos.idsuplidor.ToString(),
                                OArticulos.Identficacion.ToString(), OArticulos.total.ToString(), OArticulos.FechaPedido.ToString(), OArticulos.FechaEntrega.ToString(),
                                valor);
                        }
                        else if (dataGridView1.Rows[idP - 1].Cells[0].Value.ToString() != OArticulos.numpedido.ToString())
                        {
                            dataGridView1.Rows.Add(OArticulos.numpedido.ToString(), OArticulos.NomSup.ToString(), OArticulos.idsuplidor.ToString(),
                                OArticulos.Identficacion.ToString(), OArticulos.total.ToString(), OArticulos.FechaPedido.ToString(), OArticulos.FechaEntrega.ToString(),
                                valor);
                        }




                        idP++;
                    }


                }
                catch (Exception aas)
                {
                    //Posible error
                }
            }
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            LlenarDataGrid(txt_filtro.Text.Trim());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelarPedido();
        }

        void cancelarPedido()
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            if ((dataGridView1.SelectedRows[0].Cells["estado"].Value.ToString()) == "Cancelado")
            {
                MessageBox.Show("Accion incorrecta: Este pedido ya esta cancelado.");
                return;
            }

            string _pedido = (dataGridView1.SelectedRows[0].Cells["num_pedido"].Value.ToString());
            string _supldior = (dataGridView1.SelectedRows[0].Cells["suplidor"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seguro que desea eliminar el pedido #" + _pedido + " del suplidor " + _supldior + " ?", "Precaución", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int num = int.Parse(dataGridView1.SelectedRows[0].Cells["num_pedido"].Value.ToString());

                    var pedidoXX = db.PEDIDOS.FirstOrDefault(a => a.num_pedido == num);

                    if (num == pedidoXX.num_pedido)
                    {
                        pedidoXX.estado = 2;
                    }
                    db.SaveChanges();
                    LlenarDataGrid("");
                    MessageBox.Show("Pedido cancelado.");
                }
            }
        }
         
         
        private void btn_recibir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;

            if ((dataGridView1.SelectedRows[0].Cells["estado"].Value.ToString()) == "Recibido")
            {
                MessageBox.Show("Accion incorrecta: Este pedido ya esta recibido.");
                return;
            }

            int _pedido = int.Parse(dataGridView1.SelectedRows[0].Cells["num_pedido"].Value.ToString());
            string _supldior = (dataGridView1.SelectedRows[0].Cells["suplidor"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seguro que desea recibir el pedido #" + _pedido + " del suplidor " + _supldior + " ?", "Precaución", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                CargarFact(_pedido);

        }

        private void CargarFact(int numPEDIDO)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                if (dataGridView1.Rows.Count < 1)
                {
                    MessageBox.Show("ESTA VACIO");
                }
                else
                {
                    try
                    {
                        COMPRAS comp = new COMPRAS
                        {
                            //ningun campo vacio
                            id_suplidor = int.Parse(dataGridView1.SelectedRows[0].Cells["idsuplidor"].Value.ToString()),
                            id_empleado = Utilidades.idusuario,
                            fecha = DateTime.Now,
                            estado = true,
                        };
                        db.COMPRAS.Add(comp);
                        var pedidoXX = db.PEDIDOS.FirstOrDefault(a => a.num_pedido == numPEDIDO);
                        if (pedidoXX != null)
                        {
                            pedidoXX.estado = 1;
                        }
                        db.SaveChanges(); 
                        InsertarDetalle(db.COMPRAS.Max(p => p.num_compra));
                        LlenarDataGrid(""); 
                        MessageBox.Show("Pedido recibido.");
                    }
                    catch (Exception) { }
                }

            }
        }

        private void InsertarDetalle(int num_fact)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    var pedidosD = from v in db.PEDIDOS
                                   join dp in db.DETALLES_PEDIDOS on v.num_pedido equals dp.num_pedido
                                   join a in db.ARTICULOS on dp.id_articulo equals a.id_articulo
                                   select new
                                   {
                                       //aqui cargas los c
                                       numPED = v.num_pedido,
                                       id_articulo = a.id_articulo,
                                       precio = dp.precio,
                                       cantidad = dp.cantidad,
                                   };

                    int num = int.Parse(dataGridView1.SelectedRows[0].Cells["num_pedido"].Value.ToString());
                    pedidosD = pedidosD.Where(a => a.numPED.ToString().Contains(num.ToString()));

                    foreach (var OArticulos in pedidosD)
                    {
                        double TOtal = OArticulos.cantidad * OArticulos.precio;
                        DETALLES_COMPRAS Dcomp = new DETALLES_COMPRAS
                        {
                            num_compra = num_fact,
                            id_articulo = OArticulos.id_articulo,
                            cantidad = OArticulos.cantidad,
                            precio = OArticulos.precio,
                            itbis = 0.0,
                            descuento = 0.0,
                            total = TOtal
                        };
                        db.DETALLES_COMPRAS.Add(Dcomp);
                    }
                    db.SaveChanges();
                    foreach (var OArticulos in pedidosD)
                    {
                        int art = OArticulos.id_articulo;
                        var stockactual = db.ARTICULOS.SingleOrDefault(b => b.id_articulo == art);
                        double nuevoStock = stockactual.stock.Value + OArticulos.cantidad;
                        if (stockactual != null)
                        {
                            ActualizarStock2(nuevoStock, OArticulos.id_articulo);
                        }
                    }

                }
                catch (Exception) { }

            }
        }


        void ActualizarStock2(double cant_art, int id_art)
        {

            using (TransporSysEntities db = new TransporSysEntities())
            {  
                var pedidoXX = db.ARTICULOS.FirstOrDefault(a => a.id_articulo == id_art);

                if (id_art == pedidoXX.id_articulo)
                {
                    pedidoXX.stock = cant_art;
                }
                db.SaveChanges(); 
            }

        } 


    }
        
    }



