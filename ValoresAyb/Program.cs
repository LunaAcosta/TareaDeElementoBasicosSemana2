
//  Nombre : Luna Acosta, Kevin Alexander
//  Codigo : SMIS083121

//  Nombre : Zelaya Chavez, Kevin Alejandro
//  Codigo : SMIS091121


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresAyb
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, result, resulta;

            Console.WriteLine("Escriba el valor de a ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el valor de b ");
            b = float.Parse(Console.ReadLine());

            result = (a + b) * (a - b);
            resulta =  a*2 - b;

            Console.WriteLine(" ");
            Console.WriteLine("El resultado de (a + b) * (a - b) es: {0}  ", result);
            Console.WriteLine(" ");
            Console.WriteLine("El resultado de a(2) - b es: {0}  ", resulta);





            Console.ReadKey();



                





        }
    }
}
