﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Misc
{
    internal class Misc
    {
        public static List<T> CreateGenericList<T>(params T[] elements)
        {
            return new List<T>(elements);
        }

    }
}