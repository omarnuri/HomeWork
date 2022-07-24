using System;
namespace Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");



            //int summ = 0;
            //int min = 0;
            //int max = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    int value = 0;
            //    Console.Write($"Введите число N{i+1}: ");
            //    value = Convert.ToInt32(Console.ReadLine());
            //    if (i == 0)
            //    {
            //        min = value;
            //        max = value;
            //    }
            //    else if(value < min)
            //    {
            //        min = value;
            //    }
            //    else if (value > max)
            //    {
            //        max = value;
            //    }                
            //    summ+=value;
            //}
            //Console.WriteLine($"{summ}, {min}, {max}");





            //int number = 0, result = 0;
            //bool IsPositive = true;

            //Console.Write("Введите 6-ти значное число: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if (number > 999999 || number < -999999 || number > -100000 && number < 100000)
            //{
            //    Console.WriteLine("Я сказал 6-ти значноее число, а ты :( ");
            //    throw new ArgumentOutOfRangeException();
            //}
            //for (int i = 1; i < 7; i++)
            //{
            //    int pow = 1;
            //    int pow2 = 1;
            //    int temp = 0;

            //    for (int j = 0;j<i-1 ; j++)
            //    {
            //        pow *= 10;
            //    }
            //    temp = number / pow % 10;
            //    for (int j = 0; j < 6-i; j++)
            //    {
            //        pow2 *= 10;
            //    }
            //    temp *= pow2;
            //    result += temp;
            //}
            //Console.WriteLine(result);




            //Знаю, это ужассно, но я устал 5:02 не бейте, пожалуйста

            //int numb1 = 0, numb2 = 0, Fib = 0, Fib1 = 0, Fib2 = 1;
            //Console.Write("Введите число N1: ");
            //numb1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число N2: ");
            //numb2 = Convert.ToInt32(Console.ReadLine());
            //bool IsPos = false;
            //while (Fib < numb2)
            //{

            //    if (numb1 < 0 && IsPos == false)
            //    {
            //        Fib = 0; Fib1 = 0; Fib2 = 1;
            //        while (Fib < numb1 * -1)
            //        {
            //            Fib = Fib2;
            //            Fib2 = Fib + Fib1;
            //            Fib1 = Fib;
            //            if (Fib * -1 > numb1 && Fib * -1 < numb2)
            //            {
            //                Console.WriteLine(Fib * -1);
            //            }
            //        }
            //        IsPos = true;
            //        Fib = 0; Fib1 = 0; Fib2 = 1;
            //    }
            //    Fib = Fib2;
            //    Fib2 = Fib + Fib1;
            //    Fib1 = Fib;
            //    if (Fib > numb1 && Fib < numb2)
            //    {
            //        Console.WriteLine(Fib);
            //    }
            //}





            //    int A = 1, B = 8;
            //if (A < 0 || B < 0)
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            //if (B < A)
            //{
            //    A += B;
            //    B  = A-B;
            //    A -= B;
            //}
            //for (int i = A; i < B; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();

            //}


            //char symbol = '+';
            //int len = 5;
            //bool horizontal = false;
            //char end = '\0';
            //if(horizontal == false)
            //{
            //    end = '\n';
            //}
            //for (int i = 0; i < len; i++)
            //{
            //    Console.Write(symbol.ToString()+end.ToString());
            //}



        }
    }
}
