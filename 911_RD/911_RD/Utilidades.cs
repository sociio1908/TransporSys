using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq; 
using System.Security.Cryptography;
using System.Text; 
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace _911_RD
{
    class Utilidades
    {
        //INGJERINELMENDO;initial catalog=TransporSys;integrated security=True;
        public static SqlConnection conexion = new SqlConnection("server=INGJERINELMENDO ; database=TransporSys ; integrated security = true");

        public static Tuple<string, string, Boolean> ExtraerDireccion(string link1)
        {
            Boolean listo = false;
            string latitud = null, longitud = null;
            try
            {
                char[] data = link1.ToCharArray();
                int coma = 0;

                for (int a = 0; a < data.Length; a++)
                {
                    if (data[a].ToString().Equals("@") || (coma > 0 && coma < 3))
                    {
                        if (coma == 1 && data[a].ToString() != (","))
                        {
                            latitud += data[a].ToString();
                        }
                        if (coma == 2 && data[a].ToString() != (","))
                        {
                            longitud += data[a].ToString();
                        }
                        if (data[a].ToString().Equals("@"))
                        {
                            coma++;
                        }
                        if (data[a].ToString().Equals(","))
                        {
                            coma++;
                        }
                    }
                }
                latitud.Trim();
                longitud.Trim();
                latitud.Replace(",", "");
                longitud.Replace(",", "");
                if ((latitud != null || latitud != "") && (longitud != null || longitud != ""))
                    listo = true;

            }
            catch (Exception er)
            {
                //error
            }

            return Tuple.Create(latitud, longitud, listo);
        }

        public static Boolean ValidarFormulario(Control objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayError = false;
            try
            {
                foreach (Control Item in objeto.Controls)
                {
                    if (Item is ErrorTxtBox)
                    {
                        ErrorTxtBox obj = (ErrorTxtBox)Item;
                        if (obj.Validar == true)
                        {
                            if (String.IsNullOrEmpty(obj.Text.Trim()))
                            {
                                ErrorProvider.SetError(obj, "No puede estar en blanco");
                                HayError = true;

                            }
                        }
                        if (obj.SoloNumeros == true)
                        {
                            int cont = 0, letrasEncontradas = 0;
                            foreach (char letra in obj.Text.Trim())
                            {

                                if (char.IsLetter(obj.Text.Trim(), cont)) {
                                    letrasEncontradas++;
                                }
                                cont++;
                            }
                            if (letrasEncontradas != 0)
                            {
                                HayError = true;
                                ErrorProvider.SetError(obj, "Solo numeros");
                            }
                        }

                    }

                }
            }
            catch (Exception er)
            {
                //error
            }
            return HayError;
        }

        public static bool mayorEdad(DateTime dateTime)
        {
            if (dateTime.AddYears(18) > DateTime.Today)
            {
                return false;
            }
            return true;
        }

        public static int idusuario = 0;
        public static String nomusuario = "";
        public static string puestouser = "";
        public static string Apeuser = "";

        public class Encrypt
        {
            public static string GetSHA256(string str)
            {
                SHA256 sha256 = SHA256Managed.Create();
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] stream = null;
                StringBuilder sb = new StringBuilder();
                stream = sha256.ComputeHash(encoding.GetBytes(str));
                for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
                return sb.ToString();
            }

        }

        public static int CalcularEdad(DateTime fechaNacimiento)
        {
            // Obtiene la fecha actual:
            DateTime fechaActual = DateTime.Today;

            // Comprueba que la se haya introducido una fecha válida; si 
            // la fecha de nacimiento es mayor a la fecha actual se muestra mensaje 
            // de advertencia:
            if (fechaNacimiento > fechaActual)
            {
                return -1;
            }
            else
            {
                int edad = fechaActual.Year - fechaNacimiento.Year;

                // Comprueba que el mes de la fecha de nacimiento es mayor 
                // que el mes de la fecha actual:
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }

                return edad;
            }
        }

        public static List<Suplidor> suplidores = new List<Suplidor>();

        public static void EnviarCorreo(int id_suplidor, string nom_articulo, string cantidad, string precio, string total)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                var sup = from supi in db.SUPLIDORES
                          join ter in db.TERCEROS on supi.id_tercero equals ter.id_tercero
                          join coVS in db.TERCEROS_VS_EMAILS on ter.id_tercero equals coVS.id_tercero
                          join co in db.EMAILS on coVS.id_email equals co.id_email
                          select new
                          {
                              id_suplidor = supi.id_suplidor,
                              nom_suplidor = ter.nombre,
                              correo = co.email,
                          };

                sup = sup.Where(pro => pro.id_suplidor == id_suplidor).OrderBy(f => f.id_suplidor).Take(1);
                System.Diagnostics.Debug.WriteLine("\nCorreo: " + sup.ToList()[0].correo);
                System.Diagnostics.Debug.WriteLine("\nSUPLDIOR: " + sup.ToList()[0].nom_suplidor); 


                // PEDIO AUTOMATICO LISTO --- ARREGLAR PEDIDO


                String servidor = "smtp.mail.yahoo.com";
                int puerto = 587;
                string Guser = "yeri.paulino@yahoo.es";
                string Gpass = "@Librealos25@";

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("TransporSys", Guser));
                message.To.Add(new MailboxAddress("Destino", sup.ToList()[0].correo));
                message.Subject = "Solicitud pedido";

                BodyBuilder bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = " <b>SOLICITUD PEDIDO PARA: " + sup.ToList()[0].nom_suplidor + "</b> <br>" +
                    "-----------------------------------------------------" +
                    "<br><b>Articulo: </b>" + nom_articulo +
                    " <br><b>Cantidad requerida: </b>" + cantidad +
                    " <br><b>Costo previsto RD$: </b>" + precio
                    + " <br>-----------------------------------------------------" +
                    " <br><b>TOTAL RD$: </b>" + total +
                    " <br>-----------------------------------------------------" +
                    " <br><b>NOTA IMPORTANTE:</b><br>CUALQUIER INQUIETUD QUE PERJUDIQUE EL PROCESO DE ESTE PEDIDO FAVOR " +
                    "CONTACTARNOS DE INMEDIATO." +
                    "<br><br><b>Numero de contacto: </b>" + "(809) 886-2933" +
                    "<br>Muchas gracias de antemeano.";

                message.Body = bodyBuilder.ToMessageBody();
                try
                {
                    using (var client = new SmtpClient())
                    {
                        client.Connect(servidor, puerto, MailKit.Security.SecureSocketOptions.StartTls);
                        client.CheckCertificateRevocation = false;
                        client.Authenticate(Guser, Gpass);
                        client.Send(message);
                        client.Disconnect(true);
                    }
                }

                catch (Exception except)
                {
                    Console.WriteLine("Error on sending mail : " + except.Message);
                }

            }
        }


            public static void LimpiarControles(System.Windows.Forms.Control forms)
            {
                try
                {
                    foreach (Control Item in forms.Controls)
                    {
                        if (Item is ErrorTxtBox obj)
                        {
                            if (obj.Limpiar)
                            {
                                obj.Text = "";
                            }
                        }
                        else if (Item is DataGridView dataGrid)
                        {
                            dataGrid.Rows.Clear();
                        }
                        else if (Item is ComboBox combox)
                        {
                            combox.SelectedIndex = 0;
                        }
                        else if (Item is NumericUpDown numeric)
                        {
                            numeric.Value = 0;
                        }
                        if (Item.Controls.Count > 0)
                        {
                            LimpiarControles(Item);
                        }

                    }

                }
                catch (Exception er)
                {
                    //error
                }


            }

            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll",
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter,
                string lpszClass, string lpszWindow);
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true,
                CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern bool SetWindowText(IntPtr hwnd, string lpString);
        }





        public class Suplidor
        {
            public int id_suplidor { get; set; }
            public double tiempo_entrega { get; set; }
            public double precio { get; set; }
            public double calificacion { get; set; }

        }
    }

