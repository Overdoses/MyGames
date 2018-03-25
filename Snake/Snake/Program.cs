using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGames
{
    class Program
    {
        static void Main(string[] args)
        {
            
            View set = new View(3,1,'*');         
            set.Draw();
            View glob = new View(4,2,'/');
            glob.Draw();
            Point ds = new Point();
            ds.x = '*';
            ds.y = '$';
            ds.a = '&';
            ds.b = '3';
            List<int> MyList = new List<int>();
            MyList.Add(ds.a);
            MyList.Add(ds.b);
            MyList.Add(ds.y);
            MyList.Add(ds.x);
            foreach (char i in MyList)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
    }
}