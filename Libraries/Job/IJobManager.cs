﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public interface IJobManager<T>
    {
        bool Run(T command);
    }
}
