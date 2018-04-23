using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
   public class Program
    {
       static void Main(string[] args)
        {
            PasswordCheckerService checker = new PasswordCheckerService(new SqlRepository());
            System.Console.WriteLine(checker.VerifyPassword(string.Empty).Item2);
            System.Console.WriteLine(checker.VerifyPassword("").Item2);
            System.Console.WriteLine(checker.VerifyPassword("12345").Item2);
            System.Console.WriteLine(checker.VerifyPassword("fdrkjgrdiflgjdiojg").Item2);
            System.Console.WriteLine(checker.VerifyPassword("sjferio").Item2);
            System.Console.ReadKey();
        }
    }
}
