using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOperaciones" in both code and config file together.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        int Suma(int a, int b);
        [OperationContract]
        int Resta(int a, int b);
        [OperationContract]
        int Multiplicar(int a, int b);
        [OperationContract]
        double Dividir(double a, double b);
    }
}
