using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjivar_Marcela_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;

            do
            {
                Estadio obj1 = new Estadio();

                Console.WriteLine("Ingrese el sector que quiere ir segun el siguiente menu: ");
                Console.WriteLine("\"Sol General\"\n\"Sol Preferencial\" \n\"Sombra\" \n\"Tribuna\" \n\"Sillon reclinable\"");
                Console.Write("Respuesta: ");
                obj1.sector = Console.ReadLine().ToLower();
                try
                {
                    Console.Write("Ingrese la cantidad de entradas que comprara: ");
                    obj1.Cant_entrada = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error " + e.Message);
                }

                switch (obj1.sector)
                {
                    case "sol general":
                        obj1.precio = 3;
                        break;
                    case "sol preferencial":
                        obj1.precio = 5;
                        break;
                    case "sombra":
                        obj1.precio = 8;
                        break;
                    case "tribuna":
                        obj1.precio = 15;
                        break;
                    case "sillon reclinable":
                        obj1.precio = 25;
                        break;
                    default:
                        Console.WriteLine("Se equivoco, por favor vuelve a intentarlo...");
                        break;
                }

                obj1.total_pagar();

                Console.Write("\nDesea continuar?\nIngrese \"si\" si desea continuar \nIngrese \"no\" si desea finalizar\nRespuesta: ");
                resp =Console.ReadLine().ToLower();

            }
            while (resp == "si");
            Console.WriteLine("\nGracias por usar nuestro programa...!");
            Console.ReadKey();
        }
    }
}
