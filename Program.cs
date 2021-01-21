using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enemy has such skills as:");
            IEnemy hellBoss = new BossEnemy(new StrongEnemy(new CammonEnemy()));

            Console.WriteLine(hellBoss.attack());
        }
    }
}
