using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3resource
{
   public class Program
    {
       
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("please enter your name");
            name = Console.ReadLine();
            Console.WriteLine($"hello:{name}");
            Console.ReadLine();
        }
    }
}
