using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VersionNumberIncrementer.Handler;
using VersionNumberIncrementer.Splitter;

namespace VersionNumberIncrementer
{
    public class VersionNumberIncrementer
    {
        public void process()
        {
            // Obtains the Version Number from the source
            string versionNumber = GetVersionNumber();

            // Splits the version number into an integer array
            int[] versionNumberArray = SplitVersionNumber(versionNumber);


        }

        private string GetVersionNumber()
        {
            // Obtains the Version Number from the source
            VersionNumberHandler versionNumberHandler = new FileVersionNumberHandler("..\\..\\..\\ProductInfo.txt");
            string versionNumber = versionNumberHandler.ReadVersionNumber();
            Console.WriteLine(versionNumber);

            return versionNumber;
        }

        private int[] SplitVersionNumber(string versionNumber)
        {
            VersionNumberSplitter versionNumberSplitter = new VersionNumberSplitter();
            int[] versionNumberArray = versionNumberSplitter.SplitVersionNumber(versionNumber, '.');
            return versionNumberArray;
        }
    }
}
