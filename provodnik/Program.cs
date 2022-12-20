using provodnik;
namespace work
{
    internal class MainProgram
    {
        public static void Main()
        {
            List<string> WordList = new List<string>();
            string[] array;
            int diskamount = 0;

            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Выбор диска");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.Write("\t" + drive.Name);
                Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Из свободно - гб " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                diskamount++;
            }
            Arrow arrow = new Arrow();
            int[] y = arrow.arrow(diskamount);
            array = folder.dir(Convert.ToString(drives[y[0] - 2]), y[0] -2);
            WordList.Add(Convert.ToString(drives[y[0] - 2]));
            while (true)
            {
                y = arrow.arrow(array.Length);
                if (y[1] < -1)
                {
                    if (y[1] == -2)
                    {
                        Additional.fileadd(WordList[WordList.Count - 1]);
                    }
                    else if (y[1] == -3)
                    {
                        Additional.folderadd(WordList[WordList.Count - 1]);
                    }
                    else if(y[1] == -4)
                    {
                        Additional.deleting(array[y[0] - 2]);
                    }
                    Console.Clear();
                    WordList.Clear();
                    diskamount = 0;
                    Console.SetCursorPosition(20, 0);
                    Console.WriteLine("Выбор диска");
                    foreach (DriveInfo drive in drives)
                    {
                        Console.Write("\t" + drive.Name);
                        Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                        diskamount++;
                    }
                    y = arrow.arrow(diskamount);
                    array = folder.dir(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    WordList.Add(Convert.ToString(drives[y[0] - 2]));
                }
                if (y[1] == -1)
                {
                    if (WordList.Count == 1)
                    {
                        Console.Clear();
                        diskamount = 0;
                        Console.SetCursorPosition(20, 0);
                        Console.WriteLine("Выбор диска");
                        foreach (DriveInfo drive in drives)
                        {
                            Console.Write("\t" + drive.Name);
                            Console.WriteLine(" " + drive.TotalSize / 1073741824 + " Гб свободно из " + drive.TotalFreeSpace / 1073741824 + " ГБ");
                            diskamount++;
                        }
                    }
                    else
                    {
                        WordList.RemoveAt(WordList.Count - 1);                        
                        array = folder.dir(WordList[WordList.Count - 1], 0);                    
                    }
                }
                else
                {
                    WordList.Add(Convert.ToString(array[y[0] - 2]));
                    array = folder.dir(Convert.ToString(array[y[0] - 2]), y[0] - 2);                  
                }               
            }
        }
    }
}