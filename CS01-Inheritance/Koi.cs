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

		public override void ShowStats()
        {
            Console.WriteLine("Name: " + this.GetName());
            Console.WriteLine("State: " + this.IsAlive());
            Console.WriteLine("Abilities: swim");
        }

        public void Swim()
        {
            Console.WriteLine("*Swims*");
        }

        public void Live()
        {
            Console.WriteLine("");
        }
    }
}
