using System;

namespace ListaDeConvidados
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do convidado");
            var nome = Console.ReadLine();
             

            if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome não informado para seguir com o programa");
                return;
            }

            Console.WriteLine("Informe a idade do convidado:");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
           
            if (idadeInformada == false)
            {
                Console.WriteLine("Idade não informada para seguir com o programa");
                return;
            }
            bool estaConvidado;
            switch (nome)
            {
                case "Daniel":
                    estaConvidado = true;
                    break;
                case "Evandro":
                    estaConvidado = true;
                    break;
                case "Matheus":
                    estaConvidado = true;
                    break;
                case "Ale":
                    estaConvidado = true;
                    break;
                case "Teresa":
                    estaConvidado = true;
                    break;
                case "Gabriel":
                    estaConvidado = true;
                    break;
                case "Cledson":
                    estaConvidado = true;
                    break;
                case "Giuseppe":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;
            }
            
            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns, seja bem vinda a festa");
               
            }
            else if(estaConvidado == false)
            {
                Console.WriteLine("Voce não esta na lista de convidados");
            }
            else
            {
                Console.WriteLine("Voce nao tem 18 anos");
            }
        }
    }
}
