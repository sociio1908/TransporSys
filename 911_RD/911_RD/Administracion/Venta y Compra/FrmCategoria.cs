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
    public partial class FrmCategoria : FrmBase
    {
        public FrmCategoria()
        {
            InitializeComponent();
            cargarTabla();
            txt_filtro.Focus();
        

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transporSysDataSet.CATEGORIAS' Puede moverla o quitarla según sea necesario.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();
        }
        private void CargarCampos()
        {
            try
            {

                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_descripcion.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(groupBox1, errorProvider1) == true)
            {

            }
            else
            {
                InsertarArticulo();
                id_txt.Text = "";
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
                    var list = db.CATEGORIAS;
                    foreach (var Ocategoria in list)
                    {
                        dataGridView1.Rows.Add(Ocategoria.id_categoria.ToString(), Ocategoria.categoria.ToString(), Ocategoria.descripcion.ToString(),
                            status = Ocategoria.estado == true ? "ACTIVO" : "INACTIVO");
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
            

            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {

                    if (txt_nombre.Text == "" || txt_descripcion.Text == "" || cb_estado.Text == "")
                    {
                        MessageBox.Show("NINGUN CAMPO PUEDE ESTAR VACIO");
                    }
                    else
                   if (id_txt.Text.Trim() == "")
                    {
                        CATEGORIAS cate = new CATEGORIAS
                        {
                            categoria = txt_nombre.Text.Trim(),
                            descripcion = txt_descripcion.Text.Trim(),
                            estado = cb_estado.SelectedIndex == 0 ? true : false
                        };
                        db.CATEGORIAS.Add(cate);
                    }
                    else
                    {

                        var categoria = db.CATEGORIAS.FirstOrDefault(a => a.id_categoria.ToString() == id_txt.Text.Trim());

                        if (categoria != null)
                        {
                            categoria.categoria = txt_nombre.Text.Trim();
                            categoria.descripcion = txt_descripcion.Text.Trim();
                            categoria.estado = cb_estado.SelectedIndex == 0 ? true : false;
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

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var categoria = from pro in db.CATEGORIAS
                                    join cat in db.CATEGORIAS on pro.id_categoria
                            equals cat.id_categoria
                                   
                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        pro.id_categoria,
 
                                        pro.descripcion,
                                     
                                        cat.categoria,
                                        pro.estado,
                                        
                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        categoria = categoria.Where(pro => pro.estado == true);
                    }
                    else
                    {
                        categoria = categoria.Where(pro => pro.estado == true && (pro.id_categoria.ToString().Contains(condicion) || pro.categoria.Contains(condicion)));
                    }


                    string status;

                    foreach (var Ocategoria in categoria)
                    {
                        dataGridView1.Rows.Add(Ocategoria.id_categoria.ToString(), Ocategoria.categoria.ToString(), Ocategoria.descripcion.ToString(),
                            status = Ocategoria.estado == true ? "ACTIVO" : "INACTIVO");
                    }


                }
            }
            catch (Exception aas)
            {
                //Posible error
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();
            LlenarDataGrid(txt_filtro.Text.Trim());
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}
