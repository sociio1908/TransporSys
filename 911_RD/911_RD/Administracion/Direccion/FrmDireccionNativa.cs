using System;
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
        }

        public string id_tercero="";

        void insertarDireccion()
        {
            try
            {
                if (Utilidades.ValidarFormulario(this, errorProvider1) && validarCombo()==false)
                    return;

             int res  = metodosCRUD.InsertarDireccion(id_txt.Text, cb_ciudad.SelectedItem.ToString(), txt_descripcion.Text, id_tercero);
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



    }
}
