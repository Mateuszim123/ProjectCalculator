using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    internal class MenoPrincipal
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
                        RealizarOperacao(metodos.Soma);
                        break;
                    case "2":
                        RealizarOperacao(metodos.sub);
                        break;
                    case "3":
                        RealizarOperacao(metodos.Multiplicar);
                        break;
                    case "4":
                        RealizarOperacao(metodos.div);
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

        private void RealizarOperacao(Func<double, double, double> operacao)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = operacao(num1, num2);
            Console.WriteLine($"Resultado: {resultado}\n");
        }
    }


}
}
