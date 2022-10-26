using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Living
{
    internal class Humanoid
    {
        public string Name;

        public void Greeting()
        {
            Console.WriteLine("Greetings, I am a humanoid");
        }

        public void Introducing()
        {
            Console.WriteLine("My name is " + Name);
        }




    }
}
