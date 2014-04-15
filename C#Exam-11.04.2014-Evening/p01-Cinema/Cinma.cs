using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_Cinema
{
    class Cinma
    {
        static void Main(string[] args)
        {
            string moovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int seats = rows * cols;
            decimal ticketprice = 0;
            switch (moovie)
            {
                case "Premiere": ticketprice = 12m; break;
                case "Normal": ticketprice = 7.5m; break;
                case "Discount": ticketprice = 5m; break;
                default:
                    break;
            }
            decimal result = seats*ticketprice;
            Console.Write("{0:F2}",result);
            Console.Write(" leva");
        }
    }
}
