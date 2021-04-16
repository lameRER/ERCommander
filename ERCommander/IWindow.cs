using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    interface IWindow
    {
        abstract  int XLeft { get; }
        abstract int XRight { get; }
        abstract int YUp { get; }
        abstract int YDown { get; }

        abstract bool Tabs { get; set; }
    }
}
