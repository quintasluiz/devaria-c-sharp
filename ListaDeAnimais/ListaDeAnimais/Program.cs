using ListaDeAnimais.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeAnimais
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            // Recebe um nome de animal vertebrado
            Console.WriteLine("Favor digitar o nome do animal: ");
            var nomeAnimal = Console.ReadLine();
            if (string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido");
                return;

            }

            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new mamifero() { Nome = "Vaca", QuantidadeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() { Nome = "Cobra" });
            listaDeAnimais.Add(new Ave() { Nome = "Gaviao" });
            listaDeAnimais.Add(new Peixe() { Nome = "Tubarao", QuantidadeDeNadadeiras = 2 });

            //de acordocom um filtro para encontrar o animal
            var animalSelecionado = listaDeAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            if(animalSelecionado == null)
            {
                Console.WriteLine("O animal selecionadonao esta na nossa lista");
                return;
            }
            //identifica a qual grupo ele pertence

            //e exibir os dados genericos e exclusivos de cada grupo animal
            if(animalSelecionado is mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamifero com nome {animalSelecionado.Nome} e quantidade de mamas = {((mamifero)animalSelecionado).QuantidadeDeMamas}");

            }else if (animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um reptil com nome {animalSelecionado.Nome} e nao sabe controlar sua temperatura = {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo}");
           
            }else if (animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome {animalSelecionado.Nome} e tem penas = {((Ave)animalSelecionado).TemPena}");
            
            }else if(animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome {animalSelecionado.Nome} e  tem = {((Peixe)animalSelecionado).QuantidadeDeNadadeiras}");
          
            }else
            {
                Console.WriteLine($"O animal encontrado é um animal com  nome {animalSelecionado.Nome}");
            }
        }
    }
}
