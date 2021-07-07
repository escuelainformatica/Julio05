using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using Web.database;
using Web.repo;

// http://localhost:1216/soap/WebServiceVehiculo.asmx

namespace Web.soap
{
    /// <summary>
    /// Summary description for WebServiceVehiculo
    /// </summary>
    [WebService(Namespace = "http://cocacola.cl/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceVehiculo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Vehiculo> Listar()
        {

            Thread.Sleep(3000);
            return VehiculoRepo.Listar();
        }


        [WebMethod(Description ="Este metodo permite insertar")]
        public string Insertar(Vehiculo objeto)
        {
            VehiculoRepo.Insertar(objeto);
            return "ok";
        }

    }
}
