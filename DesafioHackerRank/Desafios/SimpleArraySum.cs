using System;
using System.Collections.Generic; 
using System.Linq;                

namespace DesafioHackerRank.Desafios
{
    public class SimpleArraySum : IDesafio
    {
        public string Codigo => "002"; 
        public string Nome => "SimpleArraySum"; 

        public static int somaArray(List<int> ar)
        {
           // int soma = 0;

            // Versão com for :
            // for (int i = 0; i < ar.Count; i++)
            // {
            //     soma += ar[i];
            // }

           
            // foreach (int numero in ar)
            // {
            //     soma += numero;
            // }

            // versao com LINQ
             return ar.Sum();
        }

    public void Executar()
    {
        Console.WriteLine("Digite os números do array separados por espaço (ex: 1 2 3 4 10 11):");

        string? linha = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(linha))
        {
            Console.WriteLine("Nenhum número informado.");
            return;
        }

        List<int> ar = linha
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();

        int result = somaArray(ar);

        Console.WriteLine($"Soma dos elementos: {result}");
    }    

    }
}
