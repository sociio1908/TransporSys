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
    public partial class FrmEmpleado : FrmBase
    {
        public FrmEmpleado()
        {
            InitializeComponent();
           cb_estado.SelectedIndex = 0;
           cargarComboxs();

            //  FALTAN LOS VS Y LAS CONSULTAS

        }

        MetodosCRUD metodoscrud = new MetodosCRUD();
       void cargarComboxs()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
            {
                
                    var listS = db.SEXOS;
                        foreach (var sEXOS in listS){ 
                        cb_sexo.Items.Add(sEXOS.descripcion.ToUpper());
                    
                    }

                    var listN  = db.NACIONALIDADES;
                    foreach (var nACIONALIDADES in listN)
                    {
                        cb_nacionalidades.Items.Add(nACIONALIDADES.nacionalidad.ToUpper());
                    }

                    var listIden = db.TIPOS_IDENTIFICACIONES;
                    foreach (var identi in listIden)
                    {
                        cb_tipoIdent.Items.Add(identi.nombre.ToUpper());
                    }


                }

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void errorTxtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
          
        }



        private void btn_guardar_Click(object sender, EventArgs e)
        {
          
             if (Utilidades.ValidarFormulario(this, errorProvider1) || validarCombo()==false || Utilidades.mayorEdad(fecha_nac.Value)==false)
            {
                MessageBox.Show("Favor llenar todos los campos y tiene que ser mayor a 18 años", "Se requiere persona mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

              InsertarEmpleado();

            }
            catch (Exception dfg)
            {

            }

        }

        string id_tercero = "";

        private void InsertarEmpleado()
        {
            try
            {
                //Tercero
                int tercero = metodoscrud.crudTerceros(id_tercero, txt_nombre.Text.Trim());
                MessageBox.Show("ID_TERCERO: " + tercero);
                //Persona
                int id_sexo = cb_sexo.SelectedIndex + 1;
                int id_nacionalidad = cb_nacionalidades.SelectedIndex + 1;
                int persona = metodoscrud.crudPersonas(tercero.ToString(), id_sexo.ToString(), fecha_nac.Value, id_nacionalidad.ToString(), txt_apellido.Text);
                MessageBox.Show("ID_PERSONA: " + persona);
                //Identificacion
                int id_tipoIdentificacion = cb_tipoIdent.SelectedIndex + 1;
                int id_identificacion = metodoscrud.crudIdentificaciones(txt_cedula.Text, id_tipoIdentificacion.ToString(), tercero.ToString());
                MessageBox.Show("ID_identificacion: " + id_identificacion);


                //Correo
                metodoscrud.crudCorreo("",txt_correo.Text, tercero.ToString());
                //Telefono
                metodoscrud.crudTelefono("", txt_telefono.Text, tercero.ToString());
                //Direccion
                 int id_direccion = metodoscrud.InsertarDireccion(txt_lat.Text, txt_long.Text, tercero.ToString());
                //Empleado
                int empleado = metodoscrud.crudEmpleado(txt_id_cargo.Text, persona.ToString(), fecha_con.Value, cb_estado.SelectedIndex == 0 ? true : false);
                MessageBox.Show("ID_empleado: " + empleado);
                if (conductor == true)
                {
                    int id_conductor = metodoscrud.crudConductor(empleado.ToString(), txt_numlicencia.Text, fecha_licencia.Value); 
                    MessageBox.Show("id_conductor: " + id_conductor);
                }

                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE");
                
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

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
                    var list = db.PUESTOS;
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_puesto.ToString(), OPuestos.puesto.ToString(), OPuestos.descripcion.ToString(),
                            OPuestos.salario.ToString(), status = OPuestos.estado == true ? "ACTIVO" : "INACTIVO");
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }



        bool validarCombo()
        {
            if (cb_sexo.SelectedItem ==null  || cb_estado.SelectedItem == null || cb_nacionalidades.SelectedItem == null)
                return false;

            return true;
        }

        bool conductor = false;


    

        private void btn_Cargo_Click(object sender, EventArgs e)
        {
            using (FrmCargo frmCargo = new FrmCargo())
            {
                DialogResult dr =  frmCargo.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txt_id_cargo.Text = frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txt_cargo.Text = frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_des_puesto.Text = frmCargo.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_salario.Text = frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString();

                    if (txt_cargo.Text.Trim().ToLower() == "conductor" || txt_cargo.Text.Trim().ToLower() == "chofer" || txt_cargo.Text.Trim().ToLower() == "piloto" || txt_cargo.Text.Trim().ToLower() == "automovilista")
                    {
                        lbl_conductor.Visible = true;
                        p_conductor.Visible = true;
                        conductor = true;
                    }
                    else
                    {
                        lbl_conductor.Visible = false;
                        p_conductor.Visible = false;
                        conductor = false;
                    }

                }
            }
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            lbl_conductor.Visible = false;
            p_conductor.Visible = false;
        }


        //Seleccionar direccion
        private void btn_busc_dir_Click(object sender, EventArgs e)
        {
            using (FrmDirecciones frm = new FrmDirecciones())
            {
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                
                try
                {
                    UseWaitCursor = true;
                    var res = Utilidades.ExtraerDireccion(frm.webBrowser1.Url.ToString());

                    if (res.Item3)
                    {
                        this.DialogResult = DialogResult.OK;
                            txt_lat.Text = res.Item1.ToString();
                            txt_long.Text = res.Item2.ToString();
                            lbl_estado_dir.Text = "DIRECCION CARGADA CON EXITO.";
                        lbl_estado_dir.ForeColor = System.Drawing.Color.DarkGreen;
                    }
                    else
                    {
                        lbl_estado_dir.Text = "ERROR, DIRECCION NO CARGADA.";
                        lbl_estado_dir.ForeColor = System.Drawing.Color.Red;
                    }
                    UseWaitCursor = false;

                }
                catch (Exception asasd)
                {
                    //error
                }

            }
        }

        private void cb_nacionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cb_nacionalidades.SelectedIndex.ToString());
        }
    }
}
