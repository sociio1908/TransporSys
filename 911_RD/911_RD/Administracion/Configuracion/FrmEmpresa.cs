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

namespace _911_RD.Administracion.Configuracion
{
    public partial class FrmEmpresa : FrmBase
    {
        public FrmEmpresa()
        {
            InitializeComponent();
             cargarTabla("");
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

                    var empresa = from cli in db.EMPRESA
                                  join ter in db.TERCEROS on cli.id_tercero equals ter.id_tercero
                                  join idenVS in db.TERCEROS_VS_IDENTIFICACIONES on ter.id_tercero equals idenVS.id_tercero
                                  join iden in db.IDENTIFICACIONES on idenVS.id_identificacion equals iden.id_identificacion
                                  select new
                                   {
                                       id_tercero = ter.id_tercero,
                                       id_empresa = cli.id_empresa,
                                       rnc = iden.identificacion,
                                       nombre = ter.nombre,
                                       lema = cli.lema,
                                       web = cli.pagina_web,
                                   };
                    //aqui vas a ver klk con lo que quieres filtrar
                     if (empresa != null)
                    {
                        foreach (var res in empresa.ToList()) {
                            tercero = res.id_tercero.ToString();
                            id_txt.Text = res.id_empresa.ToString();
                            txt_lema.Text = res.lema.ToString();
                            txt_nombre.Text = res.nombre.ToString();
                            txt_web.Text = res.web.ToString();
                            txt_rnc.Text = res.rnc.ToString();
                            cargarCorreos(res.id_tercero);
                            cargarDirecciones(res.id_tercero);
                            cargarTelefonos(res.id_tercero);

                        }
                    }
                }
            }
            catch (Exception ass)
            {
                //error
            }
        }

        private void InsertarPuesto()
        {
            try
            {
                int tercero_t = 0;

                if (id_txt.Text.Trim() != "" || tercero.Trim() != "")
                    tercero_t = int.Parse(tercero);

                tercero_t = metodoscrud.crudTerceros(tercero_t.ToString(), txt_nombre.Text.Trim(), txt_rnc.Text.Trim());

                //Identificacion
                int id_tipoIdentificacion = 2;
                int id_identificacion = metodoscrud.crudIdentificaciones(txt_rnc.Text, id_tipoIdentificacion.ToString(), tercero_t.ToString());
                //Correo
                AsignarTelefonos(tercero_t);
                //Telefono
                AsignarCorreos(tercero_t);
                //Direccion
                AsignarDIreccion(tercero_t);

                if (metodoscrud.crudEmpresa(tercero_t.ToString(), txt_web.Text.Trim().ToString().ToLower(), txt_lema.Text.Trim().ToString()) > 0)
                    MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Utilidades.LimpiarControles(this);
                cargarTabla("");

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }





        string tercero = "";
        string persona = "";


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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
        }

   

        private void tabla_correo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_direccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabla_tel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_tel, "id_telefono", "TERCEROS_VS_TELEFONOS");
        }

        private void tabla_direccion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_direccion, "id_direccion", "TERCEROS_VS_DIRECCIONES");
        }

        private void tabla_correo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            removerFila(tabla_correo, "id_email", "TERCEROS_VS_EMAILS");
        }
    }
}
