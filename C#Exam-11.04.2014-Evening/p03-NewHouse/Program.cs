using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03_NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roofHeight = 0;
            for (int i = 0; i < n; i+=2)
            {
                roofHeight++;
            }
            //Console.WriteLine(roohHeight);
            int width = n;
            int floorHeight = n;
            char dash = '-';
            char asterisk = '*';
            char pipe = '|';
            //i=roofHeight to 0
            //dash(i-1) star(width-2x(i-1)) dash (i-1)
           //for i=0 to floorheight
            //pipe(1) star (width-2) pipe(1)
            for (int i = roofHeight; i > 0; i--)
            {
                Console.Write(new string(dash,(i-1)));
                Console.Write(new string(asterisk,(width-2*(i-1))));
                Console.WriteLine(new string(dash, (i - 1)));
            }
            for (int i = 0; i < floorHeight; i++)
            {
                Console.Write(new string(pipe,1));
                Console.Write(new string(asterisk,width-2));
                Console.WriteLine(new string (pipe, 1));
            }
        }
    }
}
