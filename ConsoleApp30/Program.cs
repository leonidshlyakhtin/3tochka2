using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number, summa = 0;
                Console.WriteLine("Для поиска суммы отрицательных чисел закончите ввод значений, значением : 0");
                Console.WriteLine("Введите значения через Enter: ");
                do
                {
                    number = double.Parse(Console.ReadLine());

                    if (number > 0) continue;

                    summa += number;
                } while (number != 0);
                Console.WriteLine("Сумма отрицательных чисел: " + summa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
