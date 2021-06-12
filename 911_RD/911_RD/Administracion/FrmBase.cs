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
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            txt_filtro.Text = "BUSCAR" + lbl_titulo.Text;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           
           if(MessageBox.Show("Desea salir ?", "Aviso",MessageBoxButtons.YesNo, 
               MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                this.Close();
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
