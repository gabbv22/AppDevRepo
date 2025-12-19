using System;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Tip Calculator=====");

            Console.WriteLine("\nPress ENTER to proceed.\n");
            Console.ReadKey();


            Console.WriteLine("Enter Customer's Bill: ");
            string billInput = Console.ReadLine();
            double billTotal = Convert.ToDouble(billInput);


            Console.WriteLine("\nThank you for dining in our restaurant!\n");
            Console.WriteLine("Your bill is: PHP" + billTotal);

            Console.Write("\nHow much tip would you like to give (%): ");
            string tipInput = Console.ReadLine();
            double tipPercent = Convert.ToDouble(tipInput);

            double tipAmount = billTotal * tipPercent / 100;
            double totalAmount = billTotal + tipAmount;

            Console.WriteLine("\nTip Amount: PHP" + tipAmount);
            Console.WriteLine("Total Amount: PHP"+ totalAmount);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
