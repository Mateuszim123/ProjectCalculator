using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public class Metodos
    {

        public double a, b, result;

        public void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite dois numeros para que possamos somar os mesmos:\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            result = a + b;
            

            Console.WriteLine("O resultado da soma e:" + result);

        }

        public double sub(double a, double b, double result)
        {
            Console.WriteLine("Digite dois numeros para que possamos subtrair os mesmos:\n");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            return  a - b;

        }

        public double div(double a, double b, double result) 
        {
            Console.WriteLine("Digite dois numero para que possamos dividir os mesmo: \n");
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Erro, divisao por zero.");
                return 0;

            }
            return result;
        }

    }

}