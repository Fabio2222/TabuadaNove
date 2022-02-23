using System;

namespace Tabuada_Nove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, i;
            int resultado;

            
            do
            {
                Console.WriteLine("Digite um numero de 1 a 9! ");
                numero = int.Parse(Console.ReadLine());
            } while (numero < 1 || numero > 9);        
                                   
                       
                for (i = 0; i <= 10; i++)
                {
                    resultado = numero * i;
                    Console.WriteLine("O resultado da multiplicacao por {0} e {1}", i, resultado);
                }
                       
        }
    }
}
