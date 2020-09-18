using System;

namespace Leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite algo: ");
            string texto = Console.ReadLine();  
            string novoTexto = texto
                .Replace("a", "4").Replace("A", "4")
                .Replace("E", "3").Replace("e", "3")
                .Replace("I", "1").Replace("i", "1")
                .Replace("l", "1").Replace("L", "1")
                .Replace("o", "0").Replace("O", "0")
                .Replace("t", "7").Replace("T", "7")
                .Replace("s", "5").Replace("S", "5");
            Console.WriteLine(novoTexto);
        }
    }
}
