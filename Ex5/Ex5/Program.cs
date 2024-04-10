using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            string reverso = "";

            for(int i = palavra.Length-1; i >= 0;i--)
            {
                reverso += palavra[i];
            }

            Console.WriteLine($"Palavra invertida: {reverso}");

            Console.ReadKey();
        }
    }
}
