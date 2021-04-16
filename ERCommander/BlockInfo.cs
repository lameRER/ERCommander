using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    class BlockInfo : BlockWindow
    {
        //private int[] _x;
        //private int[] _y;

        //public int[] X
        //{
        //    get => _x;
        //    set => _x = value ?? throw new ArgumentNullException(nameof(value));
        //}

        //public int[] Y
        //{
        //    get => _y;
        //    set => _y = value ?? throw new ArgumentNullException(nameof(value));
        ////}
        //public int XLeft { get; }
        //public int XRight { get; }
        //public int YUp { get; }
        //public int YDown { get; }

        /// <summary>
        /// Отрисовка блока
        /// </summary>
        /// <param name="xLeft">Левая граница по оси X</param>
        /// <param name="xRight">Правая граница по оси Y</param>
        /// <param name="yUp">Верхняя граница по оси Y</param>
        /// <param name="yDown">Нижнаяя граница по оси Y</param>
        //public BlockInfo(int[] left, int[] top)
        //{
        //    //X = new int[] { left[0], left[1] }; ;
        //    //Y = new int[] { top[0], top[1] };
        //    //Y[0] = GetY(Y);
        //    //Render(X, Y);
        //}

        /// <summary>
        /// Отрисовка блока
        /// </summary>
        /// <param name="xLeft">Левая граница по оси X</param>
        /// <param name="xRight">Правая граница по оси Y</param>
        /// <param name="yUp">Верхняя граница по оси Y</param>
        /// <param name="yDown">Нижнаяя граница по оси Y</param>
        public BlockInfo(int xLeft, int xRight, int yUp, int yDown)
        {
            XLeft = xLeft;
            XRight = xRight;
            YUp = yUp;
            YDown = yDown;
            //X = new int[] {left[0], left[1]};
            //Y = new int[] { top[0], top[1] };
            //Y[1] = Y[1] / 5 * 4;            
            //Render(X, Y);
            //RenderFile(this.X, this.Y, 5);
        }



        private int GetY(int[] y)
        {
          return (y[1] / 5) * 4-1;
        }
    }
}
