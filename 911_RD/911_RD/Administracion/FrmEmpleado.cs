﻿using System;
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
            cargarTabla("");
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
            try
            {
                if (metodoscrud.ValidarIdentificacion(txt_cedula.Text.Trim())!=0 && id_txt.Text.Trim() == "")
                {
                    txt_error_cedula.Visible = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    txt_error_cedula.Visible = false;
                    btn_guardar.Enabled = true;
                }

            }
            catch (Exception asd)
            {

            }
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
                MessageBox.Show("Favor llenar todos los campos y tiene que ser mayor de edad (18 años)", "Se requiere persona mayor de edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

              InsertarEmpleado();
                cargarTabla("");
              

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


        private void cargarTabla(string condicion)
        {

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var empleado = from emp in db.EMPLEADOS
                                   join pues in db.PUESTOS on emp.id_puesto equals pues.id_puesto
                                   join per in db.PERSONAS on emp.id_persona equals per.id_persona
                                   join ter in db.TERCEROS on per.id_tercero equals ter.id_tercero
                                   join sex in db.SEXOS on per.id_sexo equals sex.id_sexo
                                   join idenVS in db.TERCEROS_VS_IDENTIFICACIONES on ter.id_tercero equals idenVS.id_tercero
                                   join iden in db.IDENTIFICACIONES on idenVS.id_identificacion equals iden.id_identificacion
                                   select new
                                    {
                                       id_tercero = ter.id_tercero,
                                       id_persona = per.id_persona,
                                       id_puesto = pues.id_puesto,
                                       tipo_identificacion = iden.id_tipo_identificacion,
                                       id_empleado = emp.id_empleado,
                                       Nombre = ter.nombre,
                                       Apellido = per.apellido,
                                       Cedula = iden.identificacion,
                                       Fecha_Nacimiento = per.fecha_nacimiento,
                                       Sexo = sex.descripcion,
                                       Puesto = pues.puesto,
                                       Salario = pues.salario,
                                       Fecha_Contraro = emp.fecha_ingreso,
                                       Estado = emp.estado,
                                  
                                   };

                    MessageBox.Show(empleado.ToList().Count + "");

                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        empleado = empleado.Where(em => em.Estado == true);
                    }
                    else
                    {
                        empleado = empleado.Where(em => em.Estado == true && (em.id_empleado.ToString().Contains(condicion) || em.Cedula.Contains(condicion)) || em.Nombre.Contains(condicion) || em.Apellido.Contains(condicion) || em.Puesto.Contains(condicion));
                    }

                    if (empleado!=null)
                    {
                        MessageBox.Show(empleado.ToList().Count+"");

                        dataGridView1.Rows.Clear();

                        foreach (var emple in empleado.ToList())
                        {

                            MessageBox.Show(emple.Apellido);

                            dataGridView1.Rows.Add(
                             emple.id_tercero.ToString(),
                             emple.id_persona.ToString(),
                             emple.id_puesto.ToString(),
                             emple.tipo_identificacion.ToString(),
                             emple.id_empleado.ToString(),
                             emple.Nombre.ToString(),
                             emple.Apellido.ToString(),
                             emple.Cedula.ToString(),
                             emple.Fecha_Contraro.ToString(),
                             emple.Sexo.ToString(),
                             emple.Puesto.ToString(),
                             emple.Salario.ToString(),
                             emple.Fecha_Contraro.ToString(),
                             emple.Estado.ToString()
                            );

                        }

                    }
                }

            }catch(Exception ass)
            {

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

            try
            {
                using (FrmCargo frmCargo = new FrmCargo())
                {
                    DialogResult dr = frmCargo.ShowDialog();
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
            }catch(Exception asa)
            {
                //error
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

        DataTable DatosEm = new DataTable();

        private void cb_puestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_numlicencia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
