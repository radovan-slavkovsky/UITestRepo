﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.NUnit.Tests.Sections
{
    interface IPages
    {
        bool IsAt();
        void GoTo();

    }
}
