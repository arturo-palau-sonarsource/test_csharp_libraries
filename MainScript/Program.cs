using Library1;
using Library2;
using System;

namespace MainScript
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Console.WriteLine("Result: " + result);

            var printer = new Printer();
            printer.PrintMessage("Hello from MainScript!");

            Console.ReadLine();
        }
    }
}
