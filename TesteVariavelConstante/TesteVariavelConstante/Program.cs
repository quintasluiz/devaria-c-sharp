using System;

namespace TesteVariavelConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string constante = "uma constante que nao muda";

            if(args.Length == 0)
            {
                Console.WriteLine("Favor informar um numero inteiro");
                return;
            }
            int inteiro;
            bool teste = int.TryParse(args[0], out inteiro);

            if(teste == false)
            {
                Console.WriteLine("O argummento informadonão é um numero inteiro");
                return;
            }
            Console.WriteLine(constante);
            Console.WriteLine("O numero informado foi: " + inteiro);
        }
    }
}
