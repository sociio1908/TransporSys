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
    public partial class FrmUsuarios : FrmBase
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            cargarTabla();
            txt_filtro.Focus();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void InsertarUsuario()
        {


            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {


                    if (id_txt.Text.Trim() == "")
                    {
                        USUARIOS user = new USUARIOS
                        {
                            usuario = txt_nombre.Text.Trim(),
                            id_empleado = Convert.ToInt32(txt_idemple.Text.Trim()),
                            id_tipo_usuario = Convert.ToInt32(txt_tipo.Text.Trim()),
                            contrasena = Utilidades.Encrypt.GetSHA256(txt_password.Text.Trim()),
                            estado = cb_estado.SelectedIndex == 0 ? true : false
                        };
                        db.USUARIOS.Add(user);
                    }
                    else
                    {

                        var user = db.USUARIOS.FirstOrDefault(a => a.id_usuario.ToString() == id_txt.Text.Trim());

                        if (user != null)
                        {
                            user.usuario = txt_nombre.Text.Trim();
                            user.id_empleado = Convert.ToInt32(txt_idemple.Text.Trim());
                            user.id_tipo_usuario = Convert.ToInt32(txt_tipo.Text.Trim());
                            user.contrasena = Utilidades.Encrypt.GetSHA256(txt_password.Text.Trim());
                            user.estado = cb_estado.SelectedIndex == 0 ? true : false;
                        }
                        MessageBox.Show("COMPLETO");
                    }
                    db.SaveChanges();
                    Utilidades.LimpiarControles(this);
                    cargarTabla();
                }
                catch (Exception) { }
            }

        }

        private void cargarTabla()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    string status;
                    var list = db.USUARIOS;
                    foreach (var Ouser in list)
                    {
                        dataGridView1.Rows.Add(Ouser.id_usuario.ToString(), Ouser.usuario.ToString(), Ouser.id_empleado.ToString(), Ouser.id_tipo_usuario.ToString(), Ouser.contrasena.ToString(),
                            status = Ouser.estado == true ? "ACTIVO" : "INACTIVO");
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void CargarCampos()
        {
            try
            {

                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_idemple.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_tipo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_password.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(groupBox1, errorProvider1) == true)
            {

            }
            else
            {
                InsertarUsuario();
                id_txt.Text = "";
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla();
        }

        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var user = from pro in db.USUARIOS
                                    join cat in db.EMPLEADOS on pro.id_empleado
                            equals cat.id_empleado

                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        pro.id_usuario,
                                        pro.usuario,
                                        cat.id_empleado,
                                        pro.id_tipo_usuario,
                                        pro.contrasena,
                                        pro.estado


                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        user = user.Where(pro => pro.estado == true);
                    }
                    else
                    {
                        user = user.Where(pro => pro.estado == true && (pro.id_usuario.ToString().Contains(condicion) || pro.usuario.Contains(condicion)));
                    }


                    string status;

                    foreach (var Ouser in user)
                    {
                        dataGridView1.Rows.Add(Ouser.id_usuario.ToString(), Ouser.usuario.ToString(), Ouser.id_empleado.ToString(), Ouser.id_tipo_usuario.ToString(), Ouser.contrasena.ToString(),
                            status = Ouser.estado == true ? "ACTIVO" : "INACTIVO");
                    }


                }
            }
            catch (Exception aas)
            {
                //Posible error
            }
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();
            LlenarDataGrid(txt_filtro.Text.Trim());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (FrmTipoUsuario frmunidad = new FrmTipoUsuario())
            {
                DialogResult dr = frmunidad.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txt_tipo.Text = frmunidad.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }
            }
        }
    }
}
