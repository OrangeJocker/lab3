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
        public static void Main(string[] args)
        {
        }
    }
}