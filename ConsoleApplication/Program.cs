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
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;

            Console.WriteLine("My name is {0}, and I am from {1}.", name, location);
            Console.WriteLine("Date is {0}", date);
            
            //Still need to add the countdown to Christmas
        
        }
        class GlazerCalc
        {
            static void Main()
            {
                double width, height, woodLength, glassArea;
                string widthString, heightString;
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
                woodLength = 2 * (width + height) * 3.25;
                glassArea = 2 * (width * height);
                Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
                Console.WriteLine("The area of the glass is " +
                glassArea + " square meters");
            }
        }
    }
}