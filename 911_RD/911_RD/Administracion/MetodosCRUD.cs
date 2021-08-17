
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


        public bool ValidarChasis_Placa(string campo)
        {
            bool id_result = false;

            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.VEHICULO.FirstOrDefault(a => a.num_chasis.ToString() == campo.Trim() || a.num_placa.ToString() == campo.Trim() || a.num_gps.ToString() == campo.Trim());
                    if (terceroquery != null)
                    {
                        return true;
                    }
                 
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }

        public Tuple<int, int> ValidarIdentificacion(string campo)
        {
            int id_result = 0;

            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.IDENTIFICACIONES.FirstOrDefault(a => a.identificacion.ToString() == campo.Trim());
                    if (terceroquery != null)
                    {
                        var m = db.TERCEROS_VS_IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == terceroquery.id_identificacion);
                        if (m!=null)
                       return Tuple.Create(id_result = m.id_tercero, id_result = m.id_identificacion);// return Tuple.Create(1, 2);
                    }
                }
            }
            catch (Exception asd)
            {

            }
            return Tuple.Create(id_result, 0);// return Tuple.Create(1, 2);
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

        public int crudPaciente(string id_paciente, string id_persona, string peso, string seguro, bool estadoT)
        {
            int id_result = 0;
            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.PACIENTES.FirstOrDefault(a => a.id_paciente.ToString() == id_paciente.Trim());
                    if (terceroquery == null)
                    { 
                        PACIENTES eMPLEADOS = new PACIENTES
                        {
                            id_persona = int.Parse(id_persona.Trim()),
                            peso = double.Parse(peso.Trim()),
                            num_seguro = seguro.Trim(), 
                            estado = true
                        };
                        db.PACIENTES.Add(eMPLEADOS);
                    }
                    else
                    {
                        terceroquery.id_persona = int.Parse(id_persona.Trim());
                        terceroquery.peso = double.Parse(peso.Trim());
                        terceroquery.num_seguro = seguro.Trim();
                        terceroquery.estado = true;
                        id_result = terceroquery.id_paciente;
                    }
                    db.SaveChanges(); if (terceroquery == null)
                        if (terceroquery == null)
                        {
                            id_result = db.PACIENTES.Max(x => x.id_paciente);
                        }
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }


        public int crudCliente(string id_tercero, string id_tipo, bool estadoT)
        {
            int id_result = 0;
            try
            {
                // TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.CLIENTES.FirstOrDefault(a => a.id_tercero.ToString() == id_tercero.Trim());
                    if (terceroquery == null)
                    {

                        CLIENTES eMPLEADOS = new CLIENTES
                        {
                            id_tercero = int.Parse(id_tercero.Trim()),
                            id_tipo_cliente = int.Parse(id_tipo.Trim()),
                            estado = true
                        };
                        db.CLIENTES.Add(eMPLEADOS);
                    }
                    else
                    {
                        terceroquery.id_tercero = int.Parse(id_tercero.Trim());
                        terceroquery.id_tipo_cliente = int.Parse(id_tipo.Trim());
                        terceroquery.estado = estadoT;
                        id_result = terceroquery.id_cliente;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.CLIENTES.Max(x => x.id_cliente);
                    }
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }
        public int crudEmpresa(string id_tercero, string web, string lema)
        {
            int id_result = 0;
            try
            {
                // TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.EMPRESA.FirstOrDefault(a => a.id_tercero.ToString() == id_tercero.Trim());
                    if (terceroquery == null)
                    {

                        EMPRESA eMPLEADOS = new EMPRESA
                        {
                            id_tercero = int.Parse(id_tercero.Trim()),
                            pagina_web = web.Trim(),
                            lema = lema.Trim(),
                        };
                        db.EMPRESA.Add(eMPLEADOS);
                    }
                    else
                    {
                        terceroquery.id_tercero = int.Parse(id_tercero.Trim());
                        terceroquery.pagina_web = web.Trim();
                        lema = lema.Trim();
                        id_result = terceroquery.id_empresa;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.EMPRESA.Max(x => x.id_empresa);
                    }
                }
            }
            catch (Exception asd)
            {

            }

            return id_result;
        }


        public int crudTerceros(string id_traido, string nombre_traido, string identificacion)
        {
            int id_result = 0;
            try
            {
                //TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int id = 0;
                    var iden = db.IDENTIFICACIONES.FirstOrDefault(a => a.identificacion.ToString() == identificacion.Trim());
                    int tercero = 0;
                    if (id_traido != "0")
                    {
                        tercero = db.TERCEROS_VS_IDENTIFICACIONES.FirstOrDefault(a => a.id_identificacion == iden.id_identificacion && a.id_tercero.ToString() == id_traido.Trim()).id_tercero;
                    }

                    if (tercero > 0)
                    {
                        id = tercero;
                    }
                    else
                    {
                        id = int.Parse(id_traido.Trim());
                    }


                    var terceroquery = db.TERCEROS.FirstOrDefault(a => a.id_tercero == id);
                    if (terceroquery == null)
                    {
                        TERCEROS terc = new TERCEROS
                        {
                            nombre = nombre_traido.Trim(),
                        };
                        db.TERCEROS.Add(terc);
                    }
                    else
                    {
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
                //System.Diagnostics.Debug.WriteLine("-----------ERROR: " + asd.ToString());

            }

            return id_result;
        }


        public DataTable buscarEmpleado(string identidicacion, string codigo){
            DataTable dt = new DataTable();
           

          






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
                if(id_tercero!=null)
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
                if (id_tercero != null)
                    crud_VS(int.Parse(id_tercero), id_result, "TERCEROS_VS_TELEFONOS", "id_telefono");
            }
            catch (Exception dfg)
            {
                // MessageBox.Show(lbl_titulo + " ERRORRRR");
            }
        }

        public int InsertarDireccion(string id_direccion, string id_ciudad, string id_calle, string casa, string referencia, string id_tercero)
        {
            int id_result = 0;
            try
            {
                using (TransporSysEntities db = new TransporSysEntities())
                {

                    int id_ciudad_int = db.CIUDADES.FirstOrDefault(a => a.ciudad.ToString() == id_ciudad.Trim()).id_ciudad;

                    var terceroquery = db.DIRECCIONES.FirstOrDefault(a => a.id_direccion.ToString() == id_direccion.Trim());
                    if (terceroquery == null)
                    {
                        DIRECCIONES dir = new DIRECCIONES
                        {
                            id_ciudad = id_ciudad_int,
                            id_calle = int.Parse(id_calle.Trim()),
                            num_casa = casa.Trim(),
                            referencia = referencia.Trim()

                        };
                        db.DIRECCIONES.Add(dir);
                    }
                    else
                    {
                        terceroquery.id_ciudad = id_ciudad_int;
                        terceroquery.id_calle = int.Parse(id_calle.Trim());
                        terceroquery.num_casa = casa.Trim();
                        terceroquery.referencia = referencia.Trim();
                        id_result = terceroquery.id_direccion;
                    }
                    db.SaveChanges();
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


        public void borrarVs(int id_tercero, int id_valor, string tabla, string campo)
        {
            try
            {
                Utilidades.conexion.Open();
                string delete = "Delete from " + tabla + " where id_tercero = " + id_tercero + " and " + campo + " = " + id_valor;
                System.Diagnostics.Debug.WriteLine("DELETE: " + delete.ToString());
                SqlCommand comando = new SqlCommand(delete, Utilidades.conexion);
                comando.ExecuteNonQuery();
                Utilidades.conexion.Close();
            }
            catch (Exception asd)
            {
                //error
            }
        }
        public void borrarVsGen(string id_campo1,string columna1, string id_campo2, string columna2, string tabla)
        {
            try
            {
                Utilidades.conexion.Open();
                string delete = "Delete from " + tabla + " where " + id_campo1 + " = " + columna1 + " and " + id_campo2 + " = " + columna2;
                System.Diagnostics.Debug.WriteLine("DELETE: " + delete.ToString());
                SqlCommand comando = new SqlCommand(delete, Utilidades.conexion);
                comando.ExecuteNonQuery();
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
