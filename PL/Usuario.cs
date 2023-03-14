using BL;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el UserNombre: ");
            usuario.UserNombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Email: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa la Contraseña: ");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de nacieminto(yy-mm-dd): ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa el Sexo(M/F): ");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el Telefono(10): ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el Celular(10): ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa el CURP: ");
            usuario.CURP = Console.ReadLine();

            usuario.Imagen = null;

            Console.WriteLine("Ingresa el IDRol: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());


            //ML.Result result = BL.Usuario.Add(usuario); //Query
            //ML.Result result = BL.Usuario.AddSP(usuario); //SP
            //ML.Result result = BL.Usuario.AddEF(usuario);//EF
            ML.Result result = BL.Usuario.AddLINQ(usuario);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Inserto el Usuario");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se inserto el Usuario");
                Console.ReadKey();
            }
        }


        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el UserNombre: ");
            usuario.UserNombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Nombre: ");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Paterno: ");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Apellido Materno: ");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa el Email: ");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa la Contraseña: ");
            usuario.Password = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de nacieminto(yy-mm-dd): ");
            usuario.FechaNacimiento = Console.ReadLine();

            Console.WriteLine("Ingresa el Sexo(M/F): ");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Ingresa el Telefono(10): ");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa el Celular(10): ");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Ingresa el CURP: ");
            usuario.CURP = Console.ReadLine();

            usuario.Imagen = null;

            Console.WriteLine("Ingresa el IDRol: ");
            usuario.Rol = new ML.Rol();
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Update(usuario);//query
            //ML.Result result = BL.Usuario.UpdateSP(usuario); //SP
            //ML.Result result = BL.Usuario.UpdateEF(usuario);//EF
            ML.Result result = BL.Usuario.UpdateLINQ(usuario);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Actualizo el Usuario");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se Actualizo el Usuario");
                Console.ReadKey();
            }
        }

        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Ingresa el ID: ");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Usuario.Delete(usuario); //query
            //ML.Result result = BL.Usuario.DeleteSP(usuario); //SP
            //ML.Result result = BL.Usuario.DeleteEF(usuario);//EF
            ML.Result result = BL.Usuario.DeleteLINQ(usuario);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Elimino el Usuario");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se Elimino el Usuario");
                Console.ReadKey();
            }
        }

        public static void GetAll()
        {
            //ML.Result result = BL.Usuario.GetAll();//SP
            //ML.Result result = BL.Usuario.GetAllEF();//EF
            ML.Result result = BL.Usuario.GetAllLINQ();//LINQ

            if (result.Correct)
            {
                //unboxing
                foreach (ML.Usuario usuario in result.Objects)
                {
                    Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                    Console.WriteLine("UserNombre: " + usuario.UserNombre);
                    Console.WriteLine("Nombre: " + usuario.Nombre);
                    Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                    Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                    Console.WriteLine("Email: " + usuario.Email);
                    Console.WriteLine("Password: " + usuario.Password);
                    Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
                    Console.WriteLine("Sexo: " + usuario.Sexo);
                    Console.WriteLine("Telefono: " + usuario.Telefono);
                    Console.WriteLine("Celular: " + usuario.Celular);
                    Console.WriteLine("CURP: " + usuario.CURP);

                    Console.WriteLine("IdRol: " + usuario.Rol.IdRol);
                    Console.WriteLine("NombreRol: " + usuario.Rol.Nombre);
                    Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
                }
            }
            Console.ReadKey();
        }
        public static void GetById()
        {
            Console.WriteLine("Ingresa el ID: ");
            int IdUsuario = int.Parse(Console.ReadLine());

            //ML.Usuario usuario = new ML.Usuario();
            //ML.Result result = BL.Usuario.GetById(IdUsuario);//SP
            //ML.Result result = BL.Usuario.GetByIdEF(IdUsuario);//EF
            ML.Result result = BL.Usuario.GetByIdLINQ(IdUsuario);//LINQ

            if (result.Correct)
            {
                ML.Usuario usuario = (ML.Usuario)result.Object;

                Console.WriteLine("IdUsuario: " + usuario.IdUsuario);
                Console.WriteLine("UserNombre: " + usuario.UserNombre);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("Apellido Paterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("Password: " + usuario.Password);
                Console.WriteLine("Fecha de nacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("Sexo: " + usuario.Sexo);
                Console.WriteLine("Telefono: " + usuario.Telefono);
                Console.WriteLine("Celular: " + usuario.Celular);
                Console.WriteLine("CURP: " + usuario.CURP);

                Console.WriteLine("IdRol: " + usuario.Rol.IdRol);
                Console.WriteLine("NombreRol: " + usuario.Rol.Nombre);
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
                
            }
            Console.ReadKey();
        }
    }
}
