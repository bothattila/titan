using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Living;

namespace Titan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Humanoid humanoid = new Humanoid();
            humanoid.Name = "Attila";
            humanoid.Greeting();
            humanoid.Introducing();
            

            // Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
