using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Favor informar palavras no argumento");
                return;
            }
          //for
          for(var indice = 0; indice < args.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, indice e valor: {indice},{args[indice]}");
            }
            //while
            var argumentosLidos = 0;
          while(argumentosLidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, argumentosLidos e valor lido: {argumentosLidos}, {args[argumentosLidos]}");
                argumentosLidos++;
            }
        }
    }
}
