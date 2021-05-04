using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutos
{
    class Program
    {
        static void Main(string[] argumentos)
        {

            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "requejão", "refrigerante", "arroz", "alfaçe", "frango", "doce"
            };

            try
            {
               var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
               foreach(var produtosSelecionado in produtosSelecionados)
               {
                   Console.WriteLine($"Este produto nós temos: {produtosSelecionado}");
               }

               var produtosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Contains(argumento)).ToList();
               foreach(var produtoNaoDisponivel in produtosNaoDisponiveis)

                {
                    Console.WriteLine($"Este produto nós não temos infelizmente =/ : {produtoNaoDisponivel}");
                }

                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto dísponvel: ${produtoOrdenado}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos inválidos!");
            }

        }
    }
}
