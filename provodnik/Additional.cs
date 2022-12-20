using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik
{
    public class Additional
    {
        public static void fileadd(string path)
        {
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("Введите название файла (учитывая расширение)");
            Console.SetCursorPosition(80, 11);
            string name = Console.ReadLine();
            File.Create(path + "\\"+name);
        }
        public static void folderadd(string path)
        {
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("Введите название папки");
            Console.SetCursorPosition(80, 11);
            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);
            
        }
        public static void deleting(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            else
            {
                File.Delete(path);
            }
        }
    }
}
