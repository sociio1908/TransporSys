using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _911_RD.Administracion
{
    class MetodosCRUD
    {
       public void crudTerceros(string id_traido, string nombre_traido, string identificacion_traida)
        {
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
                    System.Diagnostics.Debug.WriteLine("Proceso exitoso.");
                
                }
             }
            catch(Exception aas)
            {
                System.Diagnostics.Debug.WriteLine("Hubo un error chulo. "+aas);
            }

        }


        public void crudPersonas(string id_per_traido, string id_ter_traido, string id_sex_traido, string id_nac_traido, string apellido_traido)
        {
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
                        };
                        db.PERSONAS.Add(persona);
                    }
                    else
                    {
                        terceroquery = db.PERSONAS.FirstOrDefault(a => a.id_persona.ToString() == id_per_traido.Trim());

                        terceroquery.id_sexo = Convert.ToInt32(id_sex_traido.Trim());
                        terceroquery.id_nacionalidad = Convert.ToInt32(id_nac_traido.Trim());
                        terceroquery.apellido = apellido_traido.Trim();
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













    }
}
