using System;

namespace Ciclo_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Inserta el numero con el que inicia el ciclo:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el numero con el que finaliza el ciclo:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserta el numero con el que quieres avance:");
            c = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i += c)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
