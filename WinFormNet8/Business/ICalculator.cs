﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormNet8.Business
{
    internal interface ICalculator
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
        int Divide(int a, int b);
        int Subtract(int a, int b);

    }
}
