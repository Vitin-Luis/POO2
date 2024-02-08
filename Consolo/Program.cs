using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número.");
            int numero = int.Parse(Console.ReadLine());
            Boolean primo = true;
            int escolha;
            do
            {
                Console.WriteLine("----MENU----");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("0 - SAIR");
                
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                        Console.WriteLine("Finalizando programa...");
                        break;

                    case 1:
                        Console.WriteLine("Soma = \n");
                        break;

                    case 2:
                        Console.WriteLine("Subtração = \n");
                        break;

                    case 3:
                        Console.WriteLine("Divisão = \n");
                        break;

                    case 4:
                        Console.WriteLine("Multiplicação = \n");
                        break;

                    default :
                        Console.WriteLine("Escolha um número válido!!\n");
                        break;
                }
            } while (escolha != 0);
        }
    }
}
