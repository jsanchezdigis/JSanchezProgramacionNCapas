using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML;

namespace PL
{
    public class Aseguradora
    {
        public static void Add()
        {
            //Instanciar el servicio 
            using (AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient())
            {
                ML.Aseguradora aseguradora = new ML.Aseguradora();

                Console.WriteLine("Ingresa el nombre:");
                aseguradora.Nombre = Console.ReadLine();

                Console.WriteLine("Ingresa el IdUsuario: ");
                aseguradora.Usuario = new ML.Usuario();
                aseguradora.Usuario.IdUsuario = int.Parse(Console.ReadLine());

                //ML.Result result = BL.Aseguradora.AddEF(aseguradora);//EF
                //ML.Result result = BL.Aseguradora.AddLINQ(aseguradora);//LINQ
                ML.Result result = aseguradoraClient.Add(aseguradora);//WCF

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
                Console.ReadKey();
            }
        }

        public static void Update()
        {
            //Instanciar el servicio 
            using (AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient())
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
                //ML.Result result = BL.Aseguradora.UpdateLINQ(aseguradora);//LINQ
                ML.Result result = aseguradoraClient.Update(aseguradora);//WCF

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
        }

        public static void Delete()
        {
            //Instanciar el servicio 
            using (AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient())
            {
                ML.Aseguradora aseguradora = new ML.Aseguradora();

                Console.WriteLine("Ingresa el ID: ");
                aseguradora.IdAseguradora = int.Parse(Console.ReadLine());

                //ML.Result result = BL.Aseguradora.DeleteEF(aseguradora);//EF
                //ML.Result result = BL.Aseguradora.DeleteLINQ(aseguradora);//LINQ
                ML.Result result = aseguradoraClient.Delete(aseguradora);//WCF

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
        }

        public static void GetAll()
        {
            //Instanciar el servicio 
            using (AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient())
            {
                //ML.Result result = BL.Aseguradora.GetAllEF();//EF
                //ML.Result result = BL.Aseguradora.GetAllLINQ();//LINQ
                ML.Result result = aseguradoraClient.GetAll();//WCF

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
        }
        public static void GetById()
        {
            //Instanciar el servicio 
            using (AseguradoraService.AseguradoraClient aseguradoraClient = new AseguradoraService.AseguradoraClient())
            {
                Console.WriteLine("Ingresa el ID: ");
                int IdAseguradora = int.Parse(Console.ReadLine());

                //ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora);//EF
                //ML.Result result = BL.Aseguradora.GetByIdLINQ(IdAseguradora);//LINQ
                ML.Result result = aseguradoraClient.GetById(IdAseguradora);//WCF

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
}
