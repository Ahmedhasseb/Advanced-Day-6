﻿namespace ConsoleApp1
{
    public class customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        Action<customer> _action { get; set; }

        public void  add()
        {
            Console.WriteLine("Adding---------");

            if(_action != null)
            {
                _action(this);  
            }
        }

    }
}