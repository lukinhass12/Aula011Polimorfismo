
using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculo infoPlayer = new Calculo();

            // 1º opção, sem argumentos
            System.Console.WriteLine( infoPlayer.Calcular() );

            // 2º opção, com 1 argumento int
            System.Console.WriteLine( infoPlayer.Calcular(200) );

            // 3º opção, com 2 argumentos int
            System.Console.WriteLine( infoPlayer.Calcular(300,200) );

            // 4º opção, com 2 argumentos string
            System.Console.WriteLine( infoPlayer.Calcular("Alcool ", "em Gel") );


        }
    }
}
