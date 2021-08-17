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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
            cargarComboxs();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }





        void cargarComboxs()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var listS = db.TIPOSPAGO.Where(a=> a.estado==true);
                    cb_tipoPago.Items.Clear();
                    foreach (var sEXOS in listS)
                    {
                        cb_tipoPago.Items.Add(sEXOS.descripcion.ToUpper());
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }

        private void btn_CargoPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmPaciente frmCargo = new FrmPaciente())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_paciente.Text = frmCargo.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        txt_nomPaciente.Text = frmCargo.dataGridView1.CurrentRow.Cells[5].Value.ToString()+" " + frmCargo.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        txt_edad.Text = Utilidades.CalcularEdad(Convert.ToDateTime(frmCargo.dataGridView1.CurrentRow.Cells[7].Value.ToString())).ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
