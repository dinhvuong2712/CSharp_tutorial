﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringTest
{
    class Version
    {
        private int numberOfVerSion;
        public int NumberOfVersion { get; set; }

        public override string ToString()
        {
            return "Hello " + NumberOfVersion;
        }
    }
}
