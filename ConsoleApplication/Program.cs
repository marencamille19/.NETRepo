using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Maren Stewart";
            string location = "Enumclaw, WA";
            
            var currentDate = DateTime.Now;

            var christmasDate = new DateTime(2020, 12, 25);
            var countdown = christmasDate - currentDate;

            Console.WriteLine($"My name is {name}, and I am from {location}.");
            Console.WriteLine("The current date is: " + currentDate.ToString("d"));
            Console.WriteLine("Number of days until Christmas: " + countdown.Days);

            //timespan object to convert countdown variable to number of days
            //Still need to add the countdown to Christmas

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.Write("Please enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.Write("Please enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }    
}
