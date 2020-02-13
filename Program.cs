using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Person pers = new Person(name);
            Person enemy = new Person("Enemy");
            pers.ShowInfo();
            enemy.ShowInfo();
            Battle b = new Battle(pers, enemy);
            b.Fight();



        }
     
    }
}
