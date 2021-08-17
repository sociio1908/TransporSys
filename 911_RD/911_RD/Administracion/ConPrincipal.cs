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
    public partial class ConPrincipal : Form
    {
        public ConPrincipal()
        {
            InitializeComponent();
            CargarResumen();
        }

        void CargarResumen()
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                try
                {
                    lbl_veha.Text = db.VEHICULO.Count(a => a.id_vehiculo > 0).ToString();
                    lbl_cli.Text = db.CLIENTES.Count(a => a.id_cliente > 0).ToString();
                    lbl_pac.Text = db.PACIENTES.Count(a => a.id_paciente > 0).ToString();
                    lbl_con.Text = db.CONDUCTOR.Count(a => a.id_conductor > 0).ToString();
                }
                catch (Exception esf)
                {

                }
            };



        }
    }
    }
