using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double studio = 0;
            double doubleStudio = 0;
            double suit = 0;

            switch (month)
            {
                case "May":
                    studio = 50 * nights;
                    doubleStudio = 65 * nights;
                    suit = 75 * nights;
                    break;
                case "October":
                    studio = 50 * nights;
                    doubleStudio = 65 * nights;
                    suit = 75 * nights;
                    break;
                case "June":
                    studio = 60 * nights;
                    doubleStudio = 72 * nights;
                    suit = 82 * nights;
                    break;
                case "September":
                    studio = 60 * nights;



                    doubleStudio = 72 * nights;
                    suit = 82 * nights;
                    break;
                case "July":
                    studio = 68 * nights;
                    doubleStudio = 77 * nights;
                    suit = 89 * nights;
                        
                    break;
                case "August":
                    studio = 68 * nights;
                    doubleStudio = 77 * nights;
                    suit = 89 * nights;
                    break;
                case "December":
                    studio = 68 * nights;
                    doubleStudio = 77 * nights;
                    suit = 89 * nights;
                    break;
                default:
                    studio = 0;
                    break;
            }
            if (nights > 7 && (month == "May" || month == "October"))
            {
                studio = (studio * 0.95);
            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                doubleStudio = (doubleStudio * 0.90);
            }
                else if (nights > 14 && (month == "July" || month == "August" || month == "December"))
            {
                suit = (suit * 0.85);
            }
             if (nights > 7 && month == "September")
            {
                studio = studio - 60;
            }                
             if (nights > 7 && month == "October")
            {
                studio = studio - 47.5;
            }
            Console.WriteLine("Studio: {0:f2} lv.",studio);
            Console.WriteLine("Double: {0:f2} lv.",doubleStudio);
            Console.WriteLine("Suite: {0:f2} lv.",suit);
        }
    }
}
