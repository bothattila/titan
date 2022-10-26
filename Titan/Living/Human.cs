using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Living
{
    internal class Human : Humanoid
    {
        public override void Greeting()
        {
            Console.WriteLine("Greetings, I am a human");
        }
    }
}
