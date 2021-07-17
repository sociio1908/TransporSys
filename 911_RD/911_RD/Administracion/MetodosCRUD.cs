using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911_RD.Administracion
{
    class MetodosCRUD
    {

        //ME FALTA CONDUCTOR Y AHI PUEDO INSERTAR EMPLEADOOOOOOOOOOOOOOOS


        public int crudTerceros(string id_traido, string nombre_traido)
        {
            int id_result = 0;
            try
            {

                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.TERCEROS.FirstOrDefault(a => a.id_tercero.ToString() == id_traido.Trim());
                    if (terceroquery == null)
                    {
                        TERCEROS tercero = new TERCEROS
                        {
                            nombre = nombre_traido.Trim(),
                        };
                        db.TERCEROS.Add(tercero);
                        id_result = db.TERCEROS.Max(x => x.id_tercero);
                    }
                    else
                    {
                        terceroquery = db.TERCEROS.FirstOrDefault(a => a.id_tercero.ToString() == id_traido.Trim());
                        terceroquery.id_tercero = Convert.ToInt32(id_traido.Trim());
                        terceroquery.nombre = nombre_traido.Trim();
                        id_result = terceroquery.id_tercero;
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }

        public int crudIdentificaciones(string identificacion, string id_tipo, string id_tercero)
        {
            int id_result = 0, id_identificacion=0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    id_identificacion = db.TERCEROS_VS_IDENTIFICACIONES.FirstOrDefault(x => x.id_tercero.ToString() == id_tercero.Trim()).id_identificacion;

                    var terceroquery = db.IDENTIFICACIONES.FirstOrDefault(a => a.identificacion.ToString() == identificacion.Trim() || a.id_identificacion == id_identificacion);
                    if (terceroquery == null)
                    {
                        IDENTIFICACIONES ident = new IDENTIFICACIONES
                        {
                            id_tipo_identificacion = Convert.ToInt32(id_tipo.Trim()),
                            identificacion = identificacion.Trim(),
                        };
                        db.IDENTIFICACIONES.Add(ident);
                        id_result = db.IDENTIFICACIONES.Max(x => x.id_identificacion);
                    }
                    else
                    {
                        terceroquery.id_tipo_identificacion = Convert.ToInt32(id_tipo.Trim());
                        terceroquery.identificacion = identificacion.Trim();
                        id_result = terceroquery.id_identificacion;
                    }

                    if (id_identificacion == 0)
                    {
                        TERCEROS_VS_IDENTIFICACIONES tERCEROS_VS_IDENTIFICACIONES = new TERCEROS_VS_IDENTIFICACIONES
                        {
                            id_identificacion = id_result,
                            id_tercero = Convert.ToInt32(id_tercero.Trim()),
                        };
                        db.TERCEROS_VS_IDENTIFICACIONES.Add(tERCEROS_VS_IDENTIFICACIONES);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }

        public int crudPersonas(string id_ter_traido, string id_sex_traido, DateTime fecha_nac, string id_nac_traido, string apellido_traido)
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
                        id_result = db.PERSONAS.Max(x => x.id_persona);
                    }
                    else
                    {
                        terceroquery.id_sexo = Convert.ToInt32(id_sex_traido.Trim());
                        terceroquery.id_nacionalidad = Convert.ToInt32(id_nac_traido.Trim());
                        terceroquery.apellido = apellido_traido.Trim();
                        terceroquery.fecha_nacimiento = fecha_nac;
                        id_result = terceroquery.id_persona;
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

        public int crudEmpleado(string id_persona, DateTime fechaIngreso, bool estado, int id_puesto)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var empleado = db.EMPLEADOS.FirstOrDefault(a => a.id_persona.ToString() == id_persona);

                    if (empleado == null)
                    {
                        EMPLEADOS emp = new EMPLEADOS
                        {
                            id_persona = Convert.ToInt32(id_persona.Trim()),
                            id_puesto = id_puesto,
                            fecha_ingreso = fechaIngreso,
                            estado = true
                        };
                        db.EMPLEADOS.Add(emp);
                        id_result = db.EMPLEADOS.Max(x => x.id_empleado);
                    }
                    else
                    {
                        empleado.fecha_ingreso = fechaIngreso;
                        empleado.id_puesto = id_puesto;
                        empleado.estado = estado;
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

        public int crudCorre(string correo)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var correo_result = db.EMAILS.FirstOrDefault(a => a.email.ToString() == correo.Trim());
                    //    System.Diagnostics.Debug.WriteLine(terceroquery.nombre);
                    if (correo_result == null)
                    {
                        EMAILS tele = new EMAILS
                        {
                            email = correo.Trim(),
                        };
                        db.EMAILS.Add(tele);
                        id_result = db.EMAILS.Max(x => x.id_email);
                    }
                    else
                    {
                        id_result = correo_result.id_email;
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

        public int crudTelefono(string telefono)
        {

            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var tel_result = db.TELEFONOS.FirstOrDefault(a => a.telefono.ToString() == telefono.Trim());
                    //    System.Diagnostics.Debug.WriteLine(terceroquery.nombre);
                    if (tel_result == null)
                    {
                        TELEFONOS tele = new TELEFONOS
                        {
                            telefono = telefono.Trim(),
                        };
                        db.TELEFONOS.Add(tele);
                        id_result = db.TELEFONOS.Max(x => x.id_telefono);
                    }
                    else
                    {
                        id_result = tel_result.id_telefono;
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

        public int InsertarDireccion(string latitud_ , string longitud_ )
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var direc_result = db.DIRECCIONES.FirstOrDefault(a => a.latitud.ToString() == latitud_.Trim() && a.longitud.ToString() == longitud_.Trim());
                    //    System.Diagnostics.Debug.WriteLine(terceroquery.nombre);
                    if (direc_result == null)
                    {
                        DIRECCIONES direcciones = new DIRECCIONES
                        {
                            latitud = Convert.ToDouble(latitud_),
                            longitud = Convert.ToDouble(longitud_),
                        };
                        db.DIRECCIONES.Add(direcciones);
                        id_result = db.DIRECCIONES.Max(x => x.id_direccion);
                    }
                    else
                    {
                        id_result = direc_result.id_direccion;
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



    }
}
