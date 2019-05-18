using System;

namespace _180519_If_Else_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMoneyInSavingAccount = true;

            if (isMoneyInSavingAccount)
            {
                Console.WriteLine("I have money");
            }
            else
            {
                Console.WriteLine("I have no money");
            }

            Console.ReadKey();
        }
    }
}
