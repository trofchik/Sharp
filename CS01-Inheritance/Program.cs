
using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Animal[] ark = new Animal[3];

            Bird bird = new Bird("Fred");
            Human human = new Human("Max");
            Koi koi = new Koi("Sergey");

            ark[0] = bird;
            ark[1] = human;
            ark[2] = koi;

            for (int i = 0; i < ark.Length; i++)
            {
                Type T = ark[i].GetType();

            }

            for (int i = 0; i < ark.Length; i++)
            {
                if (ark[i] is Bird)
                {
                    Bird temp = (Bird)ark[i];
                    temp.ShowStats();
                    Console.WriteLine();
                    continue;
                }

                if (ark[i] is Koi)
                {
                    Koi temp = (Koi)ark[i];
                    temp.ShowStats();
                    Console.WriteLine();
                    continue;
                }   

                if (ark[i] is Human)
                {   
                    Human temp = (Human)ark[i];
                    temp.ShowStats();
                    Console.WriteLine();
                    continue;
                }
            }
        }
    }
}
