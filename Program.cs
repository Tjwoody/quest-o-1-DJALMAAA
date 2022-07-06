using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_1_Djalma_N_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double notaF, notaT, notaP1, notaP2;
            Console.Write("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do seu trabalho:");
            notaT = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da sua primeira prova:");
            notaP1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da sua segunda prova:");
            notaP2 = Convert.ToInt32(Console.ReadLine());
            notaF = (notaT + notaP1 + notaP2) / 3;

            if (notaF >= 8.5)
            {
                Console.Write("O conceito Final é A");
            }
            else if (notaF >= 7.0)
            {
                Console.Write("O conceito Final é B");
            }
            else if (notaF >= 6.0)
            {
                Console.Write("O conceito final é C");
            }
            else if (notaF >= 0.1)
            {
                Console.Write("O conceito final é D");
            }
            else if (notaF == 0)
            {
                Console.Write("O conceito Final é E");
            }

            Console.ReadKey();
        }
    }
}
