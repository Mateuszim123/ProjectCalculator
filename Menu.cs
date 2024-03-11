using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public class Menu
    {
        private Metodos metodos;

        public Menu()
        {
            metodos = new Metodos();
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("Selecione uma operação:");
                Console.WriteLine("1. Somar");
                Console.WriteLine("2. Subtrair");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Sair");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        metodos.Soma();

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

    }



}
