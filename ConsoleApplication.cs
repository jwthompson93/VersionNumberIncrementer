
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
                .WithParsed(Run)
                .WithNotParsed(o => Console.WriteLine("Not working!"));
        }

        private static void Run(Options opts)
        {
            string version = opts.version_type.ToLower();

            // Determines whether the input is valid for the version_type
            if (version.Equals("major") || version.Equals("minor"))
            {
                VersionNumberProcess versionNumberProcess = 
                    new VersionNumberProcess(opts.version_number_file);
                versionNumberProcess.Process(version, opts.major_number_position, 
                    opts.minor_number_position, opts.version_number_separator);
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
