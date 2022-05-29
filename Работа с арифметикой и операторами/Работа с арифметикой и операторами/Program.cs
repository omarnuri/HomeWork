using System;
namespace Dz
{
    internal class program
    {
        static void Main(string[] args)
        {
            //int numb = 0;
            //Console.Write("Введите число от 1 до 100: ");
            //numb = Convert.ToInt32(Console.ReadLine());
            //if(numb < 1 || numb > 99)
            //{
            //    Console.WriteLine("Вы вышли за пределы доп. значений!");
            //    throw new ArgumentOutOfRangeException();
            //}
            //if (numb % 3 == 0 && numb%5 == 0)
            //{
            //    Console.WriteLine("FizzBuzz");
            //}
            //else if(numb%3 == 0)
            //{
            //    Console.WriteLine("Fizz");
            //}
            //else if (numb % 5 == 0)
            //{
            //    Console.WriteLine("Buzz");
            //}
            //else
            //{
            //    Console.WriteLine(numb);
            //}



            //int numb1 = 0, numb2 = 0;
            //float result = 0;
            //Console.Write("Введите число N1: ");
            //numb1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число N2: ");
            //numb2 = Convert.ToInt32(Console.ReadLine());
            //if (numb1 == 0) { result = 0; }
            //else
            //{
            //    result = (float)numb2 / numb1 * 100;
            //}
            //Console.WriteLine($"Result = {result}");



            //int? numb = null, result = 0;
            //for (int i = 1; i < 5; i++)
            //{
            //    numb = null;
            //    Console.Write($"Введите цифру N{i}: ");
            //    numb = Convert.ToInt32(Console.ReadLine());
            //    if (numb > 9 || numb < 1)
            //    {
            //        Console.WriteLine("Ого, ты не можешь отличить число от цифры, красавчик :)");
            //        throw new ArgumentOutOfRangeException();
            //    }
            //    int pow = 1;
            //    for (int j = 0; j < 4-i; j++)
            //    {
            //        pow *= 10;
            //    }
            //    numb *= pow;
            //    result += numb;

            //}
            //Console.WriteLine(result);



            //int number = 0, index_1 = 0, index_2 = 0, result = 0, numb1 = 0, numb2 = 0;
            //bool isPositive = true;
            //Console.Write("Введите 6-ти значное число: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //if(number > 999999 || number < -999999 || number > -100000 && number < 100000)
            //{
            //    Console.WriteLine("Я ЖЕ ГОВОРИЛ 6-ТИ ЗНАЧНОЕ ШЕЕЕЕЕЕЕЕЕСТЬ!");
            //    throw new ArgumentOutOfRangeException();
            //}
            //if (number < 0)
            //{
            //    isPositive = false;
            //    number *= -1;
            //}
            //Console.Write("Введите индекс цифры N1 (от 1 до 6): ");
            //index_1 = Convert.ToInt32(Console.ReadLine());
            //if (index_1<1||index_1>6)
            //{
            //    Console.WriteLine("Я УЖЕ ДАЖЕ НЕ ЗНАЮ ЧТО ТЕБЕ СКАЗАТЬ :\\");
            //}
            //Console.Write("Введите индекс цифры N1 (от 1 до 6): ");
            //index_2 = Convert.ToInt32(Console.ReadLine());
            //if (index_2 < 1 || index_2 > 6)
            //{
            //    Console.WriteLine("Я УЖЕ ДАЖЕ НЕ ЗНАЮ ЧТО ТЕБЕ СКАЗАТЬ :\\");
            //}
            //for (int i = 0, pow = 1; i < 7 - index_1; i++)
            //{

            //    numb1 = number / pow % 10;
            //    pow *= 10;
            //}
            //for (int i = 0, pow = 1; i < 7 - index_2; i++)
            //{

            //    numb2 = number / pow % 10;
            //    pow *= 10;
            //}
            //for (int i = 1; i < 7; i++)
            //{
            //    int pow = 1;
            //    int temp = 0;
            //    for (int j = 0; j < 6 - i; j++)
            //    {
            //        pow*=10;
            //    }
            //    temp = number / pow % 10;
            //    if (i == index_1)
            //    {
            //        temp = numb2;
            //    }
            //    else if (i == index_2)
            //    {
            //        temp = numb1;
            //    }
            //    temp *= pow;

            //    result += temp;

            //}
            //if (isPositive == false)
            //{
            //    result *= -1;
            //    isPositive = true;
            //}
            //Console.WriteLine(result);





            //string? Date = String.Empty;
            //Console.Write("Введите дату в формате (Y.M.D): ");
            //Date = Console.ReadLine();
            //DateTime dateTime = new();
            //if (Date != null)
            //{

            //}
            //else
            //{
            //    throw new ArgumentNullException();
            //}
            //dateTime = DateTime.Parse(Date);
            //Console.WriteLine(dateTime.DayOfWeek);
            //if (dateTime.Month>=1&& dateTime.Month<=3)
            //{
            //    Console.WriteLine("Autumn");
            //}
            //else if (dateTime.Month >= 3 && dateTime.Month <= 6)
            //{
            //    Console.WriteLine("Spring");
            //}
            //if (dateTime.Month >= 6 && dateTime.Month <= 9)
            //{
            //    Console.WriteLine("Summer");
            //}
            //if (dateTime.Month >= 9 && dateTime.Month <= 12)
            //{
            //    Console.WriteLine("Winter");
            //}




            //double temper = 0, result = 0;
            //bool IsCels = true;
            //Console.Write("Для выбора температуры в C введите true, для выбора F введите false: ");
            //IsCels = Convert.ToBoolean(Console.ReadLine());
            //Console.Write("Введите температуру: ");
            //temper = Convert.ToDouble(Console.ReadLine());
            //if (IsCels)
            //{
            //    result = (temper * 9 / 5) + 32;
            //}
            //else
            //{
            //    result = (temper - 32) * 5 / 9;
            //}
            //Console.WriteLine(result);


            //int numb1 = 0, numb2 = 0;
            //Console.Write("Введите число N1: ");
            //numb1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите число N2: ");
            //numb2 = Convert.ToInt32(Console.ReadLine());
            //if (numb1 > numb2)
            //{
            //    numb1 += numb2;
            //    numb2 = numb1 - numb2;
            //    numb1 -= numb2;
            //}
            //for (int i = numb1; i < numb2; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
                
            //}

        }

    }
}
