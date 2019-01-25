using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Harshitha!!");
            bool isStoreOpen=false;
            int time24hrsformat;
            double customerAge;
            char toExit='q';
            String itemName=String.Empty;
            decimal itemCost;
            decimal totalCost;
            decimal tax=0.30m;

            Console.WriteLine("Please enter current time in 24hours format");
            var str_time = Console.ReadLine();
            time24hrsformat = Int32.Parse(str_time);
            if(time24hrsformat<=12){
                Console.WriteLine("Is Store Open? Y/N");
            var result=Console.ReadLine();
            }
            else if(time24hrsformat>12 && time24hrsformat<=24){


            }
            else
            Console.WriteLine("Please enter valid 24hrs format");

            
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
    

            while(isStoreOpen){
                Console.WriteLine("Please select your item listed below:");
                Console.WriteLine("Fat_FreeMushroom_Soup\n");
                Console.WriteLine("Fullchicken\n");
                Console.WriteLine("VegSandwich\n");
                Console.WriteLine("Donut\n");
                Console.WriteLine("Cinnamon rolls_Pac\n");
                Console.WriteLine("Enter item name or 'q' to quit: ");
                 itemName = Console.ReadLine();  //always return a string
                // toExit = char.Parse(str);
                if(itemName.Equals(toExit)){
                   Console.WriteLine("Done!");
                   break;
                }
                else
                isStoreOpen = false;  
            }

            switch (itemName){
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
                     break;
            }
        totalCost = itemCost+tax;
        Console.WriteLine($"Your item cost is: {totalCost}.");
       }
    }
}    
