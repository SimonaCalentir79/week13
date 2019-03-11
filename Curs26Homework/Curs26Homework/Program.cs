using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs26Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Exercitiul 1--------------------------//

            string input = "Test1ng-Leet=code-Q!";
            string revStr = new Reverse().ReverseString(input);

            Console.WriteLine("\n\t Input string: " + input);
            Console.WriteLine("\t Output string: " + revStr);

            //-----------------------Exercitiul 2--------------------------//

            var a = 25;
            var b = 35.5;
            var sum = new Calculator().Sum(a,b);
            var diff = new Calculator().Deduct(a,b);
            var cat = new Calculator().Divide(a,b);
            var prod = new Calculator().Multiply(a,b);

            Console.WriteLine($"\n Operations of {a} and {b}: ");
            Console.WriteLine($"\t add: {sum}");
            Console.WriteLine($"\t deduct: {diff}");
            Console.WriteLine($"\t multiply: {prod}");
            Console.WriteLine($"\t divide: {cat}");

            //-------------------------------------------------------------//

            Console.ReadLine();
        }
    }
}
