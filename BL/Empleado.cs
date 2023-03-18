using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Empleado
    {
        //EF
        public static ML.Result AddEF(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.EmpleadoAdd(
                        empleado.NumeroEmpleado,
                        empleado.RFC,
                        empleado.Nombre,
                        empleado.ApellidoPaterno,
                        empleado.ApellidoMaterno,
                        empleado.Email,
                        empleado.Telefono,
                        empleado.FechaNacimiento,
                        empleado.NSS,
                        empleado.Foto,
                        empleado.Empresa.IdEmpresa
                        //empleado.Empresa.Nombre,
                        //empleado.Empresa.Telefono,
                        //empleado.Empresa.Email,
                        //empleado.Empresa.DireccionWeb,
                        //empleado.Empresa.Logo
                        );
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se inserto el registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result UpdateEF(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.EmpleadoUpdate(
                        empleado.NumeroEmpleado,
                        empleado.RFC,
                        empleado.Nombre,
                        empleado.ApellidoPaterno,
                        empleado.ApellidoMaterno,
                        empleado.Email,
                        empleado.Telefono,
                        empleado.FechaNacimiento,
                        empleado.NSS,
                        empleado.Foto,
                        empleado.Empresa.IdEmpresa
                        //empleado.Empresa.Nombre,
                        //empleado.Empresa.Telefono,
                        //empleado.Empresa.Email,
                        //empleado.Empresa.DireccionWeb,
                        //empleado.Empresa.Logo
                        );
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se Actualizo el registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result DeleteEF(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.EmpleadoDelete(empleado.NumeroEmpleado);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se Actualizo el registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetAllEF(ML.Empleado empleado)
        {
            empleado.Nombre = "";
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.EmpleadoGetAll(empleado.Nombre,empleado.Empresa.IdEmpresa).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            empleado = new ML.Empleado();

                            empleado.NumeroEmpleado = obj.NumeroEmpleado;
                            empleado.Nombre = obj.Nombre;
                            empleado.ApellidoPaterno = obj.ApellidoPaterno;
                            empleado.ApellidoMaterno = obj.ApellidoMaterno;
                            empleado.Telefono = obj.Telefono;
                            empleado.Email = obj.Email;
                            empleado.FechaNacimiento = obj.FechaNacimiento.ToString();//("dd-MM-yyyy")
                            empleado.NSS = obj.NSS;
                            empleado.FechaIngreso = obj.FechaIngreso.ToString();
                            empleado.Foto = obj.Foto;

                            empleado.Empresa = new ML.Empresa();
                            empleado.Empresa.IdEmpresa = obj.IdEmpresa.Value;

                            result.Objects.Add(empleado);
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdEF(string NumeroEmpleado)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.EmpleadoGetById(NumeroEmpleado).FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;
                        {
                            ML.Empleado empleado = new ML.Empleado();

                            empleado.NumeroEmpleado = obj.NumeroEmpleado;
                            empleado.Nombre = obj.Nombre;
                            empleado.ApellidoPaterno = obj.ApellidoPaterno;
                            empleado.ApellidoMaterno = obj.ApellidoMaterno;
                            empleado.Telefono = obj.Telefono;
                            empleado.Email = obj.Email;
                            empleado.FechaNacimiento = obj.FechaNacimiento.ToString();//("dd-MM-yyyy")
                            empleado.NSS = obj.NSS;
                            empleado.FechaIngreso = obj.FechaIngreso.ToString();
                            empleado.Foto = obj.Foto;

                            empleado.Empresa = new ML.Empresa();
                            empleado.Empresa.IdEmpresa = obj.IdEmpresa.Value;

                            result.Object = empleado;
                        }
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
