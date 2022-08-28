using VersionNumberIncrementer.Handler;
using VersionNumberIncrementer.Objects;
using VersionNumberIncrementer.Splitter;

namespace VersionNumberIncrementer.Process
{
    public class VersionNumberProcess
    {
        private VersionNumber versionNumberObject;
        private VersionNumberHandler versionNumberHandler;

        public VersionNumberProcess()
        {
            versionNumberHandler = new FileVersionNumberHandler("..\\..\\..\\ProductInfo.txt");
        }

        public void Process(string version)
        {
            // Obtains the Version Number from the source
            string versionNumberString = GetVersionNumber();

            // Splits the version number into an integer array
            int[] versionNumberArray = SplitVersionNumber(versionNumberString);

            // Places the integer array into a VersionNumber object
            versionNumberObject = new VersionNumber(versionNumberArray);

            IncrementVersionNumber(version);

            WriteVersionNumber();
        }

        // Gets the version number from the file specified
        private string GetVersionNumber()
        {
            string versionNumber = versionNumberHandler.ReadVersionNumber();
            Console.WriteLine("Current Version: " + versionNumber);

            return versionNumber;
        }

        // Splits the version number in an array to be processed
        private int[] SplitVersionNumber(string versionNumber)
        {
            VersionNumberSplitter versionNumberSplitter = new VersionNumberSplitter();
            int[] versionNumberArray = versionNumberSplitter.SplitVersionNumber(versionNumber, '.');
            return versionNumberArray;
        }

        // Increments the version number based on the parameters passed
        private void IncrementVersionNumber(string version)
        {
            if(version.ToLower().Equals("major"))
            {
                versionNumberObject.incrementMajorVersion();
            }
            else if(version.ToLower().Equals("minor"))
            {
                versionNumberObject.incrementMinorVersion();
            }

            Console.WriteLine("New Version: " + versionNumberObject.getFormattedVersionNumber());
        }

        // Writes the version number to the file
        private void WriteVersionNumber()
        {
            if(versionNumberHandler.WriteVersionNumber(versionNumberObject.getFormattedVersionNumber()))
            {
                Console.WriteLine("New version written to file");
            }
            else
            {
                Console.WriteLine("Unable to write new version to file");
            }
        }
    }
}