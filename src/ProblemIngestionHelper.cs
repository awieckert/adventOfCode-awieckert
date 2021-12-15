using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace adventOfCode_awieckert
{
    public class ProblemIngestionHelper
    {

        public List<int> GetListOfInts(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Console.WriteLine($"File doesn't exist dumbass, path: {path}");
                }

                var listOfString = File.ReadAllLines(path);

                return listOfString.Select(int.Parse).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Daaayyyuumm you fucked up.", ex);
                throw;
            }
        }
    }
}
