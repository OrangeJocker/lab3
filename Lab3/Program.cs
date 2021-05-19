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
        private static float DoSum(float a, float b)
        {
            return a + b;
        }
        private static float DoMul(float a, float b)
        {
            return a * b;
        }
        private static float DoSub(float a, float b)
        {
            return a - b;
        }
        private static float DoDiv(float a, float b)
        {
            return a / b;
        }
        private static float DoOperation(float a, float b, string oper)
        {
            switch (oper)
            {
                case "+": return DoSum(a, b);
                case "-": return DoSub(a, b);
                case "/": return DoDiv(a, b);
                case "*": return DoMul(a, b);
            }

            throw new InvalidOperationException("Invalid operator");
        }
        public static void Main(string[] args)
        {
            float a = SelectA();
            float b = SelectB();
            
            Console.Write("Введите оператор: ");
            string oper = Console.ReadLine();
            
            Console.Write("Ответ: ");
            Console.WriteLine(DoOperation(a, b, oper));
        }
    }
}