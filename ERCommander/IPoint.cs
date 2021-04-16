using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }

        string Sym { get; set; }

        void Draw();
    }
}
