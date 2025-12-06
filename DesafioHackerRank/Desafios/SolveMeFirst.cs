using System;

namespace DesafioHackerRank.Desafios
{
    public class SolveMeFirst : IDesafio
    {
        public string Codigo => "001";
        public string Nome => "SolveMeFirst";

    private static int somar(int a, int b)
        {
            return a + b;
        }

        public void Executar()
        {
            
            // (SolveMeFirst)
        Console.WriteLine("Digite os 2 elementos (um por linha):");
         int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int total = somar(val1, val2);

        Console.WriteLine(total);
        }
    }
}

