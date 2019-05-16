using System;

namespace TP_API
{
    class Program
    {
        static void Main(string[] args)
        {
           var user=  new Authentication(new SaltProvider(), new PasswordProvider()).Register("victor", "monmdp");
            Console.WriteLine(user);
            Console.ReadLine();

        }
    }
}
