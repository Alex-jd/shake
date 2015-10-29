using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7,8, 'W');
            p3.Draw();

            Point p4 = new Point(3, 9, 'S');
            p4.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            List<char> charList = new List<char>();
            charList.Add('w');
            charList.Add('o');
            charList.Add('r');

            char char_x = charList[0];
            char char_y = charList[1];
            char char_z = charList[2];

            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.Remove(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);



            Console.ReadLine();
        }


    }
}
