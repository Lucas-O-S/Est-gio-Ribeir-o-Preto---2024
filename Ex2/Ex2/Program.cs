using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {

        public static bool VerificarFiboniacci(int numero)
        {
            int atual = 0;
            int anterior = atual;
            while (numero >= atual)
            {


                if (atual == numero)
                {
                    return true;
                }

                if (atual == 0) { atual += 1; }

                else {
                    int temp = atual; 
                    atual += anterior;
                    anterior = temp;
                
                
                
                }


          

            }

            return false;
        }

        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            bool teste = VerificarFiboniacci(numero);

            if (teste)
            {
                Console.WriteLine("O numero digitado pertence a sequencia de fibonachi");

            }

            else
            {
                Console.WriteLine("O numero digitado não pertence a sequencia de fibonachi");

            }

            Console.ReadKey();

        }
    }
}
