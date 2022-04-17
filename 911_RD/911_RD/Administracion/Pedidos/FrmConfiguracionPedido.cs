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
    public partial class FrmConfiguracionPedido : FrmBase
    {
        public FrmConfiguracionPedido()
        {
            InitializeComponent();

            cb_estado.SelectedIndex = 0;
            cargarTabla("");

        } 

        private void InsertarConf()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) == true)
                    return;


                using (TransporSysEntities db = new TransporSysEntities())
                {
                    if (id_txt.Text.Trim() == "")
                    {
                        CONFIGURACION_PEDIDOS model = new CONFIGURACION_PEDIDOS
                        {
                            descripcion = txt_des.Text.Trim(),
                            estado = true
                        };

                        db.CONFIGURACION_PEDIDOS.Add(model);

                    }
                    else
                    {
                        var mod = db.CONFIGURACION_PEDIDOS.FirstOrDefault(a => a.id_configuracion.ToString() == id_txt.Text.Trim());
                        if (mod != null)
                        {
                            mod.descripcion = txt_des.Text.Trim();
                             mod.estado = cb_estado.SelectedIndex == 0 ? true : false;
                        }
                    }
                    db.SaveChanges();
                }
                Utilidades.LimpiarControles(this);
                cargarTabla("");
                MessageBox.Show("Proceso exitoso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }

        }

        private void CargarCampos()
        {
            try
            {
                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                 txt_des.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                 cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
            }
            catch (Exception ea)
            {
                //
            }
        }



        private void cargarTabla(string condicion)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                try
                {
                    dataGridView1.Rows.Clear();
                    var list = from mail in db.CONFIGURACION_PEDIDOS
                               select new
                               {
                                   id_conf = mail.id_configuracion,
                                   descripcion = mail.descripcion,
                                    estado = mail.estado
                               };
                    if (condicion.Trim() != "")
                    {
                        list = list.Where(a => a.descripcion.Contains(condicion) || a.id_conf.ToString().Contains(condicion));
                    }
                    dataGridView1.Rows.Add("", "", "");
                    foreach (var OPuestos in list)
                    {
                        dataGridView1.Rows.Add(OPuestos.id_conf.ToString(), OPuestos.descripcion.ToString(),
                             OPuestos.estado == true ? "ACTIVO" : "INACTIVO");
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            InsertarConf();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarCampos();
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            cargarTabla(txt_filtro.Text.Trim());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            cargarTabla("");
        }
    }
}
