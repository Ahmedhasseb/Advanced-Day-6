using System;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main()
        {
             customer obj = new customer
            {
                Id = 1,
                Name = "shallay"
            };

            obj._action += CustomerAction;

            obj.add();

            Console.ReadKey();
        }

        static void CustomerAction(customer c)
        {
            Console.WriteLine($"Customer  ID {c.Id} , Name {c.Name} ");
        }
    }
}
