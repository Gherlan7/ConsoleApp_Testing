using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings,");
            Console.WriteLine("Have fun today learning new things !");
            Console.WriteLine("Tell me your name:");

            string userName = Console.ReadLine();
            Console.WriteLine("So, your name is: " + userName);
            
        }
    }
}
