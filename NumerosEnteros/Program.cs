
//  Nombre : Luna Acosta, Kevin Alexander
//  Codigo : SMIS083121

//  Nombre : Zelaya Chavez, Kevin Alejandro
//  Codigo : SMIS091121


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, result;
            Console.WriteLine("Escriba el primer valor entero:  ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo valor entero: ");
            b = float.Parse(Console.ReadLine());

            result = a / b;

            Console.WriteLine(" ");

            if (b >= 1)
            {
                Console.WriteLine("El resultado de la divicion es: {0}", result);
            }
            else if (b <= 0)
            {
                Console.WriteLine("Error No Se Puede Dividir Entre 0");
            }







            Console.ReadLine();


        }
    }
}
