using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCalculator
{
    public class Program
    {
        

        public Program() 
        { 
        Menu menu = new Menu();
            menu.ExibirMenu();

        }
        static void Main(string[] args)
        {
            Program ex = new Program(); 
            Console.ReadKey();  

        }
    }
}
