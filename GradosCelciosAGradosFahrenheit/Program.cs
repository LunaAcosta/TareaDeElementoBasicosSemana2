
//  Nombre : Luna Acosta, Kevin Alexander
//  Codigo : SMIS083121

//  Nombre : Zelaya Chavez, Kevin Alejandro
//  Codigo : SMIS091121
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosCelciosAGradosFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, result;

            Console.WriteLine("Detalle La Cantidad de Grados Celcios Que desea Convertir a Fahrenheit.");
            a = float.Parse(Console.ReadLine());

            result = (a * 9 / 5) + 32;
            Console.WriteLine(" ");

            Console.WriteLine("El resultado de la conversion es: {0}", result);
            Console.ReadLine();


        }
    }
}
