using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1task2 {
  class Program {
    static void Main(string[] args) {
      Console.Write("Введите число x (>= 100) = ");
      int InitialNumber = int.Parse(Console.ReadLine());
      int NumberDigit; 

      for (NumberDigit = 1; NumberDigit <= InitialNumber; NumberDigit *= 10);

      int Result = InitialNumber / (NumberDigit / 10) * (NumberDigit / 10);
          Result += InitialNumber % (NumberDigit / 100) * 10;
          Result += InitialNumber / (NumberDigit / 100) % 10;


      Console.WriteLine("n = " + Result);
      Console.ReadKey();
    }
  }
}
