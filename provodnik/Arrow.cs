using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik
{
    internal class Arrow
    {
        public int[] arrow(int x)
        {
            int[] result = new int[2];
            int poz = 2;
            int newpoz = poz;
            Console.SetCursorPosition(0, poz);
            Console.WriteLine("->");
            ConsoleKeyInfo Button = Console.ReadKey();
            while(true)
            {
                if (Button.Key == ConsoleKey.UpArrow)
                {
                    poz--;
                    if (poz <= 2)
                    {
                        poz = x+1;
                    }
                }
                if (Button.Key == ConsoleKey.DownArrow)
                {
                    poz++;
                    if (poz >= x+1)
                    {
                        poz = 2;
                    }
                }
                result[0] = poz;
                if(Button.Key == ConsoleKey.Enter)
                {
                    return result; 
                }
                if (Button.Key == ConsoleKey.Escape)
                {
                    result[1] = -1;
                    return result;
                }               
                
                if (Button.Key == ConsoleKey.Delete)
                {
                    result[1]= -4;
                    return result;
                }
                if (Button.Key == ConsoleKey.F1)
                {
                    result[1] = -2;
                    return result;
                }
                if (Button.Key == ConsoleKey.F2)
                {
                    result[1] = -3;
                    return result;
                }

                
                Console.SetCursorPosition(0, newpoz);
                Console.WriteLine("  ");
                Console.SetCursorPosition(0,poz);
                Console.WriteLine("->");
                newpoz = poz;
                Button = Console.ReadKey();
            }
            
        }
    }
}