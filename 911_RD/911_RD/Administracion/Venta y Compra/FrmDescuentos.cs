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
    public partial class FrmDescuentos : FrmBase
    {
        public FrmDescuentos()
        {
            InitializeComponent();
            cargarTabla();
            txt_filtro.Focus();
        }

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {

        }

        private void InsertarDescuento()
        {


            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {


                    if (id_txt.Text.Trim() == "")
                    {
                        DESCUENTOS des = new DESCUENTOS
                        {
                            id_empleado = Convert.ToInt32(txt_idemple.Text.Trim()),
                            fecha_inicial = date_inicio.Value.Date,
                            fecha_final = date_final.Value.Date,
                            descuento = Convert.ToDouble(txt_descuento.Text.Trim()),
                            estado = cb_estado.SelectedIndex == 0 ? true : false
                        };
                        db.DESCUENTOS.Add(des);
                    }
                    else
                    {

                        var des = db.DESCUENTOS.FirstOrDefault(a => a.id_descuento.ToString() == id_txt.Text.Trim());

                        if (des != null)
                        {
                            des.id_empleado = Convert.ToInt32(txt_idemple.Text.Trim());
                            des.fecha_inicial = date_inicio.Value.Date;
                            des.fecha_final = date_final.Value.Date;
                            des.descuento = Convert.ToDouble(txt_descuento.Text.Trim());
                            des.estado = cb_estado.SelectedIndex == 0 ? true : false;
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
                    var list = db.DESCUENTOS;
                    foreach (var Ouser in list)
                    {
                        dataGridView1.Rows.Add(Ouser.id_descuento.ToString(), Ouser.id_empleado.ToString(), Ouser.fecha_inicial.ToString(), Ouser.fecha_final.ToString(), Ouser.descuento.ToString(),
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
                txt_idemple.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                date_inicio.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                date_final.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_descuento.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
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
                    var des = from pro in db.DESCUENTOS
                              join cat in db.EMPLEADOS on pro.id_empleado
                      equals cat.id_empleado

                              select new
                              {
                                  //aqui cargas los campos de tu tabla
                                  pro.id_descuento,
                                  cat.id_empleado,
                                  pro.fecha_inicial,
                                  pro.fecha_final,
                                  pro.descuento,
                                  pro.estado


                                  //etc
                              };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        des = des.Where(pro => pro.estado == true);
                    }
                    else
                    {
                    }


                    des = des.Where(pro => pro.estado == true && (pro.id_descuento.ToString().Contains(condicion) || pro.fecha_inicial.ToString().Contains(condicion) || pro.fecha_final.ToString().Contains(condicion)));
                    string status;

                    foreach (var Ouser in des)
                    {
                        dataGridView1.Rows.Add(Ouser.id_descuento.ToString(), Ouser.id_empleado.ToString(), Ouser.fecha_inicial.ToString(), Ouser.fecha_final.ToString(), Ouser.descuento.ToString(),
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (FrmCliente frmunidad = new FrmCliente())
            {
                DialogResult dr = frmunidad.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //txt_idemple.Text = frmunidad.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(groupBox1, errorProvider1) == true)
            {

            }
            else
            {
                InsertarDescuento();
                id_txt.Text = "";
            }
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                this.DialogResult = DialogResult.OK;
        }
    }
}
