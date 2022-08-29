using VersionNumberIncrementer.Handler;
using VersionNumberIncrementer.Objects;
using VersionNumberIncrementer.Splitter;

namespace VersionNumberIncrementer.Process
{
    public class VersionNumberProcess
    {
        private VersionNumber versionNumberObject;
        private VersionNumberHandler versionNumberHandler;

        public VersionNumberProcess(string filePath)
        {
            versionNumberHandler = new FileVersionNumberHandler(filePath);
        }

        public void Process(string version, int majorVersionPosition, 
            int minorVersionPosition, char separator)
        {
            // Obtains the Version Number from the source
            string versionNumberString = GetVersionNumber();

            // Splits the version number into an integer array
            int[] versionNumberArray = SplitVersionNumber(versionNumberString, separator);

            // Places the integer array into a VersionNumber object
            versionNumberObject = new VersionNumber(versionNumberArray, 
                majorVersionPosition, minorVersionPosition);

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
        private int[] SplitVersionNumber(string versionNumber, char separator)
        {
            VersionNumberSplitter versionNumberSplitter = new VersionNumberSplitter();
            int[] versionNumberArray = versionNumberSplitter.SplitVersionNumber(versionNumber, separator);
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