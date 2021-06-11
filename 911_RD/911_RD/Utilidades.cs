using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _911_RD
{
    class Utilidades
    {


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
                        else
                        {
                            ErrorProvider.SetError(obj, "");
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
