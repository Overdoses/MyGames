using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGames
{
    class View
    {
        public int x;
        public int y;
        public char sum;
        public View()
        {

        }
        public View(int _x,int _y, char _sum)
        {
            x = _x;
            y = _y;
            sum = _sum;
        }
        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
         

    }
}
