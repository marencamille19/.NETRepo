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

        }
    }
}
