using CommandLine;

namespace VersionNumberIncrementer.Objects
{
    public class Options
    {
        [Option("version_type", Required = true, HelpText = "Determines which number will be incremented (Major | Minor)")]
        public string version_type { get; set; }

        [Option("version_number_file", Required = true, HelpText = "THe file path for the Version Number file")]
        public string version_number_file { get; set; }

        [Option("major_number_position", Default = 3, Required = false, HelpText = "Determines where the major version number is positioned in the Version Number")]
        public int major_number_position { get; set; }

        [Option("minor_number_position", Default = 4, Required = false, HelpText = "Determines where the minor version number is positioned in the Version Number")]
        public int minor_number_position { get; set; }

        [Option("version_number_separator", Default = '.', Required = false, HelpText = "The character that separates the numbers in the Version Number")]
        public char version_number_separator { get; set; }
    }
}
