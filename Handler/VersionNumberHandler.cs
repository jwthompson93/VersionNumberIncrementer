using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionNumberIncrementer.Handler
{
    public interface VersionNumberHandler
    {
        public string ReadVersionNumber();
        public bool WriteVersionNumber(string versionNumber);
    }
}
