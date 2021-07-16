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
                        cb_sexo.Items.Add(sEXOS.descripcion);
                    
                    }

                    var listN  = db.NACIONALIDADES;
                    foreach (var nACIONALIDADES in listN)
                    {
                        cb_nacionalidades.Items.Add(nACIONALIDADES.nacionalidad);
                    }

                    var listIden = db.TIPOS_IDENTIFICACIONES;
                    foreach (var identi in listIden)
                    {
                        cb_tipoIdent.Items.Add(identi.nombre);
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
            MessageBox.Show(validarCombo().ToString());


             if (Utilidades.ValidarFormulario(this, errorProvider1) || validarCombo()==false){
                MessageBox.Show("Favor llenar todos los campos.");
                return;
            }
            try
            {
                ////Method insert/Update
                //int id = metodoscrud.crudPersonas("", metodoscrud.crudTerceros(id_txt.Text, txt_nombre.Text.Trim(), txt_cedula.Text.Trim()).ToString(), Convert.ToInt32(cb_sexo.SelectedIndex).ToString(), fecha_nac.Value, Convert.ToInt32(cb_sexo.SelectedIndex).ToString(), txt_apellido.Text.Trim().ToString());
                //int ID_empleADO =  metodoscrud.crudEmpleado(txt_cedula.Text.Trim(), fecha_con.Value, cb_estado.SelectedIndex == 0 ? true : false, id_cargo);
                //if(conductor)
                //  //  metodoscrud.c



                MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE");
            }
            catch (Exception dfg)
            {

            }

        }

        private void InsertarEmpleado()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    //if (id_txt.Text.Trim() == "")
                    //{
                    //    EMPLEADOS eMPLEADOS = new EMPLEADOS
                    //    {
                    //        id = txt_puesto.Text.Trim(),
                    //        descripcion = txt_descripcion.Text.Trim(),
                    //        salario = Convert.ToDouble(txt_salario.Text.Trim()),
                    //        estado = cb_estado.SelectedIndex == 0 ? true : false
                    //    };

                    //    db.PUESTOS.Add(puesto);
                    //}
                    //else
                    //{
                    //    var puesto = db.PUESTOS.FirstOrDefault(a => a.id_puesto.ToString() == id_txt.Text.Trim());
                    //    if (puesto != null)
                    //    {
                    //        puesto.puesto = txt_puesto.Text.Trim();
                    //        puesto.descripcion = txt_descripcion.Text.Trim();
                    //        puesto.salario = Convert.ToDouble(txt_salario.Text.Trim());
                    //        puesto.estado = cb_estado.SelectedIndex == 0 ? true : false;
                    //    }
                    //}
                    //db.SaveChanges();
                }
                Utilidades.LimpiarControles(this);
              //  cargarTabla();
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        int id_cargo = 0;


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
                    txt_cargo.Text = frmCargo.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txt_des_puesto.Text = frmCargo.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txt_salario.Text = frmCargo.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    id_cargo = Convert.ToInt32(frmCargo.dataGridView1.CurrentRow.Cells[0].Value);

                    if (txt_cargo.Text.Trim().ToLower() == "conductor" || txt_cargo.Text.Trim().ToLower() == "chofer")
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
    }
}
