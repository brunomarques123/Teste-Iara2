using System;
using System.Linq;

namespace ExemploArrayLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[11];

            //leitura dos numeros informador pelo usuario
            Console.WriteLine("Informe os números abaixo:");
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Numeros[" + i + "] :");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
                    
            //percorre os numeros e contanto so os diferente de par   
            int nimpar = (from n in numero select n).Where(n => n % 2 > 0).Count();

            Console.WriteLine($"Deste total os números impares são {nimpar}");
            Console.ReadLine();
        }
    }
}
