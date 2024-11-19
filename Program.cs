using System.Xml.XPath;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine
            (
                "1 - Adição\n" +
                "2 - Subtração\n" +
                "3 - Multiplicação\n" +
                "4 - Divisão\n" +
                "0 - Sair\n" +
                "-----------------"
            );
            short choice = short.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0: Console.Clear(); Environment.Exit(0); break;
                case 1: var numbers1 = GetNumber(); Sum(numbers1[0], numbers1[1]); break;
                case 2: var numbers2 = GetNumber(); Subtraction(numbers2[0], numbers2[1]); break;
                case 3: var numbers3 = GetNumber(); Multiplication(numbers3[0], numbers3[1]); break;
                case 4: var numbers4 = GetNumber(); Division(numbers4[0], numbers4[1]); break;
                default: Menu(); break;
            }
        }

        static float[] GetNumber()
        {
            Console.Clear();

            var numbers = new float[2];

            Console.WriteLine("1° número: ");
            numbers[0] = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("2° número: ");
            numbers[1] = float.Parse(Console.ReadLine());

            Console.WriteLine();

            return numbers;
        }

        static void Sum(float no1, float no2)
        {
            float result = no1 + no2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction(float no1, float no2)
        {
            float result = no1 - no2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication(float no1, float no2)
        {
            float result = no1 * no2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Division(float no1, float no2)
        {
            float result = no1 / no2;
            Console.WriteLine($"Resultado: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}