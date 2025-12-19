using System;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Tip Calculator=====");
            Console.WriteLine("\nPress ENTER to proceed.\n");
            Console.WriteLine("==========================\n");
            Console.ReadKey();

            Console.WriteLine("==========================\n");
            Console.WriteLine("Enter Customer's Bill: ");
            string billInput = Console.ReadLine();
            double billTotal = Convert.ToDouble(billInput);

            Console.WriteLine("\n==========================\n");
            Console.WriteLine("Thank you for dining in our restaurant!\n");
            Console.WriteLine("Your bill is: PHP" + billTotal);

            Console.WriteLine("\n==========================\n");
            Console.Write("How much tip would you like to give (%): ");
            string tipInput = Console.ReadLine();
            double tipPercent = Convert.ToDouble(tipInput);

            Console.WriteLine("\n==========================\n");
            double tipAmount = billTotal * tipPercent / 100;
            double totalAmount = billTotal + tipAmount;

            Console.WriteLine("\n==========================\n");
            Console.WriteLine("Tip Amount: PHP" + tipAmount);
            Console.WriteLine("Total Amount: PHP"+ totalAmount);

            Console.WriteLine("\n==========================\n");
            Console.WriteLine("Thank you for using Tip Calculator.");
            Console.WriteLine("\nPress any key to exit.");
            Console.WriteLine("\n==========================\n");
            Console.ReadKey();

        }
    }
}
