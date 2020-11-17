
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

            foreach (var a in ark)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}
