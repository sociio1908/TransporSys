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
                foreach (var ouser in lst)
                {
                    string a = ouser.usuario;
                    
                    int b = ouser.id_empleado;
                    
                    if (a == txt_user.Text.Trim())
                    {
                        Utilidades.nomusuario = ouser.EMPLEADOS.PERSONAS.TERCEROS.nombre;
                        Utilidades.idusuario = ouser.id_empleado;
                        Utilidades.puestouser = ouser.TIPOS_USUARIOS.id_tipo_usuario.ToString();
                        Utilidades.Apeuser = ouser.EMPLEADOS.PERSONAS.apellido;
                    }
                }

                if (lst.Count() > 0)
                {

                    FrmPrincipal frmp = new FrmPrincipal();
                    frmp.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario O Contraseña Incorrectos");
                }
            }

        }

    }
}
