﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectQLSV
{
    class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId (int userId)
        {
            GlobalUserId = userId;
        }
    }
}
