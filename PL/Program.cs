using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fin = 0;
            while (fin != 1)
            {
                Console.Write("CRUD Entity Framework");
                Console.Write("\n1-Agregar(ADD) \n2.-Actualizar(Update) \n3.-Eliminar(Delete) \n4.-Mostrar(GetAll) \n5.-MostarID(GetById)\n6.-Salir");
                Console.Write("\nIngrese la opcion deseada: ");
                int op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //PL.Usuario.Add();
                        PL.Aseguradora.Add();
                        break;
                    case 2:
                        //PL.Usuario.Update();
                        PL.Aseguradora.Update();
                        break;
                    case 3:
                        //PL.Usuario.Delete();
                        PL.Aseguradora.Delete();
                        break;
                    case 4:
                        //PL.Usuario.GetAll();
                        PL.Aseguradora.GetAll();
                        break;
                    case 5:
                        //PL.Usuario.GetById();
                        PL.Aseguradora.GetById();
                        break;
                    case 6:
                        fin = 1;
                        break;
                    default:
                        Console.WriteLine("opcion incorecta");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
