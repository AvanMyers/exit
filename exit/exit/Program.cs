using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string enteredWord;
            bool cycleIsOver = false;

            Console.WriteLine("Данный цикл не закончится пока вы не введете 'exit'");

            while (cycleIsOver == true)
            {
                Console.WriteLine("Продолжаем?");
                enteredWord = Console.ReadLine();
                if (enteredWord == exit)
                {
                    cycleIsOver = true;
                    Console.WriteLine("Досвидание");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
