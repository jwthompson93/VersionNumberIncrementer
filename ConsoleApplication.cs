
using CommandLine;
using VersionNumberIncrementer.Objects;
using VersionNumberIncrementer.Process;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        public static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(Run);
        }

        private static void Run(Options opts)
        {
            string version = opts.version.ToLower();
            if (version.Equals("major") || version.Equals("minor"))
            {
                VersionNumberProcess versionNumberProcess = new VersionNumberProcess();
                versionNumberProcess.Process(version);
            }
            else
            {
                Console.WriteLine("ERROR: --version option is required to be either (major | minor)");
                Console.WriteLine("Exiting...");
                System.Environment.Exit(0);
            }
        }
    }
}
