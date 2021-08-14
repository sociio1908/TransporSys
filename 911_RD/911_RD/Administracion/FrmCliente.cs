using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion;
using _911_RD.Administracion.Email_Telefono;

namespace _911_RD
{
    public partial class FrmCliente : FrmBase

    {
        public FrmCliente()
        {
            InitializeComponent();
            cb_estado.SelectedIndex = 0;
            cargarComboxs();
            dataGridView1.AllowUserToAddRows = false;
            cargarTabla("");
            txt_cedula.Focus();
        }

            private void btn_TipoCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmTipoCliente frmCargo = new FrmTipoCliente())
                {
                    DialogResult dr = frmCargo.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_tipo_cliente.Text = frmCargo.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        txt_tipo_cliente.Text = frmCargo.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception asa)
            {
                //error
            }
        }


        void cargarComboxs()
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1))
            {
                MessageBox.Show("Favor llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tabla_direccion.RowCount < 0)
            {
                MessageBox.Show("Debe asignar al menos una direccion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InsertarPuesto();

        }


        private void cargarTabla(string condicion)
        {

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var empleado = from cli in db.CLIENTES
                                   join tCli in db.TIPOS_CLIENTES on cli.id_tipo_cliente equals tCli.id_tipo_cliente
                                   join ter in db.TERCEROS on cli.id_tercero equals ter.id_tercero
                                   join idenVS in db.TERCEROS_VS_IDENTIFICACIONES on ter.id_tercero equals idenVS.id_tercero
                                   join iden in db.IDENTIFICACIONES on idenVS.id_identificacion equals iden.id_identificacion
                                   select new
                                   {
                                       id_tercero = ter.id_tercero,
                                       id_cliente = cli.id_cliente,
                                       id_tipo_cliente = cli.id_tipo_cliente,
                                       tipo_cliente = tCli.tipo_cliente,
                                       tipo_identificacion = iden.id_tipo_identificacion,
                                       Nombre = ter.nombre,
                                       Cedula = iden.identificacion,
                                       Estado = cli.estado,
                                   };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        empleado = empleado.Where(em => em.Estado == true);
                    }
                    else
                    {
                        empleado = empleado.Where(em => em.Estado == true && (em.id_cliente.ToString().Contains(condicion) || em.Cedula.Contains(condicion)) || em.Nombre.Contains(condicion) || db.TIPOS_CLIENTES.FirstOrDefault(a => a.id_tipo_cliente == em.id_tipo_cliente).tipo_cliente.Contains(condicion) || db.TIPOS_CLIENTES.FirstOrDefault(a => a.id_tipo_cliente == em.id_tipo_cliente).descripcion.Contains(condicion));
                    }

                    if (empleado != null)
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
                        foreach (var emple in empleado.ToList())
                        {
                            dataGridView1.Rows.Add(
                             emple.id_tercero.ToString(),
                             emple.id_tipo_cliente.ToString(),
                             emple.tipo_identificacion.ToString(),
                             emple.id_cliente.ToString(),
                             emple.Nombre.ToString(),
                             emple.Cedula.ToString(),
                             emple.tipo_cliente.ToString(),
                             emple.Estado == true ? "ACTIVO" : "INACTIVO"
                            );
                        }
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }



        private void InsertarPuesto()
        {

            //try
            //{

                int tercero_t = 0;

                if (id_txt.Text.Trim() != "" || tercero.Trim() != "")
                    tercero_t = int.Parse(tercero);


                tercero_t = metodoscrud.crudTerceros(tercero_t.ToString(), txt_nombre.Text.Trim(), txt_cedula.Text.Trim());

                //Identificacion
                int id_tipoIdentificacion = cb_tipoIdent.SelectedIndex + 1;
                int id_identificacion = metodoscrud.crudIdentificaciones(txt_cedula.Text, id_tipoIdentificacion.ToString(), tercero_t.ToString());
                //Correo
                AsignarTelefonos(tercero_t);
                //Telefono
                AsignarCorreos(tercero_t);
                //Direccion
                AsignarDIreccion(tercero_t);


            if (metodoscrud.crudCliente(tercero_t.ToString(), txt_id_tipo_cliente.Text.Trim().ToString(), cb_estado.SelectedIndex == 0 ? true : false) > 0)
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Utilidades.LimpiarControles(this); 
                tercero = "";
                cargarTabla(""); clearTableAndMore();

            //}
            //catch (Exception dfg)
            //{
            //    // MessageBox.Show(lbl_titulo + " ERRORRRR");

            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    txt_id_tipo_cliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    cb_tipoIdent.SelectedIndex = (int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) - 1);
                    id_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txt_cedula.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txt_tipo_cliente.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;

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

        MetodosCRUD metodoscrud = new MetodosCRUD();

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

        private void txt_cedula_TextChanged(object sender, EventArgs e)
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
                            cb_tipoIdent.SelectedIndex = (db.IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == ide).id_tipo_identificacion - 1);

                        }
                    }
                }

            }
            catch (Exception asd)
            {

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > 0 && dataGridView1.SelectedRows.Count > 0)
                CargarCampos();
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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
           clearTableAndMore();
            cargarTabla("");
        }



        void clearTableAndMore()
        {
            tabla_correo.Rows.Clear();
            tabla_direccion.Rows.Clear();
            tabla_tel.Rows.Clear();
            txt_id_tipo_cliente.Text = "";
            txt_tipo_cliente.Text = "";
            txt_nombre.Text = "";
            txt_cedula.Text = "";
            id_txt.Text = "";
            tercero = "";
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_filtro.Text.Trim());
        }
    }
}
