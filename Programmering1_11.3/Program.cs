using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_11._3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Skriv en siffra: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv en till siffra: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Summan blir: " + Addera(num1, num2));
            Console.ReadLine();
        }
        static int Addera(int num1, int num2) {
            int summa = num1 + num2;
            return summa;
        }
    }
}
