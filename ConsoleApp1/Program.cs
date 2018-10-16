using System;
using ClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] {9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9};
            int[] number2 = new int[]{1,1,1,1};
            MyBigInteger bigInt = new MyBigInteger(number);
            bigInt.BigInt = bigInt.Add(number2);
        }
    }
}
