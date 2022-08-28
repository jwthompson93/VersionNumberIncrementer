using CommandLine;

namespace VersionNumberIncrementer.Objects
{
    public class Options
    {
        [Option("version_type", Required = true, HelpText = "Determines which number will be incremented (Major | Minor)")]
        public string version { get; set; }

        [Option("major_number_position", Required = false, HelpText = "Determines where the major version number is positioned in the Version Number")]
        public string major_number_position { get; set; }

        [Option("minor_number_position", Required = false, HelpText = "Determines where the minor version number is positioned in the Version Number")]
        public string minor_number_position { get; set; }
    }
}
