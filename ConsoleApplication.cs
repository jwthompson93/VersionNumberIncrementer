
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
                .WithParsed(Run);
        }

        private static void Run(Options opts)
        {
            string version = opts.release_type.ToLower();

            // Determines whether the input is valid for the version_type
            if (version.Equals("major") || version.Equals("minor"))
            {
                VersionNumberProcess versionNumberProcess = 
                    new VersionNumberProcess(opts.version_number_file);
                versionNumberProcess.Process(version, opts.major_release_position, 
                    opts.minor_release_position, opts.version_number_separator);
            }
            else
            {
                Console.WriteLine("ERROR: --release_type option is required to be either (major | minor)");
                Console.WriteLine("Exiting...");
                System.Environment.Exit(0);
            }
        }
    }
}
