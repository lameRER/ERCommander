using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ERCommander
{
    class Program
    {
        //[DllImport("kernel32.dll", ExactSpelling = true)]
        //private static extern IntPtr GetConsoleWindow();

        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //static extern bool EnableScrollBar(IntPtr hWnd, int wSBflags, int wArrows);
        public static BlockFile blockFile1;
        public static BlockFile blockFile2;
        static async Task Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            //BlockFile blockFile = new BlockFile(0, Console.WindowWidth - 1, 0, (Console.WindowHeight / 2 + Console.WindowHeight / 3) - 2);
            //blockFile.DrawWindow();
            blockFile1 = new BlockFile(0, Console.WindowWidth / 2 - 1, 0, (Console.WindowHeight / 2 + Console.WindowHeight / 3) - 2, true);
            blockFile1.DrawWindow();
            blockFile2 = new BlockFile((Console.WindowWidth) - Console.WindowWidth / 2, Console.WindowWidth -1 , 0, (Console.WindowHeight / 2 + Console.WindowHeight / 3) - 2, false);
            blockFile2.DrawWindow();
            //BlockInfo blockInfo = new BlockInfo(0, Console.WindowWidth - 1, (Console.WindowHeight / 2 + Console.WindowHeight / 3) - 1, Console.WindowHeight - 2);
            //blockInfo.DrawWindow();
            new Thread(() => SetFile(blockFile1)).Start();
            new Thread(() => SetFile(blockFile2)).Start();
            //thread1.Start();
            //await Task.Run(() => SetFile(blockFile1));
            //await Task.Run(() => SetFile(blockFile2));
            //Thread thread = new Thread(new ParameterizedThreadStart(SetFile));
            //thread.Start(blockFile); 




            //IntPtr handle = GetConsoleWindow();
            //EnableScrollBar(handle, 3, 3);


            //int size = 0;
            //while (true)
            //{
            //    if (Console.WindowHeight != size)
            //    {
            //        Console.Clear();
            //        //Console.BufferHeight = Console.WindowHeight;
            //        Console.CursorVisible = false;
            //        new BlockWindow();
            //        //new BlockWindow(1);
            //        //new BlockWindow(2);
            //        size = Console.WindowHeight;
            //    }

            //    //}
            //    //Console.SetCursorPosition(0, 0);
            //    //var path = Environment.OSVersion.Platform == PlatformID.Unix ? @"/home/sasha" : @"C:\Users\Sasha\Downloads\";
            //    //var manager = new FilesManager(path);
            //    //Console.BufferHeight = manager.ListItems.Count + 1;
            //    //ShowList(manager.ListItems, manager.Selected);
            //    //while (true)
            //    //{
            //    //    Console.CursorVisible = false;
            //    //    switch (Console.ReadKey().Key)
            //    //    {
            //    //        case ConsoleKey.DownArrow:
            //    //            manager.Next();
            //    //            break;
            //    //        case ConsoleKey.UpArrow:
            //    //            manager.Previous();
            //    //            break;
            //    //        default:
            //    //            break;
            //    //    }
            //    //    ShowList(manager.ListItems, manager.Selected);
            //    //}
            //    //Console.ReadLine();
            //}
            Console.ReadKey();
        }

        public static void SetFile(BlockFile blockFile)
        {            
            blockFile.RenderFile();
        }

            private static void ShowList(IEnumerable<BaseItem> items, BaseItem selected)
        {
            Console.ResetColor();
            //Console.Clear();
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
                PrintItem(item, i);
            }
            Console.SetCursorPosition(0, 0);
            Console.ResetColor();
        }

        static void PrintItem(BaseItem item, int i)
        {
            
            //Console.SetCursorPosition(2, i+1);
            var name = item.Name.Length <= 50 ? item.Name : $"{item.Name.Substring(0, 10)}...";
            //var itemType = item.Size.HasValue ? string.Empty : "dir";
            //var size = item.Size.HasValue ? BytesSizeForamt(item.Size.Value) : string.Empty;
            //Console.WriteLine($"{name,-50} {itemType,3} {size,15}");
            Console.WriteLine($"{name,-50}");
            //Console.WriteLine(name);
        }

        /// <summary>
        /// Форматирование размера
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
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

