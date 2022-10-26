using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Utils;

namespace Titan.Living
{
    internal class Humanoid
    {
        public string Name;

        public int Health;

        public double Diplomacy;
        public double Martial;
        public double Stewardship;
        public double Intrigue;
        public double Learning;

        public int sex_appeal_opinion;
        public int fertility;

        public Humanoid()
        {
            Name = MathUtils.randomVezeteknev();

            Health = 10;

            Diplomacy = StaticRandom.Instance.Next(1, 20);
            Martial = StaticRandom.Instance.Next(1, 20);
            Stewardship = StaticRandom.Instance.Next(1, 20);
            Intrigue = StaticRandom.Instance.Next(1, 20);
            Learning = StaticRandom.Instance.Next(1, 20);

            sex_appeal_opinion = 50;
            fertility = 50;


        }

        public virtual void Greeting()
        {
            Console.WriteLine("Greetings, I am a humanoid");
        }

        public void Introducing()
        {
            Console.WriteLine("My name is " + Name);
        }

        public override string ToString()
        {
            return $"{Name}";
        }


    }
}
