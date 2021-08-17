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
using _911_RD.Administracion.Pacientes;

namespace _911_RD.Administracion
{
    public partial class FrmPaciente : FrmBase
    {
        public FrmPaciente()
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
                    cb_sexo.Items.Clear();
                    foreach (var sEXOS in listS)
                    {
                        cb_sexo.Items.Add(sEXOS.descripcion.ToUpper());
                    }

                    var listN = db.NACIONALIDADES;
                    cb_nacionalidades.Items.Clear();
                    foreach (var nACIONALIDADES in listN)
                    {
                        cb_nacionalidades.Items.Add(nACIONALIDADES.nacionalidad.ToUpper());
                    }

                    var listIden = db.TIPOS_IDENTIFICACIONES;
                    cb_tipoIdent.Items.Clear();
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


        string tercero = "";
        string paciente = "";

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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) || validarCombo() == false)
            {
                MessageBox.Show("Favor llenar los campos con el error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tabla_direccion.RowCount < 0)
            {
                MessageBox.Show("Debe asignar al menos una direccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                InsertarPaciente();
            }
            catch (Exception dfg)
            {

            }

        }


        private void InsertarPaciente()
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
                if (txt_cedula.Text.Trim()!="") { 
                   int id_tipoIdentificacion = cb_tipoIdent.SelectedIndex + 1;
                   int id_identificacion = metodoscrud.crudIdentificaciones(txt_cedula.Text, id_tipoIdentificacion.ToString(), tercero_t.ToString());
                }

                //Correo
                if(tabla_tel.Rows.Count>0 && tercero_t>0)
                AsignarTelefonos(tercero_t);
                //Telefono
                if (tabla_correo.Rows.Count > 0 && tercero_t > 0)
                    AsignarCorreos(tercero_t);
                //Direccion
                if (tabla_direccion.Rows.Count > 0 && tercero_t > 0)
                    AsignarDIreccion(tercero_t);
                if(tabla_condiciones.Rows.Count > 0 && tercero_t > 0)
                    AsignarCondicionMedica(tercero_t);
                //Persona
                if (persona > 0)
                {
                    int paciente = metodoscrud.crudPaciente(id_txt.Text, persona.ToString(), txt_peso.Text.Trim(), txt_seguro.Text.Trim(), cb_estado.SelectedIndex == 0 ? true : false);
                }

                Utilidades.LimpiarControles(this);
                clearTableAndMore();
                cargarTabla("");
                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE");

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }


        int buscarIdent(string id_tercero)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                try
                {
                    var res = db.TERCEROS_VS_IDENTIFICACIONES.FirstOrDefault(a => a.id_tercero.ToString() == id_tercero);
                    if (res != null)
                        return res.id_identificacion;
                }
                catch(Exception add)
                {

                }
            }
            return 0;
        }

        private void cargarTabla(string condicion)
        {

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var empleado = from emp in db.PACIENTES
                                   join per in db.PERSONAS on emp.id_persona equals per.id_persona
                                   join nac in db.NACIONALIDADES on per.id_nacionalidad equals nac.id_nacionalidad
                                   join ter in db.TERCEROS on per.id_tercero equals ter.id_tercero
                                   join sex in db.SEXOS on per.id_sexo equals sex.id_sexo
                                   select new
                                   {
                                       id_tercero = ter.id_tercero,
                                       id_persona = per.id_persona,
                                       id_nacionalidad = nac.id_nacionalidad,
                                       id_paciente = emp.id_paciente,
                                       seguro = emp.num_seguro,
                                       nacionalidad = nac.nacionalidad,
                                       peso = emp.peso,
                                       Nombre = ter.nombre,
                                       Apellido = per.apellido,
                                       Fecha_Nacimiento = per.fecha_nacimiento,
                                       Sexo = sex.descripcion,
                                       Estado = emp.estado
                                   };

                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        empleado = empleado.Where(em => em.Estado == true);
                    }
                    else
                    {
                        empleado = empleado.Where(em => em.Estado == true && (em.id_paciente.ToString().Contains(condicion) || em.Nombre.Contains(condicion) || em.Apellido.Contains(condicion) || em.seguro.Contains(condicion)));
                    }
               
                    if (empleado != null)
                    { 
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        foreach (var emple in empleado.ToList())
                        {
                        string ced = "";
                        string tipo = "";
                        int res = buscarIdent(emple.id_tercero.ToString());
                        if (res > 0)
                        {
                            var iden = db.IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == res);
                            ced = iden.identificacion;
                            tipo = iden.id_tipo_identificacion.ToString();
                        }

                        dataGridView1.Rows.Add(
                             emple.id_tercero.ToString(),
                             emple.id_persona.ToString(),
                             emple.id_nacionalidad.ToString(),
                             tipo.ToString(),
                             emple.id_paciente.ToString(),
                             emple.Nombre.ToString(),
                             emple.Apellido.ToString(),
                             emple.Fecha_Nacimiento.ToString(),
                             ced.ToString(),
                             emple.nacionalidad.ToString(),
                             emple.Sexo.ToString(),
                             emple.seguro.ToString(),
                             emple.peso.ToString(),
                             emple.Estado == true ? "ACTIVO" : "INACTIVO"
                            );

                        }

                    }
                }
            }
            catch (Exception ass)
            {
                MessageBox.Show("ERROR DIR: " + ass.Message + "--LO OTRO: " + ass.HelpLink);
            }
        }


        bool validarCombo()
        {
            if (cb_sexo.SelectedItem == null || cb_estado.SelectedItem == null || cb_nacionalidades.SelectedItem == null)
                return false;

            return true;
        }

        void clearTableAndMore()
        {
            tabla_correo.Rows.Clear();
            tabla_direccion.Rows.Clear();
            tabla_tel.Rows.Clear();
            tabla_condiciones.Rows.Clear();
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_cedula.Text = "";
            id_txt.Text = "";
            txt_peso.Text = "";
            txt_seguro.Text = "";
            tercero = "";
        }

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
                    if (tercero.Trim() == "" || tercero.Trim() == null)
                        return;

                    cargarComboxs();
                    cargarTelefonos(int.Parse(tercero));
                    cargarCorreos(int.Parse(tercero));
                    cargarDirecciones(int.Parse(tercero));
                    cargarCondiciones(int.Parse(tercero));
                    persona = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    cb_nacionalidades.SelectedIndex = cb_nacionalidades.FindString(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
                    cb_tipoIdent.SelectedIndex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString()==""? 0 : (int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) - 1);
                    id_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txt_apellido.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    fecha_nac.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                    txt_cedula.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString()==""? "" : dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                    cb_sexo.SelectedIndex = cb_sexo.FindString(dataGridView1.SelectedRows[0].Cells[10].Value.ToString());
                    txt_seguro.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                    txt_peso.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                    cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[13].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
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
                    var telefono = from telVs in db.TERCEROS_VS_TELEFONOS
                                   where id_tercero == telVs.id_tercero
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
        private void cargarCondiciones(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var telefono = from telVs in db.TERCEROS_VS_ALERGIAS
                                   where id_tercero == telVs.id_tercero
                                   join tel in db.ALERGIAS on telVs.id_alergia equals tel.id_alergia
                                   select new
                                   {
                                       id_alergia = tel.id_alergia,
                                       alergia = tel.alergia,
                                       descripcion = tel.descripcion
                                   };

                    if (telefono != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        tabla_condiciones.Rows.Clear();
                        foreach (var tel in telefono.ToList())
                        {
                            tabla_condiciones.Rows.Add(
                             tel.id_alergia.ToString(),
                             tel.alergia.ToString()+": "+
                             tel.descripcion.ToString()
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
            try
            {
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
                                     direccion = tel.referencia + ", " + ciu.ciudad + ", " + pa.pais
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

        //validar que sea cedula o pasaporte.
        private void cb_tipoIdent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipoIdent.SelectedIndex == 1)
            {
                MessageBox.Show("Los RNC les pertenecen a las empresas y los pacientes solo pueden ser personas, seleccione CEDULA o PASAPORTE.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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


        void AsignarCondicionMedica(int id_tercero)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (tabla_condiciones.RowCount > 0)
                    {
                        // Primero averigua si el registro existe:
                        int _id = 0;
                        foreach (DataGridViewRow i in tabla_condiciones.Rows)
                        {

                            _id = int.Parse(i.Cells[0].Value.ToString());
                            var res = db.TERCEROS_VS_ALERGIAS.FirstOrDefault(a => a.id_alergia == _id && a.id_tercero == id_tercero);
                            if (res == null)
                            {
                                metodoscrud.crud_VS(id_tercero, _id, "TERCEROS_VS_ALERGIAS", "id_alergia");
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

        private void bt_agregar_nac_Click(object sender, EventArgs e)
        {
            FrmNacionalidad fm = new FrmNacionalidad();
            fm.ShowDialog();
            cargarComboxs();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            CargarCampos();
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
                            frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString() + ", " + frmCargo.dataGridView1.CurrentRow.Cells[5].Value.ToString()
                            + ", " + frmCargo.dataGridView1.CurrentRow.Cells[9].Value.ToString());
                        }

                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmAlergias frmCargo = new FrmAlergias())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        bool existe = false;
                        if (tabla_condiciones.RowCount > 0)
                        {
                            // Primero averigua si el registro existe:

                            for (int i = 0; i < tabla_condiciones.RowCount; i++)
                            {
                                if (tabla_condiciones.Rows[i].Cells[0].Value.ToString() == frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString())
                                {
                                    MessageBox.Show("Ya le pertenece esta condicion medica.");
                                    existe = true;
                                    break; // debes salirte del ciclo si encuentras el registro, no es necesario seguir dentro
                                }
                            }

                        }
                        if (existe == false)
                        {
                        tabla_condiciones.Rows.Add(frmCargo.dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString()+": " +
                        frmCargo.dataGridView1.CurrentRow.Cells[2].Value.ToString());
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

            removerFila(tabla_tel, "id_telefono", "TERCEROS_VS_TELEFONOS");
        }

        private void tabla_correo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_correo, "id_email", "TERCEROS_VS_EMAILS");
        }

        private void tabla_direccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_direccion, "id_direccion", "TERCEROS_VS_DIRECCIONES");
        }

        private void tabla_condiciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_tel, "id_alergia", "TERCEROS_VS_ALERGIAS");
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            cargarTabla(txt_filtro.Text.Trim());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            clearTableAndMore();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
