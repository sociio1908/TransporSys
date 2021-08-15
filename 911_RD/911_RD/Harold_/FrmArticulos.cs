using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BarcodeLib;

namespace _911_RD.Administracion
{
    public partial class FrmArticulos : _911_RD.Administracion.FrmBase
    {
        public FrmArticulos()
        {
            InitializeComponent();
            cargarTabla();
            txt_filtro.Focus();

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt_puesto_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                InsertarArticulo();
                id_txt.Text = "";
            }
        }
        private void CargarCampos()
        {
            try
            {


                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_nombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_des.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_stock.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_precio.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //txt_idcategoria.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                cb_estado.SelectedIndex = dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "ACTIVO" ? cb_estado.SelectedIndex = 0 : cb_estado.SelectedIndex = 1;
                txt_unidad.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txt_codBarra.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                codigo_de_barra();
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
                    var list = db.ARTICULOS;
                    foreach (var OArticulos in list)
                    {
                        dataGridView1.Rows.Add(OArticulos.id_articulo.ToString(), OArticulos.nombre.ToString(), OArticulos.descripcion.ToString(),
                            OArticulos.reorden.ToString(), OArticulos.precio.ToString(), OArticulos.CATEGORIAS.categoria.ToString(), status = OArticulos.estado == true ? "ACTIVO" : "INACTIVO", OArticulos.id_unidad_de_medida.ToString(), OArticulos.codigo_barras.ToString());
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
            try {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    //desactiva validar el id y ten pendiente que solo se va a usar para actualizar un producto

                    if (id_txt.Text.Trim() == "")
                    {
                        ARTICULOS art = new ARTICULOS
                        {
                            //ningun campo vacio
                            id_categoria = Convert.ToInt32(txt_idcategoria.Text.Trim()),  //debe existir en articulo
                            nombre = txt_nombre.Text.Trim(), //debe ser string
                            descripcion = txt_des.Text.Trim(),//debe ser string
                            reorden = Convert.ToDouble(txt_stock.Text.Trim()),//debe ser int
                            precio = Convert.ToDouble(txt_precio.Text.Trim()),
                            //imagen = (txt_foto.Text.Trim()), //debe ser string
                            codigo_barras = txt_codBarra.Text.Trim(), //debe ser string
                            estado = cb_estado.SelectedIndex == 0 ? true : false, //debe ser tru/false
                            id_unidad_de_medida = Convert.ToInt32(txt_unidad.Text.Trim())

                        };
                        db.ARTICULOS.Add(art);
                    }
                    else
                    {


                        //TODO TUYO CABALLO Dale !
                        //validamos que el articulo exista... SIEMPRE VA A EXISTIR, PORQUE?
                        //Pues porque ese txt_id solo va a estar lleno si cuando le doy click en la tabla se carga el dato...
                        //de lo contrario nunca estara lleno, pero validamos por si las moscas

                        //es int pero para no estar jodiendo convirtiendo el del txt lo hago directo, pero ese dato es int
                        var articulo = db.ARTICULOS.FirstOrDefault(a => a.id_articulo.ToString() == id_txt.Text.Trim());
                        // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                        if (articulo != null)
                        {

                            //pero aqui con ; porque es un objeto y no un tabla como alla arriba
                            articulo.id_categoria = Convert.ToInt32(txt_idcategoria.Text.Trim());  //debe existir en articulo
                            articulo.nombre = txt_nombre.Text.Trim(); //debe ser string
                            articulo.descripcion = txt_des.Text.Trim();//debe ser string
                            articulo.reorden = Convert.ToDouble(txt_stock.Text.Trim());//debe ser int
                                                                                       // articulo.imagen = (txt_foto.Text.Trim()); //debe ser string
                            articulo.codigo_barras = txt_codBarra.Text.Trim(); //debe ser string
                            articulo.estado = cb_estado.SelectedIndex == 0 ? true : false; //debe ser tru/false
                            articulo.precio = Convert.ToDouble(txt_precio.Text.Trim());
                            articulo.id_unidad_de_medida = Convert.ToInt32(txt_unidad.Text.Trim());
                        }
                    }
                    db.SaveChanges();
                    Utilidades.LimpiarControles(this);
                    cargarTabla();
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Utilidades.LimpiarControles(this);
            id_txt.Text = "";
            cargarTabla();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btn_imagen_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            using (FrmCategoria frmcategoria = new FrmCategoria())
            {
                DialogResult dr = frmcategoria.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txt_idcategoria.Text = frmcategoria.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            using (FrmUnidadesMD frmunidad = new FrmUnidadesMD())
            {
                DialogResult dr = frmunidad.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    txt_unidad.Text = frmunidad.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }
            }
        }

        private void codigo_de_barra()
        {
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            pnl_cod.BackgroundImage = codigo.Encode(BarcodeLib.TYPE.CODE128, txt_codBarra.Text, Color.Black, Color.White, 237, 70);

        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cod_valor = rnd.Next(1, 999999999);
            txt_codBarra.Text = cod_valor.ToString();
            using (TransporSysEntities db = new TransporSysEntities())
            {
                var articulo = db.ARTICULOS.FirstOrDefault(a => a.codigo_barras.ToString() == txt_codBarra.Text.Trim());
                // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                if (articulo != null)
                {
                    MessageBox.Show("Este codigo ya existe");
                }
                else
                {
                    codigo_de_barra();
                }
            }

        }

        private void txt_codBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LlenarDataGrid(txt_filtro.Text.Trim());

        }

        private void filtrar()
        {


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {

                var articulo = db.ARTICULOS.FirstOrDefault(a => a.id_articulo.ToString() == id_txt.Text.Trim());
                // si esa variable no esta vacia... pues el articulo existe y pues lo modificamos...
                if (articulo != null)
                {

                    articulo.estado = false; //debe ser tru/false

                }

                db.SaveChanges();
                Utilidades.LimpiarControles(this);
                cargarTabla();
            }

            MessageBox.Show("");

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }



        private void txt_filtro_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.Rows.Clear();
            LlenarDataGrid(txt_filtro.Text.Trim());
        }

        public void LlenarDataGrid(string condicion = "")
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var articulos = from pro in db.ARTICULOS
                                    join cat in db.CATEGORIAS on pro.id_categoria
                            equals cat.id_categoria
                                    join unidad_de_medida in db.UNIDADES_DE_MEDIDA on pro.id_unidad_de_medida
                           equals unidad_de_medida.id_unidad_de_medida
                                    select new
                                    {
                                        //aqui cargas los campos de tu tabla
                                        pro.id_articulo,
                                        pro.nombre,
                                        pro.descripcion,
                                        pro.reorden,
                                        pro.precio,
                                        cat.categoria,
                                        pro.estado,
                                        pro.id_unidad_de_medida,
                                        pro.codigo_barras,
                                        //etc
                                    };
                    //aqui vas a ver klk con lo que quieres filtrar
                    if (condicion.Equals(""))
                    {
                        articulos = articulos.Where(pro => pro.estado == true);
                    }
                    else
                    {
                        articulos = articulos.Where(pro => pro.estado == true && (pro.id_articulo.ToString().Contains(condicion) || pro.nombre.Contains(condicion) || pro.categoria.Contains(condicion)));
                    }


                    string status;
                    
                    foreach (var OArticulos in articulos)
                    {
                        dataGridView1.Rows.Add(OArticulos.id_articulo.ToString(), OArticulos.nombre.ToString(), OArticulos.descripcion.ToString(),
                            OArticulos.reorden.ToString(), OArticulos.precio.ToString(), OArticulos.categoria.ToString(), status = OArticulos.estado == true ? "ACTIVO" : "INACTIVO", OArticulos.id_unidad_de_medida.ToString(), OArticulos.codigo_barras.ToString());
                    }

                }
            }
            catch (Exception aas)
            {
                //Posible error
            }
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "stock")
                {
                    if (Convert.ToInt32(e.Value) <= 20)
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Orange;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.LightSkyBlue;
                    }
                }

                if (this.dataGridView1.Columns[e.ColumnIndex].Name == "estado")
                {
                    if (e.Value.ToString() == "ACTIVO")
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.LightPink;
                    }
                }
            }
            catch (Exception dfg)
            {

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CargarCampos();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
