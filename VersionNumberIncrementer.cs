
using VersionNumberIncrementer.Handler;

namespace VersionNumberIncrementer
{
    public class VersionNumberIncrementer
    {
        public static void Main(string[] args)
        {
            VersionNumberHandler versionNumberExtractor = new FileVersionNumberHandler("..\\..\\..\\ProductInfo.txt");
            string versionNumber = versionNumberExtractor.ReadVersionNumber();
            Console.WriteLine(versionNumber);
        }
    }
}
