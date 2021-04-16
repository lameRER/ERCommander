using System;
using System.Collections.Generic;
using System.Text;

namespace ERCommander
{
    interface IBlock
    {
        /// <summary>
        /// Координаты блока по оси X
        /// </summary>
        int[] X { get; set; }
        /// <summary>
        /// Координаты блока по оси Y
        /// </summary>
        int[] Y { get; set; }
    }
}
