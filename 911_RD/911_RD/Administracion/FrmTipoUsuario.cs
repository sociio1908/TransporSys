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
    public partial class FrmTipoUsuario : FrmBase
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
            cargarTabla();
            txt_filtro.Focus();
        }

        private void FrmTipoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
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
                        TIPOS_USUARIOS user = new TIPOS_USUARIOS
                        {
                            tipo_usuario = txt_nombre.Text.Trim(),
                            descripcion = txt_des.Text.Trim(),
                        };
                        db.TIPOS_USUARIOS.Add(user);
                    }
                    else
                    {

                        var user = db.TIPOS_USUARIOS.FirstOrDefault(a => a.id_tipo_usuario.ToString() == id_txt.Text.Trim());

                        if (user != null)
                        {
                            user.tipo_usuario = txt_nombre.Text.Trim();
                            user.descripcion = txt_des.Text.Trim();

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
                    var list = db.TIPOS_USUARIOS;
                    foreach (var Ouser in list)
                    {
                        dataGridView1.Rows.Add(Ouser.id_tipo_usuario.ToString(), Ouser.tipo_usuario.ToString(), Ouser.descripcion.ToString());
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
                txt_des.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

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
                    var user = from pro in db.TIPOS_USUARIOS
                               select new
                               {
                                   //aqui cargas los campos de tu tabla
                                   pro.id_tipo_usuario,
                                   pro.tipo_usuario,
                                   pro.descripcion
                                   


                                   //etc
                               };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        
                    }
                    else
                    {
                        user = user.Where(pro => (pro.tipo_usuario.ToString().Contains(condicion) || pro.descripcion.Contains(condicion)));
                    }


                    string status;

                    foreach (var Ouser in user)
                    {
                        dataGridView1.Rows.Add(Ouser.tipo_usuario.ToString(), Ouser.tipo_usuario.ToString(), Ouser.descripcion.ToString());
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

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
