using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Operaciones
    {
        public static void Operaciones1()
        {
            using (OperacionesService.OperacionesClient client = new OperacionesService.OperacionesClient())
            {
                
                int suma = client.Suma(10, 20);
                Console.WriteLine("El resultado de la suma es:{0}",suma);

                int resta = client.Resta(10, 20);
                Console.WriteLine("El resultado de la resta es:{0}", resta);

                double div = client.Dividir(10.0,20.0);
                Console.WriteLine("El resultado de la division es:{0}", div);

                int multi = client.Multiplicar(10, 20);
                Console.WriteLine("El resultado de la multiplicacion es:{0}", multi);
            }

        }
    }
}
