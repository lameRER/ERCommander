using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    class BlockWindow : IWindow
    {
        public int XLeft { get; set; }

        public int XRight { get; set; }

        public int YUp { get; set; }

        public int YDown { get; set; }

        public bool Tabs { get; set; }

        public void DrawWindow()
        {
            HorizontalLine horizontalLineUp = new HorizontalLine(XLeft, XRight, YUp, "─");
            HorizontalLine horizontalLineDown = new HorizontalLine(XLeft, XRight, YDown, "─");
            VerticalLine verticalLineUp = new VerticalLine(YUp, YDown, XLeft, "│");
            VerticalLine verticalLineDown = new VerticalLine(YUp, YDown, XRight, "│");
            Point pLeftUp = new Point(XLeft, YUp, "┌");
            Point pRightUp = new Point(XRight, YUp, "┐");
            Point pLeftDown = new Point(XLeft, YDown, "└");
            Point pRigthDown = new Point(XRight, YDown, "┘");
            horizontalLineUp.Draw();
            horizontalLineDown.Draw();
            verticalLineUp.Draw();
            verticalLineDown.Draw();
            pLeftUp.Draw();
            pRightUp.Draw();
            pLeftDown.Draw();
            pRigthDown.Draw();
        }
    }
}
