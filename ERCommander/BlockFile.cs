using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace ERCommander
{
    class BlockFile : BlockWindow
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
        //}        

        /// <summary>
        /// Отрисовка блока
        /// </summary>
        /// <param name="xLeft">Левая граница по оси X</param>
        /// <param name="xRight">Правая граница по оси Y</param>
        /// <param name="yUp">Верхняя граница по оси Y</param>
        /// <param name="yDown">Нижнаяя граница по оси Y</param>
        public BlockFile(int xLeft, int xRight, int yUp, int yDown, bool tabs)
        {
            XLeft = xLeft;
            XRight = xRight;
            YUp = yUp;
            YDown = yDown;
            Tabs = tabs;
            //X = new int[] {left[0], left[1]};
            //Y = new int[] { top[0], top[1] };
            //Y[1] = Y[1] / 5 * 4;            
            //Render(X, Y);
            //RenderFile(this.X, this.Y, 5);
        }

        public void RenderFile()
        {
            Console.SetCursorPosition(XLeft+1, YUp+1);
            var path = Environment.OSVersion.Platform == PlatformID.Unix ? @"/home/sasha" : @"C:\Users\Sasha\Downloads\";
            var manager = new FilesManager(path);
            //Console.BufferHeight = manager.ListItems.Count + 1;
            if (Tabs == false)
                manager.Selected = null;
            ShowList(manager.ListItems, manager.Selected);
            while (true)
            {
                //Debug.WriteLine($"1 {Tabs}");
                while (Tabs)
                {
                    Debug.WriteLine($"2 {Tabs}");
                    Console.CursorVisible = false;
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Home:
                            manager.Home();
                            break;
                        case ConsoleKey.PageUp:
                            manager.First();
                            break;
                        case ConsoleKey.PageDown:
                            manager.Last();
                            break;
                        case ConsoleKey.UpArrow:
                            manager.Previous();
                            break;
                        case ConsoleKey.DownArrow:
                            manager.Next();
                            break;
                        case ConsoleKey.Enter:
                            manager.SelectOpen();
                            break;
                        case ConsoleKey.Tab:
                            manager.TabNull();
                            break;
                        case ConsoleKey.Delete:
                            if (DeleteRequest(manager.Selected))
                                manager.Delete();
                            break;
                        default:
                            break;
                    }
                    ShowList(manager.ListItems, manager.Selected);
                }
            }
        }

        static bool DeleteRequest(BaseItem item)
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine(item.MainPath);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Удалить выбранный элемент? ");
            Console.ResetColor();
            var key = Console.ReadKey();
            return key.Key == ConsoleKey.Y;
        }

        private void ShowList(List<BaseItem> items, BaseItem selected)
        {
            Console.SetCursorPosition(XLeft + 1, YUp + 1);
            Console.ResetColor();
            //Console.Clear();
            for (int j = items.Count; j <= 22; j++)
            {
                Console.SetCursorPosition(1, j);
                Console.Write("                                                                                              ");
               
                
            }
            int i = 0;
            foreach (var item in items)
            {
                if (item.Equals(selected))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                i++;
                Console.SetCursorPosition(XLeft + 1, YUp + i);
                PrintItem(item);
            }
            Console.SetCursorPosition(XLeft + 1, YUp + 1);
            Console.ResetColor();
        }

        static void PrintItem(BaseItem item)
        {
            var name = item.Name.Length <= 50 ? item.Name : $"{item.Name.Substring(0, 10)}...";
            //var itemType = item.Size.HasValue ? string.Empty : "dir";
            //var size = item.Size.HasValue ? BytesSizeForamt(item.Size.Value) : string.Empty;
            //Console.WriteLine($"{name,-50} {itemType,3} {size,15}");
            Console.WriteLine($"{name,-50}");
            //Console.WriteLine(name);
        }

        static string BytesSizeForamt(long size)
        {
            string[] suffixes = { "B", "KB", "MB", "TB" };
            string suffix = suffixes[0];

            for (int i = 0; i < 4; i++)
            {
                suffix = suffixes[i];
                if (size > 1024)
                    size /= 1024;
                else
                    break;
            }
            return $"{size:N1} {suffix}";
        }


    }
}
