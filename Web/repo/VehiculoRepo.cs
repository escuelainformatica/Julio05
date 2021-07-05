using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using Web.database;

namespace Web.repo
{
    public class VehiculoRepo
    {
        public static Vehiculo Obtener(string patente)
        {
            var resultado=new Vehiculo();
            using (var ctx = new TransporteDB())
            {
                ctx.Configuration.ProxyCreationEnabled=false;
                resultado=ctx.Vehiculo.Find(patente); // find es solo para buscar por la llave primaria
            }
            return resultado;
        }

        public static Vehiculo ObtenerPorConductor(string conductor)
        {
            var resultado = new Vehiculo();
            using (var ctx = new TransporteDB())
            {
                ctx.Configuration.ProxyCreationEnabled = false;
                /*resultado=ctx.Vehiculo
                    .Where( v => v.Conductor==conductor)
                    .First();               
                */
                //resultado = ctx.Vehiculo
                //    .First(v => v.Conductor == conductor);
                //first: si no esta el valor, se genera un error
                //firstordefault: si no esta el valor, devuelve un nulo.
                resultado = ctx.Vehiculo
                    .Include("TipoVehiculo")
                    .FirstOrDefault(v => v.Conductor == conductor);

            }
            return resultado;
        }

        public static List<Vehiculo> Listar()
        {
            var resultado=new List<Vehiculo>();
            using(var ctx=new TransporteDB())
            {
                ctx.Configuration.ProxyCreationEnabled=false; // <-- el proxy sirve cuando modificamos datos

                // entity framework
                resultado=ctx
                    .Vehiculo
                    .Include("TipoVehiculo")
                    //.Include("TipoVehiculo/Vehiculo")
                    .ToList(); // List<Proxy.....>
                // core.
                // resultado = ctx.Vehiculo.Include(v=>v.TipoVehiculo).ToList(); // List<Proxy.....>
            }
            return resultado;
        }
        public static void Insertar(Vehiculo vehiculo)
        {
            using (var ctx = new TransporteDB())
            {
                ctx.Vehiculo.Add(vehiculo); // <-- aqui se ocupa un proxy.
                ctx.SaveChanges();
            }
        }
    }
}