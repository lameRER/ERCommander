using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    class Point : IPoint
    {
        private int x;
        private int y;
        private string sym;

        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }
        public string Sym 
        { 
            get => sym; 
            set => sym = value; 
        }
        /// <summary>
        /// Точка
        /// </summary>
        /// <param name="x">Позиция X</param>
        /// <param name="y">Позиция Y</param>
        /// <param name="sym">Символ</param>
        public Point(int x, int y, string sym)
        {
            X = x;
            Y = y;
            Sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }
    }
}
