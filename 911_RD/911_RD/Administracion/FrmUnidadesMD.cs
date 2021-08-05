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
    public partial class FrmUnidadesMD : FrmBase
    {
        public FrmUnidadesMD()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void FrmUnidadesMD_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Utilidades.ValidarFormulario(groupBox1, errorProvider1);
            InsertarArticulo();
        }

        private void CargarCampos()
        {
            try
            {

                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_unidad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_abreviatura.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }

            catch (Exception ea)
            {
                //
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
                    var list = db.UNIDADES_DE_MEDIDA;
                    foreach (var OUndMed in list)
                    {
                        dataGridView1.Rows.Add(OUndMed.id_unidad_de_medida.ToString(), OUndMed.unidad_de_medida.ToString(), OUndMed.descripcion.ToString(), OUndMed.abreviatura.ToString());
                    }
                }
                catch (Exception dfg)
                {
                    // MessageBox.Show(lbl_titulo + " ERRORRRR");

                }
            }
        }
        private void InsertarArticulo()
        {
            //if (Utilidades.ValidarFormulario(this,errorProvider1) == true)
            //    return;

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    if (txt_abreviatura.Text == "" || txt_descripcion.Text == "" || txt_unidad.Text == "")
                    {
                        MessageBox.Show("NINGUN CAMPO PUEDE ESTAR VACIO");
                    }
                    else
                    if (id_txt.Text.Trim() == "")
                    {
                        UNIDADES_DE_MEDIDA und_med = new UNIDADES_DE_MEDIDA
                        {
                            unidad_de_medida = txt_unidad.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                            abreviatura = txt_abreviatura.Text.Trim()

                        };
                        db.UNIDADES_DE_MEDIDA.Add(und_med);
                    }
                    else
                    {


                        //es int pero para no estar jodiendo convirtiendo el del txt lo hago directo, pero ese dato es int
                        var unidades = db.UNIDADES_DE_MEDIDA.FirstOrDefault(a => a.id_unidad_de_medida.ToString() == id_txt.Text.Trim());
                        // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                        if (unidades != null)
                        {

                            unidades.unidad_de_medida = txt_unidad.Text.Trim();
                            unidades.descripcion = txt_descripcion.Text.Trim();
                            unidades.abreviatura = txt_abreviatura.Text.Trim();


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

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            Utilidades.LimpiarControles(this);
            cargarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var categoria = from pro in db.UNIDADES_DE_MEDIDA
                                    join cat in db.UNIDADES_DE_MEDIDA on pro.id_unidad_de_medida
                            equals cat.id_unidad_de_medida

                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        pro.id_unidad_de_medida,
                                        pro.unidad_de_medida,
                                        pro.descripcion,

                                        
                                        pro.abreviatura,

                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                       
                    }
                    else
                    {
                        categoria = categoria.Where(pro => (pro.id_unidad_de_medida.ToString().Contains(condicion) || pro.unidad_de_medida.Contains(condicion)));
                    }


                    string status;

                    foreach (var OUndMed in categoria)
                    {

                        dataGridView1.Rows.Add(OUndMed.id_unidad_de_medida.ToString(), OUndMed.unidad_de_medida.ToString(), OUndMed.descripcion.ToString(), OUndMed.abreviatura.ToString());
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
    }
}
