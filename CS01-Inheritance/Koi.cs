using System;
namespace Inheritance
{
    public class Koi: Animal, ISwim
    {
        public Koi(String newName = "") : base(newName)
        {
        }

        public override String ToString()
        {
            String output = "";
            output += "This is a Koi-fish named " + GetName() + ". It can swim. " +
            	"It appears to be ";
            if (IsAlive())
                output += "alive.";
            else
                output += "dead. ";

            return output;
        }

        public void swim()
        {
            Console.WriteLine("*Swims*");
        }

        public void live()
        {
            Console.WriteLine("");
        }
    }
}
