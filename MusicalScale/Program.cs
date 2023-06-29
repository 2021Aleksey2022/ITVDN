using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicalScale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;  //Устанавливаем цвет букв.
            Console.BackgroundColor = ConsoleColor.White;  //Устанавливаем цвет фона.

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, Friends!");

            Console.ResetColor();  //Сьрасываем цвет букв и фона.

            Console.WriteLine("Goodbye!");

            //Delay
            Console.ReadKey();
        }
        public void BeepSound()
        {
            Console.Beep(523, 500);  //До
            Console.Beep(587, 500);  //Ре
            Console.Beep(659, 500);  //Ми
            Console.Beep(698, 500);  //Фа
            Console.Beep(784, 500);  //Соль
            Console.Beep(880, 500);  //Ля
            Console.Beep(988, 500);  //си
            Console.ReadKey();
        }
    }
}
