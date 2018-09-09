using System;

namespace numeros_aleatorios
{
    public class Program
    {
        public static void Main()
        {
            Random r = new Random();
            int aleatorio = r.Next(1, 11);
            Console.WriteLine("un numero entero entre 1 y 10 es:{0} ", aleatorio);
            int aleatorio2 = r.Next(10, 21);
            Console.WriteLine("Otro entre 10 y 20 es: {0}", aleatorio2);


            Console.ReadKey();
        }
    }
}
