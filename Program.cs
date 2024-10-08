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
            bool isContinue = false;
            long result = 1;

            do{
                
                if( x > 0 )
                { 
                    for(int i = 1; i <= x; i++)
                    {
                        result *= i;
                        isContinue = false;
                    }
                    System.Console.WriteLine("Natija: "  + result);
                }
                else if( x == 0)
                {
                        result = 1;
                        isContinue = false;
                        System.Console.WriteLine("Natija: "  + result);
                }
                else {
                    System.Console.Write("Ma'lumot kiritishdagi xatolik. Qayta urunib ko'ring: ");
                    isContinue = true;
                    x = Convert.ToInt32(Console.ReadLine());
                } 
            }while(isContinue);

            }   
    }
}