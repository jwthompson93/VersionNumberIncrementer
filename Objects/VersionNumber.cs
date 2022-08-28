using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionNumberIncrementer.Objects
{
    public class VersionNumber
    {
        private int majorNumberPosition;
        private int minorNumberPosition;
        private int[] versionNumberArray;


        public VersionNumber(int[] versionNumberArray)
        {
            this.versionNumberArray = versionNumberArray;
            this.majorNumberPosition = 2;
            this.minorNumberPosition = 3;
        }

        public VersionNumber(int[] versionNumberArray, int majorNumberPosition, int minorNumberPosition)
        {
            this.versionNumberArray = versionNumberArray;
            this.majorNumberPosition = majorNumberPosition - 1;
            this.minorNumberPosition = minorNumberPosition - 1;
        }

        public void incrementMajorVersion()
        {
            versionNumberArray[majorNumberPosition]++;
            versionNumberArray[minorNumberPosition] = 0;
        }

        public void incrementMinorVersion()
        {
            versionNumberArray[minorNumberPosition]++;
        }

        public string getFormattedVersionNumber()
        {
            return String.Join('.', versionNumberArray);
        }
    }
}
