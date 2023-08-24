using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattedOutPut
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.FormattingStrings();
            Console.ReadLine();
        }
        public void FormattingStrings()
        {
            Console.Write("Введите первое слогаемое: ");
            string stringAugend = Console.ReadLine();

            Console.Write("Введите второе слогаемое: ");
            string stringAddend = Console.ReadLine();

            int augend = Convert.ToInt32(stringAugend);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augend + addend;

            string result = string.Format("Результат: {0} + {1} = {2}", augend, addend, sum);

            Console.WriteLine(result);
        }
    }
}
