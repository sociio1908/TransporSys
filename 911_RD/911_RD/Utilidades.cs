using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                            int cont = 0, letrasEncontradas=0;
                            foreach (char letra in obj.Text.Trim())
                            {

                                if(char.IsLetter(obj.Text.Trim(), cont)){
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
}
