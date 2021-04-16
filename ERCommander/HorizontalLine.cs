using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    class HorizontalLine : Figure
    {
        /// <summary>
        /// Отрисовка горизонтальной линии
        /// </summary>
        /// <param name="xLeft">Начало оси X</param>
        /// <param name="XRight">Конеч оси X</param>
        /// <param name="y">Начало оси Y</param>
        /// <param name="sym">Символ</param>
        public HorizontalLine(int xLeft, int XRight, int y, string sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x < XRight; x++)
            {
                var p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
