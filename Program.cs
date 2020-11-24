using System;

namespace Repeticao_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10. Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.

            Console.WriteLine("TABUADA\n");
            Console.WriteLine("Escolha a quantidade de tabuadas");
            int quant = int.Parse(Console.ReadLine());

            int numeroMax = 11;           


            for (var i = 1; i <= quant; i++)
            {
                Console.WriteLine("Tabuada do "+i+"\n");
                for (var multiplicador = 1; multiplicador < numeroMax; multiplicador++)
                {
                    Console.WriteLine(i+" X "+multiplicador+" = "+i*multiplicador);
                }

                Console.WriteLine(" \n");
            } 
        }
    }
}
