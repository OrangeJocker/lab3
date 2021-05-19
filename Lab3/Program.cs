using System;
using System.Globalization;


namespace Lab3
{
    internal class Program
    {
        private static float SelectA()
        {
            Console.Write("Введите A: ");
            float a = 0;
            a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            return a;
        }
        private static float SelectB()
        {
            Console.Write("Введите Б: ");
            float b = 0;
            b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
            return b;
        }
        public static void Main(string[] args)
        {
        }
    }
}