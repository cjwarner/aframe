﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Core
{
    public interface IContext : IDisposable
    {
        SearchPropertyStack SearchPropertyStack { get; }

        IContext ParentContext { get; }

        T As<T>() where T : Control;

        Control As();
    }
}
