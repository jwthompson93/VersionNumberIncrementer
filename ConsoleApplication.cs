
using VersionNumberIncrementer.Process;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        public static void Main(string[] args)
        {
            VersionNumberProcess versionNumberIncrementer = new VersionNumberProcess();
            versionNumberIncrementer.Process();
        }
    }
}
