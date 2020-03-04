using System;

namespace Secondlesson.calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite pirma skaiciu");
            string num1 = Console.ReadLine();
            Console.WriteLine("Irasykite antra skaiciu");
            string num2 = Console.ReadLine();
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);
            //sudetis
            int sudetis = number1 + number2;
            Console.WriteLine("Suma "+ sudetis);
            //atimtis
            int atimtis = number1 - number2; ;
            Console.WriteLine("Atimtis: " + atimtis);
            //daugyba
            int daugyba = number1 * number2; ;
            Console.WriteLine("Daugyba: " + daugyba);
            //dalyba
            int dalyba = number1 / number2;
            Console.WriteLine("Dalyba: " + dalyba);

        }
    }
}
