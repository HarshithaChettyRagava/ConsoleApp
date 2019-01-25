using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            bool isStoreOpen = false;
            int time24hrsformat;
            double customerAge;
            char toExit = 'q';
            String itemName = String.Empty;
            decimal itemCost;
            decimal totalCost;
            decimal tax = 0.30m;

            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Welcome {name}.");

            Console.WriteLine("Please enter your age");
            String getAge = Console.ReadLine();
            customerAge = Convert.ToDouble(getAge);
            if(customerAge<=10){
                Console.WriteLine($"Sorry {name}, You are not having enough age to do shopping!");
            }
            else{
            Console.WriteLine("\nPlease enter current time in 24hours format");
            var str_time = Console.ReadLine();
            time24hrsformat = Int32.Parse(str_time);
            if (time24hrsformat <= 12)
            {
                Console.WriteLine("Store is Open! Happy shopping\n");
                isStoreOpen = true;
            }
            else if (time24hrsformat > 12 && time24hrsformat <= 24)
            {
                Console.WriteLine("Sorry,Store is Closed!");
                isStoreOpen = false;
            }
            else
                Console.WriteLine("Please enter valid 24hrs format time\n");


            // if(result.Equals("Y") || result.Equals("y")){
            //         isStoreOpen = true;
            // }
            // else if(result.Equals("N") || result.Equals("n")){
            //         isStoreOpen = false;
            //         Console.WriteLine("Sorry, The store is closed!");
            // }
            // else{
            //     Console.WriteLine("Please enter valid string");
            // }


            while (isStoreOpen)
            {
                Console.WriteLine("Please select your item listed below:\n");
                Console.WriteLine("Fat_FreeMushroom_Soup\n");
                Console.WriteLine("Fullchicken\n");
                Console.WriteLine("VegSandwich\n");
                Console.WriteLine("Donut\n");
                Console.WriteLine("Cinnamon rolls_Pac\n");
                Console.WriteLine("Enter item name or 'q' to quit: ");
                itemName = Console.ReadLine();  //always return a string
                // toExit = char.Parse(str);
                if (itemName.Equals(toExit))
                {
                    Console.WriteLine("Done!");
                    break;
                }
                else
                    isStoreOpen = false;

                switch (itemName)
                {
                    case "Fat_FreeMushroom_Soup":
                        itemCost = 3.4m;
                        break;
                    case "Fullchicken":
                        itemCost = 7.5m;
                        break;
                    case "VegSandwich":
                        itemCost = 2.0m;
                        break;
                    case "Donut":
                        itemCost = 0.78m;
                        break;
                    case "Cinnamon rolls_Pac":
                        itemCost = 2.45m;
                        break;
                    default:
                        itemCost = 0.0m;
                        tax = 0.0m;
                        break;
                }
                totalCost = itemCost + tax;
                Console.WriteLine($"{name}, Your item cost is: ${totalCost}.");
            }
        }
    }
}
}