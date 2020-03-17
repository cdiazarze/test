using HelloWorldApp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warriorFirst = new Warrior("Bob", "Kunga");
            Console.WriteLine(warriorFirst.GetName());
            Console.ReadKey();
        }
    }
}
