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
    public partial class FrmDirecciones : Form
    {
        public FrmDirecciones()
        {
            InitializeComponent();
              webBrowser1.Navigate(link);
        }
        
        string link = "https://www.google.com.mx/maps/place/Santiago+De+Los+Caballeros/@19.4399935,-70.7430635,12z/data=!3m1!4b1!4m5!3m4!1s0x8eb1c5c838e5899f:0x75d4b059b8768429!8m2!3d19.4791963!4d-70.6930568";
       
        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ej: UTESA SANTIAGO","EJEMPLO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ej:SANTIAGO", "EJEMPLO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label8_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ej: LAS CARRERAS SANTIAGO", "EJEMPLO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        FrmEmpleado frmEmpleado = new FrmEmpleado();
        private void button5_Click(object sender, EventArgs e)
        {
            try {
               
                if (webBrowser1.Url != null || webBrowser1.ScriptErrorsSuppressed)
                {
                    this.DialogResult = DialogResult.OK;
                }
                this.Close();

            } catch (Exception asasd)
            {
                //error
            }
        }
    }
}
