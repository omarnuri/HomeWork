using System;
using System.Linq;
using System.IO;
namespace Ping_Test
{

    public class Program
    {
        public class Result
        {
            public decimal Sent_Packages;
            public decimal Lost_Packages;
            public decimal Delivered_Packages;
            public decimal Loss_Percent;
            public decimal Delivered_Percent;
            public Result(string text)
            {
                int ind = 0;
                List<string> list = new List<string>();
                text = text.Replace("\r", "");
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '\n')
                    {
                        list.Add(text[ind..i]);
                        ind = i+1;
                    }
                }
                list.Add(text[ind..text.Length]);
                foreach (var item in list)
                {
                    if (item == "Превышен интервал ожидания для запроса.")
                    {
                        Lost_Packages++;
                    }
                    else
                    {
                        Delivered_Packages++;
                    }
                    
                }
                Sent_Packages = list.Count;
                Delivered_Percent = Delivered_Packages * 100 / Sent_Packages;
                Loss_Percent = 100 - Delivered_Percent;
            }


             public override string ToString()
            {
                return $"Отправленные пакеты: {Sent_Packages}\n\nДоставленные пакеты: {Delivered_Packages}\nПотерянные пакеты: {Lost_Packages}\n\nДоставленные пакеты: {Delivered_Percent}%\nПотерянные пакеты: {Loss_Percent}%" ;
            }
        }

        static void Main()
        {
            string Text = string.Empty;
            Text = File.ReadAllText(@"C:\HomeWork\PingTest\PingTest\Result.txt");
            Result result = new(Text);
            Console.WriteLine(result);
        }
    }
    
}