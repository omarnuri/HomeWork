using System;
namespace Wonders
{
	interface Wonder
    {
		void Name();
		void Place();
		void Creator();
		void Creation_Time();
		void Destruction_time();
		void Print()
        {
            Console.Write("Имя: ");
			Name();
			Console.Write("Место: ");
			Place();
			Console.Write("Создано: ");
			Creation_Time();
			Console.Write("Уничтожено: ");
			Destruction_time();
        }

    }

	public class Wonder_1:Wonder
	{
        public void Name() => Console.WriteLine("Пирамида Хеопса");
		public void Place() => Console.WriteLine("Гиза(Египет)");   
		public void Creator() => Console.WriteLine("Египтяне");
		public void Creation_Time() => Console.WriteLine("XXVI—XXIII век до н. э.");
		public void Destruction_time() => Console.WriteLine("один из двух чудес, сохранившихся до наших дней");
	}

	public class Wonder_2:Wonder
	{
		public void Name() => Console.WriteLine("Висячие сады Семирамиды");
		public void Place() => Console.WriteLine("Вавилон(Ирак, Месопотамия)");
		public void Creator() => Console.WriteLine("были возведены по приказу Навуходоносора II");
		public void Creation_Time() => Console.WriteLine("605 г. до н. э.");
		public void Destruction_time() => Console.WriteLine("II в. до н. э.");
	}

	public class Wonder_3:Wonder
	{
		public void Name() => Console.WriteLine("Статуя Зевса в Олимпии");
		public void Place() => Console.WriteLine("Олимпия(Греция)");
        public void Creator() => Console.WriteLine("Фидий");
		public void Creation_Time() => Console.WriteLine("435 г. до н. э.");
		public void Destruction_time() => Console.WriteLine("V в.");
	}

	public class Wonder_4:Wonder
	{
		public void Name() => Console.WriteLine("Храм Артемиды в Эфесе");
		public void Place()	=> Console.WriteLine("Эфес(Турция)");
		public void Creator() => Console.WriteLine("Херсифрон разработал проект Храма и начал его строить. Пеоний и Деметрий закончили строение");
		public void Creation_Time() => Console.WriteLine("560 г. до н. э.");
		public void Destruction_time() => Console.WriteLine("370 г. до н. э. 356 г. до н. э. (Геростратом) или 262 г. н. э. (готами)");
	}

	public class Wonder_5:Wonder
	{
		public void Name() => Console.WriteLine("Мавзолей в Галикарнасе");
		public void Place()	=> Console.WriteLine("Галикарнас(на юго-западе Турции)");
		public void Creator() => Console.WriteLine("Пифей");
		public void Creation_Time() => Console.WriteLine("351 г. до н. э.");
		public void Destruction_time() => Console.WriteLine("1494 г.");
	}

	public class Wonder_6:Wonder
	{
		public void Name() => Console.WriteLine("Колосс Родосский");
		public void Place()	=> Console.WriteLine("Родос(Греция)");
		public void Creator() => Console.WriteLine("Харес");
		public void Creation_Time() => Console.WriteLine("между 292 и 280 гг. до н. э.");
		public void Destruction_time() => Console.WriteLine("224 (или 226) г. до н. э. бронзовый корпус был демонтирован в 654 г. н. э.");
	}

	public class Wonder_7:Wonder
	{
		public void Name() => Console.WriteLine("Александрийский маяк");
		public void Place()	=> Console.WriteLine("Александрия Египетская");
		public void Creator() => Console.WriteLine("греки, династия Птолемеев");
		public void Creation_Time() => Console.WriteLine("303 г. до н. э.");
		public void Destruction_time() => Console.WriteLine("XIV в.");
	}

	public class Wonder_8:Wonder
	{
		public void Name() => Console.WriteLine("Тормоз типа\"Омар\"");
		public void Place() => Console.WriteLine("Баку(Азербайджан)");
		public void Creator() => Console.WriteLine("Рамин.Н");
		public void Creation_Time() => Console.WriteLine("2006 г. н. э.");
        public void Destruction_time() => Console.WriteLine("один из двух чудес, сохранившихся до наших дней");


	}
}