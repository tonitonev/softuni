using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace p04_sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            BigInteger second = BigInteger.Parse(Console.ReadLine());
            BigInteger third = BigInteger.Parse(Console.ReadLine());
            BigInteger spiralNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger step = BigInteger.Parse(Console.ReadLine());
            BigInteger next = third + second + first;
            List<BigInteger> tribonacci = new List<BigInteger>();
            List<BigInteger> spiral = new List<BigInteger>();
            BigInteger result = -1;
            tribonacci.Add(first);
            tribonacci.Add(second);
            tribonacci.Add(third);
            tribonacci.Add(next);
            while (true)
            {
                // tribonacci 
                first = second;
                second = third;
                third = next;
                next = third + second + first;
                //Console.WriteLine(next);
                //Console.WriteLine("--");
                tribonacci.Add(next);
                if (next > 1000000)
                {
                    break;
                }
            }
            int cornerAtPosition = 0;
            int length = 1;
            spiral.Add(spiralNumber);
            spiralNumber += step;
            while (true)
            {

                //spiral
                for (int i = 0; i < 2; i++) //alway 2 times
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (j == cornerAtPosition)
                        {
                            spiral.Add(spiralNumber);
                        }
                        spiralNumber += step;
                    }
                }
                length++;
                cornerAtPosition++;
                if (spiralNumber > 1000000)
                {
                    break;
                }
            }
            //foreach (var item in spiral)
            //{
            //    Console.WriteLine(item);
            //}
            bool resultFound = false;
            for (int i = 0; i < tribonacci.Count; i++)
            {
                if (resultFound)
                {
                    break;
                }
                for (int j = 0; j < spiral.Count; j++)
                {
                    if (spiral[j] == tribonacci[i])
                    {
                        result = spiral[j];
                        resultFound = true;
                        break;
                    }
                }
            }
            if (result != -1 && result <= 1000000) // && result<=1000000 added after exam
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
