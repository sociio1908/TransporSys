﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _911_RD.Administracion.Direccion;

namespace _911_RD.Administracion
{
    public partial class FrmDireccionNativa : FrmBase
    {
        public FrmDireccionNativa()
        {
            InitializeComponent();
            cargar_combox("", "CONTINENTES");
            cargarTabla("", dataGridView1);
        }

        private void FrmDireccionNativa_Load(object sender, EventArgs e)
        {

        }

        private void bt_agregar_cont_Click(object sender, EventArgs e)
        {
            new FrmContinente().ShowDialog();
            cargar_combox("", "CONTINENTES");
        }

        private void bt_agregar_pais_Click(object sender, EventArgs e)
        {
            FrmPais fm = new FrmPais();
            fm.ShowDialog();
            cargar_combox((cb_continente.SelectedItem.ToString()), "PAISES");
        }


        MetodosCRUD metodosCRUD = new MetodosCRUD();

        private void btn_agregar_provincia_Click(object sender, EventArgs e)
        {
            FrmProvincia fm = new FrmProvincia();
            fm.ShowDialog();
            cargar_combox((cb_pais.SelectedItem.ToString()), "PROVINCIAS");
        }

        private void bt_agregar_ciu_Click(object sender, EventArgs e)
        {
            FrmCiudad fm = new FrmCiudad();
            fm.ShowDialog();
            cargar_combox((cb_pais.SelectedItem.ToString()), "PROVINCIAS");


        }

