/*
Consolga int tipidagi butun son kiritilgan => int x
x! (x factorial) ni hisoblaydigan dastur tuzing.

*/
using System;
namespace Takrorlash
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("INT tipidagi son kiriting: ");
            int x = Convert.ToInt32(Console.ReadLine());
            long result = 1;
            for(int i = 1; i <= x; i++)
            {
                result *= i;
            }
            System.Console.WriteLine("Natija: "  + result);
        }
    }
}