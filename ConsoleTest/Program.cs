using System;

namespace ConsoleTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease Enter Your Percentage? ");
            decimal _percentage = Convert.ToDecimal( Console.ReadLine());
            decimal _range = 0;
            Program p = new Program();
            p.FxgetPercentage(_percentage);
        }
        private void Loop()
        {

            ConsoleKey response;
            bool confirmed = false;
            string Key;
            do
            {
                Console.Write("Do you want to try another percentage??[y/N]");
                Key = Console.ReadLine();


                do
                {
                    response = Console.ReadKey(false).Key;
                    if (response != ConsoleKey.Enter && response != ConsoleKey.Y && response != ConsoleKey.N)
                        Console.WriteLine("Please enter Y or N");

                } while (response != ConsoleKey.Y && response != ConsoleKey.N);
                if (response == ConsoleKey.N)
                {
                    Console.Write("\nPress any key to exit...");
                    break;
                }
                else
                {
                    confirmed = response == ConsoleKey.Y;
                }
               
            } while (!confirmed);
            if (response == ConsoleKey.Y)
            {
                Console.WriteLine("\nPlease Enter Your Percentage? ");
                decimal _percentage = Convert.ToDecimal(Console.ReadLine());
                Program p = new Program();
                p.FxgetPercentage(_percentage);
            }
               
        }
        private void FxgetPercentage(decimal _percentage)
        {
            if (_percentage >= 80)
            {
                Console.WriteLine("\n You passed with distinction. We prefer you Science faculty");
            }
            else if (_percentage <= Convert.ToDecimal(79.99) && _percentage > Convert.ToDecimal(60))
            {
                Console.WriteLine("\n You passed with First division. We prefer you Business Study");
            }
            else if (_percentage <= Convert.ToDecimal(79.99) && _percentage > Convert.ToDecimal(60))
            {
                Console.WriteLine("\n You passed with First division. We prefer you Business Study");
            }
            else if (_percentage <= Convert.ToDecimal(59.99) && _percentage > Convert.ToDecimal(45))
            {
                Console.WriteLine("\n You passed with Second division. We prefer you Arts");
            }
            else if (_percentage < Convert.ToDecimal(44.99))
            {
                Console.WriteLine("\n You are not eligible For Higher study");
            }
            Loop();
        }
    }
}
