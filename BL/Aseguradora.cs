using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        //EF
        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.AseguradoraAdd(
                        aseguradora.Nombre,
                        aseguradora.Usuario.IdUsuario);
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

        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.AseguradoraUpdate(
                        aseguradora.IdAseguradora,
                        aseguradora.Nombre,
                        //aseguradora.FechaModificacion,
                        aseguradora.Usuario.IdUsuario);
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

        public static ML.Result DeleteEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.AseguradoraDelete(aseguradora.IdAseguradora);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se Elimino el registro";
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

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();//Actualizar sql

                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;

                            result.Objects.Add(aseguradora);
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

        public static ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();//Actualizar sql

                            aseguradora.Usuario = new ML.Usuario();
                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;

                            result.Object = aseguradora;
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

        //LINQ
        public static ML.Result AddLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    DL_EF.Aseguradora aseguradoraDL_EF = new DL_EF.Aseguradora();
                    aseguradoraDL_EF.Nombre = aseguradora.Nombre;
                    aseguradoraDL_EF.FechaCreacion = DateTime.Today;
                    aseguradoraDL_EF.FechaModificacion = DateTime.Today;

                    aseguradoraDL_EF.IdUsuario = aseguradora.Usuario.IdUsuario;
                    context.Aseguradoras.Add(aseguradoraDL_EF);
                    context.SaveChanges();

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

        public static ML.Result UpdateLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 where Aseguradora.IdAseguradora == aseguradora.IdAseguradora
                                 select Aseguradora).SingleOrDefault();

                    if (query != null)
                    {
                        query.IdAseguradora = aseguradora.IdAseguradora;
                        query.Nombre = aseguradora.Nombre;
                        //query.FechaModificacion = DateTime.Parse(aseguradora.FechaModificacion);//Checar para dar formato (dd-mm-yyyy)--Quitar esta linea
                        query.FechaModificacion = DateTime.Today;
                        query.Usuario.IdUsuario = aseguradora.Usuario.IdUsuario;
                        context.SaveChanges();

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

        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 join Usuario in context.Usuarios on Aseguradora.IdUsuario equals Usuario.IdUsuario
                                 select new
                                 {
                                     IdAseguradora = Aseguradora.IdAseguradora,
                                     Nombre = Aseguradora.Nombre,
                                     FechaCreacion = Aseguradora.FechaCreacion,
                                     FechaModificacion = Aseguradora.FechaModificacion,
                                     IdUsuario = Aseguradora.Usuario.IdUsuario,
                                     NombreUsuario = Aseguradora.Usuario.Nombre
                                 });
                    result.Objects = new List<object>();

                    if (query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();

                            aseguradora.IdAseguradora = obj.IdAseguradora;
                            aseguradora.Nombre = obj.Nombre;
                            aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                            aseguradora.FechaModificacion = obj.FechaModificacion.ToString();

                            aseguradora.Usuario = new ML.Usuario();

                            aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                            aseguradora.Usuario.Nombre = obj.NombreUsuario;

                            result.Objects.Add(aseguradora);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result GetByIdLINQ(int IdAseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 join Usuario in context.Usuarios on Aseguradora.IdUsuario equals Usuario.IdUsuario
                                 where Aseguradora.IdAseguradora == IdAseguradora
                                 select new
                                 {
                                     IdAseguradora = Aseguradora.IdAseguradora,
                                     Nombre = Aseguradora.Nombre,
                                     FechaCreacion = Aseguradora.FechaCreacion,
                                     FechaModificacion = Aseguradora.FechaModificacion,
                                     IdUsuario = Aseguradora.Usuario.IdUsuario,
                                     NombreUsuario = Aseguradora.Usuario.Nombre
                                 }).FirstOrDefault();
                    result.Object = new List<object>();

                    if (query != null)
                    {
                        var obj = query;

                        ML.Aseguradora aseguradora = new ML.Aseguradora();

                        aseguradora.IdAseguradora = obj.IdAseguradora;
                        aseguradora.Nombre = obj.Nombre;
                        aseguradora.FechaCreacion = obj.FechaCreacion.ToString();
                        aseguradora.FechaModificacion = obj.FechaModificacion.ToString();

                        aseguradora.Usuario = new ML.Usuario();

                        aseguradora.Usuario.IdUsuario = obj.IdUsuario;
                        aseguradora.Usuario.Nombre = obj.NombreUsuario;

                        result.Object = aseguradora;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontro el registro";
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

        public static ML.Result DeleteLINQ(ML.Aseguradora aseguradora)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Aseguradora in context.Aseguradoras
                                 where Aseguradora.IdAseguradora == aseguradora.IdAseguradora
                                 select Aseguradora).First();

                    context.Aseguradoras.Remove(query);
                    context.SaveChanges();

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