        void cargar_combox(string dato, string combo)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    switch (combo)
                    {
                        case "CONTINENTES":
                            cb_pais.Items.Clear();
                            cb_continente.Items.Clear();
                            cb_provincia.Items.Clear();
                            cb_ciudad.Items.Clear();
                            cb_pais.Text = "";
                            cb_provincia.Text = "";
                            cb_ciudad.Text = "";
                            var listS = db.CONTINENTES;
                            foreach (var cont in listS)
                            {
                                cb_continente.Items.Add(cont.continente.ToUpper());
                            }
                            break;
                        case "PAISES":
                            cb_pais.Items.Clear();
                            cb_provincia.Items.Clear();
                            cb_ciudad.Items.Clear();
                            cb_provincia.Text = "";
                            cb_ciudad.Text = "";
                            int id_con = db.CONTINENTES.FirstOrDefault(a => a.continente==dato).id_continente;
                            var listP = db.PAISES.Where(a => a.id_continente == id_con);
                            foreach (var pa in listP)
                            {
                                cb_pais.Items.Add(pa.pais.ToUpper());
                            }
                            break;
                        case "PROVINCIAS":
                            cb_provincia.Items.Clear();
                            cb_ciudad.Items.Clear();
                            cb_ciudad.Text = "";
                            int id_pa = db.PAISES.FirstOrDefault(a => a.pais == dato).id_pais;
                            var lis = db.PROVINCIAS.Where(a => a.id_pais == id_pa);
                            foreach (var pa in lis)
                            {
                                cb_provincia.Items.Add(pa.provincia.ToUpper());
                            }
                            break;
                        case "CIUDADES":
                            cb_ciudad.Items.Clear();
                            int id_pro = db.PROVINCIAS.FirstOrDefault(a => a.provincia == dato).id_provincia;
                            var lisc = db.CIUDADES.Where(a => a.id_provincia == id_pro);
                            foreach (var pa in lisc)
                            {
                                cb_ciudad.Items.Add(pa.ciudad.ToUpper());
                            }
                            break;

                        default:
                            //error
                            break;
                    }

           
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");

            }
        }

        private void cb_pais_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_pais.SelectedIndex >= 0)
            {
                cargar_combox(cb_pais.SelectedItem.ToString(), "PROVINCIAS");
                btn_agregar_provincia.Enabled = true;
            }
        }

        private void cb_continente_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (cb_continente.SelectedIndex >= 0)
            {
                cargar_combox(cb_continente.SelectedItem.ToString(), "PAISES");
                bt_agregar_pais.Enabled = true;
            }
        }

        private void cb_provincia_SelectedValueChanged(object sender, EventArgs e)
        {
         
            if (cb_provincia.SelectedIndex >= 0)
            {
                cargar_combox(cb_provincia.SelectedItem.ToString(), "CIUDADES");
                bt_agregar_ciu.Enabled = true;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            insertarDireccion();
            Utilidades.LimpiarControles(this);
            cargarTabla("",dataGridView1);
        }

        public string id_tercero="";

        void insertarDireccion()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1)==true || validarCombo()==false)
                    return;

                 int res  = metodosCRUD.InsertarDireccion(id_txt.Text, cb_ciudad.SelectedItem.ToString(), txt_id_calle.Text.Trim(), txt_num_casa.Text, txt_referencia.Text, id_tercero);
                
                if(res>0)
                    MessageBox.Show("Proceso exitoso");

            }
            catch (Exception ase)
            {



            }

        }

        bool validarCombo()
        {
            if (cb_ciudad.SelectedItem == null || cb_continente.SelectedItem == null || cb_pais.SelectedItem == null || cb_provincia.SelectedItem == null)
                return false;

            return true;
        }


        void cargarTabla(string condicion, DataGridView dataGrid)
        {

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    var direcciones = from dir in db.DIRECCIONES
                                      join ciu in db.CIUDADES on dir.id_ciudad equals ciu.id_ciudad
                                      join ca in db.CALLES on dir.id_calle equals ca.id_calle
                                      join provi in db.PROVINCIAS on ciu.id_provincia equals provi.id_provincia
                                      join pai in db.PAISES on provi.id_pais equals pai.id_pais
                                      join con in db.CONTINENTES on pai.id_continente equals con.id_continente
                                       select new
                                      {
                                           id_direccion = dir.id_direccion,
                                           referencia = dir.referencia,
                                           id_continente = con.id_continente,
                                           id_calle = dir.id_calle,
                                           calle = ca.nombre,
                                           num_casa = dir.num_casa,
                                           contienente = con.continente,
                                           id_provincia = provi.id_provincia,
                                           provincia = provi.provincia,
                                           id_ciudad = ciu.id_ciudad,
                                           ciudad = ciu.ciudad,
                                           id_pais = pai.id_pais,
                                           pais = pai.pais
                                       };

                    if (condicion.Equals("") == false)
                    {
                        direcciones = direcciones.Where(di => di.calle.ToString().Contains(condicion) || di.ciudad.Contains(condicion) || di.referencia.Contains(condicion) || di.num_casa.Contains(condicion));
                    }
                    if (direcciones != null)
                    {
                        //    MessageBox.Show("ENTRO");
                        dataGrid.Rows.Clear();
                       
                        dataGrid.Rows.Add("", "", "", "");
                        foreach (var dire in direcciones.ToList())
                        {   dataGrid.Rows.Add(
                             dire.id_direccion.ToString(),
                             dire.referencia.ToString(),
                             dire.id_continente.ToString(),
                             dire.contienente.ToString(),
                             dire.id_pais.ToString(),
                             dire.calle.ToString(),
                             dire.pais.ToString(),
                             dire.id_provincia.ToString(),
                             dire.provincia.ToString(),
                             dire.ciudad.ToString(),
                             dire.id_ciudad.ToString(),
                             dire.num_casa.ToString(),
                             dire.id_calle.ToString()
                            );
                        }
                    }
                    else
                    {
                        dataGrid.Visible = false;
                    }
                }
            }
            catch (Exception ass)
            {

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows.Count > 0) 
                this.DialogResult = DialogResult.OK;
 
        }

        private void txt_filtro_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
                cargarTabla(txt_filtro.Text.Trim(), dataGridView1);
        }




        private void CargarCampos()
        {
            try
            {


                id_txt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                txt_referencia.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                cargar_combox("", "CONTINENTES");
                cb_continente.SelectedIndex = cb_continente.FindString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

                txt_calle.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                cargar_combox(cb_continente.SelectedItem.ToString(), "PAISES");
                cb_pais.SelectedIndex = cb_pais.FindString(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());

                cargar_combox(cb_pais.SelectedItem.ToString(), "PROVINCIAS");
                cb_provincia.SelectedIndex = cb_provincia.FindString(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());

                cargar_combox(cb_provincia.SelectedItem.ToString(), "CIUDADES");
                cb_ciudad.SelectedIndex = cb_ciudad.FindString(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());

                txt_num_casa.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                txt_id_calle.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
               

           

             
            }
            catch (Exception ea)
            {
                //
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
              CargarCampos();
        }

        private void btn_calle_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmCalle frmMarca = new FrmCalle())
                {
                    DialogResult dr = frmMarca.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        txt_id_calle.Text = frmMarca.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        txt_calle.Text = frmMarca.dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
            cargarTabla("", dataGridView1);
        }
    }
}
