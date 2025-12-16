using System;
using System.Collections.Generic;
using System.Text;
using DesafioHackerRank.Desafios;

namespace DesafioHackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            
            var desafios = new Dictionary<string, IDesafio>(StringComparer.OrdinalIgnoreCase)
            {
                ["001"] = new SolveMeFirst(),
                ["002"] = new SimpleArraySum(),
                ["004"] = new DiagonalDifference()
            };

            string codigoEscolhido;

            if (args.Length > 0)
            {
                
                codigoEscolhido = args[0];
            }
            else
            {
                Console.WriteLine("=== Desafios HackerRank ===");
                Console.WriteLine("Desafios disponíveis:");

                foreach (var d in desafios.Values)
                {
                    Console.WriteLine($"{d.Codigo} - {d.Nome}");
                }

                Console.WriteLine();
                Console.Write("Digite o código do desafio que deseja executar: ");
                codigoEscolhido = Console.ReadLine() ?? "";
            }

            if (!desafios.TryGetValue(codigoEscolhido, out var desafioSelecionado))
            {
                Console.WriteLine();
                Console.WriteLine($"Desafio \"{codigoEscolhido}\" não encontrado.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine($"=== Executando desafio {desafioSelecionado.Codigo} - {desafioSelecionado.Nome} ===");
            Console.WriteLine();

            desafioSelecionado.Executar();

            Console.WriteLine();
            Console.WriteLine("=== Fim do desafio ===");
        }
    }
}
