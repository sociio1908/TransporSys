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
                    }
                }
            }
            catch (Exception asdd)
            {

            }
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            try
            {

                string con, des;
                using (FrmConfiguracionPedido frmarticulos = new FrmConfiguracionPedido())
                {
                    DialogResult dr = frmarticulos.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        con = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        des = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        if (Existe(con) == false)
                        {
                            dataGridView1.Rows.Add(con, des);
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

            bool existe = false ;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells["id_eme"].Value.ToString()); 
                if(id.ToString() == con)
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
            if (dataGridView1.Rows.Count > 0) 
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex); 
        }
    }
}
