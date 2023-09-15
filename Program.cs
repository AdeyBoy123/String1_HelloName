using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1_HelloName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine(helloName(name));
            Console.ReadLine();
        }

        static string helloName(string name)
        {
            return "Hello " + name + "!";
        }
    }
}
