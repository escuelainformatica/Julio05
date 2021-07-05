using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.database;
using Web.repo;

namespace Web.api
{
    [RoutePrefix("api/Vehiculo")]

    public class VehiculoController : ApiController
    {
        // http://locahost:4444/api/Vehiculo/Listar
        [HttpGet]
        [Route("Listar")]
        public List<Vehiculo> Listar()
        {
            return VehiculoRepo.Listar();
        }

        [HttpGet]
        [Route("obtener/{patente}")]
        public Vehiculo ObtenerPorPatente(string patente)
        {
            return VehiculoRepo.Obtener(patente);
        }
        [HttpGet]
        [Route("obtenerconductor/{conductor}")]
        public Vehiculo ObtenerPorConductor(string conductor)
        {
            return VehiculoRepo.ObtenerPorConductor(conductor);
        }
        // http://localhost:1216/api/vehiculo/insertar2?patente=222-222&tipovehiculo=1&conductor=nuevo&ejes=22
        
        [HttpGet]
        [Route("insertar2")]
        public void Insertar2([FromUri(Name = "patente")] string patente
            ,[FromUri(Name = "tipovehiculo")] int tipovehiculo
            , [FromUri(Name = "conductor")] string conductor
            , [FromUri(Name = "ejes")] int ejes
            )
        {
            Vehiculo vehiculo=new Vehiculo();
            vehiculo.Patente=patente;
            vehiculo.IdTipoVehiculo=tipovehiculo;
            vehiculo.Conductor=conductor;
            vehiculo.Ejes=ejes;

            VehiculoRepo.Insertar(vehiculo);
        }

        [HttpPost]
        [Route("insertar")]
        public HttpResponseMessage Insertar([FromBody]Vehiculo vehiculo)
        {
            string usuario =Request.Headers.FirstOrDefault( h=>h.Key == "Usuario").Value.FirstOrDefault();
            if(usuario== "JOHN123")
            {
                VehiculoRepo.Insertar(vehiculo);
                return Request.CreateResponse(HttpStatusCode.OK,"insertado correctamente");
            }
            
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"usuario incorrecto");            
        }
    }
}
