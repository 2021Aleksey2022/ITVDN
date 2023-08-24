using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\a");
            Console.ReadLine();
        }
        public void NumericFormat()
        {
            Console.WriteLine("1. C format: {0:C}", 2.50);  //Валюта.
            Console.WriteLine("2. D format: {0:D}", 25);  //Десятичное число.
            Console.WriteLine("3. E format: {0:E2}", 250000);  //Экспоненциальный.
            Console.WriteLine("4. F format: {0:F2}", 2.5);  //С фиксированной запятой.
            Console.WriteLine("5. G format: {0:G}", 2.5);  //Общий.
            Console.WriteLine("6. N format: {0:N}", 2500000);  //Numeric.
            Console.WriteLine("7. P format: {0:P}", 0.25);  //Процент.
            Console.WriteLine("8. R format: {0:R}", 2.5);  //Приемо-передача(Round-Trip).
            Console.WriteLine("9. X format: {0:X}", 250);  //Шеснадцатеричный.
        }
        public void RoundTrip()
        {
            Console.WriteLine(" format: {0}", 0.123456789_12345678);
            Console.WriteLine("R format: {0:R}", 0.123456789_12345678);

            Console.ReadLine();
        }
        public void NumericFormat2()
        {
            Console.WriteLine($"1. C format: {2.50:C}");  //Валюта.
            Console.WriteLine($"2. D format: {0xFF:D}");  //Десятичное число.
            Console.WriteLine($"3. E format: {250000:E2}");  //Экспоненциальный.
            Console.WriteLine($"4. F format: {2.5:F2}");  //С фиксированной запятой.
            Console.WriteLine($"5. G format: {2.5:G}");  //Общий.
            Console.WriteLine($"6. N format: {2500000:N}");  //Numeric.
            Console.WriteLine($"7. P format: {0.25:P}");  //Процент.
            Console.WriteLine($"8. R format: {2.5:R}");  //Приемо-передача(Round-Trip).
            Console.WriteLine($"9. X format: {250:X}");  //Шеснадцатеричный.
        }
        public void NumericFormat3()
        {
            double interpolationExpression = 0.123456789_12345678;
            const int alignment = -30;

            Console.WriteLine($"8. R Format: {interpolationExpression, alignment:R} : End.");
        }
    }
}
