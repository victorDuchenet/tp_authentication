using System;

namespace TP_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var saltProvider = new SaltProvider(new RandomProvider(), new TimestampProvider());
            var auth = new Authentication(saltProvider, new PasswordProvider());
            var user = auth.Register("victor", "monmdp");
            Console.WriteLine(user);
            Console.ReadLine();

        }
    }
}
