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
            //do while
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, loopsEfetuados: {loopsEfetuados} e valor lido: {args[loopsEfetuados}");
                loopsEfetuados++;
            } while (loopsEfetuados < args.Length);

            //do while tras pra frente
            var argumentosRestantesASeremLidos = args.Length;
            do
            {
                Console.WriteLine($"Estrutura do while, argumentosRestantesASeremLidos: {argumentosRestantesASeremLidos}, valor lido:{args[argumentosRestantesASeremLidos - 1]}");
                argumentosRestantesASeremLidos--;
            } while (argumentosRestantesASeremLidos > 0);
        
            //foreach
            foreach(var argumento in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido: {argumento}");
            }
            }

    }
}
