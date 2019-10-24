using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*************************************");
            Console.WriteLine("***** Welcome to My Rocking App *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            int number1 = 3000;
            int number2 = 0;
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Catched Exception: Division of {0} by zero.", number1);
            }


            // Wait for Enter key to be pressed.
            Console.ReadLine();
            MessageBox.Show("All done!");
        }
    }
}