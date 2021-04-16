using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    class VerticalLine : Figure
    {
        /// <summary>
        /// Отрисовка горизонтальной линии
        /// </summary>
        /// <param name="xLeft">Начало оси Y</param>
        /// <param name="XRight">Конеч оси Y</param>
        /// <param name="y">Начало оси X</param>
        /// <param name="sym">Символ</param>
        public VerticalLine(int yLeft, int yRight, int x, string sym)
        {
            pList = new List<Point>();
            for (int y = yLeft; y < yRight; y++)
            {
                var p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
