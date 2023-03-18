using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Empleado" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Empleado.svc or Empleado.svc.cs at the Solution Explorer and start debugging.
    public class Empleado : IEmpleado
    {
        public ML.Result Add(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.AddEF(empleado);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result Update(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.UpdateEF(empleado);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result Delete(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.DeleteEF(empleado);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result GetAll(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.GetAllEF(empleado);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result GetById(string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.GetByIdEF(NumeroEmpleado);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
