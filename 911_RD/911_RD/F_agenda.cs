using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _911_RD
{
    public partial class F_agenda : Form
    {
        public F_agenda()
        {
            InitializeComponent();
            _LlenarLista();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        void _LlenarLista(){

            List<string> Nombre = new List<string>();
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("BOMBERO LAS CANAS");
            Nombre.Add("POLICIA BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("BOMBERO MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("POLICIA LAS CANAS");
            Nombre.Add("BOMBERO BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("BOMBERO LAS CANAS");
            Nombre.Add("POLICIA BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("BOMBERO MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("POLICIA LAS CANAS");
            Nombre.Add("POLICIA BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("BOMBERO LAS CANAS");
            Nombre.Add("POLICIA BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("BOMBERO MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("POLICIA LAS CANAS");
            Nombre.Add("BOMBERO BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("POLICIA MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("BOMBERO LAS CANAS");
            Nombre.Add("POLICIA BASE");
            Nombre.Add("POLICIA PUNAL");
            Nombre.Add("POLICIA MOCA");
            Nombre.Add("BOMBERO MARILOPEZ");
            Nombre.Add("POLICIA BAITOA");
            Nombre.Add("POLICIA LAS CANAS");
            Nombre.Add("POLICIA BASE");
            List<string> Ubicacion = new List<string>();
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            Ubicacion.Add("PUNAL SANTIAGO");
            Ubicacion.Add("MOCA");
            Ubicacion.Add("MARILOPEZ SANTIAGO");
            Ubicacion.Add("BAITOA SANTIAGO");
            Ubicacion.Add("LAS CANAS LA  VEGA");
            Ubicacion.Add("BASE SANTIAGO");
            List<string> Contacto = new List<string>();
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");
            Contacto.Add("809-220-3577");
            Contacto.Add("809-633-3352");
            Contacto.Add("809-570-1245");
            Contacto.Add("809-213-2113");
            Contacto.Add("809-244-8363");
            Contacto.Add("809-220-0011");

 //  table.Columns.Add
               for (int a = 0; a < Contacto.Count; a++)
            {
               t_agenda.Rows.Add(Nombre[a], Ubicacion[a], Contacto[a]);
            }

            t_agenda.DataSource = table;
        }
        DataTable table ;
        private void txt_filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
