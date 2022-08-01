using System;

namespace SecuenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar la serie de Fibonacci
            Console.WriteLine("Primeros 15 numeros de la Serie de Fibonacci");
            int x = 1;
            int y = 0;
            int contador2 = 1;
            int[] array = new int[14];
            Console.Write(1);
            Console.Write(",");
            for (int contador = 0; contador < array.Length; contador++)
            {
                array[contador] = x + y;
                y = x;
                x = array[contador];
                Console.Write(array[contador]);
                contador2 += 1;
                if (contador2 <= array.Length)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.Write("...");
                }               
            }

            //Buscar un numero de la serie de Fibonacci
            Console.WriteLine("");
            int a, b, limite, i, auxiliar;
            Console.WriteLine("Ingrese el número de la serie de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
            }
            Console.WriteLine("Fib("+limite+")= " + a);
            Console.ReadKey();
        }
    }
}