namespace Firsovalab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваша любимая игра/кино/аниме-");
            string? favorite = Console.ReadLine();
            Console.Write("Ваша любимая цифра-");
            int number = int.Parse(Console.ReadLine());
            Console.Write(" Значение числа пи-");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Ваша любимая буква алфавита-");
            string? bykva = Console.ReadLine();
            //2
            Console.WriteLine("\nI");
            Console.WriteLine("need");
            Console.WriteLine("more");
            Console.WriteLine("power!");
            //3
            Console.WriteLine("\nHello There");
            //4
            Console.Write("\nСтоимость монитора:");
            int monitor = int.Parse(Console.ReadLine());
            Console.Write("Стоимость системного блока:");
            int blok = int.Parse(Console.ReadLine());
            Console.Write("Стоимость клавиатуры:");
            int klav = int.Parse(Console.ReadLine());
            Console.Write("Стоимость мыши:");
            int m = int.Parse(Console.ReadLine());
            int result = (monitor + blok + klav + m) * 3;
            Console.WriteLine($"стоимость трех компьютеров-{result}");
            //5
            Console.WriteLine();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int b = int.Parse(Console.ReadLine());
            double f = 3 * Math.Pow(a + b, 3) + 275 * Math.Pow(b, 2) - 127 * a - 41;
            Console.WriteLine(f);
            //6
            Console.Write("Имя:");
            string? name = Console.ReadLine();
            Console.Write("Возраст:");
            int age = int.Parse(Console.ReadLine());
            int age2 = age + 1;
            Console.WriteLine($"Привет,{name}!");
            Console.WriteLine($"Тебе {age} лет.");
            Console.WriteLine($" В следующем году тебе будет {age2}.");
            //7
            Console.Write("Имя:");
            string? name2 = Console.ReadLine();
            Console.Write("Возраст:");
            int agee = int.Parse(Console.ReadLine());
            Console.Write("Город:");
            string? city = Console.ReadLine();
            Console.WriteLine($"Привет, {name2}! Тебе {agee} лет и ты живёшь в городе {city}.");
            //8
            Console.Write("Температура в градусах Цельсия:");
            double temp = double.Parse(Console.ReadLine());
            double temp2 = temp * 1.8 + 32;
            Console.WriteLine($"Температура в градусах Фаренгейта:{temp2}");

        }
    }
}
