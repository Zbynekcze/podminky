using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podminky
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press enter");
            //string userValue;
            //       userValue = Console.ReadLine();
            //Console.WriteLine("You type: " + userValue);
            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3");
            string userValue = Console.ReadLine();
            /*
            string message = "";
            if (userValue == "1")
            {
                message = "You won a new licence Visual Studio 2013 Ultimate with unlimited subscribtion";                
            }
            else if (userValue == "2")
            {
                message = "You won a new licence for windows 8.1";
            }
            else if (userValue == "3")
            {
                message = "advance to the next level of programming";
            }
            else
            {
                message = "Unfortunately, you did not win";
            }
            Console.WriteLine(message);*/
            string message = (userValue == "1") ? "First" : "second";
            Console.WriteLine("You are {0}!", message);
            Console.ReadLine();
        }
    }
}
