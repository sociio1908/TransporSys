using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace _911_RD
{
    public partial class F_principal : Form
    {

        
        double latini = 19.4517;
        double lonini = -70.69703;


        public F_principal()
        {
            InitializeComponent();
            UseWaitCursor = true;

            webBrowser1.Navigate("https://www.google.com/maps/place/Santiago+De+Los+Caballeros/@19.4398316,-70.7430638,12z/data=!3m1!4b1!4m5!3m4!1s0x8eb1c5c838e5899f:0x75d4b059b8768429!8m2!3d19.4791963!4d-70.6930568");
            UseWaitCursor = false;

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            F_agenda f_Agenda = new F_agenda();
            f_Agenda.ShowDialog();
        }

        private void p_agenda2_Click(object sender, EventArgs e)
        {
            F_agenda f_Agenda = new F_agenda();
            f_Agenda.ShowDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }


        //filtro ciudad
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

 

        void CrearPuntero(double lat, double lng)
        {

            
      

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { 
            MessageBox.Show(webBrowser1.Url.ToString());
            }catch(Exception adsd)
            {

            }



        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_principal_Load(object sender, EventArgs e)
        {
            
        }
        

        private void gmap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Seleccion_Und seleccion_Und = new Seleccion_Und();
            var dialogResult = seleccion_Und.ShowDialog();

            if (dialogResult == DialogResult.OK )
            {
                MessageBox.Show(webBrowser1.Url.ToString());

            }

//            MessageBox.Show(webBrowser1.Url.ToString());
            
        }
    }
}
