using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion;

namespace _911_RD
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void btn_suplidor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmSuplidor frmcliente = new FrmSuplidor())
                {
                    DialogResult dr = frmcliente.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_suplidor.Text = frmcliente.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        txt_nombre_suplidor.Text = frmcliente.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_traer_Click(object sender, EventArgs e)
        {
          /*  try
            {*/
                using (FrmArticulos frmarticulos = new FrmArticulos())
                {
                    DialogResult dr = frmarticulos.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id.Text = frmarticulos.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_nombre.Text = frmarticulos.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txt_stock.Text = frmarticulos.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        MessageBox.Show(frmarticulos.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        MessageBox.Show("VOLVIMOS");
                    }
                }
            }
         /*   catch(Exception asdd)
            {
                //
            }*/
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
