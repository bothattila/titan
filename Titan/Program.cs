using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Living;
using Titan.Utils;

namespace Titan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Humanoid humanoid = new Humanoid();
            //humanoid.Name = "Attila";
            humanoid.Greeting();
            humanoid.Introducing();
            Console.WriteLine("***");
            Console.WriteLine(humanoid.ToString());
            Console.WriteLine("***");

            Orc orc = new Orc();
            orc.Name = "Ferencorak";
            orc.Introducing();
            orc.Greeting();
            Console.WriteLine(orc.ToString());
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.WriteLine("***");


            int humansToCreate = 40;
            Humanoid[] myHumanGroup = new Humanoid[humansToCreate];
            for (int i = 0; i < humansToCreate; i++)
            {
                // Instantiate a new object, set it's number and
                // some other properties
                myHumanGroup[i] = new Humanoid()
                {
                    //Name = "pityu"
                };
                myHumanGroup[i].Greeting();
                myHumanGroup[i].Introducing();
                
                // Console.WriteLine(myHumanGroup[i].Diplomacy.GetType());
                Console.WriteLine("Diplomacy skill level: " + myHumanGroup[i].Diplomacy.ToString());
                Console.WriteLine("Martial skill level: " + myHumanGroup[i].Martial.ToString());
                Console.WriteLine("Stewardship skill level: " + myHumanGroup[i].Stewardship.ToString());
                Console.WriteLine("Intrigue skill level: " + myHumanGroup[i].Intrigue.ToString());
                Console.WriteLine("Learning skill level: " + myHumanGroup[i].Learning.ToString());
                Console.WriteLine("***");

            }

            Console.WriteLine("***");
            Console.WriteLine("***");

            myHumanGroup[1].Learning = myHumanGroup[1].Learning + ((myHumanGroup[1].Learning / 100) * 5);
            Console.WriteLine("Learning skill level: " + myHumanGroup[1].Learning.ToString());


            Console.WriteLine("***");
            Console.WriteLine("***");
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            IOUtils.ReadTxtFile();
            // Console.WriteLine("Hello");
            Console.ReadKey();
        }
    }
}
