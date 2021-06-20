using System;
using System.Collections.Generic;
using System.Linq;
using ListaProdutoMercadoClasse.Classes;

namespace ListaProdutoMercadoClasse
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 15.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.5 });

            if (argumentos.Length == 0)
            {
                Console.WriteLine("Voce nao passou os produtos que deseja comprar");
                return;

            }

            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto => argumentos.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach(var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nos temos {produto.ExibirDadosProduto()}");
            }
            var produtosSelecionadosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper()));
            
            foreach(var produtoNaoDisponivel in produtosSelecionadosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto nos nao temos {produtoNaoDisponivel}");
            }

            var produtosOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            foreach(var produtoOrdenado in produtosOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }
        }
   }
}
