using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion.Email_Telefono;

namespace _911_RD.Administracion
{
    public partial class FrmEmpleado : FrmBase
    {
        public FrmEmpleado()
        {
            InitializeComponent();
           cb_estado.SelectedIndex = 0;
           cargarComboxs(); 
           dataGridView1.AllowUserToAddRows = false;
           cargarTabla("");
            txt_cedula.Focus();

        }
        int cont = 0;
        MetodosCRUD metodoscrud = new MetodosCRUD();



        FrmDireccionNativa FrmDir = new FrmDireccionNativa();
        //void cargarFormDIr()
        //{
        //    FrmDir.TopLevel = false;
        //    p_dir.Controls.Add(FrmDir);
        //    FrmDir.btn_guardar.Visible = false;
        //    FrmDir.btn_limpiar.Visible = false;
        //    FrmDir.btn_salir.Visible = false;
        //    FrmDir.Show();
        //}

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
            dataGridView1.Rows[0].Selected = false;
        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {
            CargarTercero();
        }


        void CargarTercero()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int te = metodoscrud.ValidarIdentificacion(txt_cedula.Text.Trim()).Item1;
                    int ide = metodoscrud.ValidarIdentificacion(txt_cedula.Text.Trim()).Item2;
                    if (te > 0)
                    {
                        var ter = db.TERCEROS.FirstOrDefault(a => a.id_tercero == te);
                        if (ter != null)
                        {
                            tercero = te.ToString();
                            txt_nombre.Text = ter.nombre;
                            cargarDirecciones(te);
                            cargarCorreos(te);
                            cargarTelefonos(te);
                            MessageBox.Show("TIPO: " + (db.IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == ide).id_tipo_identificacion - 1));
                            cb_tipoIdent.SelectedIndex = (db.IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == ide).id_tipo_identificacion - 1);
                        }
                    }
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
                MessageBox.Show("Favor llenar todos los campos y tiene que ser mayor de edad (18 años)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tabla_direccion.RowCount < 0)
            {
                MessageBox.Show("Debe asignar al menos una direccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

              InsertarEmpleado();
                cargarTabla("");
                Utilidades.LimpiarControles(this);
                Utilidades.LimpiarControles(p_conductor);       tercero = "";
                clearTableAndMore();

            }
            catch (Exception dfg)
            {

            }

        }


        private void InsertarEmpleado()
        {
            try
            {

                int tercero_t = 0;

                if (id_txt.Text.Trim() != "" || tercero.Trim() != "")
                    tercero_t = int.Parse(tercero);

                tercero_t = metodoscrud.crudTerceros(tercero_t.ToString(), txt_nombre.Text.Trim(), txt_cedula.Text.Trim());
                //Persona
                int id_sexo = cb_sexo.SelectedIndex + 1;
                int id_nacionalidad = cb_nacionalidades.SelectedIndex + 1;
                int persona = metodoscrud.crudPersonas(tercero_t.ToString(), id_sexo.ToString(), fecha_nac.Value, id_nacionalidad.ToString(), txt_apellido.Text);
                //Identificacion
                int id_tipoIdentificacion = cb_tipoIdent.SelectedIndex + 1;
                int id_identificacion = metodoscrud.crudIdentificaciones(txt_cedula.Text, id_tipoIdentificacion.ToString(), tercero_t.ToString());
                //Correo
                    AsignarTelefonos(tercero_t);
                //Telefono
                    AsignarCorreos(tercero_t);
                //Direccion
                    AsignarDIreccion(tercero_t);
                //Empleado
                int empleado = metodoscrud.crudEmpleado(txt_id_cargo.Text, persona.ToString(), fecha_con.Value, cb_estado.SelectedIndex == 0 ? true : false);
                if (conductor == true)
                {
                    int id_conductor = metodoscrud.crudConductor(empleado.ToString(), txt_numlicencia.Text, fecha_licencia.Value); 
                }

            //    Utilidades.LimpiarControles(this);
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
                                       nacionalidad = per.id_nacionalidad,
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
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        foreach (var emple in empleado.ToList())
                        {
                            dataGridView1.Rows.Add(
                             emple.id_tercero.ToString(),
                             emple.id_persona.ToString(),
                             emple.id_puesto.ToString(),
                             emple.tipo_identificacion.ToString(),
                             emple.id_empleado.ToString(),
                             emple.Nombre.ToString(),
                             emple.Apellido.ToString(),
                             emple.Cedula.ToString(),
                             emple.Fecha_Nacimiento.ToString(),
                             emple.Sexo.ToString(),
                             emple.Puesto.ToString(),
                             emple.Salario.ToString(),
                             emple.Fecha_Contraro.ToString(),
                             emple.Estado==true ? "ACTIVO" : "INACTIVO",
                             emple.nacionalidad.ToString()
                            );

                        }

                    }
                }
            }
            catch (Exception ass)
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

            MessageBox.Show("ENTRO");

            //  dataGridView1.Rows.Clear();
            Utilidades.LimpiarControles(this);

            lbl_conductor.Visible = false;
            p_conductor.Visible = false;
          //  cargarTabla("");
        }


        //Seleccionar direccion
        private void btn_busc_dir_Click(object sender, EventArgs e)
        {
         

        }

        private void cb_nacionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        DataTable DatosEm = new DataTable();

        private void cb_puestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_numlicencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "salario")
            {
                if (e.Value != null)
                {
                            e.CellStyle.BackColor = Color.LightSalmon;
                            e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {
               cargarTabla(txt_filtro.Text.Trim());

        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {

                cargarTabla(txt_filtro.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && dataGridView1.SelectedRows.Count > 0)
                CargarCampos();
        }


        string tercero = "";
        string persona = "";

        private void CargarCampos()
        {
            try
            {

                if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == "")
                    return;

                using (TransporSysEntities db = new TransporSysEntities())
                {
                    tercero = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); 
                    cargarTelefonos(int.Parse(tercero));
                    cargarCorreos(int.Parse(tercero));
                    cargarDirecciones(int.Parse(tercero));
                    persona = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txt_id_cargo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txt_des_puesto.Text = db.PUESTOS.FirstOrDefault(a=>a.id_puesto.ToString()== txt_id_cargo.Text).descripcion;
                    cb_tipoIdent.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) - 1);
                    id_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txt_apellido.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    txt_cedula.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    fecha_nac.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                    cb_sexo.SelectedIndex = dataGridView1.SelectedRows[0].Cells[9].Value.ToString().ToLower() == "hombre" ? cb_sexo.SelectedIndex = 0 : 1;
                    txt_cargo.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                    txt_salario.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    fecha_con.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
                    cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[13].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
                    cb_nacionalidades.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[14].Value.ToString()) -1);
                    if (txt_cargo.Text.Trim().ToLower() == "conductor" || txt_cargo.Text.Trim().ToLower() == "chofer" || txt_cargo.Text.Trim().ToLower() == "piloto" || txt_cargo.Text.Trim().ToLower() == "automovilista")
                    {
                        lbl_conductor.Visible = true;
                        p_conductor.Visible = true;
                        conductor = true;
                        var condu = db.CONDUCTOR.FirstOrDefault(a => a.id_empleado.ToString() == id_txt.Text.Trim());
                        txt_numlicencia.Text = condu.num_licencia.ToString();
                        fecha_licencia.Value = DateTime.Parse(condu.fecha_vencimiento.ToString());
                    }
                    else
                    {
                        lbl_conductor.Visible = false;
                        p_conductor.Visible = false;
                        conductor = false;
                    }

                }
            }
            catch (Exception ea)
            {
                //
            }
        }


        private void cargarTelefonos(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var telefono = from telVs in db.TERCEROS_VS_TELEFONOS where id_tercero ==telVs.id_tercero
                               join tel in db.TELEFONOS on telVs.id_telefono equals tel.id_telefono
                                   select new
                               {
                                   id_telefono = tel.id_telefono,
                                   telefono = tel.telefono
                               };

                    if (telefono != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        tabla_tel.Rows.Clear();
                        foreach (var tel in telefono.ToList())
                        {
                            tabla_tel.Rows.Add(
                             tel.id_telefono.ToString(),
                             tel.telefono.ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }

        void removerFila(DataGridView tabla, string campo, string table)
        {
            try { 
            int _id = 0;
            if (tabla.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Quiere remover este campo ?", "Opcion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
               
                foreach (DataGridViewRow row in tabla.SelectedRows)
                {

                    tabla.Rows.RemoveAt(row.Index);
                    _id = int.Parse(row.Cells[0].Value.ToString());
                }
                MessageBox.Show(": " + _id);
            }
               
            if (_id > 0)
                metodoscrud.borrarVs(int.Parse(tercero), _id, table, campo);
            }
            catch (Exception ass)
            {

              //  MessageBox.Show("ERROR DIR: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
}
        
        private void cargarCorreos(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var correo = from telVs in db.TERCEROS_VS_EMAILS
                                 where id_tercero == telVs.id_tercero
                                 join tel in db.EMAILS on telVs.id_email equals tel.id_email
                                 select new
                               {
                                   id_correo = tel.id_email,
                                   correo = tel.email
                               };

                    if (correo != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        tabla_correo.Rows.Clear();
                        foreach (var dire in correo)
                        {
                            tabla_correo.Rows.Add(
                             dire.id_correo.ToString(),
                             dire.correo.ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }
        private void cargarDirecciones(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var correo = from telVs in db.TERCEROS_VS_DIRECCIONES
                                 where id_tercero == telVs.id_tercero
                                 join tel in db.DIRECCIONES on telVs.id_direccion equals tel.id_direccion
                                 join ciu in db.CIUDADES on tel.id_ciudad equals ciu.id_ciudad
                                 join pro in db.PROVINCIAS on ciu.id_provincia equals pro.id_provincia
                                 join pa in db.PAISES on pro.id_pais equals pa.id_pais
                                 select new
                                 {
                                     id_direccion = tel.id_direccion,
                                     direccion = tel.descripcion + ", " + ciu.ciudad + ", " + pa.pais
                                 };

                    if (correo != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        tabla_direccion.Rows.Clear();
                        foreach (var dire in correo)
                        {
                            tabla_direccion.Rows.Add(
                             dire.id_direccion.ToString(),
                             dire.direccion.ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && dataGridView1.SelectedRows.Count > 0)
                return;
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void c_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void c_puesto_SelectedValueChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_filtro.Text.Trim());
        }

        private void btn_direccion_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmDireccionNativa frmCargo = new FrmDireccionNativa())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        bool existe = false;
                        if (tabla_direccion.RowCount > 0)
                        {
                            // Primero averigua si el registro existe:

                            for (int i = 0; i < tabla_direccion.RowCount; i++)
                            {
                                if (tabla_direccion.Rows[i].Cells[0].Value.ToString() == frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    MessageBox.Show("Ya le pertenece esta direccion.");
                                    existe = true;
                                    break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                                }
                            }

                        }
                        if (existe == false)
                        {
                            tabla_direccion.Rows.Add(frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                            frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString() + ", " + frmCargo.dataGridView1.CurrentRow.Cells[9].Value.ToString() 
                            + ", " + frmCargo.dataGridView1.CurrentRow.Cells[5].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void btn_telefono_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmTelefono frmCargo = new FrmTelefono())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        bool existe = false;
                        if (tabla_tel.RowCount > 0)
                        {
                            // Primero averigua si el registro existe:
                          
                            for (int i = 0; i < tabla_tel.RowCount; i++)
                            {
                                if (tabla_tel.Rows[i].Cells[0].Value.ToString() == frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    MessageBox.Show("Ya le pertenece este numero.");
                                    existe = true;
                                    break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                                }
                            }
                            // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:
                          
                        }
                        if (existe == false)
                        {
                            tabla_tel.Rows.Add(frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                            frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }


        void AsignarCorreos(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (tabla_correo.RowCount > 0)
                    {
                        // Primero averigua si el registro existe:
                        int _id = 0;
                        foreach (DataGridViewRow i in tabla_correo.Rows)
                        {
                            _id = int.Parse(i.Cells[0].Value.ToString());
                            var res = db.TERCEROS_VS_EMAILS.FirstOrDefault(a => a.id_email == _id && a.id_tercero == id_tercero);
                            if (res == null)
                            {
                                metodoscrud.crud_VS(id_tercero, _id, "TERCEROS_VS_EMAILS", "id_email");
                            }
                        }
                    }
                }
            }
            catch (Exception ass)
            {

                //MessageBox.Show("ERROR CORRE: " + ass.Message+"--LO OTRO: "+ ass.HelpLink);
            }

        }

        void AsignarTelefonos(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int _id = 0;
                    if (tabla_tel.RowCount > 0)
                    {
                        foreach (DataGridViewRow i in tabla_tel.Rows)
                        {
                          _id = int.Parse(i.Cells[0].Value.ToString());
                            var res = db.TERCEROS_VS_TELEFONOS.FirstOrDefault(a => a.id_telefono == _id && a.id_tercero == id_tercero);
                            if (res == null)
                            {
                                metodoscrud.crud_VS(id_tercero, _id, "TERCEROS_VS_TELEFONOS", "id_telefono");
                            }
                        }
                    }
                }
            }
            catch (Exception ass)
            {
                //   MessageBox.Show("ERROR TEL: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
        }
        void AsignarDIreccion(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (tabla_direccion.RowCount > 0)
                    {
                        // Primero averigua si el registro existe:
                        int _id = 0;
                        foreach (DataGridViewRow i in tabla_direccion.Rows)
                        {

                            _id = int.Parse(i.Cells[0].Value.ToString());
                           var res = db.TERCEROS_VS_DIRECCIONES.FirstOrDefault(a => a.id_direccion == _id && a.id_tercero == id_tercero);
                            if (res == null)
                            {
                                metodoscrud.crud_VS(id_tercero, _id, "TERCEROS_VS_DIRECCIONES", "id_direccion");
                            }
                        }
                    }
                }
            }
            catch (Exception ass)
            {

              //  MessageBox.Show("ERROR DIR: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
        }


        private void btn_correo_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmEmail frmCargo = new FrmEmail())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        bool existe = false;
                        if (tabla_tel.RowCount > 0)
                        {
                            // Primero averigua si el registro existe:

                            for (int i = 0; i < tabla_correo.RowCount; i++)
                            {
                                if (tabla_correo.Rows[i].Cells[0].Value.ToString() == frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    MessageBox.Show("Ya le pertenece este email.");
                                    existe = true;
                                    break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                                }
                            }
                            // Luego, ya fuera del ciclo, solo si no existe, realizas la insercion:

                        }
                        if (existe == false)
                        {
                            tabla_correo.Rows.Add(frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void tabla_tel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_tel,"id_telefono", "TERCEROS_VS_TELEFONOS");
        }
        
        private void tabla_correo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                removerFila(tabla_correo, "id_email", "TERCEROS_VS_EMAILS");
        }

        private void tabla_direccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_direccion, "id_direccion", "TERCEROS_VS_DIRECCIONES");
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            Utilidades.LimpiarControles(p_conductor);
            clearTableAndMore();
        }



        void clearTableAndMore()
        {
            tabla_correo.Rows.Clear();
            tabla_direccion.Rows.Clear();
            tabla_tel.Rows.Clear();
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_cedula.Text = "";
            id_txt.Text = "";
            txt_cargo.Text = "";
            txt_des_puesto.Text = "";
            txt_id_cargo.Text = "";
            txt_salario.Text = "";
            p_conductor.Visible = false;
            lbl_conductor.Visible = false;
            tercero = "";
        }

        private void txt_cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabla_tel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
