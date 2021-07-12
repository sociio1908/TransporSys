using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911_RD.Administracion
{
    class MetodosCRUD
    {
        public int crudTerceros(string id_traido, string nombre_traido, string identificacion_traida)
        {

           int id_result = 0;
            try {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.TERCEROS.FirstOrDefault(a => a.identificacion.ToString() == identificacion_traida.Trim());
                //    System.Diagnostics.Debug.WriteLine(terceroquery.nombre);
                    if (terceroquery == null) { 
                        TERCEROS tercero = new TERCEROS
                        {
                            nombre = nombre_traido.Trim(),
                            identificacion = identificacion_traida.Trim(),
                         };
                        db.TERCEROS.Add(tercero);
                    }
                    else
                    {
                      terceroquery.nombre = nombre_traido.Trim();
                      terceroquery.identificacion = identificacion_traida.Trim();
                    }
                    db.SaveChanges();
                    if (terceroquery == null) { 
                        id_result = db.TERCEROS.Max(x => x.id_tercero);
                    }
                    else
                    {
                        id_result = terceroquery.id_tercero;
                    }
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");
                }
             }
            catch(Exception aas)
            {
                System.Diagnostics.Debug.WriteLine("Hubo un error chulo. "+aas);
            }

            return id_result;
        }


    

        public int crudPersonas(string id_per_traido, string id_ter_traido, string id_sex_traido, DateTime fecha_nac ,string id_nac_traido, string apellido_traido)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.PERSONAS.FirstOrDefault(a => a.id_tercero.ToString() == id_ter_traido.Trim());
                    if (terceroquery == null)
                    {
                        PERSONAS persona = new PERSONAS
                        {
                            id_tercero = Convert.ToInt32(id_ter_traido.Trim()),
                            id_sexo = Convert.ToInt32(id_sex_traido.Trim()),
                            id_nacionalidad = Convert.ToInt32(id_nac_traido.Trim()),
                            apellido = apellido_traido.Trim(),
                            fecha_nacimiento = fecha_nac,
                        };
                        db.PERSONAS.Add(persona);
                    }
                    else
                    {
                        terceroquery = db.PERSONAS.FirstOrDefault(a => a.id_persona.ToString() == id_per_traido.Trim());

                        terceroquery.id_sexo = Convert.ToInt32(id_sex_traido.Trim());
                        terceroquery.id_nacionalidad = Convert.ToInt32(id_nac_traido.Trim());
                        terceroquery.apellido = apellido_traido.Trim();
                        terceroquery.fecha_nacimiento = fecha_nac;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.PERSONAS.Max(x => x.id_persona);
                    }
                    else
                    {
                        id_result = terceroquery.id_persona;
                    }
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");

                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return id_result;

        }

        public int crudEmpleado(string identificacion_traida, DateTime fechaIngreso, bool estado, int id_puesto)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    int tercero = db.TERCEROS.FirstOrDefault(a => a.identificacion.ToString() == identificacion_traida.Trim()).id_tercero;
                    int persona = db.PERSONAS.FirstOrDefault(a => a.id_tercero == tercero).id_persona;
                    var empleado = db.EMPLEADOS.FirstOrDefault(a => a.id_persona == persona);

                    if (empleado == null)
                    {
                        EMPLEADOS emp = new EMPLEADOS
                        {
                            id_persona = persona,
                            id_puesto = id_puesto,
                            fecha_ingreso = fechaIngreso,
                            estado = true
                        };
                        db.EMPLEADOS.Add(emp);
                    }
                    else
                    {
                        empleado.fecha_ingreso = fechaIngreso;
                        empleado.id_puesto = id_puesto;
                        empleado.estado = estado;
                    }
                    if (empleado == null)
                    {
                        id_result = db.EMPLEADOS.Max(x => x.id_empleado);
                    }
                    else
                    {
                        id_result = empleado.id_empleado;
                    }
                    db.SaveChanges();

                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");

                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return id_result;

        }

        public void crudCorre(string correo)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var email_result = db.EMAILS.FirstOrDefault(a => a.email.ToString() == correo.Trim());
                    if (email_result == null)
                    {
                        EMAILS emails = new EMAILS
                        {
                            email = correo.Trim()
                        };
                        db.EMAILS.Add(emails);
                    }
                    else
                    {
                        email_result.email = correo.Trim();
                    }
                    db.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");

                }
            }
            catch (Exception aas)
            {
                System.Diagnostics.Debug.WriteLine("Hubo un error chulo. " + aas);
            }

        }

        public void crudTelefono(string telefono)
        {
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var tel_result = db.TELEFONOS.FirstOrDefault(a => a.telefono.ToString() == telefono.Trim());
                    if (tel_result == null)
                    {
                        TELEFONOS tel = new TELEFONOS
                        {
                            telefono = telefono.Trim()
                        };
                        db.TELEFONOS.Add(tel);
                    }
                    else
                    {
                        telefono = telefono.Trim();
                    }
                    db.SaveChanges();
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");

                }
            }
            catch (Exception aas)
            {
                System.Diagnostics.Debug.WriteLine("Hubo un error chulo. " + aas);
            }

        }

        public List<string> AsignarPaises(string continente)
        {
            List<string> result = new List<string>();

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int id_cont = db.CONTINENTES.FirstOrDefault(a => a.continente == continente).id_continente;
                    //   MessageBox.Show("ID: "+id_cont);
                    if (id_cont < 0)
                        return result = null;

                    var paises = db.PAISES.Where(a => a.id_continente == id_cont);
                    //       MessageBox.Show(paises.ToString());
                    if (paises != null)
                    {
                        foreach (var a in paises)
                        {
                            result.Add(a.pais);
                            //MessageBox.Show(a.pais.ToString());
                        }
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return result;
        }

        public List<string> AsignarProvincias(string pais)
        {
            List<string> result = new List<string>();
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int id_p = db.PAISES.FirstOrDefault(a => a.pais == pais).id_pais;
                    //   MessageBox.Show("ID: "+id_cont);
                    if (id_p < 0)
                        return result = null;

                    var provincias = db.PROVINCIAS.Where(a => a.id_pais == id_p);
                    //       MessageBox.Show(paises.ToString());
                    if (provincias != null)
                    {
                        foreach (var a in provincias)
                        {
                            result.Add(a.provincia);
                            //MessageBox.Show(a.pais.ToString());
                        }
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return result;
        }
       
        public List<string> AsignarCiudad(string provincia)
        {
            List<string> result = new List<string>();

            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int id_provincia = db.PROVINCIAS.FirstOrDefault(a => a.provincia == provincia).id_provincia;
                    //   MessageBox.Show("ID: "+id_cont);
                    if (id_provincia < 0)
                        return result = null;

                    var ciudades = db.CIUDADES.Where(a => a.id_provincia == id_provincia);
                    //       MessageBox.Show(paises.ToString());
                    if (ciudades != null)
                    {
                        foreach (var a in ciudades)
                        {
                            result.Add(a.ciudad);
                            //MessageBox.Show(a.pais.ToString());
                        }
                    }
                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return result;
        }

        public int InsertarDireccion(string id_direc, string direccion, string id_ciudad)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var direc_result = db.DIRECCIONES.FirstOrDefault(a => a.id_direccion.ToString() == id_direc.Trim());
                    //    System.Diagnostics.Debug.WriteLine(terceroquery.nombre);
                    if (direc_result == null)
                    {
                        DIRECCIONES direcciones = new DIRECCIONES
                        { 
                            id_ciudad = Convert.ToInt32(id_ciudad),
                            direccion = direccion.Trim(),
                        };
                        db.DIRECCIONES.Add(direcciones);
                    }
                    else
                    {
                        direc_result.id_ciudad = Convert.ToInt32(id_ciudad);
                        direc_result.direccion = direccion.Trim();
                    }
                    db.SaveChanges();
                    if (direc_result == null)
                    {
                        id_result = db.DIRECCIONES.Max(x => x.id_direccion);
                    }
                    else
                    {
                        id_result = db.DIRECCIONES.FirstOrDefault(a => a.id_direccion.ToString() == id_direc.Trim()).id_direccion;
                    }
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");

                }
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

            return id_result;
        }



    }
}
