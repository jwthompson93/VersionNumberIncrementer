using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VersionNumberIncrementer.Extractor
{
    public class FileVersionNumberExtractor : VersionNumberExtractor
    {
        private string fileName;

        public FileVersionNumberExtractor(string fileName)
        {
            this.fileName = fileName;
        }

        public int[] ReadVersionNumber()
        {
            int[] versionNumberArray = { 0, 0, 0, 0 };

            try
            {
                string versionNumber = File.ReadAllText(fileName);

                string[] versionNumberStringArray = versionNumber.Split('.');
                Console.WriteLine(versionNumberStringArray);
                versionNumberArray = Array.ConvertAll(versionNumberStringArray, v => int.Parse(v));
                Console.WriteLine(versionNumberArray);

                return versionNumberArray;
            }
            catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
                Console.WriteLine("ERROR: Version Number contains non-numeric values");
                Console.WriteLine("Exiting...");
                System.Environment.Exit(0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                System.Environment.Exit(0);
            }

            return versionNumberArray;
        }

        public int[] WriteVersionNumber(int[] versionNumberArray)
        {
            throw new NotImplementedException();
        }
    }
}
