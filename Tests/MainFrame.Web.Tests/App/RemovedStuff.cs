﻿using MainFrame.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainFrame.Web.Tests.App
{
    public class RemovedStuff : WebControl
    {
        public WebControl IGotRemoved { get { return this.CreateControl<WebControl>("b.remove-me"); } }

        public RemovedStuff(WebContext context)
            : base(context)
        { }
    }
}
