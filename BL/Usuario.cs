using DL_EF;
using ML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BL
{
    public class Usuario
    {
        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConectionString()))
                //using (var conn = new SqlConnection("Data Source=.;Initial Catalog=JSanchezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))
                {
                    string query = "INSERT INTO [Usuario]([Nombre],[App],[Apm],[Email]) VALUES (@Nombre,@App,@Apm,@Email";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        //var cmd = new SqlCommand("INSERT INTO [Usuario]([Nombre],[App],[Apm],[Email]) VALUES (@Nombre,@App,@Apm,@Email)", conn);
                        cmd.Connection = context;//asigno la cadena de conexion al objeto cmd
                        cmd.CommandText = query;//asigno el query al objeto cmd

                        //cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                        //cmd.Parameters.AddWithValue("@App", usuario.App);
                        //cmd.Parameters.AddWithValue("@Apm", usuario.Apm);
                        //cmd.Parameters.AddWithValue("@Email", usuario.Email);

                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("App", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("Apm", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[3].Value = usuario.Email;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        //conn.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Insertado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al agregar Ususario";
            }
            return result;
        }
        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConectionString()))
                //using (var conn = new SqlConnection("Data Source=.;Initial Catalog=JSanchezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))
                {
                    string query = "UPDATE Usuario SET Nombre=@Nombre,App=@App,Apm=@Apm,Email=@Email WHERE IdUsuario=@IdUsuario";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = contex;
                        cmd.CommandText = query;

                        SqlParameter[] collection = new SqlParameter[5];

                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
                        collection[0].Value = usuario.IdUsuario;

                        collection[1] = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
                        collection[1].Value = usuario.Nombre;

                        collection[2] = new SqlParameter("App", System.Data.SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoPaterno;

                        collection[3] = new SqlParameter("Apm", System.Data.SqlDbType.VarChar);
                        collection[3].Value = usuario.ApellidoMaterno;

                        collection[4] = new SqlParameter("Email", System.Data.SqlDbType.VarChar);
                        collection[4].Value = usuario.Email;

                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Actualizado";
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No se pudo Actualizar al Usuario";
                        }
                    }
                }
                //var cmd = new SqlCommand("UPDATE Usuario SET Nombre=@Nombre,App=@App,Apm=@Apm,Email=@Email WHERE IdUsuario=@IdUsuario", conn);
                //cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                //conn.Open();
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al actualizar Ususario";
            }
            return result;
        }
        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection cotext = new SqlConnection(DL.Conexion.GetConectionString()))
                //using (var conn = new SqlConnection("Data Source=.;Initial Catalog=JSanchezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))
                {
                    string query = "DELETE FROM Usuario WHERE IdUsuario=@IdUsuario";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cotext;
                        cmd.CommandText = query;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
                        collection[0].Value = usuario.IdUsuario;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Eliminado";
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No se pudo eliminar al Usuario";
                        }
                    }
                    //var cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@IdUsuario", conn);
                    //cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                    //conn.Open();
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al eliminar Usuario";
            }
            return result;
        }
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection cotext = new SqlConnection(DL.Conexion.GetConectionString()))
                {
                    string query = "UsuarioGetAll";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cotext;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataTable UsuarioDataTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(UsuarioDataTable);
                        
                        if(UsuarioDataTable.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();
                            foreach (DataRow row in UsuarioDataTable.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.IdUsuario = (int)row[0];
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Email = row[4].ToString();

                                result.Objects.Add(usuario);
                            }
                        }
                        result.Correct = true;

                        //cmd.Connection.Open();
                        //int rowAffected = cmd.ExecuteNonQuery();
                        //if (rowAffected > 0)
                        //{
                        //    result.Correct = true;
                        //    result.Message = "Usuario Mostrado";
                        //}
                        //else
                        //{
                        //    result.Correct = false;
                        //    result.Message = "No se pudo mostrar el Usuario";
                        //}
                        //var cmd = new SqlCommand("SELECT * FROM Usuario WHERE IdUsuario=@IdUsuario", conn);
                        //cmd.Parameters.AddWithValue("@IdUsuario", usuario.IdUsuario);
                        //conn.Open();
                        //modifica  dataTable
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al Mostrar Usuario";
            }
            return result;
        }

        public static ML.Result GetById(int IdUsuario)
        {
            ML. Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConectionString()))
                {
                    string query = "UsuarioGetById";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
                        collection[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(collection);

                        DataTable UsuarioDataTable = new DataTable();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(UsuarioDataTable);

                        if (UsuarioDataTable.Rows.Count > 0)
                        {
                            DataRow row = UsuarioDataTable.Rows[0];

                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = (int)row[0];
                            usuario.Nombre = row[1].ToString();
                            usuario.ApellidoPaterno = row[2].ToString();
                            usuario.ApellidoMaterno = row[3].ToString();
                            usuario.Email = row[4].ToString();

                            result.Object = usuario;

                        }
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al Mostrar Usuario";
            }
            return result;
        }

        public static ML.Result AddSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConectionString()))
                {
                    string query = "UsuarioAdd";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;//asigno la cadena de conexion al objeto cmd
                        cmd.CommandText = query;//asigno el query al objeto cmd
                        cmd.CommandType = CommandType.StoredProcedure;// Para saber que es un SP

                        SqlParameter[] collection = new SqlParameter[4];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = usuario.Nombre;

                        collection[1] = new SqlParameter("App", SqlDbType.VarChar);
                        collection[1].Value = usuario.ApellidoPaterno;

                        collection[2] = new SqlParameter("Apm", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoMaterno;

                        collection[3] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[3].Value = usuario.Email;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Insertado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al agregar Ususario";
            }
            return result;
        }
        public static ML.Result UpdateSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection contex = new SqlConnection(DL.Conexion.GetConectionString()))
                {
                    string query = "UsuarioUpdate";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = contex;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;// Para saber que es un SP

                        SqlParameter[] collection = new SqlParameter[5];

                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
                        collection[0].Value = usuario.IdUsuario;

                        collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[1].Value = usuario.Nombre;

                        collection[2] = new SqlParameter("App", SqlDbType.VarChar);
                        collection[2].Value = usuario.ApellidoPaterno;

                        collection[3] = new SqlParameter("Apm", SqlDbType.VarChar);
                        collection[3].Value = usuario.ApellidoMaterno;

                        collection[4] = new SqlParameter("Email", SqlDbType.VarChar);
                        collection[4].Value = usuario.Email;

                        cmd.Parameters.AddRange(collection);

                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Actualizado";
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No se pudo Actualizar al Usuario";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al actualizar Usuario";
            }
            return result;
        }
        public static ML.Result DeleteSP(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection cotext = new SqlConnection(DL.Conexion.GetConectionString()))
                {
                    string query = "UsuarioDelete";
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = cotext;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;// Para saber que es un SP

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdUsuario", SqlDbType.TinyInt);
                        collection[0].Value = usuario.IdUsuario;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            result.Correct = true;
                            result.ErrorMessage = "Usuario Eliminado";
                        }
                        else
                        {
                            result.Correct = false;
                            result.ErrorMessage = "No se pudo eliminar al Usuario";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = "Ocurrio un error al eliminar Usuario";
            }
            return result;
        }

        //EF
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.UsuarioAdd(
                        usuario.UserNombre,
                        usuario.Nombre, 
                        usuario.ApellidoPaterno, 
                        usuario.ApellidoMaterno, 
                        usuario.Email,
                        usuario.Password,
                        usuario.FechaNacimiento,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.CURP,
                        usuario.Imagen,
                        usuario.Rol.IdRol,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia);
                    if (query >= 1)
                    {
                        result.Correct=true;
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

        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.UsuarioUpdate(
                        usuario.IdUsuario,
                        usuario.UserNombre,
                        usuario.Nombre,
                        usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno,
                        usuario.Email,
                        usuario.Password,
                        usuario.FechaNacimiento,
                        usuario.Sexo,
                        usuario.Telefono,
                        usuario.Celular,
                        usuario.CURP,
                        usuario.Imagen,
                        usuario.Rol.IdRol,
                        usuario.Direccion.Calle,
                        usuario.Direccion.NumeroInterior,
                        usuario.Direccion.NumeroExterior,
                        usuario.Direccion.Colonia.IdColonia);
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

        public static ML.Result DeleteEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    int query = context.UsuarioDelete(usuario.IdUsuario);
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

        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            usuario.ApellidoMaterno = "";

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.UsuarioGetAll(usuario.Nombre,usuario.ApellidoPaterno,usuario.ApellidoMaterno).ToList();

                    if (query != null)
                        {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            usuario = new ML.Usuario();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserNombre = obj.UserNombre;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Password = obj.Password;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString("dd-MM-yyyy");
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.Imagen = obj.Imagen;

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol.Value;
                            usuario.Rol.Nombre = obj.NombreRol;
                            //agrgar los campos faltantes y en byid
                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = obj.IdDireccion.Value;
                            usuario.Direccion.Calle = obj.Calle;
                            usuario.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuario.Direccion.NumeroExterior = obj.NumeroExterior;

                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = obj.IdColonia.Value;
                            usuario.Direccion.Colonia.Nombre = obj.NombreColonia;

                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio.Value;
                            usuario.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;

                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;

                            //usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            //usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais.Value;
                            //usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.Nombre;

                            result.Objects.Add(usuario);
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

        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = context.UsuarioGetById(IdUsuario).FirstOrDefault();

                    if (query != null)
                    {
                        result.Object = new List<object>();
                        var obj = query;
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserNombre = obj.UserNombre;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Password = obj.Password;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString("dd-MM-yyyy");
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.Imagen = obj.Imagen;

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = obj.IdRol.Value;
                            usuario.Rol.Nombre = obj.NombreRol;

                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = obj.IdDireccion.Value;
                            usuario.Direccion.Calle = obj.Calle;
                            usuario.Direccion.NumeroInterior = obj.NumeroInterior;
                            usuario.Direccion.NumeroExterior = obj.NumeroExterior;

                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = obj.IdColonia.Value;
                            usuario.Direccion.Colonia.Nombre = obj.NombreColonia;

                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = obj.IdMunicipio.Value;
                            usuario.Direccion.Colonia.Municipio.Nombre = obj.NombreMunicipio;

                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = obj.IdEstado.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = obj.NombreEstado;

                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = obj.IdPais.Value;
                            //usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = obj.Nombre;

                            result.Object = usuario;
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
        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    //var query = (from Usuario in context.Usuarios
                    //             select Usuario).ToList();

                    DL_EF.Usuario usuarioDL_EF = new DL_EF.Usuario();
                    usuarioDL_EF.IdUsuario = usuario.IdUsuario;
                    usuarioDL_EF.UserNombre = usuario.UserNombre;
                    usuarioDL_EF.Nombre = usuario.Nombre;
                    usuarioDL_EF.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL_EF.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL_EF.Email = usuario.Email;
                    usuarioDL_EF.Password = usuario.Password;
                    usuarioDL_EF.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioDL_EF.Sexo = usuario.Sexo;
                    usuarioDL_EF.Telefono = usuario.Telefono;
                    usuarioDL_EF.Celular = usuario.Celular;
                    usuarioDL_EF.CURP = usuario.CURP;
                    usuarioDL_EF.Imagen = usuario.Imagen;

                    //usuarioDL_EF.Rol = new DL_EF.Rol();
                    usuarioDL_EF.IdRol = usuario.Rol.IdRol;
                    context.Usuarios.Add(usuarioDL_EF);
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

        public static ML.Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 where Usuario.IdUsuario == usuario.IdUsuario
                                 select Usuario).SingleOrDefault();

                    if (query != null)
                    {
                        query.IdUsuario = usuario.IdUsuario;
                        query.UserNombre = usuario.UserNombre;
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Email = usuario.Email;
                        query.Password = usuario.Password;
                        query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                        query.Sexo = usuario.Sexo;
                        query.Telefono = usuario.Telefono;
                        query.Celular = usuario.Celular;
                        query.CURP = usuario.CURP;
                        query.Imagen = usuario.Imagen;

                        query.Rol.IdRol = usuario.Rol.IdRol;
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
                    var query = (from Usuario in context.Usuarios
                                 join Rol in context.Rols on Usuario.IdRol equals Rol.IdRol
                                 select new
                                 {
                                     IdUsuario = Usuario.IdUsuario,
                                     UserNombre = Usuario.UserNombre,
                                     Nombre = Usuario.Nombre,
                                     ApellidoPaterno = Usuario.ApellidoPaterno,
                                     ApellidoMaterno = Usuario.ApellidoMaterno,
                                     Email = Usuario.Email,
                                     Password = Usuario.Password,
                                     Sexo = Usuario.Sexo,
                                     Telefono = Usuario.Telefono,
                                     Celular = Usuario.Celular,
                                     FechaNacimiento = Usuario.FechaNacimiento,
                                     CURP = Usuario.CURP,
                                     Imagen = Usuario.Imagen,
                                     IdRol = Usuario.Rol.IdRol,
                                     NombreRol = Usuario.Rol.Nombre
                                 });
                    result.Objects = new List<object>();

                    if (query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserNombre = obj.UserNombre;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno = obj.ApellidoPaterno;
                            usuario.ApellidoMaterno = obj.ApellidoMaterno;
                            usuario.Email = obj.Email;
                            usuario.Password = obj.Password;
                            usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                            usuario.Sexo = obj.Sexo;
                            usuario.Telefono = obj.Telefono;
                            usuario.Celular = obj.Celular;
                            usuario.CURP = obj.CURP;
                            usuario.Imagen = obj.Imagen;

                            usuario.Rol = new ML.Rol();

                            usuario.Rol.IdRol = obj.IdRol;
                            usuario.Rol.Nombre = obj.NombreRol;

                            result.Objects.Add(usuario);
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

        public static ML.Result GetByIdLINQ(int IdUsuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                 join Rol in context.Rols on Usuario.IdRol equals Rol.IdRol
                                 where Usuario.IdUsuario == IdUsuario
                                 select new
                                 {
                                     IdUsuario = IdUsuario,
                                     UserNombre = Usuario.UserNombre,
                                     Nombre = Usuario.Nombre,
                                     ApellidoPaterno = Usuario.ApellidoPaterno,
                                     ApellidoMaterno = Usuario.ApellidoMaterno,
                                     Email = Usuario.Email,
                                     Password = Usuario.Password,
                                     Sexo = Usuario.Sexo,
                                     Telefono = Usuario.Telefono,
                                     Celular = Usuario.Celular,
                                     FechaNacimiento = Usuario.FechaNacimiento,
                                     CURP = Usuario.CURP,
                                     Imagen = Usuario.Imagen,
                                     IdRol = Usuario.Rol.IdRol,
                                     NombreRol = Usuario.Rol.Nombre
                                 }).FirstOrDefault();
                    result.Object = new List<object>();

                    if (query != null)
                    {
                        var obj = query;
                        
                        ML.Usuario usuario = new ML.Usuario();

                        usuario.IdUsuario = obj.IdUsuario;
                        usuario.UserNombre = obj.UserNombre;
                        usuario.Nombre = obj.Nombre;
                        usuario.ApellidoPaterno = obj.ApellidoPaterno;
                        usuario.ApellidoMaterno = obj.ApellidoMaterno;
                        usuario.Email = obj.Email;
                        usuario.Password = obj.Password;
                        usuario.FechaNacimiento = obj.FechaNacimiento.ToString();
                        usuario.Sexo = obj.Sexo;
                        usuario.Telefono = obj.Telefono;
                        usuario.Celular = obj.Celular;
                        usuario.CURP = obj.CURP;
                        usuario.Imagen = obj.Imagen;

                        usuario.Rol = new ML.Rol();

                        usuario.Rol.IdRol = obj.IdRol;
                        usuario.Rol.Nombre = obj.NombreRol;

                        result.Object = usuario;
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

        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL_EF.JSanchezProgramacionNCapasEntities context = new DL_EF.JSanchezProgramacionNCapasEntities())
                {
                    var query = (from Usuario in context.Usuarios
                                  where Usuario.IdUsuario == usuario.IdUsuario
                                  select Usuario).First();
                    
                    context.Usuarios.Remove(query);
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
