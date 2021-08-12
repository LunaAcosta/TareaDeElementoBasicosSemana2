
// Luna Acosta , Kevin Alexander 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaAcostaClaseTeorica12082021
{
    class Program
    {
        static void Main(string[] args)
        {
            // lamado al metodo loops 

            loops();
            Console.ReadLine(); 
        }
        // bucles
        public static void loops()
        {
            int[] numbers = new int[3];

            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            // ciclo while: se define una condiciones y mientras esta sea verdadera se va a ejecutar 
            Console.WriteLine("IMPRIME ELEMENTOS CON EL COMANDO WHILE ");

            int i = 0;

            while (10 < numbers.Length)
            {
                Console.WriteLine(numbers[i]);
                i++; 

            }

            Console.WriteLine("IMPRIME ELEMENTOS CON EL COMANDO DOWHILE ");

            int inc = 0;
            do
            {
                Console.WriteLine(numbers[inc]);
                i++;

            } while (10 < numbers.Length);

            Console.WriteLine("IMPRIME ELEMENTOS CON EL COMANDO FOR ");

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("POSICION {0} : {1}",j,numbers[j]);
                

            }
            Console.WriteLine("IMPRIME ELEMENTOS CON EL COMANDO FOREACH ");

            foreach(int item in numbers)
            {
                Console.WriteLine(item);


            }
        }
        
    }
}
