using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionNumberIncrementer.Extractor
{
    public interface VersionNumberExtractor
    {
        public int[] ReadVersionNumber();
        public int[] WriteVersionNumber(int[] versionNumberArray);
    }
}
