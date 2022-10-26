using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Utils
{
    public static class IOUtils
    {
        
        
        public static void ReadTxtFile()
        {
            /// <summary>
            ///     Creates an enumeration of every line in a file.
            /// </summary>
            /// <param name="filePath">Path to file.</param>
            /// <returns>Enumeration of lines in specified file.</returns>
            IEnumerable<string> GetFileLines(string filePath)
            {
                // Open the file.
                var fileStream = new System.IO.StreamReader(filePath);

                // Read each line.
                string line;
                while ((line = fileStream.ReadLine()) != null) yield return line;

                // Shut it down!
                fileStream.Close();
            }

            string path = Directory.GetCurrentDirectory();
            string backslash = @"\";
            foreach (var line in GetFileLines(path + backslash + "common" + backslash + "forenames.txt")) Console.WriteLine(line);
            // Get lines as list.
            var lines = GetFileLines(path + backslash + "common" + backslash + "forenames.txt").ToList();

            // How many lines are there?
            var numberOfLines = lines.Count;

            // Add a new line.
            // lines.Add("This is another line we are adding to our list");

            // If you want it as an array, make an array from the list after manipulating
            var lineArray = lines.ToArray();

            //
            //Console.WriteLine("The current directory is {0}", path);
            Console.WriteLine("Doing something");

        }

        public static string[] ReadTxtFileToArray()
        {
            /// <summary>
            ///     Creates an enumeration of every line in a file.
            /// </summary>
            /// <param name="filePath">Path to file.</param>
            /// <returns>Enumeration of lines in specified file.</returns>
            IEnumerable<string> GetFileLines(string filePath)
            {
                // Open the file.
                var fileStream = new System.IO.StreamReader(filePath);

                // Read each line.
                string line;
                while ((line = fileStream.ReadLine()) != null) yield return line;

                // Shut it down!
                fileStream.Close();
            }

            string path = Directory.GetCurrentDirectory();
            string backslash = @"\";
            foreach (var line in GetFileLines(path + backslash + "common" + backslash + "forenames.txt")) Console.WriteLine(line);
            // Get lines as list.
            var lines = GetFileLines(path + backslash + "common" + backslash + "forenames.txt").ToList();

            // How many lines are there?
            var numberOfLines = lines.Count;

            // Add a new line.
            // lines.Add("This is another line we are adding to our list");

            // If you want it as an array, make an array from the list after manipulating
            var lineArray = lines.ToArray();

            //
            //Console.WriteLine("The current directory is {0}", path);
            Console.WriteLine("Doing something");

            return lineArray;

        }


        public static string[] ReadSpecificTxtFileToArray(string folder, string filename)
        {
            /// <summary>
            ///     Creates an enumeration of every line in a file.
            /// </summary>
            /// <param name="filePath">Path to file.</param>
            /// <returns>Enumeration of lines in specified file.</returns>
            IEnumerable<string> GetFileLines(string filePath)
            {
                // Open the file.
                var fileStream = new System.IO.StreamReader(filePath);

                // Read each line.
                string line;
                while ((line = fileStream.ReadLine()) != null) yield return line;

                // Shut it down!
                fileStream.Close();
            }

            string path = Directory.GetCurrentDirectory();
            string backslash = @"\";
            foreach (var line in GetFileLines(path + backslash + folder + backslash + filename)) Console.WriteLine(line);
            // Get lines as list.
            var lines = GetFileLines(path + backslash + folder + backslash + filename).ToList();

            // How many lines are there?
            var numberOfLines = lines.Count;

            // Add a new line.
            // lines.Add("This is another line we are adding to our list");

            // If you want it as an array, make an array from the list after manipulating
            var lineArray = lines.ToArray();

            //
            //Console.WriteLine("The current directory is {0}", path);
            Console.WriteLine("Doing something");

            return lineArray;

        }

    }
}
