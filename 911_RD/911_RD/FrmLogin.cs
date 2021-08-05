using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sPass = Utilidades.Encrypt.GetSHA256(txt_password.Text.Trim());

            using (TransporSysEntities db = new TransporSysEntities())
            {
                var lst = from d in db.USUARIOS
                          where d.usuario == txt_user.Text
                          && d.contrasena == sPass
                          select d;

                if (lst.Count() > 0)
                {
                    FrmPrincipal frmp = new FrmPrincipal();
                    frmp.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario O Contraseña Incorrectos");
                }
            }

        }

    }
}
