using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cat_JP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Read(args[0]);
            }
            else
            {
                Console.WriteLine("正しくパスを入力してね");
            }
        }
        public static void Read(string path)
        {
            string Text = "";
            Console.WriteLine();
            try
            {
                Text = File.ReadAllText(path);
                Console.WriteLine("■パス=" + path);
                Console.WriteLine("----------------------------------------------------------------------------");
            }
            catch
            {
                Console.WriteLine("パスが見当たんないよ");
            }
            Console.Write(Text);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("終了するにはなにかキーを押してください....");
            Console.Read();
        }
    }
}
