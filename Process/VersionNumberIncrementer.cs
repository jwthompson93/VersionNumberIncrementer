using VersionNumberIncrementer.Handler;
using VersionNumberIncrementer.Objects;
using VersionNumberIncrementer.Splitter;

namespace VersionNumberIncrementer.Process
{
    public class VersionNumberProcess
    {
        public void Process()
        {
            // Obtains the Version Number from the source
            string versionNumberString = GetVersionNumber();

            // Splits the version number into an integer array
            int[] versionNumberArray = SplitVersionNumber(versionNumberString);

            // Places the integer array into a VersionNumber object
            VersionNumber versionNumber = new VersionNumber(versionNumberArray);
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
