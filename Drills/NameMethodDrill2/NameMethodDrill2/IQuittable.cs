﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameMethodDrill2
{
    interface IQuittable
    {
        void Quit();

        List<string> EmployeeQuit { get; set; }

    }
}
