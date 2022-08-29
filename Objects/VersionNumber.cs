﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionNumberIncrementer.Objects
{
    public class VersionNumber
    {
        public int majorNumberPosition { get; }
        public int minorNumberPosition { get; }
        public int[] versionNumberArray { get; }

        public VersionNumber(int[] versionNumberArray, int majorNumberPosition, int minorNumberPosition)
        {
            this.versionNumberArray = versionNumberArray;
            Console.WriteLine("Version Number Length: {0}", versionNumberArray.Length);
            this.majorNumberPosition = majorNumberPosition - 1;
            Console.WriteLine("Major Release Position: {0}", majorNumberPosition);
            this.minorNumberPosition = minorNumberPosition - 1;
            Console.WriteLine("Minor Release Position: {0}", minorNumberPosition);
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
