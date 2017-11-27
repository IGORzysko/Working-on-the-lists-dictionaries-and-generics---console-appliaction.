using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = new Entity();
            var list = instance.MethodName();

            foreach (var item in list)
            {
                foreach (var item1 in item)
                    foreach (var item2 in item1)
                        Console.WriteLine($"{item2.Key}, {item2.Value}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
