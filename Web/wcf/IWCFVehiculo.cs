using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Web.database;

namespace Web.wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFVehiculo" in both code and config file together.
    [ServiceContract]
    public interface IWCFVehiculo
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<Vehiculo> Listar();
    }
}
