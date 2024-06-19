using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.UI
{
    class GameUI
    {
        public static void printOnConsole(char c)
        {
            Console.CursorVisible = false;
            Console.WriteLine(c);
        }
    }
}
