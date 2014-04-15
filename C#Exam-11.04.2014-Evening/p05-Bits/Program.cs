using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            byte firstNumber = 0;
            string tempNumber = "";
            string inputNumbersToString = "";
            for (int i = 0; i < n; i++)
            {
                firstNumber = byte.Parse(Console.ReadLine());
                tempNumber = Convert.ToString(firstNumber, 2);
                tempNumber = tempNumber.PadLeft(8, '0');
                inputNumbersToString += tempNumber;
                //outputString += "|";
            }
            StringBuilder extractedBits = new StringBuilder();
            int takeAtPos = 1 + step;
            int counter = 0;
            bool atLeast2loops = false; //added at home
            for (int i = 0; i < inputNumbersToString.Length; i++) 
            {
                if (i == 1)
                {
                    extractedBits.Append(inputNumbersToString[i]);
                    atLeast2loops = true;
                }
                if (atLeast2loops && takeAtPos >= inputNumbersToString.Length) //added at home
                {
                    break;
                }
                else
                {
                    if (i == takeAtPos)
                    {
                        extractedBits.Append(inputNumbersToString[i]);
                        counter++;
                        takeAtPos = 1 + step * (counter + 1);
                    }
                }
            }
            //add zeros
            int numberOfZerosToAdd = 0;
            if (extractedBits.Length%8 ==0)
            {
                numberOfZerosToAdd = 0;
            }
            else 
            {
                numberOfZerosToAdd = 8 - extractedBits.Length % 8;
            }
            //if (extractedBits.Length > 8)
            //{
            //    numberOfZerosToAdd = 8 - extractedBits.Length % 8;
            //}
            //else if(extractedBits.Length < 8 )
            //{
            //    numberOfZerosToAdd = 8 - extractedBits.Length % 8;
            //}
            //else
            //{
            //    numberOfZerosToAdd = 0;
            //}
            //Console.WriteLine(extractedBits);
            for (int i = 0; i < numberOfZerosToAdd; i++)
            {
                extractedBits.Append("0");
            }
            //Console.WriteLine(extractedBits);
            List<String> readyBytes = new List<string>();
            StringBuilder temp = new StringBuilder();
            int divideable = 7;
            for (int i = 0; i < extractedBits.Length; i++)
            {
                temp.Append(extractedBits[i].ToString());

                if (i != 0 && i % divideable == 0)
                {
                    readyBytes.Add(temp.ToString());
                    temp.Clear();
                    divideable += 8;
                }
            }
            foreach (var item in readyBytes)
            {
                Console.WriteLine(Convert.ToInt32(item, 2).ToString());
            }
        }
    }
}
