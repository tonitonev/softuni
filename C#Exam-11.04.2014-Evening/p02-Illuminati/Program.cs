using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace p02_Illuminati
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int aCounter = 0;
            int eCounter = 0;
            int iCounter = 0;
            int oCounter = 0;
            int uCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                switch (c)
                {
                    case 'A': aCounter++; break;
                    case 'a': aCounter++; break;
                    case 'E': eCounter++; break;
                    case 'e': eCounter++; break;
                    case 'I': iCounter++; break;
                    case 'i': iCounter++; break;
                    case 'o': oCounter++; break;
                    case 'O': oCounter++; break;
                    case 'u': uCounter++; break;
                    case 'U': uCounter++; break;
                }
            }
            int sum = aCounter + eCounter + iCounter + oCounter + uCounter;
            BigInteger result = aCounter * 65 + eCounter * 69 + iCounter * 73 + oCounter * 79 + uCounter * 85;
            Console.WriteLine(sum);
            Console.WriteLine(result);
        }
    }
}
