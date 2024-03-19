using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção A, B ou C.");
            string opcao = Console.ReadLine().ToUpper();

            switch(opcao)
            {
                case "A":
                    Console.WriteLine("Opção selecionada foi A.");
                    break;
                case "B":
                    Console.WriteLine("Opção selecionada foi B.");
                    break;
                case "C":
                    Console.WriteLine("Opção selecionada foi C.");
                    break;
                default: Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
