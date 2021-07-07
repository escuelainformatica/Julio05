using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Web.database;
using Web.repo;

namespace Web.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFVehiculo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFVehiculo.svc or WCFVehiculo.svc.cs at the Solution Explorer and start debugging.
    public class WCFVehiculo : IWCFVehiculo
    {
        public void DoWork()
        {
        }

        public List<Vehiculo> Listar()
        {
            return VehiculoRepo.Listar();
        }
    }
}
