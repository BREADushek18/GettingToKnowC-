using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
  static void Main()
  {
    Console.Write("Введите число: ");
    double Number = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите степень: ");
    double Degree = Convert.ToDouble(Console.ReadLine());
    double Result = 1;

    for (int i = 1; i <= Degree; ++i)
    {
      Result *= Number;
    }

    Console.WriteLine("{0} в степени {1} = {2}.", Number, Degree, Result);
    Console.ReadKey();
  }
}