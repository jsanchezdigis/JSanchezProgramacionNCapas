using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAseguradora" in both code and config file together.
    [ServiceContract]
    public interface IAseguradora
    {
        [OperationContract]
        ML.Result Add(ML.Aseguradora aseguradora);
        [OperationContract]
        ML.Result Update(ML.Aseguradora aseguradora);
        [OperationContract]
        ML.Result Delete(ML.Aseguradora aseguradora);
        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        ML.Result GetAll();
        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        ML.Result GetById(int IdAseguradora);
    }
}
