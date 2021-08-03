
//  Nombre : Luna Acosta, Kevin Alexander
//  Codigo : SMIS083121

//  Nombre : Zelaya Chavez, Kevin Alejandro
//  Codigo : SMIS091121


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CalculoDei
{
    class Program
    {
        static void Main(string[] args)
        {

            double  precio,IVA;
            
            // produc = double.Parse(Console.ReadLine());

            Console.Write("Ingresa El Precio Del Producto : ");
            precio = double.Parse(Console.ReadLine());

            IVA = precio * 0.13;
            Console.WriteLine(" ");
            Console.WriteLine("El Impuesto del producto es: {0}  ", IVA);


            Console.ReadKey();
        }
    }
}
