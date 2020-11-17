using System;
namespace Inheritance
{
    public class Human: Animal, IWalk, ISwim
    {
        private bool hasEvolved = false;

        public Human(String newName = "") : base(newName)
        {
        }

        public override String ToString()
        {
            String output = "";
            output += "This is a human named " + GetName() + ". It can walk " +
            	"and write JS code or TS code if it evolves. It appears to be ";
            if (IsAlive())
                output += "alive.";
            else
                output += "dead. ";

            return output;
        }

        public void live()
        {
            Console.WriteLine("*Writes JS code*");
        }

        public void Walk()
        {
            Console.WriteLine("It walks!");
        }

        public void swim()
        {
            Console.WriteLine("*Swims like a human*");
        }

        public void evolve()
        {
            hasEvolved = true;
        }

        public void liveBetter()
        {
            if (hasEvolved)
                Console.WriteLine("*Writes TypeScript code*");
            else
                Console.WriteLine("It haven't evolved yet to do this.");
        }
    }
}
