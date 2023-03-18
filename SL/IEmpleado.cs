using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpleado" in both code and config file together.
    [ServiceContract]
    public interface IEmpleado
    {
        [OperationContract]
        ML.Result Add(ML.Empleado empleado);
        [OperationContract]
        ML.Result Update(ML.Empleado empleado);
        [OperationContract]
        ML.Result Delete(ML.Empleado empleado);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        ML.Result GetAll(ML.Empleado empleado);
        [OperationContract]
        //[DataContract]
        [ServiceKnownType(typeof(ML.Empleado))]
        ML.Result GetById(string NumeroEmpleado);
    }
}
