using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionNumberIncrementer.Splitter
{
    public class VersionNumberSplitter
    {
        public int[] SplitVersionNumber(string VersionNumber)
        {
            int[] versionNumberArray = { 0, 0, 0, 0 };

            try
            {
                string[] VersionNumberStringArray = VersionNumber.Split('.');
                Console.WriteLine(VersionNumberStringArray);
                versionNumberArray = Array.ConvertAll(VersionNumberStringArray, v => int.Parse(v));
                Console.WriteLine(versionNumberArray);
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.Message);
                Console.WriteLine("ERROR: Version Number contains non-numeric values");
                Console.WriteLine("Exiting...");
                System.Environment.Exit(0);
            }

            return versionNumberArray;
        }
    }
}
