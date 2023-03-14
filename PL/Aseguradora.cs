using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el Nombre: ");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el IdUsuario: ");
            aseguradora.Usuario = new ML.Usuario();
            aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.AddEF(aseguradora);//EF
            ML.Result result = BL.Aseguradora.AddLINQ(aseguradora);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Inserto la aseguradora");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se inserto la aseguradora");
                Console.ReadKey();
            }
        }

        public static void Update()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el ID: ");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Nombre: ");
            aseguradora.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la Fecha de Modificacion(yyyy-mm-dd): ");
            aseguradora.FechaModificacion = Console.ReadLine();

            Console.WriteLine("Ingresa el IdUsuario: ");
            aseguradora.Usuario = new ML.Usuario();
            aseguradora.Usuario.IdUsuario = byte.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);//EF
            ML.Result result = BL.Aseguradora.UpdateLINQ(aseguradora);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Actualizo la aseguradora");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se Actualizo la aseguradora");
                Console.ReadKey();
            }
        }

        public static void Delete()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            Console.WriteLine("Ingresa el ID: ");
            aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);//EF
            ML.Result result = BL.Aseguradora.DeleteLINQ(aseguradora);//LINQ

            if (result.Correct)
            {
                Console.WriteLine("Se Elimino la aseguradora");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se Elimino la aseguradora");
                Console.ReadKey();
            }
        }

        public static void GetAll()
        {
            //ML.Result result = BL.Aseguradora.GetAllEF();//EF
            ML.Result result = BL.Aseguradora.GetAllLINQ();//LINQ

            if (result.Correct)
            {
                //unboxing
                foreach (ML.Aseguradora aseguradora in result.Objects)
                {
                    Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                    Console.WriteLine("Nombre: " + aseguradora.Nombre);
                    Console.WriteLine("Fecha de creacion: " + aseguradora.FechaCreacion);
                    Console.WriteLine("Fecha de modificion: " + aseguradora.FechaModificacion);

                    Console.WriteLine("IdUsuario: " + aseguradora.Usuario.IdUsuario);
                    Console.WriteLine("Nombre del Usuario: " + aseguradora.Usuario.Nombre);
                    Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");
                }
            }
            Console.ReadKey();
        }
        public static void GetById()
        {
            Console.WriteLine("Ingresa el ID: ");
            int IdAseguradora = int.Parse(Console.ReadLine());

            //ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora);//EF
            ML.Result result = BL.Aseguradora.GetByIdLINQ(IdAseguradora);//LINQ

            if (result.Correct)
            {
                ML.Aseguradora aseguradora = (ML.Aseguradora)result.Object;

                Console.WriteLine("IdAseguradora: " + aseguradora.IdAseguradora);
                Console.WriteLine("Nombre: " + aseguradora.Nombre);
                Console.WriteLine("Fecha de creacion: " + aseguradora.FechaCreacion);
                Console.WriteLine("Fecha de modificion: " + aseguradora.FechaModificacion);

                Console.WriteLine("IdUsuario: " + aseguradora.Usuario.IdUsuario);
                Console.WriteLine("Nombre del Usuario: " + aseguradora.Usuario.Nombre);
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-");

            }
            Console.ReadKey();
        }
    }
}
