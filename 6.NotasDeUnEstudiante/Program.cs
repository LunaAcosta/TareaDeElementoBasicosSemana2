

//  Nombre : Luna Acosta, Kevin Alexander
//  Codigo : SMIS083121

//  Nombre : Zelaya Chavez, Kevin Alejandro
//  Codigo : SMIS091121

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.NotasDeUnEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {

            double Nota1, nota2, nota3, p1, p2, p3,  prom;

            Console.Write("Ingrese Su Primera Nota : "); 
            Nota1 = double.Parse(Console.ReadLine());

            p1 = (Nota1 * 0.30);

            Console.Write("Ingrese Su Segunda Nota : ");
            nota2 = double.Parse(Console.ReadLine());

            p2 = (nota2 * 0.35);

            Console.Write("Ingrese Su Tercera Nota : ");
            nota3 = double.Parse(Console.ReadLine());

            p3 = (nota3 * 0.25);

            prom = (p1 + p2 + p3);
            Console.WriteLine(" ");
            Console.WriteLine("Su Primera Nota Es: {0}  ", Nota1);
            Console.WriteLine("Su Segunda Nota Es: {0}  ", nota2);
            Console.WriteLine("Su Tercera Nota Es: {0}  ", nota3);
            Console.WriteLine(" ");
            Console.WriteLine("Primera Nota Con El Porcentaje Aplicado: {0}  ", p1);
            Console.WriteLine("Segunda Nota Con El Porcentaje Aplicado: {0}  ", p2);
            Console.WriteLine("Tercera Nota Con El Porcentaje Aplicado: {0}  ", p3);
            Console.WriteLine(" ");
            Console.WriteLine("LA NOTA FINAL ES: {0}  ", prom);
           

            Console.ReadKey();






        }
    }
}
