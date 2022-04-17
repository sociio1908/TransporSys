using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace _911_RD.Administracion.Configuracion
{
    public partial class FrmConfiguracionProducto : Form
    {
        public FrmConfiguracionProducto()
        {
            InitializeComponent();
        }

        private void btn_articulo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmArticulos frmarticulos = new FrmArticulos())
                {
                    DialogResult dr = frmarticulos.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id.Text = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_articulo.Text = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txt_descripcion.Text = frmarticulos.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        cargarTabla(frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    }
                }
            }
            catch (Exception asdd)
            {

            }
        }
        private void cargarTabla(string id_art)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    var pedidosD = from vs in db.ARTICULOS_VS_CONFIGURACION_PEDIDO
                                   join art in db.ARTICULOS on vs.id_articulo equals art.id_articulo 
                                   join s in db.CONFIGURACION_PEDIDOS on vs.id_configuracion equals s.id_configuracion 
                                   select new
                                   {
                                       //aqui cargas los campos de tu tabla
                                       id_articulo = art.id_articulo,
                                       articulo = art.nombre,
                                       descart = art.descripcion,
                                       idcon = s.id_configuracion,
                                       descon = s.descripcion,
                                       nump = vs.num_prioridad
                                   };
                    if (id_art.Trim().Equals("") == false)
                    {
                        pedidosD = pedidosD.Where(a => a.id_articulo.ToString().Contains(id_art));
                    }
                    if (pedidosD != null)
                        foreach (var OPuestos in pedidosD)
                        {
                            txt_id.Text = OPuestos.id_articulo.ToString();
                            txt_articulo.Text = OPuestos.articulo.ToString();
                            txt_descripcion.Text = OPuestos.descart.ToString(); 
                            dataGridView1.Rows.Add(OPuestos.idcon.ToString(), OPuestos.descon.ToString(), OPuestos.nump.ToString());
                        }


                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }


        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            try
            {
                string con, des;
                using (FrmConfiguracionPedido frmarticulos = new FrmConfiguracionPedido())
                {
                    int indice = dataGridView1.Rows.Count + 1;
                    DialogResult dr = frmarticulos.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        con = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        des = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        if (Existe(con) == false)
                        {
                            dataGridView1.Rows.Add(con, des, indice);
                        }
                    }
                }
            }
            catch (Exception asdd)
            {

            }
        }



        bool Existe(string con)
        {
            if (dataGridView1.Rows.Count < 1)
                return false;

            bool existe = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells["id_eme"].Value.ToString());
                if (id.ToString() == con)
                {
                    existe = true;
                }
            }
            return existe;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            dataGridView1.Rows.Clear();


        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count < 1)
                return;
            DialogResult dialogResult = MessageBox.Show("SEGURO QUE DESEA QUITAR ESTA CONFIGURACION ?", "Precaución", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) || dataGridView1.Rows.Count<1)
                return;

            DialogResult dialogResult = MessageBox.Show("DESEA ASIGNAR ESTA CONFIGURACION ?", "Precaución", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                InsertarConfiguracion();
            } 
        }

        MetodosCRUD MetodosCRUD = new MetodosCRUD();
        void InsertarConfiguracion()
        {

            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                        return;

                MetodosCRUD.borrarVsConfArt(txt_id.Text);
                    using (TransporSysEntities db = new TransporSysEntities())
                   {
                    for (int a = 0; a < dataGridView1.Rows.Count; a++)
                    {
                        dataGridView1.Rows[a].Cells["prioridad"].Value = a + 1;
                        ARTICULOS_VS_CONFIGURACION_PEDIDO puesto = new ARTICULOS_VS_CONFIGURACION_PEDIDO
                        {
                            id_articulo = int.Parse(txt_id.Text),
                            id_configuracion = int.Parse(dataGridView1.Rows[a].Cells["id_eme"].Value.ToString()),
                            num_prioridad = int.Parse(dataGridView1.Rows[a].Cells["prioridad"].Value.ToString())
                        };
                        db.ARTICULOS_VS_CONFIGURACION_PEDIDO.Add(puesto);
                    }
                    db.SaveChanges();
                    }
                     Utilidades.LimpiarControles(this); 
                    MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        } 
         


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CamniarPrioridad();
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CamniarPrioridad();
        }

        void CamniarPrioridad()
        {
            if (dataGridView1.Rows.Count < 1)
                return;

            if (dataGridView1.Rows.Count > 1)
            { 
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    dataGridView1.Rows[a].Cells["prioridad"].Value = a + 1;
                }
            }

            else if (dataGridView1.Rows.Count == 1)
            {
                dataGridView1.Rows[0].Cells[2].Value = 1;
            }
        }

        private void btn_subir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            int totalRows = dataGridView1.Rows.Count;
            int idx = dataGridView1.SelectedCells[0].OwningRow.Index;
            if (idx == 0)
                return;
            int col = dataGridView1.SelectedCells[0].OwningColumn.Index;
            DataGridViewRowCollection rows = dataGridView1.Rows;
            DataGridViewRow row = rows[idx];
            rows.Remove(row);
            rows.Insert(idx - 1, row);
            dataGridView1.ClearSelection();
            dataGridView1.Rows[idx - 1].Cells[col].Selected = true;
            CamniarPrioridad();
        }


    }
   }
