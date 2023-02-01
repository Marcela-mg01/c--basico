using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menjivar_Marcela_P3
{
    class Estadio
    {
        public string sector; 
        public double precio;
        private int cantidad_entrada;

        public void total_pagar()
        {

            Console.WriteLine("El total a pagar es: $"+(precio*cantidad_entrada));

        }

        public int Cant_entrada
        {
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("Error, no se permite cantidad negativa o cero");
                    Console.Write("Ingrese la cantidad nuevamente: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                if (value > 0)
                    cantidad_entrada = value;

            }
            get { return cantidad_entrada; }
        }



        //Constructor
        public Estadio()
        {
            Console.WriteLine("\n\"Bienvenido al Estadio Mágico González...\"\n");
        }
    }
}
