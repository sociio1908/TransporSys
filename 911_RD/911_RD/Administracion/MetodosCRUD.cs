



using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace _911_RD.Administracion
{
    class MetodosCRUD
    {

        //ME FALTA CONDUCTOR Y AHI PUEDO INSERTAR EMPLEADOOOOOOOOOOOOOOOS

        public int crudConductor(string id_empleado, string num_licencia, DateTime fecha_vencimiento)
        {
            int id_result = 0;
            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.CONDUCTOR.FirstOrDefault(a => a.id_empleado.ToString() == id_empleado.Trim());
                    if (terceroquery == null)
                    {
                        CONDUCTOR empleado = new CONDUCTOR
                        {
                            id_empleado = int.Parse(id_empleado.Trim()),
                            num_licencia = int.Parse(num_licencia.Trim()),
                            fecha_vencimiento = fecha_vencimiento,
                        };
                        db.CONDUCTOR.Add(empleado);
                    }
                    else
                    {
                        terceroquery.id_empleado = int.Parse(id_empleado.Trim());
                        terceroquery.num_licencia = int.Parse(num_licencia.Trim());
                        terceroquery.fecha_vencimiento = fecha_vencimiento;
                        id_result = terceroquery.id_conductor;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.CONDUCTOR.Max(x => x.id_conductor);
                    }
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }

        public int crudEmpleado(string id_puesto, string id_persona, DateTime fecha, bool estadoT)
        {
            int id_result = 0;
            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.EMPLEADOS.FirstOrDefault(a => a.id_persona.ToString() == id_persona.Trim());
                    if (terceroquery == null)
                    {

                        EMPLEADOS eMPLEADOS = new EMPLEADOS
                        {
                            id_persona = int.Parse(id_persona.Trim()),
                            id_puesto = int.Parse(id_puesto.Trim()),
                            fecha_ingreso = fecha,
                            estado = true,
                        };
                        db.EMPLEADOS.Add(eMPLEADOS);
                    }
                    else
                    {
                        terceroquery.id_persona = int.Parse(id_persona.Trim());
                        terceroquery.id_puesto = int.Parse(id_puesto.Trim());
                        terceroquery.fecha_ingreso = fecha;
                        terceroquery.estado = estadoT;
                        id_result = terceroquery.id_empleado;
                    }
                    db.SaveChanges(); if (terceroquery == null)
                        if (terceroquery == null)
                        {
                            id_result = db.EMPLEADOS.Max(x => x.id_empleado);
                        }
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }

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
                    }
                    else
                    {
                        terceroquery.id_tercero = int.Parse(id_traido.Trim());
                        terceroquery.nombre = nombre_traido.Trim();
                        id_result = terceroquery.id_tercero;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.TERCEROS.Max(x => x.id_tercero);
                    }

                }
            }
            catch (Exception asd)
            {
                Console.WriteLine("ERROR: " + asd);
            }

            return id_result;
        }




        public DataTable buscarEmpleado(string identidicacion, string codigo){
            DataTable dt = new DataTable();
            //try
            //{
            //    // List<string> Empleados = new List<string>();

                Utilidades.conexion.Open();
                var query = "SELECT ter.id_tercero as ID_TERCERO, per.id_persona as ID_PERSONA, emp.id_empleado as ID_EMPLEADO, ter.nombre +' '+per.apellido as NOMBRE_COMPLETO, per.fecha_nacimiento as FECHANACIMIENTO, sex.descripcion as SEXO, " +
                        " nac.nacionalidad as NACIONALIDAD, iden.identificacion as IDENTIFICACION, tipo_iden.nombre as TIPO_IDENTIFICACION," +
                        " emp.fecha_ingreso as FECHACONTRATO, pue.puesto as PUESTO, pue.salario as SUELDO, tel.telefono as TELEFONO, cor.email as EMAIL, dir.latitud as LATITUD, dir.longitud as LONGITUD" +
                        " from TERCEROS ter " +
                        " inner join PERSONAS per on ter.id_tercero = per.id_tercero " +
                        " inner join SEXOS sex on per.id_sexo = sex.id_sexo  " +
                        " inner join NACIONALIDADES nac on per.id_nacionalidad = nac.id_nacionalidad " +
                        " inner join TERCEROS_VS_IDENTIFICACIONES idenVS on ter.id_tercero = idenVS.id_tercero " +
                        " inner join IDENTIFICACIONES iden on idenVS.id_identificacion = iden.id_identificacion " +
                        " inner join TIPOS_IDENTIFICACIONES tipo_iden on iden.id_tipo_identificacion = tipo_iden.id_tipo_identificacion " +
                        " inner join TERCEROS_VS_DIRECCIONES dirVS on ter.id_tercero = dirVS.id_tercero " +
                        " inner join DIRECCIONES dir on dirVS.id_direccion = dir.id_direccion " +
                        " inner join TERCEROS_VS_EMAILS corVS on ter.id_tercero = corVS.id_tercero " +
                        " inner join EMAILS cor on corVS.id_email = cor.id_email " +
                        " inner join TERCEROS_VS_TELEFONOS telVS on ter.id_tercero = telVS.id_tercero " +
                        " inner join TELEFONOS tel on telVS.id_telefono = tel.id_telefono " +
                        " inner join EMPLEADOS emp on per.id_persona = emp.id_persona " +
                        " inner join PUESTOS pue on emp.id_puesto = pue.id_puesto";


                SqlCommand comandoSelect = new SqlCommand(query, Utilidades.conexion);

                SqlDataAdapter adap = new SqlDataAdapter(comandoSelect);
                    adap.Fill(dt);
                Utilidades.conexion.Close();
                return dt;
               

            //}

            //catch (Exception aas)
            //{
            //    //Posible error
            //}
            return dt;
        }

        public int crudIdentificaciones(string identificacion, string id_tipo, string id_tercero)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.IDENTIFICACIONES.FirstOrDefault(a => a.identificacion.ToString() == identificacion.Trim());
                    if (terceroquery == null)
                    {
                        IDENTIFICACIONES ident = new IDENTIFICACIONES
                        {
                            
                            id_tipo_identificacion = int.Parse(id_tipo.Trim()),
                            identificacion = identificacion.Trim(),
                        };
                        db.IDENTIFICACIONES.Add(ident);
                    }
                    else
                    {
                        terceroquery.id_tipo_identificacion = int.Parse(id_tipo.Trim());
                        terceroquery.identificacion = identificacion.Trim();
                        id_result = terceroquery.id_identificacion;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                       id_result = db.IDENTIFICACIONES.Max(x => x.id_identificacion);

                }
                crud_VS(int.Parse(id_tercero), id_result, "TERCEROS_VS_IDENTIFICACIONES", "id_identificacion");
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
                            id_tercero = int.Parse(id_ter_traido.Trim()),
                            id_sexo = int.Parse(id_sex_traido.Trim()),
                            id_nacionalidad = int.Parse(id_nac_traido.Trim()),
                            apellido = apellido_traido.Trim(),
                            fecha_nacimiento = fecha_nac,
                        };
                        db.PERSONAS.Add(persona);
                    }
                    else
                    {
                        terceroquery.id_sexo = int.Parse(id_sex_traido.Trim());
                        terceroquery.id_nacionalidad = int.Parse(id_nac_traido.Trim());
                        terceroquery.apellido = apellido_traido.Trim();
                        terceroquery.fecha_nacimiento = fecha_nac;
                        id_result = terceroquery.id_persona;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.PERSONAS.Max(x => x.id_persona);
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

        public void crudCorreo(string id_correo, string correo, string id_tercero)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.EMAILS.FirstOrDefault(a => a.email.ToString() == correo.Trim());
                    if (terceroquery == null)
                    {
                        EMAILS core = new EMAILS
                        {
                            email = correo.Trim(),
                        };
                        db.EMAILS.Add(core);
                    }
                    else
                    {
                        terceroquery.email = correo.Trim();
                        id_result = terceroquery.id_email;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.EMAILS.Max(x => x.id_email);
                    }
                  
                }
                crud_VS(int.Parse(id_tercero), id_result, "TERCEROS_VS_EMAILS", "id_email");

            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }

        }

        public void crudTelefono(string id_telefono, string telefono, string id_tercero)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.TELEFONOS.FirstOrDefault(a => a.telefono.ToString() == telefono.Trim());
                    if (terceroquery == null)
                    {
                        TELEFONOS core = new TELEFONOS
                        {
                                
                            telefono = telefono.Trim(),
                            id_tipo_telefono =1,
                        };
                        db.TELEFONOS.Add(core);
                    }

                    else
                    {
                        terceroquery.id_tipo_telefono = 3;
                        id_result = terceroquery.id_telefono;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.TELEFONOS.Max(x => x.id_telefono);
                    }
                }
                crud_VS(int.Parse(id_tercero), id_result, "TERCEROS_VS_TELEFONOS", "id_telefono");
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }
        }

        public int InsertarDireccion(string latitud_, string longitud_, string id_tercero)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.DIRECCIONES.FirstOrDefault(a => a.latitud.ToString() == latitud_.Trim() && a.longitud.ToString() == longitud_.Trim());
                    if (terceroquery == null)
                    {
                        DIRECCIONES core = new DIRECCIONES
                        {
                            
                            latitud = Convert.ToDouble(latitud_),
                            longitud = Convert.ToDouble(longitud_),
                        };
                        db.DIRECCIONES.Add(core);
                        db.SaveChanges();
                    }
                    else
                    {
                        id_result = terceroquery.id_direccion;
                    }
                    if (terceroquery == null)
                    {
                        id_result = db.DIRECCIONES.Max(x => x.id_direccion);
                    }

                }
                if (id_tercero.Trim() != "")
                    crud_VS(int.Parse(id_tercero), id_result, "TERCEROS_VS_DIRECCIONES", "id_direccion");
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }
            return id_result;
        }

        public void crud_VS(int id_tercero, int id_valor, string tabla, string campo)
        {
            try
            {
               Utilidades.conexion.Open();
                if(campo== "id_identificacion")
                {
                    string delete = "Delete from " + tabla + " where id_tercero = " + id_tercero + " and " + campo + " = " + id_valor;
                    System.Diagnostics.Debug.WriteLine("DELETE: " + delete.ToString());
                    SqlCommand comando = new SqlCommand(delete, Utilidades.conexion);
                    comando.ExecuteNonQuery();
                }
                var cadenaSelect = "Select  ISNULL( id_tercero  , 0)  as id_tercero from " + tabla + " where id_tercero = " + id_tercero + " and " + campo + " = " + id_valor;
                System.Diagnostics.Debug.WriteLine("SELECT: " + cadenaSelect.ToString());
                SqlCommand comandoSelect = new SqlCommand(cadenaSelect, Utilidades.conexion);

                var resul = comandoSelect.ExecuteScalar();

                if (resul ==null )
                {
                    string cadena_insert = "insert into " + tabla + " ( id_tercero," + campo + ") values (" + id_tercero + "," + id_valor + ")";
                    System.Diagnostics.Debug.WriteLine("insert: " + cadena_insert);
                    SqlCommand comando = new SqlCommand(cadena_insert, Utilidades.conexion);
                    comando.ExecuteNonQuery();
                }
                Utilidades.conexion.Close();
            }
            catch (Exception asd)
            {
                //error
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

    }
}
