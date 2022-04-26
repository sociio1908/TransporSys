﻿
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using static _911_RD.Utilidades;

namespace _911_RD.Administracion
{
    class MetodosCRUD
    {

        public int HacerPedido(int id_suplidor, int id_articulo )
        { 
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    try
                    {
                    var art = db.ARTICULOS.FirstOrDefault(x => x.id_articulo == id_articulo); 
                    double total; 
                    var sup = Utilidades.suplidores.FirstOrDefault(f => f.id_suplidor== id_suplidor);

                    total = double.Parse(sup.precio.ToString()) * double.Parse(art.recompra.ToString()); 
                        PEDIDOS comp = new PEDIDOS
                        {
                            id_suplidor = id_suplidor,
                            total = total,
                            creado = DateTime.Now,
                            estado = 0,
                        };
                        db.PEDIDOS.Add(comp);
                        db.SaveChanges();
                        insertarDetallePedido(id_articulo, double.Parse(art.recompra.ToString()), sup.precio);
                    Utilidades.EnviarCorreo(id_suplidor, art.nombre, art.recompra.ToString(), sup.precio.ToString(), total.ToString());
                         return 1;
                    }
                    catch (Exception sds) {
                }
            } 
            return 0;
        }  

        public int LlenarSuplidor(int id_articulo)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                var suplidor = from pro in db.ARTICULOS
                               join Dped in db.DETALLES_PEDIDOS on pro.id_articulo equals Dped.id_articulo
                               join ped in db.PEDIDOS on Dped.num_pedido equals ped.num_pedido
                               join sup in db.SUPLIDORES on ped.id_suplidor equals sup.id_suplidor 
                                select new
                                { 
                                    ped.num_pedido,
                                    pro.id_articulo,  
                                    pro.recompra, 
                                    sup.id_suplidor,
                                    Dped.precio,
                                    fechai = ped.creado,
                                    fechaf = ped.fechaEntrega, 
                                };
                //filtro 
                suplidor = suplidor.Where(pro => pro.id_articulo == id_articulo).OrderBy(f => f.id_suplidor);
                if(suplidor==null)
                    return 0;

                foreach (var OArticulos in suplidor.ToList())
                {
                    double Upre = 0;

                    //ultimo pedido de ese suplidor en este articulo
                    var nump = db.PEDIDOS
                           .Where(x => x.id_suplidor == OArticulos.id_suplidor && x.estado== 1)
                             .OrderByDescending(x => x.num_pedido)
                             .Take(1); 

                    foreach (var d in nump)
                    {
                        if(OArticulos.num_pedido == d.num_pedido)
                        {  
                            
                            //precio
                            Upre = db.DETALLES_PEDIDOS.FirstOrDefault(x => x.num_pedido == d.num_pedido).precio; 
                            DateTime datef;
                            //Tiempo en minutos de entrega 
                            datef = DateTime.Parse(d.fechaEntrega.ToString());
                            double time = CalcularTiempo(d.creado, datef);  
                            Suplidor suplidor1 = new Suplidor();
                            suplidor1.id_suplidor = d.id_suplidor;
                            suplidor1.precio = Upre;
                            suplidor1.tiempo_entrega = time;
                            suplidor1.calificacion = 0;
                            Utilidades.suplidores.Add(suplidor1);
                        } 
                     }
                } 
                if (Utilidades.suplidores.Count > 0)
                {
                    string res = ValidarPrioridad(id_articulo);
                    if (res != null){
                        int id_sup = SacarSuplidor(res);
                        if (id_sup > 0)
                        {
                            if(HacerPedido(id_sup, id_articulo)==1)
                            {
                                return 1;
                            }
                        }
                    }
                } 
            }
            return 0;
        }  

        public string ValidarPrioridad(int id_articulo)
        { 
            using (TransporSysEntities db = new TransporSysEntities())
            {
                var config = from art in db.ARTICULOS
                               join ac in db.ARTICULOS_VS_CONFIGURACION_PEDIDO on art.id_articulo equals ac.id_articulo
                               join c in db.CONFIGURACION_PEDIDOS on ac.id_configuracion equals c.id_configuracion
                               select new
                               {
                                    art.id_articulo,
                                    ac.id_configuracion,
                                    c.descripcion,
                                    ac.num_prioridad,
                               };
                //filtro
                config = config.Where(pro => pro.id_articulo == id_articulo).OrderBy(f => f.num_prioridad); 
                 if(config==null)
                    return null;

                foreach (var OArticulos in config.ToList())
                { 
                    if (OArticulos.num_prioridad==1)
                    {
                        return OArticulos.descripcion;
                    }
                }
            }
            return null;
          }

        public int SacarSuplidor(string prioridad)
        {
            //metodo validando orden
            if (prioridad == "Precio")
            {
                var sup = Utilidades.suplidores.ToList().OrderBy(f => f.precio).Take(1);

                foreach (var OArticulos in sup)
                {
                    return OArticulos.id_suplidor;
                }
            }
            if (prioridad == "Tiempo entrega")
            {
                var sup = Utilidades.suplidores.ToList().OrderBy(f => f.tiempo_entrega).Take(1);

                foreach (var OArticulos in sup)
                {
                    return OArticulos.id_suplidor;
                }
            }
            return 0;
        }

        public double CalcularTiempo(DateTime ini, DateTime fin)
                { 
                       return (fin - ini).TotalMinutes;
                } 


        int numP;
        public void insertarDetallePedido(int id_articulo, double cant, double prec)
        {
            using (TransporSysEntities db = new TransporSysEntities())
            {
                numP = db.PEDIDOS.Max(j => j.num_pedido);

                    DETALLES_PEDIDOS Dpedido = new DETALLES_PEDIDOS
                    {
                        num_pedido = numP,
                        id_articulo = id_articulo,
                        cantidad = cant,
                        precio = prec,
                    };
                    db.DETALLES_PEDIDOS.Add(Dpedido);
                  db.SaveChanges(); 
            }
        }

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

        public int crudSuplidor(string id_tercero, string id_tipo, bool estadoT)
        {
            int id_result = 0;
            try
            {
                // TransporSysEntities
                using (TransporSysEntities db = new TransporSysEntities())
                {
                    var terceroquery = db.SUPLIDORES.FirstOrDefault(a => a.id_tercero.ToString() == id_tercero.Trim());
                    if (terceroquery == null)
                    {

                        SUPLIDORES eMPLEADOS = new SUPLIDORES
                        {
                            id_tercero = int.Parse(id_tercero.Trim()),
                            id_tipo_suplidor = int.Parse(id_tipo.Trim()),
                            estado = true
                        };
                        db.SUPLIDORES.Add(eMPLEADOS);
                    }
                    else
                    {
                        terceroquery.id_tercero = int.Parse(id_tercero.Trim());
                        terceroquery.id_tipo_suplidor = int.Parse(id_tipo.Trim());
                        terceroquery.estado = estadoT;
                        id_result = terceroquery.id_suplidor;
                    }
                    db.SaveChanges();
                    if (terceroquery == null)
                    {
                        id_result = db.SUPLIDORES.Max(x => x.id_suplidor);
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
        public void borrarVsGen(string id_campo1, string columna1, string id_campo2, string columna2, string tabla)
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
        public void borrarVsConfArt(string id_articulo )
        {
            try
            {
                Utilidades.conexion.Open();
                string delete = "Delete from ARTICULOS_VS_CONFIGURACION_PEDIDO where id_articulo =  "+ id_articulo;
                System.Diagnostics.Debug.WriteLine("\n\n\n\nDELETE: " + delete.ToString()+ "\n\n\n\n");
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
