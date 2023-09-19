using System.Globalization;

namespace Coffe_machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallPrice = 10;
            int mediumPrice = 20;
            int largePrice = 30;
            int totalCost = 0;
            bool isRunning = true;
            Console.WriteLine("Hej och välkommna!");

            try
            {
                while (isRunning)
                {
                    Console.WriteLine("Vilken storlek på kaffet vill du? \n[1]Small \n[2]Medium \n[3]Large");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    int price = 0;

                    switch (choice)
                    {
                        case 1:
                            price = smallPrice;
                            break;

                        case 2:
                            price = mediumPrice;
                            break;

                        case 3:
                            price = largePrice;
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val!");
                            continue;

                    }
                    totalCost += price;

                    Console.WriteLine("Vill du fortsätta beställa? Ja/Nej");
                    string input = Console.ReadLine();
                    if (input.ToUpper() == "Ja".ToUpper())
                    {

                    }
                    else if (input.ToUpper() == "Nej".ToUpper())
                    {
                        isRunning = false;
                        Console.WriteLine("Tack för denna gång!");
                        Console.WriteLine($"Din totalsumma blir: {totalCost}");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt val!");
                    }
                }
            
             }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}